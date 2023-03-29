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
            List<Adresa> temp = mainForm.adresaManager.GetAll();

            foreach (Adresa item in temp)
            {
                dataGridAddress.Rows.Add(item.Id, item.Ulice, item.cisloPopisne, item.psc, item.Obec);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //TODO čeknout všechny textboxy
            if (string.IsNullOrEmpty(textBoxPoznamka.Text))
            {
                MessageBox.Show("Políčko Obec nevyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPoznamka.Focus();
                return;
            }
            zamestnani = new Zamestnani();
            if (mainForm.adresaManager.AdresaExist(int.Parse(textBoxAdresaID.Text)))
            {
                zamestnani.NazevFirmy = textNazevZamestnani.Text;
                zamestnani.Poznamka = textBoxPoznamka.Text;
                zamestnani.AdresaId = int.Parse(textBoxAdresaID.Text);
            }
            else
            {
                MessageBox.Show("Zaměstnání nepřidáno do databáze, Adresa neexistuje", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
