using EvideenceObvytelstva2.Manager;
using EvideenceObvytelstva2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvideenceObvytelstva2.UI
{
    public partial class PridejAdresu : Form
    {
        Form1 mainForm;
        Adresa adresa { get; set; }
        public PridejAdresu(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TODO čeknout všechny textboxy
            if (string.IsNullOrEmpty(textBoxObec.Text))
            {
                MessageBox.Show("Políčko Obec nevyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxObec.Focus();
                return;
            }
            adresa = new Adresa();
            adresa.Ulice = textBoxUlice.Text;
            adresa.cisloPopisne = int.Parse(textBoxPopisne.Text);
            adresa.psc = int.Parse(textBoxPsc.Text);
            adresa.Obec = textBoxObec.Text;
            if (mainForm.adresaManager.Add(adresa))
            {
                MessageBox.Show("Adresa přidána do databáze", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Adresa nepřidána do databáze", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
