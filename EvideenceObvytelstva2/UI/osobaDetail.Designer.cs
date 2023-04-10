namespace EvideenceObvytelstva2.UI
{
    partial class osobaDetail
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
            textBoxVek = new TextBox();
            label8 = new Label();
            button2 = new Button();
            textBoxPrijmeni = new TextBox();
            textBoxJmeno = new TextBox();
            labelPrijmeni = new Label();
            labelJmeno = new Label();
            dataGridZamestnani = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            NazevFirmy = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridSkola = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            NazevSkoly = new DataGridViewTextBoxColumn();
            Poznamka = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridZamestnanec = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Nastup = new DataGridViewTextBoxColumn();
            Oddeleni = new DataGridViewTextBoxColumn();
            ZamestnaniID = new DataGridViewTextBoxColumn();
            dataGridStudent = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            OborStudia = new DataGridViewTextBoxColumn();
            Rocnik = new DataGridViewTextBoxColumn();
            SkolaID = new DataGridViewTextBoxColumn();
            dataGridAddress = new DataGridView();
            AddressId = new DataGridViewTextBoxColumn();
            Ulice = new DataGridViewTextBoxColumn();
            cisloPopisne = new DataGridViewTextBoxColumn();
            psc = new DataGridViewTextBoxColumn();
            Obec = new DataGridViewTextBoxColumn();
            labelID = new Label();
            comboBoxStudent = new ComboBox();
            comboBoxZamestnanec = new ComboBox();
            comboBoxAdresa = new ComboBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            comboBoxTitulyZa = new ComboBox();
            label5 = new Label();
            comboBoxTitulyPred = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridZamestnani).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSkola).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridZamestnanec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridAddress).BeginInit();
            SuspendLayout();
            // 
            // textBoxVek
            // 
            textBoxVek.Location = new Point(143, 75);
            textBoxVek.Name = "textBoxVek";
            textBoxVek.Size = new Size(100, 23);
            textBoxVek.TabIndex = 50;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(143, 57);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 49;
            label8.Text = "Věk:";
            // 
            // button2
            // 
            button2.Location = new Point(143, 128);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 45;
            button2.Text = "Uprav";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // textBoxPrijmeni
            // 
            textBoxPrijmeni.Location = new Point(118, 27);
            textBoxPrijmeni.Name = "textBoxPrijmeni";
            textBoxPrijmeni.Size = new Size(100, 23);
            textBoxPrijmeni.TabIndex = 44;
            // 
            // textBoxJmeno
            // 
            textBoxJmeno.Location = new Point(12, 27);
            textBoxJmeno.Name = "textBoxJmeno";
            textBoxJmeno.Size = new Size(100, 23);
            textBoxJmeno.TabIndex = 43;
            // 
            // labelPrijmeni
            // 
            labelPrijmeni.AutoSize = true;
            labelPrijmeni.Location = new Point(118, 9);
            labelPrijmeni.Name = "labelPrijmeni";
            labelPrijmeni.Size = new Size(57, 15);
            labelPrijmeni.TabIndex = 42;
            labelPrijmeni.Text = "Přijmení: ";
            // 
            // labelJmeno
            // 
            labelJmeno.AutoSize = true;
            labelJmeno.Location = new Point(12, 9);
            labelJmeno.Name = "labelJmeno";
            labelJmeno.Size = new Size(83, 15);
            labelJmeno.TabIndex = 41;
            labelJmeno.Text = "Křestní jméno:";
            // 
            // dataGridZamestnani
            // 
            dataGridZamestnani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridZamestnani.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, NazevFirmy, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dataGridZamestnani.Location = new Point(12, 313);
            dataGridZamestnani.MultiSelect = false;
            dataGridZamestnani.Name = "dataGridZamestnani";
            dataGridZamestnani.RowTemplate.Height = 25;
            dataGridZamestnani.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridZamestnani.Size = new Size(443, 150);
            dataGridZamestnani.TabIndex = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "ID";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // NazevFirmy
            // 
            NazevFirmy.HeaderText = "Název Firmy";
            NazevFirmy.Name = "NazevFirmy";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Poznamka";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "ID Adresy";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridSkola
            // 
            dataGridSkola.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSkola.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, NazevSkoly, Poznamka, dataGridViewTextBoxColumn4 });
            dataGridSkola.Location = new Point(471, 313);
            dataGridSkola.MultiSelect = false;
            dataGridSkola.Name = "dataGridSkola";
            dataGridSkola.RowTemplate.Height = 25;
            dataGridSkola.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridSkola.Size = new Size(443, 150);
            dataGridSkola.TabIndex = 59;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "ID";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // NazevSkoly
            // 
            NazevSkoly.HeaderText = "Název Školy";
            NazevSkoly.Name = "NazevSkoly";
            // 
            // Poznamka
            // 
            Poznamka.HeaderText = "Poznamka";
            Poznamka.Name = "Poznamka";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "ID Adresy";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridZamestnanec
            // 
            dataGridZamestnanec.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridZamestnanec.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, Nastup, Oddeleni, ZamestnaniID });
            dataGridZamestnanec.Location = new Point(12, 157);
            dataGridZamestnanec.MultiSelect = false;
            dataGridZamestnanec.Name = "dataGridZamestnanec";
            dataGridZamestnanec.RowTemplate.Height = 25;
            dataGridZamestnanec.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridZamestnanec.Size = new Size(443, 150);
            dataGridZamestnanec.TabIndex = 58;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "ID";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Nastup
            // 
            Nastup.HeaderText = "Datum Nastupu";
            Nastup.Name = "Nastup";
            // 
            // Oddeleni
            // 
            Oddeleni.HeaderText = "Oddeleni";
            Oddeleni.Name = "Oddeleni";
            // 
            // ZamestnaniID
            // 
            ZamestnaniID.HeaderText = "ID Zamestnani";
            ZamestnaniID.Name = "ZamestnaniID";
            // 
            // dataGridStudent
            // 
            dataGridStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStudent.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, OborStudia, Rocnik, SkolaID });
            dataGridStudent.Location = new Point(471, 157);
            dataGridStudent.MultiSelect = false;
            dataGridStudent.Name = "dataGridStudent";
            dataGridStudent.RowTemplate.Height = 25;
            dataGridStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridStudent.Size = new Size(443, 150);
            dataGridStudent.TabIndex = 57;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // OborStudia
            // 
            OborStudia.HeaderText = "OborStudia";
            OborStudia.Name = "OborStudia";
            // 
            // Rocnik
            // 
            Rocnik.HeaderText = "Rocnik";
            Rocnik.Name = "Rocnik";
            // 
            // SkolaID
            // 
            SkolaID.HeaderText = "ID Skoly";
            SkolaID.Name = "SkolaID";
            // 
            // dataGridAddress
            // 
            dataGridAddress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAddress.Columns.AddRange(new DataGridViewColumn[] { AddressId, Ulice, cisloPopisne, psc, Obec });
            dataGridAddress.Location = new Point(471, 6);
            dataGridAddress.MultiSelect = false;
            dataGridAddress.Name = "dataGridAddress";
            dataGridAddress.RowTemplate.Height = 25;
            dataGridAddress.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAddress.Size = new Size(544, 150);
            dataGridAddress.TabIndex = 56;
            // 
            // AddressId
            // 
            AddressId.HeaderText = "id";
            AddressId.Name = "AddressId";
            // 
            // Ulice
            // 
            Ulice.HeaderText = "Ulice";
            Ulice.Name = "Ulice";
            // 
            // cisloPopisne
            // 
            cisloPopisne.HeaderText = "CisloPopisne";
            cisloPopisne.Name = "cisloPopisne";
            // 
            // psc
            // 
            psc.HeaderText = "PSC";
            psc.Name = "psc";
            // 
            // Obec
            // 
            Obec.HeaderText = "Obec";
            Obec.Name = "Obec";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(275, 24);
            labelID.Name = "labelID";
            labelID.Size = new Size(0, 15);
            labelID.TabIndex = 61;
            // 
            // comboBoxStudent
            // 
            comboBoxStudent.FormattingEnabled = true;
            comboBoxStudent.Location = new Point(256, 128);
            comboBoxStudent.Name = "comboBoxStudent";
            comboBoxStudent.Size = new Size(199, 23);
            comboBoxStudent.TabIndex = 67;
            // 
            // comboBoxZamestnanec
            // 
            comboBoxZamestnanec.FormattingEnabled = true;
            comboBoxZamestnanec.Location = new Point(256, 75);
            comboBoxZamestnanec.Name = "comboBoxZamestnanec";
            comboBoxZamestnanec.Size = new Size(199, 23);
            comboBoxZamestnanec.TabIndex = 66;
            // 
            // comboBoxAdresa
            // 
            comboBoxAdresa.FormattingEnabled = true;
            comboBoxAdresa.Location = new Point(256, 24);
            comboBoxAdresa.Name = "comboBoxAdresa";
            comboBoxAdresa.Size = new Size(199, 23);
            comboBoxAdresa.TabIndex = 65;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 57);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 64;
            label4.Text = "ID zamestnance:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 110);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 63;
            label1.Text = "ID studenta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 6);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 62;
            label2.Text = "ID adresy: ";
            // 
            // comboBoxTitulyZa
            // 
            comboBoxTitulyZa.FormattingEnabled = true;
            comboBoxTitulyZa.Items.AddRange(new object[] { "DiS.", "MBA", "LL.M.", "Ph.D. ", "CSc.", "DrSc. ", "" });
            comboBoxTitulyZa.Location = new Point(12, 128);
            comboBoxTitulyZa.Name = "comboBoxTitulyZa";
            comboBoxTitulyZa.Size = new Size(121, 23);
            comboBoxTitulyZa.TabIndex = 71;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 110);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 70;
            label5.Text = "Titul za jménem:";
            // 
            // comboBoxTitulyPred
            // 
            comboBoxTitulyPred.FormattingEnabled = true;
            comboBoxTitulyPred.Items.AddRange(new object[] { "Bc.", "BcA.", "Ing. ", "JUDr.", "MDDr. ", "PhDr.", "Mgr.", "Ph.D. ", "doc. ", "prof. " });
            comboBoxTitulyPred.Location = new Point(12, 75);
            comboBoxTitulyPred.Name = "comboBoxTitulyPred";
            comboBoxTitulyPred.Size = new Size(121, 23);
            comboBoxTitulyPred.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 57);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 68;
            label3.Text = "Titul před jménem:";
            // 
            // osobaDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 477);
            Controls.Add(comboBoxTitulyZa);
            Controls.Add(label5);
            Controls.Add(comboBoxTitulyPred);
            Controls.Add(label3);
            Controls.Add(comboBoxStudent);
            Controls.Add(comboBoxZamestnanec);
            Controls.Add(comboBoxAdresa);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(labelID);
            Controls.Add(dataGridZamestnani);
            Controls.Add(dataGridSkola);
            Controls.Add(dataGridZamestnanec);
            Controls.Add(dataGridStudent);
            Controls.Add(dataGridAddress);
            Controls.Add(labelJmeno);
            Controls.Add(labelPrijmeni);
            Controls.Add(textBoxJmeno);
            Controls.Add(textBoxVek);
            Controls.Add(textBoxPrijmeni);
            Controls.Add(label8);
            Controls.Add(button2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "osobaDetail";
            StartPosition = FormStartPosition.CenterParent;
            Text = "osobaDetail";
            ((System.ComponentModel.ISupportInitialize)dataGridZamestnani).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSkola).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridZamestnanec).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridAddress).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridZamestnani;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn NazevFirmy;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridView dataGridSkola;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn NazevSkoly;
        private DataGridViewTextBoxColumn Poznamka;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridView dataGridZamestnanec;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Nastup;
        private DataGridViewTextBoxColumn Oddeleni;
        private DataGridViewTextBoxColumn ZamestnaniID;
        private DataGridView dataGridStudent;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn OborStudia;
        private DataGridViewTextBoxColumn Rocnik;
        private DataGridViewTextBoxColumn SkolaID;
        private DataGridView dataGridAddress;
        private DataGridViewTextBoxColumn AddressId;
        private DataGridViewTextBoxColumn Ulice;
        private DataGridViewTextBoxColumn cisloPopisne;
        private DataGridViewTextBoxColumn psc;
        private DataGridViewTextBoxColumn Obec;
        public Label labelID;
        public TextBox textBoxVek;
        public Label label8;
        public Button button2;
        public TextBox textBoxPrijmeni;
        public TextBox textBoxJmeno;
        public Label labelPrijmeni;
        public Label labelJmeno;
        public ComboBox comboBoxStudent;
        public ComboBox comboBoxZamestnanec;
        public ComboBox comboBoxAdresa;
        public Label label4;
        public Label label1;
        public Label label2;
        private Label label5;
        private Label label3;
        public ComboBox comboBoxTitulyZa;
        public ComboBox comboBoxTitulyPred;
    }
}