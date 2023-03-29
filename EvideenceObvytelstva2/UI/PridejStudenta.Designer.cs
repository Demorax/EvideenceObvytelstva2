namespace EvideenceObvytelstva2.UI
{
    partial class PridejStudenta
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
            textBoxSkolaID = new TextBox();
            label8 = new Label();
            button2 = new Button();
            textBoxRocnik = new TextBox();
            textOborStudia = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dataGridSkola = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            NazevSkoly = new DataGridViewTextBoxColumn();
            Poznamka = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridSkola).BeginInit();
            SuspendLayout();
            // 
            // textBoxSkolaID
            // 
            textBoxSkolaID.Location = new Point(19, 118);
            textBoxSkolaID.Name = "textBoxSkolaID";
            textBoxSkolaID.Size = new Size(100, 23);
            textBoxSkolaID.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 100);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 33;
            label8.Text = "ID Školy";
            // 
            // button2
            // 
            button2.Location = new Point(150, 118);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 32;
            button2.Text = "Přidej";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxRocnik
            // 
            textBoxRocnik.Location = new Point(125, 61);
            textBoxRocnik.Name = "textBoxRocnik";
            textBoxRocnik.Size = new Size(100, 23);
            textBoxRocnik.TabIndex = 31;
            // 
            // textOborStudia
            // 
            textOborStudia.Location = new Point(19, 61);
            textOborStudia.Name = "textOborStudia";
            textOborStudia.Size = new Size(100, 23);
            textOborStudia.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 43);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 29;
            label5.Text = "Rocnik";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 43);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 28;
            label6.Text = "OborStudia";
            // 
            // dataGridSkola
            // 
            dataGridSkola.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSkola.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, NazevSkoly, Poznamka, dataGridViewTextBoxColumn4 });
            dataGridSkola.Location = new Point(255, 32);
            dataGridSkola.MultiSelect = false;
            dataGridSkola.Name = "dataGridSkola";
            dataGridSkola.RowTemplate.Height = 25;
            dataGridSkola.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridSkola.Size = new Size(443, 150);
            dataGridSkola.TabIndex = 37;
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
            // PridejStudenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 198);
            Controls.Add(dataGridSkola);
            Controls.Add(textBoxSkolaID);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(textBoxRocnik);
            Controls.Add(textOborStudia);
            Controls.Add(label5);
            Controls.Add(label6);
            Name = "PridejStudenta";
            Text = "PridejStudenta";
            ((System.ComponentModel.ISupportInitialize)dataGridSkola).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBoxObec;
        public TextBox textBoxSkolaID;
        public Label label7;
        public Label label8;
        private Button button2;
        public TextBox textBoxRocnik;
        public TextBox textOborStudia;
        public Label label5;
        public Label label6;
        private DataGridView dataGridSkola;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn NazevSkoly;
        private DataGridViewTextBoxColumn Poznamka;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}