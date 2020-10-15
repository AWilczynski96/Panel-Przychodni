namespace Panel_przychodni
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lLista = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lista = new System.Windows.Forms.ListBox();
            this.tImię = new System.Windows.Forms.TextBox();
            this.tNazwisko = new System.Windows.Forms.TextBox();
            this.tPesel = new System.Windows.Forms.TextBox();
            this.tPłeć = new System.Windows.Forms.TextBox();
            this.tWiek = new System.Windows.Forms.TextBox();
            this.tUrodziny = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cPłeć = new System.Windows.Forms.ComboBox();
            this.cRodzaj = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.listaTerminów = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "les go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lLista
            // 
            this.lLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lLista.FullRowSelect = true;
            this.lLista.GridLines = true;
            this.lLista.HideSelection = false;
            this.lLista.Location = new System.Drawing.Point(306, 37);
            this.lLista.Name = "lLista";
            this.lLista.Size = new System.Drawing.Size(326, 138);
            this.lLista.TabIndex = 11;
            this.lLista.UseCompatibleStateImageBehavior = false;
            this.lLista.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Osoba";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Termin";
            this.columnHeader2.Width = 150;
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(143, 70);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(120, 95);
            this.lista.TabIndex = 9;
            this.lista.DoubleClick += new System.EventHandler(this.WybranieUżytkownika);
            // 
            // tImię
            // 
            this.tImię.Location = new System.Drawing.Point(32, 222);
            this.tImię.Name = "tImię";
            this.tImię.Size = new System.Drawing.Size(100, 20);
            this.tImię.TabIndex = 3;
            // 
            // tNazwisko
            // 
            this.tNazwisko.Location = new System.Drawing.Point(143, 222);
            this.tNazwisko.Name = "tNazwisko";
            this.tNazwisko.Size = new System.Drawing.Size(100, 20);
            this.tNazwisko.TabIndex = 4;
            // 
            // tPesel
            // 
            this.tPesel.Location = new System.Drawing.Point(32, 271);
            this.tPesel.Name = "tPesel";
            this.tPesel.Size = new System.Drawing.Size(100, 20);
            this.tPesel.TabIndex = 5;
            // 
            // tPłeć
            // 
            this.tPłeć.Location = new System.Drawing.Point(663, 27);
            this.tPłeć.Name = "tPłeć";
            this.tPłeć.Size = new System.Drawing.Size(100, 20);
            this.tPłeć.TabIndex = 6;
            this.tPłeć.Visible = false;
            // 
            // tWiek
            // 
            this.tWiek.Enabled = false;
            this.tWiek.Location = new System.Drawing.Point(32, 319);
            this.tWiek.Name = "tWiek";
            this.tWiek.Size = new System.Drawing.Size(100, 20);
            this.tWiek.TabIndex = 7;
            // 
            // tUrodziny
            // 
            this.tUrodziny.Enabled = false;
            this.tUrodziny.Location = new System.Drawing.Point(143, 319);
            this.tUrodziny.Name = "tUrodziny";
            this.tUrodziny.Size = new System.Drawing.Size(100, 20);
            this.tUrodziny.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pesel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Płeć";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Wiek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Data Urodzenia";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Rozpocznij dodawanie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cPłeć
            // 
            this.cPłeć.FormattingEnabled = true;
            this.cPłeć.Items.AddRange(new object[] {
            "Kobieta",
            "Mężczyzna"});
            this.cPłeć.Location = new System.Drawing.Point(143, 270);
            this.cPłeć.Name = "cPłeć";
            this.cPłeć.Size = new System.Drawing.Size(100, 21);
            this.cPłeć.TabIndex = 16;
            // 
            // cRodzaj
            // 
            this.cRodzaj.FormattingEnabled = true;
            this.cRodzaj.Items.AddRange(new object[] {
            "Lekarz",
            "Pacjent"});
            this.cRodzaj.Location = new System.Drawing.Point(249, 319);
            this.cRodzaj.Name = "cRodzaj";
            this.cRodzaj.Size = new System.Drawing.Size(121, 21);
            this.cRodzaj.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(197, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Usuń wybraną Osobe";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Rodzaj Osoby";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 65);
            this.button4.TabIndex = 20;
            this.button4.Text = "Przygotuj wybranego lekarza do dodania terminu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(106, 116);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 65);
            this.button5.TabIndex = 21;
            this.button5.Text = "Przygotuj wybranego pacjenta do dodania terminu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(393, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 181);
            this.panel1.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 87);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "Dodaj termin";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listaTerminów
            // 
            this.listaTerminów.FormattingEnabled = true;
            this.listaTerminów.Location = new System.Drawing.Point(599, 271);
            this.listaTerminów.Name = "listaTerminów";
            this.listaTerminów.Size = new System.Drawing.Size(120, 95);
            this.listaTerminów.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listaTerminów);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cRodzaj);
            this.Controls.Add(this.cPłeć);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tUrodziny);
            this.Controls.Add(this.tWiek);
            this.Controls.Add(this.tPłeć);
            this.Controls.Add(this.tPesel);
            this.Controls.Add(this.tNazwisko);
            this.Controls.Add(this.tImię);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.lLista);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Panel Przychodni";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lLista;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.TextBox tImię;
        private System.Windows.Forms.TextBox tNazwisko;
        private System.Windows.Forms.TextBox tPesel;
        private System.Windows.Forms.TextBox tPłeć;
        private System.Windows.Forms.TextBox tWiek;
        private System.Windows.Forms.TextBox tUrodziny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cPłeć;
        private System.Windows.Forms.ComboBox cRodzaj;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listaTerminów;
    }
}