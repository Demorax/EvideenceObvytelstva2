namespace EvideenceObvytelstva2.UI
{
    partial class PridejSkolu
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
            label8 = new Label();
            button2 = new Button();
            textBoxPoznamka = new TextBox();
            textNazevSkoly = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dataGridAddress = new DataGridView();
            AddressId = new DataGridViewTextBoxColumn();
            Ulice = new DataGridViewTextBoxColumn();
            cisloPopisne = new DataGridViewTextBoxColumn();
            psc = new DataGridViewTextBoxColumn();
            Obec = new DataGridViewTextBoxColumn();
            comboBoxAdresa = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridAddress).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 81);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 41;
            label8.Text = "ID Adresy";
            // 
            // button2
            // 
            button2.Location = new Point(136, 139);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 40;
            button2.Text = "Přidej";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxPoznamka
            // 
            textBoxPoznamka.Location = new Point(118, 42);
            textBoxPoznamka.Name = "textBoxPoznamka";
            textBoxPoznamka.Size = new Size(100, 23);
            textBoxPoznamka.TabIndex = 39;
            // 
            // textNazevSkoly
            // 
            textNazevSkoly.Location = new Point(12, 42);
            textNazevSkoly.Name = "textNazevSkoly";
            textNazevSkoly.Size = new Size(100, 23);
            textNazevSkoly.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 24);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 37;
            label5.Text = "Poznámka:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 24);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 36;
            label6.Text = "Název Školy:";
            // 
            // dataGridAddress
            // 
            dataGridAddress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAddress.Columns.AddRange(new DataGridViewColumn[] { AddressId, Ulice, cisloPopisne, psc, Obec });
            dataGridAddress.Location = new Point(244, 24);
            dataGridAddress.MultiSelect = false;
            dataGridAddress.Name = "dataGridAddress";
            dataGridAddress.RowTemplate.Height = 25;
            dataGridAddress.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAddress.Size = new Size(544, 150);
            dataGridAddress.TabIndex = 43;
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
            // comboBoxAdresa
            // 
            comboBoxAdresa.FormattingEnabled = true;
            comboBoxAdresa.Location = new Point(12, 99);
            comboBoxAdresa.Name = "comboBoxAdresa";
            comboBoxAdresa.Size = new Size(199, 23);
            comboBoxAdresa.TabIndex = 44;
            // 
            // PridejSkolu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 209);
            Controls.Add(comboBoxAdresa);
            Controls.Add(dataGridAddress);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(textBoxPoznamka);
            Controls.Add(textNazevSkoly);
            Controls.Add(label5);
            Controls.Add(label6);
            Name = "PridejSkolu";
            Text = "PridejSkolu";
            ((System.ComponentModel.ISupportInitialize)dataGridAddress).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label label8;
        private Button button2;
        public TextBox textBoxPoznamka;
        public TextBox textNazevSkoly;
        public Label label5;
        public Label label6;
        private DataGridView dataGridAddress;
        private DataGridViewTextBoxColumn AddressId;
        private DataGridViewTextBoxColumn Ulice;
        private DataGridViewTextBoxColumn cisloPopisne;
        private DataGridViewTextBoxColumn psc;
        private DataGridViewTextBoxColumn Obec;
        private ComboBox comboBoxAdresa;
    }
}