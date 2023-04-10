namespace EvideenceObvytelstva2.UI
{
    partial class StudentDetail
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
            dataGridSkola = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            NazevSkoly = new DataGridViewTextBoxColumn();
            Poznamka = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            button2 = new Button();
            textBoxRocnik = new TextBox();
            textOborStudia = new TextBox();
            label5 = new Label();
            label6 = new Label();
            labelIDInput = new Label();
            labelID = new Label();
            comboBoxSkola = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridSkola).BeginInit();
            SuspendLayout();
            // 
            // dataGridSkola
            // 
            dataGridSkola.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSkola.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, NazevSkoly, Poznamka, dataGridViewTextBoxColumn4 });
            dataGridSkola.Location = new Point(236, 3);
            dataGridSkola.MultiSelect = false;
            dataGridSkola.Name = "dataGridSkola";
            dataGridSkola.RowTemplate.Height = 25;
            dataGridSkola.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridSkola.Size = new Size(443, 150);
            dataGridSkola.TabIndex = 45;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 97);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 43;
            label8.Text = "ID Školy";
            // 
            // button2
            // 
            button2.Location = new Point(74, 144);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 42;
            button2.Text = "Uprav";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxRocnik
            // 
            textBoxRocnik.Location = new Point(116, 57);
            textBoxRocnik.Name = "textBoxRocnik";
            textBoxRocnik.Size = new Size(100, 23);
            textBoxRocnik.TabIndex = 41;
            // 
            // textOborStudia
            // 
            textOborStudia.Location = new Point(10, 57);
            textOborStudia.Name = "textOborStudia";
            textOborStudia.Size = new Size(100, 23);
            textOborStudia.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(116, 39);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 39;
            label5.Text = "Rocnik";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 39);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 38;
            label6.Text = "OborStudia";
            // 
            // labelIDInput
            // 
            labelIDInput.AutoSize = true;
            labelIDInput.Location = new Point(116, 12);
            labelIDInput.Name = "labelIDInput";
            labelIDInput.Size = new Size(17, 15);
            labelIDInput.TabIndex = 47;
            labelIDInput.Text = "id";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(89, 12);
            labelID.Name = "labelID";
            labelID.Size = new Size(21, 15);
            labelID.TabIndex = 46;
            labelID.Text = "ID:";
            // 
            // comboBoxSkola
            // 
            comboBoxSkola.FormattingEnabled = true;
            comboBoxSkola.Location = new Point(10, 115);
            comboBoxSkola.Name = "comboBoxSkola";
            comboBoxSkola.Size = new Size(199, 23);
            comboBoxSkola.TabIndex = 54;
            // 
            // StudentDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 171);
            Controls.Add(comboBoxSkola);
            Controls.Add(labelIDInput);
            Controls.Add(labelID);
            Controls.Add(dataGridSkola);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(textBoxRocnik);
            Controls.Add(textOborStudia);
            Controls.Add(label5);
            Controls.Add(label6);
            Name = "StudentDetail";
            Text = "StudentDetail";
            ((System.ComponentModel.ISupportInitialize)dataGridSkola).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridSkola;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn NazevSkoly;
        private DataGridViewTextBoxColumn Poznamka;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        public Label label8;
        private Button button2;
        public TextBox textBoxRocnik;
        public TextBox textOborStudia;
        public Label label5;
        public Label label6;
        public Label labelIDInput;
        public Label labelID;
        public ComboBox comboBoxSkola;
    }
}