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
    public partial class ZamestnaniDetail : Form
    {
        Form1 mainForm;
        public ZamestnaniDetail(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPoznamka.Text) || string.IsNullOrEmpty(textNazevZamestnani.Text))
            {
                MessageBox.Show("Políčko Poznámka nebo Název Zaměstnání nevyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPoznamka.Focus();
                return;
            }
            Zamestnani zamestnani = new Zamestnani();
            object? selectedAdresa = comboBoxAdresa.SelectedItem;
            if (selectedAdresa == null)
            {
                MessageBox.Show("Políčko Adresa musí být vyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Adresa adresa = selectedAdresa as Adresa;
                zamestnani.AdresaId = adresa.Id;
            }
            zamestnani.Id = int.Parse(labelIDInput.Text);
            zamestnani.NazevFirmy = textNazevZamestnani.Text;
            zamestnani.Poznamka = textBoxPoznamka.Text;

            if (mainForm.zamestnaniManager.Update(zamestnani))
            {
                MessageBox.Show("Zaměstnání upraveno", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Zaměstnání neupraveno", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void dataAdresa(int id)
        {
            dataGridAddress.Rows.Clear();
            Adresa adresa = mainForm.adresaManager.GetAdresa(id);

            dataGridAddress.Rows.Add(adresa.Id, adresa.Ulice, adresa.cisloPopisne, adresa.psc, adresa.Obec);


        }
    }
}
