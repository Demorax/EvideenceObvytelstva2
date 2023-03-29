namespace EvideenceObvytelstva2.UI
{
    partial class PridejZamestnance
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
            textBoxZamestnaniID = new TextBox();
            label8 = new Label();
            button2 = new Button();
            textBoxOddeleni = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dataGridZamestnani = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            NazevFirmy = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dateTimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridZamestnani).BeginInit();
            SuspendLayout();
            // 
            // textBoxZamestnaniID
            // 
            textBoxZamestnaniID.Location = new Point(149, 30);
            textBoxZamestnaniID.Name = "textBoxZamestnaniID";
            textBoxZamestnaniID.Size = new Size(100, 23);
            textBoxZamestnaniID.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(149, 9);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 43;
            label8.Text = "ID Zamestnani";
            // 
            // button2
            // 
            button2.Location = new Point(215, 139);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 42;
            button2.Text = "Přidej";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxOddeleni
            // 
            textBoxOddeleni.Location = new Point(18, 30);
            textBoxOddeleni.Name = "textBoxOddeleni";
            textBoxOddeleni.Size = new Size(100, 23);
            textBoxOddeleni.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 9);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 39;
            label5.Text = "Oddělení: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 68);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 38;
            label6.Text = "Datum Nástupu:";
            // 
            // dataGridZamestnani
            // 
            dataGridZamestnani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridZamestnani.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, NazevFirmy, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dataGridZamestnani.Location = new Point(296, 12);
            dataGridZamestnani.MultiSelect = false;
            dataGridZamestnani.Name = "dataGridZamestnani";
            dataGridZamestnani.RowTemplate.Height = 25;
            dataGridZamestnani.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridZamestnani.Size = new Size(443, 150);
            dataGridZamestnani.TabIndex = 45;
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
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(18, 88);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(208, 23);
            dateTimePicker.TabIndex = 46;
            // 
            // PridejZamestnance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 203);
            Controls.Add(dateTimePicker);
            Controls.Add(dataGridZamestnani);
            Controls.Add(textBoxZamestnaniID);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(textBoxOddeleni);
            Controls.Add(label5);
            Controls.Add(label6);
            Name = "PridejZamestnance";
            Text = "PridejZamestnance";
            ((System.ComponentModel.ISupportInitialize)dataGridZamestnani).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBoxZamestnaniID;
        public Label label8;
        private Button button2;
        public TextBox textBoxOddeleni;
        public Label label5;
        public Label label6;
        private DataGridView dataGridZamestnani;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn NazevFirmy;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DateTimePicker dateTimePicker;
    }
}