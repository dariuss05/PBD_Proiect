using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBD_Proiect.MainApps
{
    public partial class AddNote : Form
    {
        long nr_legim;
        public AddNote()
        {
            InitializeComponent();
        }

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            this.Close();
            MainApp f = new MainApp();
            f.Show();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            int nr_prezentare;
            int an_studiu;
            float nota_obtinuta;
            if (String.IsNullOrEmpty(txtBoxDisciplina.Text) || String.IsNullOrEmpty(txtBoxAnStudiu.Text)
                || String.IsNullOrEmpty(txtBoxNrPrezentare.Text) ||
                    String.IsNullOrEmpty(txtBoxNota.Text)) {
                MessageBox.Show("Completati toate campurile!", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                an_studiu = int.Parse(txtBoxAnStudiu.Text);
                if (!Regex.Match(txtBoxDisciplina.Text, "^[A-Z][a-zA-Z]{3,20}$").Success)
                {
                    MessageBox.Show("Nume disciplina invalid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxDisciplina.Focus();
                    return;
                }
                if(an_studiu<1 || an_studiu>3) {
                    MessageBox.Show("An de studiu invalid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxAnStudiu.Focus();
                    return;
                }
                if (!int.TryParse(txtBoxNrPrezentare.Text, out nr_prezentare))
                {
                    MessageBox.Show("Numarul prezentarii este invalid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxAnStudiu.Focus();
                    return;
                }
                if (!Single.TryParse(txtBoxNota.Text, out nota_obtinuta))
                {
                    MessageBox.Show("Nota este invalida!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxNota.Focus();
                    return;
                }
                else
                {
                    try
                    {
                        SqlConnection sqlConnection = new SqlConnection(DatabaseConnection.databaseConnectionString);
                        sqlConnection.Open();

                        string addQuery =
                               "INSERT INTO [dbo].[note] ([nrLegim],[disciplina],[an_studiu],[nr_prezentare],[data_prezentare]," +
                               "[nota_obtinuta]) VALUES (@nrLegim,@d,@a,@np,@dp,@nota)";
                        SqlCommand addCommand = new SqlCommand(addQuery, sqlConnection);
                        addCommand.Parameters.AddWithValue("@nrLegim", nr_legim);
                        addCommand.Parameters.AddWithValue("@d", txtBoxDisciplina.Text);
                        addCommand.Parameters.AddWithValue("@a", int.Parse(txtBoxAnStudiu.Text));
                        addCommand.Parameters.AddWithValue("@np", int.Parse(txtBoxNrPrezentare.Text));
                        addCommand.Parameters.AddWithValue("@dp", datePickerData.Value);
                        addCommand.Parameters.AddWithValue("@nota", txtBoxNota.Text);
                        addCommand.ExecuteNonQuery();

                        MessageBox.Show("Nota a fost adaugata cu succes!", "Succes", MessageBoxButtons.OK,
                                                       MessageBoxIcon.Information);
                        this.Close();
                        MainApp f = new MainApp();
                        f.Show();

                    }
                    catch (SqlException exception)
                    {
                        MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AddNote_Load(object sender, EventArgs e)
        {
            txtBoxDisciplina.ReadOnly = true;
            txtBoxAnStudiu.ReadOnly = true;
            txtBoxNota.ReadOnly = true;
            txtBoxNrPrezentare.ReadOnly = true;
            datePickerData.Enabled = false;
        }

        private void btnValidare_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtBoxNrLegim.Text))
            {
                MessageBox.Show("Introduceti un nr. de legitimatie!", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (!Regex.Match(txtBoxNrLegim.Text, "^[0-9]{6}$").Success)
                {
                    MessageBox.Show("Numar legitimatie invalid! Trebuie sa fie din 6 cifre.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxNrLegim.Focus();
                    return;
                }
                else
                {
                    nr_legim = long.Parse(txtBoxNrLegim.Text);
                    try
                    {
                        SqlConnection sqlConnection = new SqlConnection(DatabaseConnection.databaseConnectionString);
                        sqlConnection.Open();

                        String nrLegimQuery = "SELECT * FROM student WHERE student.nrLegim=" + nr_legim;

                        using (SqlCommand cautare_nume_prenume = new SqlCommand(nrLegimQuery, sqlConnection))
                        {
                            using (SqlDataReader reader = cautare_nume_prenume.ExecuteReader())
                            {
                                if (reader.Read()) //daca s-a gasit nr.legim
                                {
                                    MessageBox.Show("Studentul se afla in baza de date! Puteti adauga nota.", "Succes",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtBoxNrLegim.ReadOnly = true;
                                    txtBoxDisciplina.ReadOnly = false;
                                    txtBoxAnStudiu.ReadOnly = false;
                                    txtBoxNota.ReadOnly = false;
                                    txtBoxNrPrezentare.ReadOnly = false;
                                    datePickerData.Enabled = true;
                                    btnValidare.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show("Studentul cu numarul de legitimatie " + nr_legim + " nu exista in baza de date.", "Eroare",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                    }
                    catch (SqlException exception)
                    {
                        MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
