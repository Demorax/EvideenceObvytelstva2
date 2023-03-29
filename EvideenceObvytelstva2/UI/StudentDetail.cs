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
    public partial class StudentDetail : Form
    {
        Form1 mainForm;
        public StudentDetail(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            FillDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxRocnik.Text))
            {
                MessageBox.Show("Políčko Obec nevyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxRocnik.Focus();
                return;
            }
            Student student = new Student();
            student.Id = int.Parse(labelIDInput.Text);
            student.Rocnik = int.Parse(textBoxRocnik.Text);
            student.OborStudia = textOborStudia.Text;
            if (mainForm.skolaManager.SkolaExist(int.Parse(textBoxSkolaID.Text)))
            {
                
                student.SkolaId = int.Parse(textBoxSkolaID.Text);
            }
            else
            {
                MessageBox.Show("Student neupraven, Škola neexistuje", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (mainForm.studentManager.Update(student))
            {
                MessageBox.Show("Student upraven", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Student neupraven", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
