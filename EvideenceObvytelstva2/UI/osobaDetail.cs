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
    public partial class osobaDetail : Form
    {
        OsobaManager osobaManager;

        Form1 mainForm;
        public osobaDetail(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

                if (string.IsNullOrEmpty(textBoxJmeno.Text))
                {
                    MessageBox.Show("Políčko jméno nevyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxJmeno.Focus();
                    return;
                }

                Osoba osoba = new Osoba();
                osoba.Id = Convert.ToInt32(labelID.Text);
                osoba.KrestniJmeno = textBoxJmeno.Text;
                osoba.Prijmeni = textBoxPrijmeni.Text;
                osoba.Titul = comboBoxTituly.SelectedItem.ToString();
                osoba.Vek = int.Parse(textBoxVek.Text);
                osoba.AddressId = int.Parse(textBoxAdresaId.Text);

                try
                {
                    if (string.IsNullOrEmpty(textBoxZamestnanecID.Text))
                    {
                        osoba.ZamestnanecId = null;
                    }
                    else
                    {
                        osoba.ZamestnanecId = int.Parse(textBoxZamestnanecID.Text);
                    }

                    if (string.IsNullOrEmpty(textBoxStudentID.Text))
                    {
                        osoba.StudentId = null;
                    }
                    else
                    {
                        osoba.StudentId = int.Parse(textBoxStudentID.Text);
                    }

                    if (!mainForm.adresaManager.AdresaExist(osoba.AddressId))
                    {
                        MessageBox.Show("Daná adresa se v databázi nenachází, objekt Osoba nebyl vytvořen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (!mainForm.studentManager.StudentExist(osoba.StudentId) && osoba.StudentId != null)
                    {
                        MessageBox.Show("Daný student se v databázi nenachází, objekt Osoba nebyl vytvořen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }


                    if (!mainForm.zamestnanecManager.ZamestnanecExist(osoba.ZamestnanecId) && osoba.ZamestnanecId != null)
                    {
                        MessageBox.Show("Daný zaměstnanec se v databázi nenachází, objekt Osoba nebyl vytvořen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (mainForm.osobaManager.Update(osoba))
                {
                    MessageBox.Show("Osoba přidána do databáze", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainForm.dataOsoba();
                }
                else
                {
                    MessageBox.Show("Osoba nepřidána do databáze", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            
         }

        public void Reset()
        {
            try
            {
                dataAdresa(int.Parse(textBoxAdresaId.Text));
                //dataSkola();
                dataStudent(int.Parse(textBoxStudentID.Text));
                dataZamestnanec(int.Parse(textBoxZamestnanecID.Text));
                //dataZamestnani();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void dataSkola()
        {
            dataGridSkola.Rows.Clear();
            List<Skola> temp = mainForm.skolaManager.GetAll();

            foreach (Skola item in temp)
            {
                dataGridSkola.Rows.Add(item.Id, item.NazevSkoly, item.Poznamka, item.AdresaId);
            }

        }
        public void dataAdresa(int id)
        {
            dataGridAddress.Rows.Clear();
            Adresa adresa = mainForm.adresaManager.GetAdresa(id);

            dataGridAddress.Rows.Add(adresa.Id, adresa.Ulice, adresa.cisloPopisne, adresa.psc, adresa.Obec);


        }

        public void dataZamestnani(int id)
        {
            dataGridZamestnani.Rows.Clear();
            List<Zamestnani> temp = mainForm.zamestnaniManager.GetAll();

            foreach (Zamestnani item in temp)
            {
                dataGridZamestnani.Rows.Add(item.Id, item.NazevFirmy, item.Poznamka, item.AdresaId);
            }

        }

        public void dataStudent(int id)
        {
            dataGridStudent.Rows.Clear();
            Student student = mainForm.studentManager.GetStudent(id);
            dataGridStudent.Rows.Add(student.Id, student.OborStudia, student.Rocnik, student.SkolaId);


        }

        public void dataZamestnanec(int id)
        {
            dataGridZamestnanec.Rows.Clear();
            Zamestnanec zamestnanec = mainForm.zamestnanecManager.GetZamestnanec(id);
            dataGridZamestnanec.Rows.Add(zamestnanec.Id, zamestnanec.Nastup, zamestnanec.Oddeleni, zamestnanec.ZamestnaniId);


        }

    }
}
