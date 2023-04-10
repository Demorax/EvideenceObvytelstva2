namespace EvideenceObvytelstva2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelJmeno = new Label();
            labelPrijmeni = new Label();
            textBoxJmeno = new TextBox();
            textBoxPrijmeni = new TextBox();
            button1 = new Button();
            dataGrid = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            TitulPred = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            TitulZa = new DataGridViewTextBoxColumn();
            Vek = new DataGridViewTextBoxColumn();
            AdresaID = new DataGridViewTextBoxColumn();
            StudentID = new DataGridViewTextBoxColumn();
            ZamestnanecID = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem1 = new ToolStripMenuItem();
            dataGridAddress = new DataGridView();
            AddressId = new DataGridViewTextBoxColumn();
            Ulice = new DataGridViewTextBoxColumn();
            cisloPopisne = new DataGridViewTextBoxColumn();
            psc = new DataGridViewTextBoxColumn();
            Obec = new DataGridViewTextBoxColumn();
            contextMenuStrip2 = new ContextMenuStrip(components);
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            labelAdresaId = new Label();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            label1 = new Label();
            textBoxVek = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label9 = new Label();
            label10 = new Label();
            dataGridStudent = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            OborStudia = new DataGridViewTextBoxColumn();
            Rocnik = new DataGridViewTextBoxColumn();
            SkolaID = new DataGridViewTextBoxColumn();
            contextMenuStrip5 = new ContextMenuStrip(components);
            deleteToolStripMenuItem2 = new ToolStripMenuItem();
            updateToolStripMenuItem2 = new ToolStripMenuItem();
            dataGridZamestnanec = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Nastup = new DataGridViewTextBoxColumn();
            Oddeleni = new DataGridViewTextBoxColumn();
            ZamestnaniID = new DataGridViewTextBoxColumn();
            contextMenuStrip7 = new ContextMenuStrip(components);
            deleteToolStripMenuItem4 = new ToolStripMenuItem();
            updateToolStripMenuItem4 = new ToolStripMenuItem();
            dataGridSkola = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            NazevSkoly = new DataGridViewTextBoxColumn();
            Poznamka = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            contextMenuStrip6 = new ContextMenuStrip(components);
            deleteToolStripMenuItem3 = new ToolStripMenuItem();
            updateToolStripMenuItem3 = new ToolStripMenuItem();
            dataGridZamestnani = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            NazevFirmy = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            contextMenuStrip8 = new ContextMenuStrip(components);
            deleteToolStripMenuItem5 = new ToolStripMenuItem();
            updateToolStripMenuItem5 = new ToolStripMenuItem();
            buttonAddAdres = new Button();
            buttonAddStudent = new Button();
            buttonAddSkola = new Button();
            buttonAddZamestnanec = new Button();
            buttonAddZamestnani = new Button();
            comboBoxTitulyPred = new ComboBox();
            contextMenuStrip3 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            contextMenuStrip4 = new ContextMenuStrip(components);
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            comboBoxAdresa = new ComboBox();
            comboBoxZamestnanec = new ComboBox();
            comboBoxStudent = new ComboBox();
            comboBoxTitulyZa = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAddress).BeginInit();
            contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridStudent).BeginInit();
            contextMenuStrip5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridZamestnanec).BeginInit();
            contextMenuStrip7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridSkola).BeginInit();
            contextMenuStrip6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridZamestnani).BeginInit();
            contextMenuStrip8.SuspendLayout();
            contextMenuStrip3.SuspendLayout();
            contextMenuStrip4.SuspendLayout();
            SuspendLayout();
            // 
            // labelJmeno
            // 
            labelJmeno.AutoSize = true;
            labelJmeno.Location = new Point(12, 12);
            labelJmeno.Name = "labelJmeno";
            labelJmeno.Size = new Size(83, 15);
            labelJmeno.TabIndex = 2;
            labelJmeno.Text = "Křestní jméno:";
            // 
            // labelPrijmeni
            // 
            labelPrijmeni.AutoSize = true;
            labelPrijmeni.Location = new Point(118, 12);
            labelPrijmeni.Name = "labelPrijmeni";
            labelPrijmeni.Size = new Size(57, 15);
            labelPrijmeni.TabIndex = 3;
            labelPrijmeni.Text = "Přijmení: ";
            // 
            // textBoxJmeno
            // 
            textBoxJmeno.Location = new Point(12, 30);
            textBoxJmeno.Name = "textBoxJmeno";
            textBoxJmeno.Size = new Size(100, 23);
            textBoxJmeno.TabIndex = 5;
            // 
            // textBoxPrijmeni
            // 
            textBoxPrijmeni.Location = new Point(118, 30);
            textBoxPrijmeni.Name = "textBoxPrijmeni";
            textBoxPrijmeni.Size = new Size(100, 23);
            textBoxPrijmeni.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(258, 188);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Přidej";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGrid
            // 
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { Id, TitulPred, FirstName, LastName, TitulZa, Vek, AdresaID, StudentID, ZamestnanecID });
            dataGrid.ContextMenuStrip = contextMenuStrip1;
            dataGrid.Location = new Point(461, 36);
            dataGrid.MultiSelect = false;
            dataGrid.Name = "dataGrid";
            dataGrid.RowTemplate.Height = 25;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.Size = new Size(689, 217);
            dataGrid.TabIndex = 8;
            dataGrid.TabStop = false;
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            dataGrid.RowHeaderMouseDoubleClick += dataGrid_RowHeaderMouseDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // TitulPred
            // 
            TitulPred.HeaderText = "Titul před";
            TitulPred.Name = "TitulPred";
            // 
            // FirstName
            // 
            FirstName.HeaderText = "Křestní jméno";
            FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            LastName.HeaderText = "Přijmení";
            LastName.Name = "LastName";
            // 
            // TitulZa
            // 
            TitulZa.HeaderText = "Titul za";
            TitulZa.Name = "TitulZa";
            // 
            // Vek
            // 
            Vek.HeaderText = "Věk";
            Vek.Name = "Vek";
            // 
            // AdresaID
            // 
            AdresaID.HeaderText = "ID Adresy";
            AdresaID.Name = "AdresaID";
            // 
            // StudentID
            // 
            StudentID.HeaderText = "ID Studenta";
            StudentID.Name = "StudentID";
            // 
            // ZamestnanecID
            // 
            ZamestnanecID.HeaderText = "ID Zamestnance";
            ZamestnanecID.Name = "ZamestnanecID";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, updateToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(113, 48);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(112, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem1
            // 
            updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            updateToolStripMenuItem1.Size = new Size(112, 22);
            updateToolStripMenuItem1.Text = "Update";
            updateToolStripMenuItem1.Click += updateToolStripMenuItem1_Click;
            // 
            // dataGridAddress
            // 
            dataGridAddress.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAddress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAddress.Columns.AddRange(new DataGridViewColumn[] { AddressId, Ulice, cisloPopisne, psc, Obec });
            dataGridAddress.ContextMenuStrip = contextMenuStrip2;
            dataGridAddress.Location = new Point(12, 259);
            dataGridAddress.MultiSelect = false;
            dataGridAddress.Name = "dataGridAddress";
            dataGridAddress.RowTemplate.Height = 25;
            dataGridAddress.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAddress.Size = new Size(544, 150);
            dataGridAddress.TabIndex = 9;
            dataGridAddress.TabStop = false;
            dataGridAddress.RowHeaderMouseDoubleClick += dataGridAddress_RowHeaderMouseDoubleClick;
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
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem1, updateToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(113, 48);
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(112, 22);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(112, 22);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // labelAdresaId
            // 
            labelAdresaId.AutoSize = true;
            labelAdresaId.Location = new Point(12, 66);
            labelAdresaId.Name = "labelAdresaId";
            labelAdresaId.Size = new Size(61, 15);
            labelAdresaId.TabIndex = 19;
            labelAdresaId.Text = "ID adresy: ";
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 170);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 25;
            label1.Text = "ID studenta:";
            // 
            // textBoxVek
            // 
            textBoxVek.Location = new Point(355, 30);
            textBoxVek.Name = "textBoxVek";
            textBoxVek.Size = new Size(100, 23);
            textBoxVek.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 12);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 22;
            label2.Text = "Věk:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 12);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 21;
            label3.Text = "Titul před jménem:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 117);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 27;
            label4.Text = "ID zamestnance:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(492, 9);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 29;
            label9.Text = "Tabulka Osob";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 241);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 30;
            label10.Text = "Tabulka Adres";
            // 
            // dataGridStudent
            // 
            dataGridStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStudent.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, OborStudia, Rocnik, SkolaID });
            dataGridStudent.ContextMenuStrip = contextMenuStrip5;
            dataGridStudent.Location = new Point(574, 259);
            dataGridStudent.MultiSelect = false;
            dataGridStudent.Name = "dataGridStudent";
            dataGridStudent.RowTemplate.Height = 25;
            dataGridStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridStudent.Size = new Size(443, 150);
            dataGridStudent.TabIndex = 31;
            dataGridStudent.TabStop = false;
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
            // contextMenuStrip5
            // 
            contextMenuStrip5.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem2, updateToolStripMenuItem2 });
            contextMenuStrip5.Name = "contextMenuStrip5";
            contextMenuStrip5.Size = new Size(113, 48);
            // 
            // deleteToolStripMenuItem2
            // 
            deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            deleteToolStripMenuItem2.Size = new Size(112, 22);
            deleteToolStripMenuItem2.Text = "Delete";
            deleteToolStripMenuItem2.Click += deleteToolStripMenuItem2_Click;
            // 
            // updateToolStripMenuItem2
            // 
            updateToolStripMenuItem2.Name = "updateToolStripMenuItem2";
            updateToolStripMenuItem2.Size = new Size(112, 22);
            updateToolStripMenuItem2.Text = "Update";
            updateToolStripMenuItem2.Click += updateToolStripMenuItem2_Click;
            // 
            // dataGridZamestnanec
            // 
            dataGridZamestnanec.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridZamestnanec.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, Nastup, Oddeleni, ZamestnaniID });
            dataGridZamestnanec.ContextMenuStrip = contextMenuStrip7;
            dataGridZamestnanec.Location = new Point(12, 426);
            dataGridZamestnanec.MultiSelect = false;
            dataGridZamestnanec.Name = "dataGridZamestnanec";
            dataGridZamestnanec.RowTemplate.Height = 25;
            dataGridZamestnanec.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridZamestnanec.Size = new Size(443, 150);
            dataGridZamestnanec.TabIndex = 32;
            dataGridZamestnanec.TabStop = false;
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
            // contextMenuStrip7
            // 
            contextMenuStrip7.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem4, updateToolStripMenuItem4 });
            contextMenuStrip7.Name = "contextMenuStrip7";
            contextMenuStrip7.Size = new Size(113, 48);
            // 
            // deleteToolStripMenuItem4
            // 
            deleteToolStripMenuItem4.Name = "deleteToolStripMenuItem4";
            deleteToolStripMenuItem4.Size = new Size(112, 22);
            deleteToolStripMenuItem4.Text = "Delete";
            deleteToolStripMenuItem4.Click += deleteToolStripMenuItem4_Click;
            // 
            // updateToolStripMenuItem4
            // 
            updateToolStripMenuItem4.Name = "updateToolStripMenuItem4";
            updateToolStripMenuItem4.Size = new Size(112, 22);
            updateToolStripMenuItem4.Text = "Update";
            updateToolStripMenuItem4.Click += updateToolStripMenuItem4_Click;
            // 
            // dataGridSkola
            // 
            dataGridSkola.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSkola.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, NazevSkoly, Poznamka, dataGridViewTextBoxColumn4 });
            dataGridSkola.ContextMenuStrip = contextMenuStrip6;
            dataGridSkola.Location = new Point(461, 426);
            dataGridSkola.MultiSelect = false;
            dataGridSkola.Name = "dataGridSkola";
            dataGridSkola.RowTemplate.Height = 25;
            dataGridSkola.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridSkola.Size = new Size(443, 150);
            dataGridSkola.TabIndex = 33;
            dataGridSkola.TabStop = false;
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
            // contextMenuStrip6
            // 
            contextMenuStrip6.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem3, updateToolStripMenuItem3 });
            contextMenuStrip6.Name = "contextMenuStrip6";
            contextMenuStrip6.Size = new Size(113, 48);
            // 
            // deleteToolStripMenuItem3
            // 
            deleteToolStripMenuItem3.Name = "deleteToolStripMenuItem3";
            deleteToolStripMenuItem3.Size = new Size(112, 22);
            deleteToolStripMenuItem3.Text = "Delete";
            deleteToolStripMenuItem3.Click += deleteToolStripMenuItem3_Click;
            // 
            // updateToolStripMenuItem3
            // 
            updateToolStripMenuItem3.Name = "updateToolStripMenuItem3";
            updateToolStripMenuItem3.Size = new Size(112, 22);
            updateToolStripMenuItem3.Text = "Update";
            updateToolStripMenuItem3.Click += updateToolStripMenuItem3_Click;
            // 
            // dataGridZamestnani
            // 
            dataGridZamestnani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridZamestnani.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, NazevFirmy, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dataGridZamestnani.ContextMenuStrip = contextMenuStrip8;
            dataGridZamestnani.Location = new Point(910, 426);
            dataGridZamestnani.MultiSelect = false;
            dataGridZamestnani.Name = "dataGridZamestnani";
            dataGridZamestnani.RowTemplate.Height = 25;
            dataGridZamestnani.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridZamestnani.Size = new Size(443, 150);
            dataGridZamestnani.TabIndex = 34;
            dataGridZamestnani.TabStop = false;
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
            // contextMenuStrip8
            // 
            contextMenuStrip8.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem5, updateToolStripMenuItem5 });
            contextMenuStrip8.Name = "contextMenuStrip8";
            contextMenuStrip8.Size = new Size(113, 48);
            // 
            // deleteToolStripMenuItem5
            // 
            deleteToolStripMenuItem5.Name = "deleteToolStripMenuItem5";
            deleteToolStripMenuItem5.Size = new Size(112, 22);
            deleteToolStripMenuItem5.Text = "Delete";
            deleteToolStripMenuItem5.Click += deleteToolStripMenuItem5_Click;
            // 
            // updateToolStripMenuItem5
            // 
            updateToolStripMenuItem5.Name = "updateToolStripMenuItem5";
            updateToolStripMenuItem5.Size = new Size(112, 22);
            updateToolStripMenuItem5.Text = "Update";
            updateToolStripMenuItem5.Click += updateToolStripMenuItem5_Click;
            // 
            // buttonAddAdres
            // 
            buttonAddAdres.Location = new Point(1187, 234);
            buttonAddAdres.Name = "buttonAddAdres";
            buttonAddAdres.Size = new Size(141, 23);
            buttonAddAdres.TabIndex = 35;
            buttonAddAdres.Text = "Přidej Adresu";
            buttonAddAdres.UseVisualStyleBackColor = true;
            buttonAddAdres.Click += buttonAddAdres_Click;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Location = new Point(1187, 269);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(141, 23);
            buttonAddStudent.TabIndex = 36;
            buttonAddStudent.Text = "Přidej Studenta";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // buttonAddSkola
            // 
            buttonAddSkola.Location = new Point(1187, 347);
            buttonAddSkola.Name = "buttonAddSkola";
            buttonAddSkola.Size = new Size(141, 23);
            buttonAddSkola.TabIndex = 38;
            buttonAddSkola.Text = "Přidej Školu";
            buttonAddSkola.UseVisualStyleBackColor = true;
            buttonAddSkola.Click += buttonAddSkola_Click;
            // 
            // buttonAddZamestnanec
            // 
            buttonAddZamestnanec.Location = new Point(1187, 306);
            buttonAddZamestnanec.Name = "buttonAddZamestnanec";
            buttonAddZamestnanec.Size = new Size(141, 23);
            buttonAddZamestnanec.TabIndex = 37;
            buttonAddZamestnanec.Text = "Přidej Zaměstnance";
            buttonAddZamestnanec.UseVisualStyleBackColor = true;
            buttonAddZamestnanec.Click += buttonAddZamestnanec_Click;
            // 
            // buttonAddZamestnani
            // 
            buttonAddZamestnani.Location = new Point(1187, 386);
            buttonAddZamestnani.Name = "buttonAddZamestnani";
            buttonAddZamestnani.Size = new Size(141, 23);
            buttonAddZamestnani.TabIndex = 39;
            buttonAddZamestnani.Text = "Přidej Zaměstnání";
            buttonAddZamestnani.UseVisualStyleBackColor = true;
            buttonAddZamestnani.Click += buttonAddZamestnani_Click;
            // 
            // comboBoxTitulyPred
            // 
            comboBoxTitulyPred.FormattingEnabled = true;
            comboBoxTitulyPred.Items.AddRange(new object[] { "Bc.", "BcA.", "Ing. ", "JUDr.", "MDDr. ", "PhDr.", "Mgr.", "Ph.D. ", "doc. ", "prof. " });
            comboBoxTitulyPred.Location = new Point(224, 30);
            comboBoxTitulyPred.Name = "comboBoxTitulyPred";
            comboBoxTitulyPred.Size = new Size(121, 23);
            comboBoxTitulyPred.TabIndex = 40;
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            contextMenuStrip3.Name = "contextMenuStrip2";
            contextMenuStrip3.Size = new Size(113, 48);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(112, 22);
            toolStripMenuItem1.Text = "Delete";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(112, 22);
            toolStripMenuItem2.Text = "Update";
            // 
            // contextMenuStrip4
            // 
            contextMenuStrip4.Items.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem4 });
            contextMenuStrip4.Name = "contextMenuStrip2";
            contextMenuStrip4.Size = new Size(113, 48);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(112, 22);
            toolStripMenuItem3.Text = "Delete";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(112, 22);
            toolStripMenuItem4.Text = "Update";
            // 
            // comboBoxAdresa
            // 
            comboBoxAdresa.FormattingEnabled = true;
            comboBoxAdresa.Location = new Point(12, 84);
            comboBoxAdresa.Name = "comboBoxAdresa";
            comboBoxAdresa.Size = new Size(199, 23);
            comboBoxAdresa.TabIndex = 41;
            // 
            // comboBoxZamestnanec
            // 
            comboBoxZamestnanec.FormattingEnabled = true;
            comboBoxZamestnanec.Location = new Point(12, 135);
            comboBoxZamestnanec.Name = "comboBoxZamestnanec";
            comboBoxZamestnanec.Size = new Size(199, 23);
            comboBoxZamestnanec.TabIndex = 42;
            // 
            // comboBoxStudent
            // 
            comboBoxStudent.FormattingEnabled = true;
            comboBoxStudent.Location = new Point(12, 188);
            comboBoxStudent.Name = "comboBoxStudent";
            comboBoxStudent.Size = new Size(199, 23);
            comboBoxStudent.TabIndex = 43;
            // 
            // comboBoxTitulyZa
            // 
            comboBoxTitulyZa.FormattingEnabled = true;
            comboBoxTitulyZa.Items.AddRange(new object[] { "DiS.", "MBA", "LL.M.", "Ph.D. ", "CSc.", "DrSc. ", "" });
            comboBoxTitulyZa.Location = new Point(224, 84);
            comboBoxTitulyZa.Name = "comboBoxTitulyZa";
            comboBoxTitulyZa.Size = new Size(121, 23);
            comboBoxTitulyZa.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(224, 66);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 44;
            label5.Text = "Titul za jménem:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 622);
            Controls.Add(comboBoxTitulyZa);
            Controls.Add(label5);
            Controls.Add(comboBoxStudent);
            Controls.Add(comboBoxZamestnanec);
            Controls.Add(comboBoxAdresa);
            Controls.Add(comboBoxTitulyPred);
            Controls.Add(buttonAddZamestnani);
            Controls.Add(buttonAddSkola);
            Controls.Add(buttonAddZamestnanec);
            Controls.Add(buttonAddStudent);
            Controls.Add(buttonAddAdres);
            Controls.Add(dataGridZamestnani);
            Controls.Add(dataGridSkola);
            Controls.Add(dataGridZamestnanec);
            Controls.Add(dataGridStudent);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(textBoxVek);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(labelAdresaId);
            Controls.Add(dataGridAddress);
            Controls.Add(dataGrid);
            Controls.Add(button1);
            Controls.Add(textBoxPrijmeni);
            Controls.Add(textBoxJmeno);
            Controls.Add(labelPrijmeni);
            Controls.Add(labelJmeno);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridAddress).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridStudent).EndInit();
            contextMenuStrip5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridZamestnanec).EndInit();
            contextMenuStrip7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridSkola).EndInit();
            contextMenuStrip6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridZamestnani).EndInit();
            contextMenuStrip8.ResumeLayout(false);
            contextMenuStrip3.ResumeLayout(false);
            contextMenuStrip4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelJmeno;
        private Label labelPrijmeni;
        private TextBox textBoxJmeno;
        private TextBox textBoxPrijmeni;
        private Button button1;
        private DataGridView dataGrid;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private DataGridView dataGridAddress;
        private DataGridViewTextBoxColumn AddressId;
        private DataGridViewTextBoxColumn Ulice;
        private DataGridViewTextBoxColumn cisloPopisne;
        private DataGridViewTextBoxColumn psc;
        private DataGridViewTextBoxColumn Obec;
        private Label labelAdresaId;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Label label1;
        private TextBox textBoxVek;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label9;
        private Label label10;
        private DataGridView dataGridStudent;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn OborStudia;
        private DataGridViewTextBoxColumn Rocnik;
        private DataGridViewTextBoxColumn SkolaID;
        private DataGridView dataGridZamestnanec;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Nastup;
        private DataGridViewTextBoxColumn Oddeleni;
        private DataGridViewTextBoxColumn ZamestnaniID;
        private DataGridView dataGridSkola;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn NazevSkoly;
        private DataGridViewTextBoxColumn Poznamka;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridView dataGridZamestnani;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn NazevFirmy;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Button buttonAddAdres;
        private Button buttonAddStudent;
        private Button buttonAddSkola;
        private Button buttonAddZamestnanec;
        private Button buttonAddZamestnani;
        private ComboBox comboBoxTitulyPred;
        private ToolStripMenuItem updateToolStripMenuItem1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ContextMenuStrip contextMenuStrip4;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ContextMenuStrip contextMenuStrip5;
        private ToolStripMenuItem deleteToolStripMenuItem2;
        private ToolStripMenuItem updateToolStripMenuItem2;
        private ContextMenuStrip contextMenuStrip6;
        private ToolStripMenuItem deleteToolStripMenuItem3;
        private ToolStripMenuItem updateToolStripMenuItem3;
        private ContextMenuStrip contextMenuStrip7;
        private ToolStripMenuItem deleteToolStripMenuItem4;
        private ToolStripMenuItem updateToolStripMenuItem4;
        private ContextMenuStrip contextMenuStrip8;
        private ToolStripMenuItem deleteToolStripMenuItem5;
        private ToolStripMenuItem updateToolStripMenuItem5;
        private ComboBox comboBoxAdresa;
        private ComboBox comboBoxZamestnanec;
        private ComboBox comboBoxStudent;
        private ComboBox comboBoxTitulyZa;
        private Label label5;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn TitulPred;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn TitulZa;
        private DataGridViewTextBoxColumn Vek;
        private DataGridViewTextBoxColumn AdresaID;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn ZamestnanecID;
    }
}