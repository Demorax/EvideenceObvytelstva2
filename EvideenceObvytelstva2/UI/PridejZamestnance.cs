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
    public partial class PridejZamestnance : Form
    {

        Zamestnanec zamestnanec;
        Form1 mainForm;
        public PridejZamestnance(Form1 form)
        {
            InitializeComponent();
            this.mainForm = form;
            FillDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TODO čeknout všechny textboxy
            if (string.IsNullOrEmpty(textBoxOddeleni.Text))
            {
                MessageBox.Show("Políčko Obec nevyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxOddeleni.Focus();
                return;
            }
            zamestnanec = new Zamestnanec();
            if (mainForm.zamestnaniManager.ZamestnaniExist(int.Parse(textBoxZamestnaniID.Text)))
            {
                DateTime dateTime = dateTimePicker.Value;
                DateOnly dateOnly = DateOnly.FromDateTime(dateTime);
                zamestnanec.Nastup = dateOnly;
                zamestnanec.Oddeleni = textBoxOddeleni.Text;
                zamestnanec.ZamestnaniId = int.Parse(textBoxZamestnaniID.Text);
            }
            else
            {
                MessageBox.Show("Zamestnanec nepřidán do databáze, Zaměstnání neexistuje", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (mainForm.zamestnanecManager.Add(zamestnanec))
            {
                MessageBox.Show("Zamestnanec přidán do databáze", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Zamestnanec nepřidán do databáze", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FillDataGrid()
        {
            dataGridZamestnani.Rows.Clear();
            List<Zamestnani> temp = mainForm.zamestnaniManager.GetAll();

            foreach (Zamestnani item in temp)
            {
                dataGridZamestnani.Rows.Add(item.Id, item.NazevFirmy, item.Poznamka, item.AdresaId);
            }

        }
    }
}
