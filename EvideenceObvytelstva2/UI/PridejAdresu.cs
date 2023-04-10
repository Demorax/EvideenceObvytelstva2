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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            if (string.IsNullOrEmpty(textBoxObec.Text) || string.IsNullOrEmpty(textBoxUlice.Text))
            {
                MessageBox.Show("Políčko Obec nebo Ulice nevyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxObec.Focus();
                return;
            }
            adresa = new Adresa();
            adresa.Ulice = textBoxUlice.Text;
            int cisloPopisne;
            if (int.TryParse(textBoxPopisne.Text, out cisloPopisne))
            {
                adresa.cisloPopisne = cisloPopisne;
            }
            else
            {
                MessageBox.Show("Políčko cisloPopisne špatně vyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPopisne.Focus();
                return;
            }
            int psc;
            if (int.TryParse(textBoxPsc.Text, out psc))
            {
                adresa.psc = psc;
            }
            else
            {
                MessageBox.Show("Políčko psc špatně vyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPopisne.Focus();
                return;
            }
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
