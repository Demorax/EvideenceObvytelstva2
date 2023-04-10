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
    public partial class PridejZamestnani : Form
    {
        Zamestnani zamestnani;
        Form1 mainForm;
        public PridejZamestnani(Form1 form)
        {
            InitializeComponent();
            this.mainForm = form;
            FillDataGrid();
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPoznamka.Text) || string.IsNullOrEmpty(textNazevZamestnani.Text))
            {
                MessageBox.Show("Políčko Poznámka nebo Název Zaměstnání nevyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPoznamka.Focus();
                return;
            }
            zamestnani = new Zamestnani();
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
            zamestnani.NazevFirmy = textNazevZamestnani.Text;
            zamestnani.Poznamka = textBoxPoznamka.Text;

            if (mainForm.zamestnaniManager.Add(zamestnani))
            {
                MessageBox.Show("Zaměstnání přidáno do databáze", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Zaměstnání nepřidáno do databáze", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
