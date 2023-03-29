namespace EvideenceObvytelstva2.UI
{
    partial class SkolaDetail
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
            textBoxAdresaID = new TextBox();
            label8 = new Label();
            button2 = new Button();
            textBoxPoznamka = new TextBox();
            textNazevSkoly = new TextBox();
            label5 = new Label();
            label6 = new Label();
            labelIDInput = new Label();
            labelID = new Label();
            dataGridAddress = new DataGridView();
            AddressId = new DataGridViewTextBoxColumn();
            Ulice = new DataGridViewTextBoxColumn();
            cisloPopisne = new DataGridViewTextBoxColumn();
            psc = new DataGridViewTextBoxColumn();
            Obec = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridAddress).BeginInit();
            SuspendLayout();
            // 
            // textBoxAdresaID
            // 
            textBoxAdresaID.Location = new Point(12, 131);
            textBoxAdresaID.Name = "textBoxAdresaID";
            textBoxAdresaID.Size = new Size(100, 23);
            textBoxAdresaID.TabIndex = 49;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 113);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 48;
            label8.Text = "ID Adresy";
            // 
            // button2
            // 
            button2.Location = new Point(143, 131);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 47;
            button2.Text = "Uprav";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxPoznamka
            // 
            textBoxPoznamka.Location = new Point(118, 74);
            textBoxPoznamka.Name = "textBoxPoznamka";
            textBoxPoznamka.Size = new Size(100, 23);
            textBoxPoznamka.TabIndex = 46;
            // 
            // textNazevSkoly
            // 
            textNazevSkoly.Location = new Point(12, 74);
            textNazevSkoly.Name = "textNazevSkoly";
            textNazevSkoly.Size = new Size(100, 23);
            textNazevSkoly.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 56);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 44;
            label5.Text = "Poznámka:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 56);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 43;
            label6.Text = "Název Školy:";
            // 
            // labelIDInput
            // 
            labelIDInput.AutoSize = true;
            labelIDInput.Location = new Point(118, 26);
            labelIDInput.Name = "labelIDInput";
            labelIDInput.Size = new Size(17, 15);
            labelIDInput.TabIndex = 51;
            labelIDInput.Text = "id";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(91, 26);
            labelID.Name = "labelID";
            labelID.Size = new Size(21, 15);
            labelID.TabIndex = 50;
            labelID.Text = "ID:";
            // 
            // dataGridAddress
            // 
            dataGridAddress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAddress.Columns.AddRange(new DataGridViewColumn[] { AddressId, Ulice, cisloPopisne, psc, Obec });
            dataGridAddress.Location = new Point(224, 12);
            dataGridAddress.MultiSelect = false;
            dataGridAddress.Name = "dataGridAddress";
            dataGridAddress.RowTemplate.Height = 25;
            dataGridAddress.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAddress.Size = new Size(544, 150);
            dataGridAddress.TabIndex = 52;
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
            // SkolaDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 175);
            Controls.Add(dataGridAddress);
            Controls.Add(labelIDInput);
            Controls.Add(labelID);
            Controls.Add(textBoxAdresaID);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(textBoxPoznamka);
            Controls.Add(textNazevSkoly);
            Controls.Add(label5);
            Controls.Add(label6);
            Name = "SkolaDetail";
            Text = "SkolaDetail";
            ((System.ComponentModel.ISupportInitialize)dataGridAddress).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBoxAdresaID;
        public Label label8;
        public TextBox textBoxPoznamka;
        public TextBox textNazevSkoly;
        public Label label5;
        public Label label6;
        public Label labelIDInput;
        public Label labelID;
        private DataGridView dataGridAddress;
        private DataGridViewTextBoxColumn AddressId;
        private DataGridViewTextBoxColumn Ulice;
        private DataGridViewTextBoxColumn cisloPopisne;
        private DataGridViewTextBoxColumn psc;
        private DataGridViewTextBoxColumn Obec;
        public Button button2;
    }
}