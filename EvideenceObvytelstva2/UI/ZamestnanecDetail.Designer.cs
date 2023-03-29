namespace EvideenceObvytelstva2.UI
{
    partial class ZamestnanecDetail
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
            labelIDInput = new Label();
            labelID = new Label();
            dateTimePicker = new DateTimePicker();
            dataGridZamestnani = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            NazevFirmy = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            textBoxZamestnaniID = new TextBox();
            label8 = new Label();
            button2 = new Button();
            textBoxOddeleni = new TextBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridZamestnani).BeginInit();
            SuspendLayout();
            // 
            // labelIDInput
            // 
            labelIDInput.AutoSize = true;
            labelIDInput.Location = new Point(111, 25);
            labelIDInput.Name = "labelIDInput";
            labelIDInput.Size = new Size(17, 15);
            labelIDInput.TabIndex = 49;
            labelIDInput.Text = "id";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(84, 25);
            labelID.Name = "labelID";
            labelID.Size = new Size(21, 15);
            labelID.TabIndex = 48;
            labelID.Text = "ID:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(15, 130);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(208, 23);
            dateTimePicker.TabIndex = 57;
            // 
            // dataGridZamestnani
            // 
            dataGridZamestnani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridZamestnani.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, NazevFirmy, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dataGridZamestnani.Location = new Point(293, 54);
            dataGridZamestnani.MultiSelect = false;
            dataGridZamestnani.Name = "dataGridZamestnani";
            dataGridZamestnani.RowTemplate.Height = 25;
            dataGridZamestnani.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridZamestnani.Size = new Size(443, 150);
            dataGridZamestnani.TabIndex = 56;
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
            // textBoxZamestnaniID
            // 
            textBoxZamestnaniID.Location = new Point(146, 72);
            textBoxZamestnaniID.Name = "textBoxZamestnaniID";
            textBoxZamestnaniID.Size = new Size(100, 23);
            textBoxZamestnaniID.TabIndex = 55;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(146, 51);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 54;
            label8.Text = "ID Zamestnani";
            // 
            // button2
            // 
            button2.Location = new Point(212, 181);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 53;
            button2.Text = "Uprav";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxOddeleni
            // 
            textBoxOddeleni.Location = new Point(15, 72);
            textBoxOddeleni.Name = "textBoxOddeleni";
            textBoxOddeleni.Size = new Size(100, 23);
            textBoxOddeleni.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 51);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 51;
            label5.Text = "Oddělení: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 110);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 50;
            label6.Text = "Datum Nástupu:";
            // 
            // ZamestnanecDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 217);
            Controls.Add(dateTimePicker);
            Controls.Add(dataGridZamestnani);
            Controls.Add(textBoxZamestnaniID);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(textBoxOddeleni);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(labelIDInput);
            Controls.Add(labelID);
            Name = "ZamestnanecDetail";
            Text = "ZamestnanecDetail";
            ((System.ComponentModel.ISupportInitialize)dataGridZamestnani).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labelIDInput;
        public Label labelID;
        public DateTimePicker dateTimePicker;
        public DataGridView dataGridZamestnani;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn NazevFirmy;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        public TextBox textBoxZamestnaniID;
        public Label label8;
        public Button button2;
        public TextBox textBoxOddeleni;
        public Label label5;
        public Label label6;
    }
}