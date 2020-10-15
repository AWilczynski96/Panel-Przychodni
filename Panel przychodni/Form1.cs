using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using Biblioteka;

namespace Panel_przychodni
{
    public partial class Form1 : Form
    {
        List<Osoba> osoby;
        Osoba edytowany;
        int numerEdytowanego;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Lekarz l1 = new Lekarz("Jan", "Kowal", Plec.Mężczyzna, "77072256747");
            osoby.Add(l1);
            
            Pacjent p1 = new Pacjent("Antoś", "Robal", Plec.Mężczyzna, "72112344897");            
            osoby.Add(p1);
            

            Serializuj("osoby.xml");
        }
        public void Serializuj(String plik)
        {
            
            System.IO.TextWriter wr = new System.IO.StreamWriter(plik);
            try
            {
                XmlSerializer xmlSerial = new XmlSerializer(typeof(List<Osoba>));
                xmlSerial.Serialize(wr, osoby);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Błąd: " + ex.Message);
            }
            wr.Close();
        }
        public void Deserializuj(String plik)
        {
            System.IO.TextReader wr = new System.IO.StreamReader(plik);
            try
            {
                XmlSerializer xmlSerial = new XmlSerializer(typeof(List<Osoba>));
                osoby = (List<Osoba>)xmlSerial.Deserialize(wr);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Błąd: " + ex.Message);
            }
            wr.Close();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            osoby = new List<Osoba>();
           
            Deserializuj("osoby.xml");
            lLista.Items.Clear();
            foreach (Osoba p in osoby)
            {
                lista.Items.Add(p.Nazwisko+ " " + p.Imię);
                String tekst = p.Wyświetl();
                int nr = tekst.IndexOf("Termin");
                if (nr == -1)
                    lLista.Items.Add(tekst);
               else
                {
                    String k1 = tekst.Substring(0, nr - 1);
                    String k2 = tekst.Substring(nr + 7);
                    ListViewItem it = new ListViewItem();
                    it.Text = k1;
                    it.SubItems.Add(k2);
                    lLista.Items.Add(it);
                }
               
            }
        }

         private void WybranieUżytkownika(object sender, EventArgs e)
        {
            string nazwa;
            
            try
            {
                nazwa = lista.SelectedItem.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(" Nie klikaj w puste pajacu");
                return;
            }
            numerEdytowanego = lista.SelectedIndex;
            foreach (Osoba p in osoby)
                if (p.Nazwisko + " " + p.Imię == nazwa)
                {
                tImię.Text = p.Imię;
                tNazwisko.Text = p.Nazwisko;
                tPesel.Text = p.Pesel;
                    if (p.Plec.ToString() == "Kobieta")
                        cPłeć.SelectedIndex = 0;
                    if (p.Plec.ToString() == "Mężczyzna")
                        cPłeć.SelectedIndex = 1;
                    
                tWiek.Text = p.Wiek.ToString();
                
                    string sub = p.Urodziny.ToString().Substring(0, 10);
                    tUrodziny.Text = sub;

                    if (p is Lekarz)
                        cRodzaj.SelectedIndex = 0;
                    if (p is Pacjent)
                        cRodzaj.SelectedIndex = 1;
                    if (p is Lekarz)
                        {

                            Lekarz lekarz = (Lekarz)p;                           
                            foreach (int dzień in lekarz.listaTerminów)
                                listaTerminów.Items.Add(dzień.ToString());
                            
                        }
                        
                    edytowany = p;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Rozpocznij dodawanie")
            {
                button2.Text = "Dodaj";
                

                tImię.Text = "";
                tNazwisko.Text = "";
                tPesel.Text = "";
                tPłeć.Text = "";

            }
            else
            {
                Osoba nowy = new Osoba();
                if (tImię.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Puste imię");
                    return;
                }
                nowy.Imię = tImię.Text;
                if (tNazwisko.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Puste nazwisko");
                    return;
                }
                nowy.Nazwisko = tNazwisko.Text;

                if (tPesel.Text.Trim().Length != 11)
                {
                    MessageBox.Show("Niewłaściwy Pesel");
                    return;
                }
                nowy.Pesel = tPesel.Text;

                if (cPłeć.SelectedItem.ToString().Length == 0)
                {
                    MessageBox.Show("Pusta Płeć");
                    return;
                }
                if (cPłeć.SelectedIndex == 0)
                    nowy.Plec = Plec.Kobieta;
                if (cPłeć.SelectedIndex == 1)
                    nowy.Plec = Plec.Mężczyzna;

                foreach (Osoba p in osoby)
                {
                    if (p.Pesel == nowy.Pesel)
                    {
                        MessageBox.Show("Numer pesel pokrywa się z Peselem pracownika: " + p.Nazwisko);
                        return;
                    }
                                        
                }
                String tekst = "";


                if (cRodzaj.SelectedItem.ToString() == "Lekarz")
                {
                    Lekarz lekarz = new Lekarz(nowy);
                    

                    

                    lekarz.listaTerminów = new List<int>();
                    foreach (String s in listaTerminów.Items)
                        lekarz.listaTerminów.Add(int.Parse(s));
                                        
                    osoby.Add(lekarz);
                    tekst = lekarz.Wyświetl();
                }

                if (cRodzaj.SelectedItem.ToString() == "Pacjent")
                {
                    Pacjent pacjent = new Pacjent(nowy);


                    
                    osoby.Add(pacjent);
                    tekst = pacjent.Wyświetl();
                }
               
                Serializuj("osoby.xml");
                button2.Text = "Rozpocznij dodawanie";
                
                tImię.Text = "";
                tNazwisko.Text = "";
                tPesel.Text = "";
                tPłeć.Text = "";
                cRodzaj.Enabled = true;
                this.Refresh();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            osoby.Remove(edytowany);
            Serializuj("osoby.xml");
        }

        private void button4_Click(object sender, EventArgs e)
        {           
            int numeredytowanegolekarza = numerEdytowanego;
        }

        private void button5_Click(object sender, EventArgs e)
        {            
            int numeredytowanegopacjenta = numerEdytowanego;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int nr = dateTimePicker1.Value.Day;
            listaTerminów.Items.Add(nr.ToString());
        }
    }
}
