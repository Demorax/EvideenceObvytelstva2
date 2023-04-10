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
    public partial class SkolaDetail : Form
    {
        Form1 mainForm;
        public SkolaDetail(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPoznamka.Text) || string.IsNullOrEmpty(textNazevSkoly.Text))
            {
                MessageBox.Show("Políčko Poznámka nebo Název Školy nevyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPoznamka.Focus();
                return;
            }
            Skola skola = new Skola();
            object? selectedAdresa = comboBoxAdresa.SelectedItem;
            if (selectedAdresa == null)
            {
                MessageBox.Show("Políčko Adresa musí být vyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Adresa adresa = selectedAdresa as Adresa;
                skola.AdresaId = adresa.Id;
            }
            skola.Id = int.Parse(labelIDInput.Text);
            skola.NazevSkoly = textNazevSkoly.Text;
            skola.Poznamka = textBoxPoznamka.Text;

            if (mainForm.skolaManager.Update(skola))
            {
                MessageBox.Show("Škola upravnea", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Škola neupravena", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
