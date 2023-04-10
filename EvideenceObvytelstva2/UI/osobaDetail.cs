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

            if (string.IsNullOrEmpty(textBoxJmeno.Text) || string.IsNullOrEmpty(textBoxPrijmeni.Text))
            {
                MessageBox.Show("Políčko jméno nebo příjmení nevyplněno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxJmeno.Focus();
                textBoxPrijmeni.Focus();
                return;
            }


            Osoba osoba = new Osoba();

            try
            {
                osoba.Id = Convert.ToInt32(labelID.Text);
                object? selectedTitulPred = comboBoxTitulyPred.SelectedItem;
                osoba.KrestniJmeno = textBoxJmeno.Text;
                osoba.Prijmeni = textBoxPrijmeni.Text;
                object? selectedTitulZa = comboBoxTitulyZa.SelectedItem;

                object selectedAdresa = comboBoxAdresa.SelectedItem;
                Adresa adresa = selectedAdresa as Adresa;
                osoba.AddressId = adresa.Id;

                object? selectedStudent = comboBoxStudent.SelectedItem;
                object? selectedZamestnanec = comboBoxZamestnanec.SelectedItem;
                int vek;
                if (int.TryParse(textBoxVek.Text, out vek))
                {
                    osoba.Vek = vek;
                }
                else
                {
                    MessageBox.Show("Špatně zadaný formát pro věk, objekt Osoba nebyl vytvořen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (selectedTitulPred == null)
                {
                    osoba.TitulPred = null;
                }
                else
                {
                    osoba.TitulPred = selectedTitulPred.ToString();

                }

                if (selectedTitulZa == null)
                {
                    osoba.TitulZa = null;
                }
                else
                {
                    osoba.TitulZa = selectedTitulZa.ToString();
                }

                if (selectedZamestnanec == null)
                {
                    osoba.ZamestnanecId = null;
                }
                else
                {
                    Zamestnanec zamestnanec = selectedZamestnanec as Zamestnanec;
                    osoba.ZamestnanecId = zamestnanec.Id;
                }
                if (selectedStudent == null)
                {
                    osoba.StudentId = null;
                }
                else
                {
                    Student student = selectedStudent as Student;
                    osoba.StudentId = student.Id;
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
                MessageBox.Show("Osoba upravena", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm.dataOsoba();
            }
            else
            {
                MessageBox.Show("Osoba neupravena", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        public void dataSkola(int id)
        {
            dataGridSkola.Rows.Clear();

            Skola skola = mainForm.skolaManager.GetSkola(id);
            dataGridSkola.Rows.Add(skola.Id, skola.NazevSkoly, skola.Poznamka, skola.AdresaId);

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
            Zamestnani zamestnani = mainForm.zamestnaniManager.GetZamestnani(id);

            dataGridZamestnani.Rows.Add(zamestnani.Id, zamestnani.NazevFirmy, zamestnani.Poznamka, zamestnani.AdresaId);

        }

        public void dataStudent(int id)
        {
            dataGridStudent.Rows.Clear();
            Student student = mainForm.studentManager.GetStudent(id);

            dataGridStudent.Rows.Add(student.Id, student.OborStudia, student.Rocnik, student.SkolaId);

            dataSkola(student.SkolaId);


        }

        public void dataZamestnanec(int id)
        {
            dataGridZamestnanec.Rows.Clear();
            Zamestnanec zamestnanec = mainForm.zamestnanecManager.GetZamestnanec(id);

            dataGridZamestnanec.Rows.Add(zamestnanec.Id, zamestnanec.Nastup, zamestnanec.Oddeleni, zamestnanec.ZamestnaniId);
            dataZamestnani(zamestnanec.ZamestnaniId);


        }

    }
}
