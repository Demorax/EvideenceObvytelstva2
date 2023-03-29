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
            //TODO čeknout všechny textboxy
            if (string.IsNullOrEmpty(textBoxPoznamka.Text))
            {
                MessageBox.Show("Políčko Obec nevyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPoznamka.Focus();
                return;
            }
            skola = new Skola();
            if (mainForm.adresaManager.AdresaExist(int.Parse(textBoxAdresaID.Text)))
            {
                skola.NazevSkoly = textNazevSkoly.Text;
                skola.Poznamka = textBoxPoznamka.Text;
                skola.AdresaId = int.Parse(textBoxAdresaID.Text);
            }
            else
            {
                MessageBox.Show("Škola nepřidána do databáze, Adresa neexistuje", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            List<Adresa> temp = mainForm.adresaManager.GetAll();

            foreach (Adresa item in temp)
            {
                dataGridAddress.Rows.Add(item.Id, item.Ulice, item.cisloPopisne, item.psc, item.Obec);
            }

        }
    }
}
