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
            Skola skola = new Skola();
            if (mainForm.adresaManager.AdresaExist(int.Parse(textBoxAdresaID.Text)))
            {
                skola.Id = int.Parse(labelIDInput.Text);
                skola.NazevSkoly = textNazevSkoly.Text;
                skola.Poznamka = textBoxPoznamka.Text;
                skola.AdresaId = int.Parse(textBoxAdresaID.Text);
            }
            else
            {
                MessageBox.Show("Škola neupravena, Adresa neexistuje", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (mainForm.skolaManager.Update(skola))
            {
                MessageBox.Show("Škola upravnea", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Škola neupravena", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FillDataGrid()
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
