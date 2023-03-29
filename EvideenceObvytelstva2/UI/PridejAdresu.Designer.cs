namespace EvideenceObvytelstva2.UI
{
    partial class PridejAdresu
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
            SuspendLayout();
            // 
            // textBoxObec
            // 
            textBoxObec.Location = new Point(127, 116);
            textBoxObec.Name = "textBoxObec";
            textBoxObec.Size = new Size(100, 23);
            textBoxObec.TabIndex = 27;
            // 
            // textBoxPsc
            // 
            textBoxPsc.Location = new Point(21, 116);
            textBoxPsc.Name = "textBoxPsc";
            textBoxPsc.Size = new Size(100, 23);
            textBoxPsc.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(127, 98);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 25;
            label7.Text = "Obec";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 98);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 24;
            label8.Text = "PSC";
            // 
            // button2
            // 
            button2.Location = new Point(87, 157);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 23;
            button2.Text = "Přidej";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxPopisne
            // 
            textBoxPopisne.Location = new Point(127, 59);
            textBoxPopisne.Name = "textBoxPopisne";
            textBoxPopisne.Size = new Size(100, 23);
            textBoxPopisne.TabIndex = 22;
            // 
            // textBoxUlice
            // 
            textBoxUlice.Location = new Point(21, 59);
            textBoxUlice.Name = "textBoxUlice";
            textBoxUlice.Size = new Size(100, 23);
            textBoxUlice.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(127, 41);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 20;
            label5.Text = "CisloPopisne";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 41);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 19;
            label6.Text = "Ulice";
            // 
            // PridejAdresu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 205);
            Controls.Add(textBoxObec);
            Controls.Add(textBoxPsc);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(textBoxPopisne);
            Controls.Add(textBoxUlice);
            Controls.Add(label5);
            Controls.Add(label6);
            Name = "PridejAdresu";
            Text = "PridejAdresu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        public TextBox textBoxObec;
        public TextBox textBoxPsc;
        public Label label7;
        public Label label8;
        public TextBox textBoxPopisne;
        public TextBox textBoxUlice;
        public Label label5;
        public Label label6;
    }
}