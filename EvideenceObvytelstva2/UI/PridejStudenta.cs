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
            if (string.IsNullOrEmpty(textBoxRocnik.Text) || string.IsNullOrEmpty(textOborStudia.Text))
            {
                MessageBox.Show("Políčko Rocnik nebo Obor Studia nevyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxRocnik.Focus();
                return;
            }
            student = new Student();
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
            } else
            {
                MessageBox.Show("Políčko Ročník musí být vyplněno a pouze číslo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            student.OborStudia = textOborStudia.Text;

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
            comboBoxSkola.Items.Clear();
            List<Skola> temp = mainForm.skolaManager.GetAll();

            foreach (Skola item in temp)
            {
                dataGridSkola.Rows.Add(item.Id, item.NazevSkoly, item.Poznamka, item.AdresaId);
                comboBoxSkola.Items.Add(item);
            }
            comboBoxSkola.SelectedIndex = 0;

        }
    }
}
