using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace PBD_Proiect.MainApps
{
    public partial class AddStudent : Form
    {
        public AddStudent()
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
            string nume, prenume;
            float medie_gen, medie_an1, medie_an2, medie_an3;
            long nr_legim;
            if (String.IsNullOrEmpty(txtBoxNume.Text) || String.IsNullOrEmpty(txtBoxPrenume.Text) ||
                String.IsNullOrEmpty(txtBoxNrLegim.Text) || String.IsNullOrEmpty(txtBoxMedieGenerala.Text) ||
                String.IsNullOrEmpty(txtBoxMedieAn1.Text) || String.IsNullOrEmpty(txtBoxMedieAn2.Text) ||
                String.IsNullOrEmpty(txtBoxMedieAn3.Text)) {
                MessageBox.Show("Completati toate campurile!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else {
                if (!Regex.Match(txtBoxNume.Text, "^[A-Z][a-zA-Z]{3,15}$").Success)
                {
                    MessageBox.Show("Nume invalid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxNume.Focus();
                    return;
                }
                if (!Regex.Match(txtBoxPrenume.Text, "^[A-Z][a-zA-Z]{3,20}$").Success)
                {
                    MessageBox.Show("Prenume invalid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxPrenume.Focus();
                    return;
                }
                if (!Regex.Match(txtBoxNrLegim.Text, "^[0-9]{6}$").Success)
                {
                    MessageBox.Show("Numar legitimatie invalid! Trebuie sa fie din 6 cifre.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxNrLegim.Focus();
                    return;
                }
                if (!Single.TryParse(txtBoxMedieGenerala.Text, out medie_gen))
                {
                    MessageBox.Show("Media generala introdusa este invalida!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxMedieGenerala.Focus();
                    return;
                }
                if (!Single.TryParse(txtBoxMedieAn1.Text, out medie_an1))
                {
                    MessageBox.Show("Media pe anul 1 introdusa este invalida!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxMedieAn1.Focus();
                    return;
                }
                if (!Single.TryParse(txtBoxMedieAn2.Text, out medie_an2))
                {
                    MessageBox.Show("Media pe anul 2 introdusa este invalida!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxMedieAn2.Focus();
                    return;
                }
                if (!Single.TryParse(txtBoxMedieAn3.Text, out medie_an3))
                {
                    MessageBox.Show("Media pe anul 3 introdusa este invalida!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxMedieAn3.Focus();
                    return;
                }
                else
                {
                    //verificam daca studentul exista deja in baza de date, verificam doar nrLegim + nume familie
                    nume = txtBoxNume.Text;
                    prenume = txtBoxPrenume.Text;
                    nr_legim = long.Parse(txtBoxNrLegim.Text);
                    try
                    {
                        SqlConnection sqlConnection = new SqlConnection(DatabaseConnection.databaseConnectionString);
                        sqlConnection.Open();

                        String numePrenumeQuery = "SELECT * FROM student WHERE student.nume='" + nume +
                            "' AND student.prenume='" + prenume+ "'";
                        String nrLegimQuery = "SELECT * FROM student WHERE student.nrLegim=" + nr_legim;

                        using (SqlCommand cautare_nume_prenume = new SqlCommand(numePrenumeQuery, sqlConnection))
                        {
                            using (SqlDataReader reader = cautare_nume_prenume.ExecuteReader())
                            {
                                if (reader.Read()) //daca s-a gasit numele si prenumele
                                {
                                    MessageBox.Show("Acest student exista deja in baza de date!", "Eroare",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }

                        using (SqlCommand cautare_nrLegim = new SqlCommand(nrLegimQuery, sqlConnection))
                        {
                            using (SqlDataReader reader = cautare_nrLegim.ExecuteReader())
                            {
                                if (reader.Read()) //daca s-a gasit nrLegim
                                {
                                    MessageBox.Show("Exista deja un student cu acest numar de legitimatie!", "Eroare",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                        //adaugare              
                        string addQuery =
                                "INSERT INTO [dbo].[student] ([nrLegim],[nume],[prenume],[medie_generala],[medie_an1]," +
                                "[medie_an2],[medie_an3]) VALUES (@nrLegim,@n,@p,@mg,@m1,@m2,@m3)";
                            SqlCommand addCommand = new SqlCommand(addQuery, sqlConnection);
                            addCommand.Parameters.AddWithValue("@nrLegim", txtBoxNrLegim.Text);
                            addCommand.Parameters.AddWithValue("@n", txtBoxNume.Text);
                            addCommand.Parameters.AddWithValue("@p", txtBoxPrenume.Text);
                            addCommand.Parameters.AddWithValue("@mg", txtBoxMedieGenerala.Text);
                            addCommand.Parameters.AddWithValue("@m1", txtBoxMedieAn1.Text);
                            addCommand.Parameters.AddWithValue("@m2", txtBoxMedieAn2.Text);
                            addCommand.Parameters.AddWithValue("@m3", txtBoxMedieAn3.Text);
                            addCommand.ExecuteNonQuery();
                            MessageBox.Show("Studentul a fost adaugat cu succes!", "Succes", MessageBoxButtons.OK,
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
    }
}