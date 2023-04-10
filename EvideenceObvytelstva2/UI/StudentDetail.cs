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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxRocnik.Text) || string.IsNullOrEmpty(textOborStudia.Text))
            {
                MessageBox.Show("Políčko Rocnik nebo Obor Studia nevyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxRocnik.Focus();
                return;
            }
            Student student = new Student();
            object? selectedSkola = comboBoxSkola.SelectedItem;
            if (selectedSkola == null)
            {
                MessageBox.Show("Políčko Škola musí být vyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Skola skola = selectedSkola as Skola;
                student.SkolaId = skola.Id;
            }
            int rocnik;
            if (int.TryParse(textBoxRocnik.Text, out rocnik))
            {
                student.Rocnik = rocnik;
            }
            else
            {
                MessageBox.Show("Políčko Ročník musí být vyplněno a pouze číslo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            student.Id = int.Parse(labelIDInput.Text);
            student.OborStudia = textOborStudia.Text;

            if (mainForm.studentManager.Update(student))
            {
                MessageBox.Show("Student upraven", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Student neupraven", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void dataSkola(int id)
        {
            dataGridSkola.Rows.Clear();

            Skola skola = mainForm.skolaManager.GetSkola(id);

            dataGridSkola.Rows.Add(skola.Id, skola.NazevSkoly, skola.Poznamka, skola.AdresaId);

        }
    }
}
