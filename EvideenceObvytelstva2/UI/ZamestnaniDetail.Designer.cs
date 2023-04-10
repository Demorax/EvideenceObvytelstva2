namespace EvideenceObvytelstva2.UI
{
    partial class ZamestnaniDetail
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
            dataGridAddress = new DataGridView();
            AddressId = new DataGridViewTextBoxColumn();
            Ulice = new DataGridViewTextBoxColumn();
            cisloPopisne = new DataGridViewTextBoxColumn();
            psc = new DataGridViewTextBoxColumn();
            Obec = new DataGridViewTextBoxColumn();
            label8 = new Label();
            button2 = new Button();
            textBoxPoznamka = new TextBox();
            textNazevZamestnani = new TextBox();
            label5 = new Label();
            label6 = new Label();
            labelIDInput = new Label();
            labelID = new Label();
            comboBoxAdresa = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridAddress).BeginInit();
            SuspendLayout();
            // 
            // dataGridAddress
            // 
            dataGridAddress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAddress.Columns.AddRange(new DataGridViewColumn[] { AddressId, Ulice, cisloPopisne, psc, Obec });
            dataGridAddress.Location = new Point(244, 59);
            dataGridAddress.MultiSelect = false;
            dataGridAddress.Name = "dataGridAddress";
            dataGridAddress.RowTemplate.Height = 25;
            dataGridAddress.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAddress.Size = new Size(544, 150);
            dataGridAddress.TabIndex = 59;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 116);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 57;
            label8.Text = "ID Adresy";
            // 
            // button2
            // 
            button2.Location = new Point(73, 163);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 56;
            button2.Text = "Uprav";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxPoznamka
            // 
            textBoxPoznamka.Location = new Point(118, 77);
            textBoxPoznamka.Name = "textBoxPoznamka";
            textBoxPoznamka.Size = new Size(100, 23);
            textBoxPoznamka.TabIndex = 55;
            // 
            // textNazevZamestnani
            // 
            textNazevZamestnani.Location = new Point(12, 77);
            textNazevZamestnani.Name = "textNazevZamestnani";
            textNazevZamestnani.Size = new Size(100, 23);
            textNazevZamestnani.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 59);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 53;
            label5.Text = "Poznámka:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 59);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 52;
            label6.Text = "Název Zaměstnání:";
            // 
            // labelIDInput
            // 
            labelIDInput.AutoSize = true;
            labelIDInput.Location = new Point(118, 32);
            labelIDInput.Name = "labelIDInput";
            labelIDInput.Size = new Size(17, 15);
            labelIDInput.TabIndex = 61;
            labelIDInput.Text = "id";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(91, 32);
            labelID.Name = "labelID";
            labelID.Size = new Size(21, 15);
            labelID.TabIndex = 60;
            labelID.Text = "ID:";
            // 
            // comboBoxAdresa
            // 
            comboBoxAdresa.FormattingEnabled = true;
            comboBoxAdresa.Location = new Point(12, 134);
            comboBoxAdresa.Name = "comboBoxAdresa";
            comboBoxAdresa.Size = new Size(199, 23);
            comboBoxAdresa.TabIndex = 62;
            // 
            // ZamestnaniDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 231);
            Controls.Add(comboBoxAdresa);
            Controls.Add(labelIDInput);
            Controls.Add(labelID);
            Controls.Add(dataGridAddress);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(textBoxPoznamka);
            Controls.Add(textNazevZamestnani);
            Controls.Add(label5);
            Controls.Add(label6);
            Name = "ZamestnaniDetail";
            Text = "ZamestnaniDetail";
            ((System.ComponentModel.ISupportInitialize)dataGridAddress).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewTextBoxColumn AddressId;
        private DataGridViewTextBoxColumn Ulice;
        private DataGridViewTextBoxColumn cisloPopisne;
        private DataGridViewTextBoxColumn psc;
        private DataGridViewTextBoxColumn Obec;
        public Label label8;
        public TextBox textBoxPoznamka;
        public TextBox textNazevZamestnani;
        public Label label5;
        public Label label6;
        public DataGridView dataGridAddress;
        public Button button2;
        public Label labelIDInput;
        public Label labelID;
        public ComboBox comboBoxAdresa;
    }
}