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
    public partial class AdresaDetail : Form
    {
        AdresaManager adresaManager;
        Form1 mainForm;
        public AdresaDetail(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxUlice.Text))
            {
                MessageBox.Show("Políčko jméno nevyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUlice.Focus();
                return;
            }
            Adresa adresa = new Adresa();
            try
            {
                adresa.Id = Convert.ToInt32(labelIDInput.Text);
                adresa.Ulice = textBoxUlice.Text;
                adresa.cisloPopisne = int.Parse(textBoxPopisne.Text);
                adresa.psc = int.Parse(textBoxPsc.Text);
                adresa.Obec = textBoxObec.Text;

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (mainForm.adresaManager.Update(adresa))
            {
                MessageBox.Show("Adresa upravena", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm.dataOsoba();
            }
            else
            {
                MessageBox.Show("Osoba nepřidána do databáze", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
