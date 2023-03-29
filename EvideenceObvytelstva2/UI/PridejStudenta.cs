using EvideenceObvytelstva2.Manager;
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
    public partial class PridejStudenta : Form
    {
        Form1 mainForm;
        Student student = new Student();
        public PridejStudenta(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            FillDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TODO čeknout všechny textboxy
            if (string.IsNullOrEmpty(textBoxRocnik.Text))
            {
                MessageBox.Show("Políčko Obec nevyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxObec.Focus();
                return;
            }
            student = new Student();
            if (mainForm.skolaManager.SkolaExist(int.Parse(textBoxSkolaID.Text)))
            {
                student.Rocnik = int.Parse(textBoxRocnik.Text);
                student.OborStudia = textOborStudia.Text;
                student.SkolaId = int.Parse(textBoxSkolaID.Text);
            } else
            {
                MessageBox.Show("Student nepřidán do databáze, Škola neexistuje", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (mainForm.studentManager.Add(student))
            {
                MessageBox.Show("Student přidán do databáze", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Student nepřidán do databáze", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void FillDataGrid()
        {
            dataGridSkola.Rows.Clear();
            List<Skola> temp = mainForm.skolaManager.GetAll();

            foreach (Skola item in temp)
            {
                dataGridSkola.Rows.Add(item.Id, item.NazevSkoly, item.Poznamka, item.AdresaId);
            }

        }
    }
}
