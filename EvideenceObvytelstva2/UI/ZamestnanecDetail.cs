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
    public partial class ZamestnanecDetail : Form
    {
        Form1 mainForm;
        public ZamestnanecDetail(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
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
            Zamestnanec zamestnanec = new Zamestnanec();
            if (mainForm.zamestnaniManager.ZamestnaniExist(int.Parse(textBoxZamestnaniID.Text)))
            {
                zamestnanec.Id = int.Parse(labelIDInput.Text);
                DateTime dateTime = dateTimePicker.Value;
                DateOnly dateOnly = DateOnly.FromDateTime(dateTime);
                zamestnanec.Nastup = dateOnly;
                zamestnanec.Oddeleni = textBoxOddeleni.Text;
                zamestnanec.ZamestnaniId = int.Parse(textBoxZamestnaniID.Text);
            }
            else
            {
                MessageBox.Show("Zamestnanec neupraven, Zaměstnání neexistuje", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (mainForm.zamestnanecManager.Update(zamestnanec))
            {
                MessageBox.Show("Zamestnanec upraven", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Zamestnanec neupraven", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
