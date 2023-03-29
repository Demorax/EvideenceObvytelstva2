namespace EvideenceObvytelstva2.UI
{
    partial class AdresaDetail
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
            textBoxObec = new TextBox();
            textBoxPsc = new TextBox();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            textBoxPopisne = new TextBox();
            textBoxUlice = new TextBox();
            label5 = new Label();
            label6 = new Label();
            labelID = new Label();
            labelIDInput = new Label();
            SuspendLayout();
            // 
            // textBoxObec
            // 
            textBoxObec.Location = new Point(118, 128);
            textBoxObec.Name = "textBoxObec";
            textBoxObec.Size = new Size(100, 23);
            textBoxObec.TabIndex = 36;
            // 
            // textBoxPsc
            // 
            textBoxPsc.Location = new Point(12, 128);
            textBoxPsc.Name = "textBoxPsc";
            textBoxPsc.Size = new Size(100, 23);
            textBoxPsc.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(118, 110);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 34;
            label7.Text = "Obec";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 110);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 33;
            label8.Text = "PSC";
            // 
            // button2
            // 
            button2.Location = new Point(78, 169);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 32;
            button2.Text = "Uprav";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxPopisne
            // 
            textBoxPopisne.Location = new Point(118, 71);
            textBoxPopisne.Name = "textBoxPopisne";
            textBoxPopisne.Size = new Size(100, 23);
            textBoxPopisne.TabIndex = 31;
            // 
            // textBoxUlice
            // 
            textBoxUlice.Location = new Point(12, 71);
            textBoxUlice.Name = "textBoxUlice";
            textBoxUlice.Size = new Size(100, 23);
            textBoxUlice.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 53);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 29;
            label5.Text = "CisloPopisne";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 53);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 28;
            label6.Text = "Ulice";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(91, 21);
            labelID.Name = "labelID";
            labelID.Size = new Size(21, 15);
            labelID.TabIndex = 37;
            labelID.Text = "ID:";
            // 
            // labelIDInput
            // 
            labelIDInput.AutoSize = true;
            labelIDInput.Location = new Point(118, 21);
            labelIDInput.Name = "labelIDInput";
            labelIDInput.Size = new Size(17, 15);
            labelIDInput.TabIndex = 38;
            labelIDInput.Text = "id";
            // 
            // AdresaDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(226, 216);
            Controls.Add(labelIDInput);
            Controls.Add(labelID);
            Controls.Add(textBoxObec);
            Controls.Add(textBoxPsc);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(textBoxPopisne);
            Controls.Add(textBoxUlice);
            Controls.Add(label5);
            Controls.Add(label6);
            Name = "AdresaDetail";
            Text = "AdresaDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBoxObec;
        public TextBox textBoxPsc;
        public Label label7;
        public Label label8;
        public TextBox textBoxPopisne;
        public TextBox textBoxUlice;
        public Label label5;
        public Label label6;
        public Button button2;
        public Label labelID;
        public Label labelIDInput;
    }
}