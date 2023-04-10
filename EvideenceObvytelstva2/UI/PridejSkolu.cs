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
    public partial class PridejSkolu : Form
    {
        Skola skola;
        Form1 mainForm;

        public PridejSkolu(Form1 form)
        {
            InitializeComponent();
            this.mainForm = form;
            FillDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPoznamka.Text) || string.IsNullOrEmpty(textNazevSkoly.Text) )
            {
                MessageBox.Show("Políčko Poznámka nebo Název Školy nevyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPoznamka.Focus();
                return;
            }
            skola = new Skola();
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
            skola.NazevSkoly = textNazevSkoly.Text;
            skola.Poznamka = textBoxPoznamka.Text;
            
            if (mainForm.skolaManager.Add(skola))
            {
                MessageBox.Show("Škola přidána do databáze", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Škola nepřidána do databáze", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void FillDataGrid()
        {
            dataGridAddress.Rows.Clear();
            comboBoxAdresa.Items.Clear();
            List<Adresa> temp = mainForm.adresaManager.GetAll();

            foreach (Adresa item in temp)
            {
                dataGridAddress.Rows.Add(item.Id, item.Ulice, item.cisloPopisne, item.psc, item.Obec);
                comboBoxAdresa.Items.Add(item);
            }
            comboBoxAdresa.SelectedIndex = 0;

        }
    }
}
