using EvideenceObvytelstva2.Manager;
using EvideenceObvytelstva2.Models;
using EvideenceObvytelstva2.UI;
using System.Net.PeerToPeer.Collaboration;
using System.Numerics;
using System.Windows.Forms;

namespace EvideenceObvytelstva2
{
    public partial class Form1 : Form
    {
        public OsobaManager osobaManager = new OsobaManager();
        public AdresaManager adresaManager = new AdresaManager();
        public StudentManager studentManager = new StudentManager();
        public ZamestnanecManager zamestnanecManager = new ZamestnanecManager();
        public SkolaManager skolaManager = new SkolaManager();
        public ZamestnaniManager zamestnaniManager = new ZamestnaniManager();
        public Form1()
        {
            InitializeComponent();
            Reset();

            this.dataGridSkola.ClearSelection();
            this.dataGridStudent.ClearSelection();
            this.dataGridZamestnanec.ClearSelection();
            this.dataGridZamestnani.ClearSelection();


        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxJmeno.Text))
            {
                MessageBox.Show("Políèko jméno nevyplnìno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxJmeno.Focus();
                return;
            }

            Osoba osoba = new Osoba();
            osoba.KrestniJmeno = textBoxJmeno.Text;
            osoba.Prijmeni = textBoxPrijmeni.Text;
            osoba.Titul = comboBoxTituly.SelectedItem.ToString();
            osoba.AddressId = int.Parse(textBoxAdresaId.Text);
            osoba.Vek = int.Parse(textBoxVek.Text);
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

                if (!adresaManager.AdresaExist(osoba.AddressId))
                {
                    MessageBox.Show("Daná adresa se v databázi nenachází, objekt Osoba nebyl vytvoøen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!studentManager.StudentExist(osoba.StudentId) && osoba.StudentId != null)
                {
                    MessageBox.Show("Daný student se v databázi nenachází, objekt Osoba nebyl vytvoøen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                if (!zamestnanecManager.ZamestnanecExist(osoba.ZamestnanecId) && osoba.ZamestnanecId != null)
                {
                    MessageBox.Show("Daný zamìstnanec se v databázi nenachází, objekt Osoba nebyl vytvoøen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (osobaManager.Add(osoba))
            {
                MessageBox.Show("Osoba pøidána do databáze", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            else
            {
                MessageBox.Show("Osoba nepøidána do databáze", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dataGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGrid.SelectedRows[0];
                osobaDetail osobaDetail = new osobaDetail(this);
                //this.Hide();
                //osobaDetail.Show();
                osobaDetail.labelID.Text = row.Cells[0].Value.ToString();
                osobaDetail.textBoxJmeno.Text = row.Cells[1].Value.ToString();
                osobaDetail.textBoxPrijmeni.Text = row.Cells[2].Value.ToString();
                int index = osobaDetail.comboBoxTituly.FindStringExact(row.Cells[3].Value.ToString());
                if (index >= 0)
                {
                    osobaDetail.comboBoxTituly.SelectedIndex = index;
                }
                osobaDetail.textBoxVek.Text = row.Cells[4].Value.ToString();
                Adresa adresa = adresaManager.GetAdresa(int.Parse(row.Cells[5].Value.ToString()));
                if (row.Cells[6].Value?.ToString() == null)
                {
                    osobaDetail.textBoxStudentID.Text = "";
                }
                else
                {
                    Student student = studentManager.GetStudent(int.Parse(row.Cells[6].Value.ToString()));
                    osobaDetail.dataStudent(student.Id);
                    osobaDetail.textBoxStudentID.Text = student.Id.ToString();
                }
                if (row.Cells[7].Value?.ToString() == null)
                {
                    osobaDetail.textBoxZamestnanecID.Text = "";
                }
                else
                {
                    Zamestnanec zamestnanec = zamestnanecManager.GetZamestnanec(int.Parse(row.Cells[7].Value.ToString()));
                    osobaDetail.dataZamestnanec(zamestnanec.Id);
                    osobaDetail.textBoxZamestnanecID.Text = zamestnanec.Id.ToString();
                }
                osobaDetail.textBoxAdresaId.Text = adresa.Id.ToString();
                osobaDetail.dataAdresa(adresa.Id);
                osobaDetail.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGrid.SelectedRows[0];
                if (MessageBox.Show("Jsi si jistý odstranìním ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)row.Cells[0].Value;
                    bool isDeleted = osobaManager.Delete(id);
                    if (isDeleted)
                    {
                        MessageBox.Show("Osoba byla vymazána", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataOsoba();
                    }
                    else
                    {
                        MessageBox.Show("Osoba nebyla vymazána", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGrid.SelectedRows[0];
                osobaDetail osobaDetail = new osobaDetail(this);
                //this.Hide();
                //osobaDetail.Show();
                osobaDetail.labelID.Text = row.Cells[0].Value.ToString();
                osobaDetail.textBoxJmeno.Text = row.Cells[1].Value.ToString();
                osobaDetail.textBoxPrijmeni.Text = row.Cells[2].Value.ToString();
                int index = osobaDetail.comboBoxTituly.FindStringExact(row.Cells[3].Value.ToString());
                if (index >= 0)
                {
                    osobaDetail.comboBoxTituly.SelectedIndex = index;
                }
                osobaDetail.textBoxVek.Text = row.Cells[4].Value.ToString();
                Adresa adresa = adresaManager.GetAdresa(int.Parse(row.Cells[5].Value.ToString()));
                if (row.Cells[6].Value?.ToString() == null)
                {
                    osobaDetail.textBoxStudentID.Text = "";
                }
                else
                {
                    Student student = studentManager.GetStudent(int.Parse(row.Cells[6].Value.ToString()));
                    osobaDetail.dataStudent(student.Id);
                    osobaDetail.textBoxStudentID.Text = student.Id.ToString();
                }
                if (row.Cells[7].Value?.ToString() == null)
                {
                    osobaDetail.textBoxZamestnanecID.Text = "";
                }
                else
                {
                    Zamestnanec zamestnanec = zamestnanecManager.GetZamestnanec(int.Parse(row.Cells[7].Value.ToString()));
                    osobaDetail.dataZamestnanec(zamestnanec.Id);
                    osobaDetail.textBoxZamestnanecID.Text = zamestnanec.Id.ToString();
                }
                osobaDetail.textBoxAdresaId.Text = adresa.Id.ToString();
                osobaDetail.dataAdresa(adresa.Id);
                osobaDetail.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dataGridAddress_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                AdresaDetail adresaDetail = new AdresaDetail(this);
                DataGridViewRow row = dataGridAddress.SelectedRows[0];
                osobaDetail osobaDetail = new osobaDetail(this);
                //this.Hide();
                //osobaDetail.Show();
                adresaDetail.labelIDInput.Text = row.Cells[0].Value.ToString();
                adresaDetail.textBoxUlice.Text = row.Cells[1].Value.ToString();
                adresaDetail.textBoxPopisne.Text = row.Cells[2].Value.ToString();
                adresaDetail.textBoxPsc.Text = row.Cells[3].Value.ToString();
                adresaDetail.textBoxObec.Text = row.Cells[4].Value.ToString();

                adresaDetail.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Reset()
        {
            textBoxJmeno.Text = string.Empty;
            textBoxPrijmeni.Text = string.Empty;
            comboBoxTituly.Text = string.Empty;
            textBoxVek.Text = string.Empty;
            textBoxAdresaId.Text = string.Empty;
            textBoxStudentID.Text = string.Empty;
            textBoxZamestnanecID.Text = string.Empty;
            dataOsoba();
            dataAdresa();
            dataSkola();
            dataStudent();
            dataZamestnanec();
            dataZamestnani();
        }
        public void dataOsoba()
        {
            dataGrid.Rows.Clear();
            List<Osoba> temp = osobaManager.GetAll();

            foreach (Osoba item in temp)
            {
                dataGrid.Rows.Add(item.Id, item.KrestniJmeno, item.Prijmeni, item.Titul, item.Vek, item.AddressId, item.StudentId, item.ZamestnanecId);
            }
            dataGrid.ClearSelection();

        }

        public void dataAdresa()
        {
            dataGridAddress.Rows.Clear();
            List<Adresa> temp = adresaManager.GetAll();

            foreach (Adresa item in temp)
            {
                dataGridAddress.Rows.Add(item.Id, item.Ulice, item.cisloPopisne, item.psc, item.Obec);
            }
            dataGridAddress.ClearSelection();
        }

        public void dataSkola()
        {
            dataGridSkola.Rows.Clear();
            List<Skola> temp = skolaManager.GetAll();

            foreach (Skola item in temp)
            {
                dataGridSkola.Rows.Add(item.Id, item.NazevSkoly, item.Poznamka, item.AdresaId);
            }
            dataGridSkola.ClearSelection();
        }

        public void dataZamestnani()
        {
            dataGridZamestnani.Rows.Clear();
            List<Zamestnani> temp = zamestnaniManager.GetAll();

            foreach (Zamestnani item in temp)
            {
                dataGridZamestnani.Rows.Add(item.Id, item.NazevFirmy, item.Poznamka, item.AdresaId);
            }
            dataGridZamestnani.ClearSelection();
        }

        public void dataStudent()
        {
            dataGridStudent.Rows.Clear();
            List<Student> temp = studentManager.GetAll();

            foreach (Student item in temp)
            {
                dataGridStudent.Rows.Add(item.Id, item.OborStudia, item.Rocnik, item.SkolaId);
            }
            dataGridStudent.ClearSelection();
        }

        public void dataZamestnanec()
        {
            dataGridZamestnanec.Rows.Clear();
            List<Zamestnanec> temp = zamestnanecManager.GetAll();

            foreach (Zamestnanec item in temp)
            {
                dataGridZamestnanec.Rows.Add(item.Id, item.Nastup, item.Oddeleni, item.ZamestnaniId);
            }
            dataGridZamestnanec.ClearSelection();
        }

        private void buttonAddAdres_Click(object sender, EventArgs e)
        {
            try
            {
                PridejAdresu pridejAdresu = new PridejAdresu(this);
                //this.Hide();
                //osobaDetail.Show();
                pridejAdresu.ShowDialog();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                PridejStudenta pridejStudenta = new PridejStudenta(this);
                //this.Hide();
                //osobaDetail.Show();
                pridejStudenta.ShowDialog();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddSkola_Click(object sender, EventArgs e)
        {
            try
            {
                PridejSkolu pridejSkolu = new PridejSkolu(this);
                //this.Hide();
                //osobaDetail.Show();
                pridejSkolu.ShowDialog();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddZamestnani_Click(object sender, EventArgs e)
        {
            try
            {
                PridejZamestnani pridejZamestnani = new PridejZamestnani(this);
                //this.Hide();
                //osobaDetail.Show();
                pridejZamestnani.ShowDialog();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddZamestnanec_Click(object sender, EventArgs e)
        {
            try
            {
                PridejZamestnance pridejZamestnance = new PridejZamestnance(this);
                //this.Hide();
                //osobaDetail.Show();
                pridejZamestnance.ShowDialog();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridAddress_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AdresaDetail adresaDetail = new AdresaDetail(this);
                DataGridViewRow row = dataGridAddress.SelectedRows[0];
                //this.Hide();
                //osobaDetail.Show();
                adresaDetail.labelIDInput.Text = row.Cells[0].Value.ToString();
                adresaDetail.textBoxUlice.Text = row.Cells[1].Value.ToString();
                adresaDetail.textBoxPopisne.Text = row.Cells[2].Value.ToString();
                adresaDetail.textBoxPsc.Text = row.Cells[3].Value.ToString();
                adresaDetail.textBoxObec.Text = row.Cells[4].Value.ToString();

                adresaDetail.ShowDialog();
                dataAdresa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridAddress.SelectedRows[0];
                if (MessageBox.Show("Jsi si jistý odstranìním ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)row.Cells[0].Value;
                    bool isDeleted = adresaManager.Delete(id);
                    if (isDeleted)
                    {
                        MessageBox.Show("Adresa byla vymazána", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataAdresa();
                    }
                    else
                    {
                        MessageBox.Show("Adresa nebyla vymazána", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                StudentDetail studentDetail = new StudentDetail(this);
                DataGridViewRow row = dataGridStudent.SelectedRows[0];
                //this.Hide();
                //osobaDetail.Show();
                studentDetail.labelIDInput.Text = row.Cells[0].Value.ToString();
                studentDetail.textOborStudia.Text = row.Cells[1].Value.ToString();
                studentDetail.textBoxRocnik.Text = row.Cells[2].Value.ToString();
                studentDetail.textBoxSkolaID.Text = row.Cells[3].Value.ToString();

                studentDetail.ShowDialog();
                dataStudent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridStudent.SelectedRows[0];
                if (MessageBox.Show("Jsi si jistý odstranìním ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)row.Cells[0].Value;
                    bool isDeleted = studentManager.Delete(id);
                    if (isDeleted)
                    {
                        MessageBox.Show("Student byl vymazán", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataAdresa();
                    }
                    else
                    {
                        MessageBox.Show("Student nebyl vymazán", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                SkolaDetail skolaDetail = new SkolaDetail(this);
                DataGridViewRow row = dataGridSkola.SelectedRows[0];
                //this.Hide();
                //osobaDetail.Show();
                skolaDetail.labelIDInput.Text = row.Cells[0].Value.ToString();
                skolaDetail.textNazevSkoly.Text = row.Cells[1].Value.ToString();
                skolaDetail.textBoxPoznamka.Text = row.Cells[2].Value.ToString();
                skolaDetail.textBoxAdresaID.Text = row.Cells[3].Value.ToString();

                skolaDetail.ShowDialog();
                dataSkola();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow row = dataGridSkola.SelectedRows[0];
                if (MessageBox.Show("Jsi si jistý odstranìním ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)row.Cells[0].Value;
                    bool isDeleted = skolaManager.Delete(id);
                    if (isDeleted)
                    {
                        MessageBox.Show("Škola byla vymazána", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataSkola();
                    }
                    else
                    {
                        MessageBox.Show("Škola nebyla vymazána", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                ZamestnanecDetail zamestnanecDetail = new ZamestnanecDetail(this);
                DataGridViewRow row = dataGridZamestnanec.SelectedRows[0];
                //this.Hide();
                //osobaDetail.Show();
                zamestnanecDetail.labelIDInput.Text = row.Cells[0].Value.ToString();
                DateOnly dateOnly = (DateOnly)row.Cells[1].Value;
                DateTime dateTime = new DateTime(dateOnly.Year, dateOnly.Month, dateOnly.Day, 0, 0, 0);
                zamestnanecDetail.dateTimePicker.Value = dateTime;
                zamestnanecDetail.textBoxOddeleni.Text = row.Cells[2].Value.ToString();
                zamestnanecDetail.textBoxZamestnaniID.Text = row.Cells[3].Value.ToString();

                zamestnanecDetail.ShowDialog();
                dataZamestnanec();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridZamestnanec.SelectedRows[0];
                if (MessageBox.Show("Jsi si jistý odstranìním ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)row.Cells[0].Value;
                    bool isDeleted = zamestnanecManager.Delete(id);
                    if (isDeleted)
                    {
                        MessageBox.Show("Zamìstnanec byl vymazán", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataZamestnanec();
                    }
                    else
                    {
                        MessageBox.Show("Zamìstnanec nebyl vymazán", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                ZamestnaniDetail zamestnaniDetail = new ZamestnaniDetail(this);
                DataGridViewRow row = dataGridZamestnani.SelectedRows[0];
                //this.Hide();
                //osobaDetail.Show();
                zamestnaniDetail.labelIDInput.Text = row.Cells[0].Value.ToString();
                zamestnaniDetail.textNazevZamestnani.Text = row.Cells[1].Value.ToString();
                zamestnaniDetail.textBoxPoznamka.Text = row.Cells[2].Value.ToString();
                zamestnaniDetail.textBoxAdresaID.Text = row.Cells[3].Value.ToString();

                zamestnaniDetail.ShowDialog();
                dataZamestnani();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridZamestnani.SelectedRows[0];
                if (MessageBox.Show("Jsi si jistý odstranìním ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)row.Cells[0].Value;
                    bool isDeleted = zamestnaniManager.Delete(id);
                    if (isDeleted)
                    {
                        MessageBox.Show("Zamìstnaní bylo vymazáno", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataZamestnani();
                    }
                    else
                    {
                        MessageBox.Show("Zamìstnaní nebylo vymazáno", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

