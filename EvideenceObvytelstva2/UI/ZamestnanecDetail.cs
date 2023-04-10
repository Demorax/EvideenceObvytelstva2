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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxOddeleni.Text))
            {
                MessageBox.Show("Políčko Oddělení nevyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxOddeleni.Focus();
                return;
            }
            Zamestnanec zamestnanec = new Zamestnanec();
            object? selectedZamestnani = comboBoxZamestnani.SelectedItem;
            if (selectedZamestnani == null)
            {
                MessageBox.Show("Políčko Zaměstnání musí být vyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Zamestnani zamestnani = selectedZamestnani as Zamestnani;
                zamestnanec.ZamestnaniId = zamestnani.Id;
            }

            DateTime dateTime = dateTimePicker.Value;
            DateOnly dateOnly = DateOnly.FromDateTime(dateTime);
            zamestnanec.Id = int.Parse(labelIDInput.Text);
            zamestnanec.Nastup = dateOnly;
            zamestnanec.Oddeleni = textBoxOddeleni.Text;

            if (mainForm.zamestnanecManager.Update(zamestnanec))
            {
                MessageBox.Show("Zamestnanec upraven", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Zamestnanec neupraven", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void dataZamestnani(int id)
        {
            dataGridZamestnani.Rows.Clear();
            
            Zamestnani zamestnani = mainForm.zamestnaniManager.GetZamestnani(id);

            dataGridZamestnani.Rows.Add(zamestnani.Id, zamestnani.NazevFirmy, zamestnani.Poznamka, zamestnani.AdresaId);
            

        }
    }
}
