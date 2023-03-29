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
            Zamestnani zamestnani = new Zamestnani();
            if (mainForm.adresaManager.AdresaExist(int.Parse(textBoxAdresaID.Text)))
            {
                zamestnani.Id = int.Parse(labelIDInput.Text);
                zamestnani.NazevFirmy = textNazevZamestnani.Text;
                zamestnani.Poznamka = textBoxPoznamka.Text;
                zamestnani.AdresaId = int.Parse(textBoxAdresaID.Text);
            }
            else
            {
                MessageBox.Show("Zaměstnání neupraveno, Adresa neexistuje", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (mainForm.zamestnaniManager.Update(zamestnani))
            {
                MessageBox.Show("Zaměstnání upraveno", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Zaměstnání neupraveno", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
