using PBD_Proiect.Displays;
using PBD_Proiect.LoginApp;
using PBD_Proiect.MainApps;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PBD_Proiect
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(DatabaseConnection.databaseConnectionString);
                sqlConnection.Open();

                String selectQuery = "SELECT * FROM student";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, DatabaseConnection.databaseConnectionString);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "student");
                tabelStudenti.DataSource = dataSet.Tables["student"].DefaultView;

                selectQuery = "SELECT * from note";
                dataAdapter = new SqlDataAdapter(selectQuery, DatabaseConnection.databaseConnectionString);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "note");
                tabelNote.DataSource = dataSet.Tables["note"].DefaultView;


                dataAdapter.Dispose();
                dataSet.Dispose();
            }
            catch (SqlException exception)
            {
                MessageBox.Show("EROARE", exception.Message);
            }
        }

        private void iesireMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentMenuAdd_Click(object sender, EventArgs e)
        {
            var addStudentForm = new AddStudent();
            addStudentForm.Show();
        }

        private void notaMenuAdd_Click(object sender, EventArgs e)
        {
            var addNotaForm = new AddNote();
            addNotaForm.Show();
        }

        private void restantieriMenuDisplay_Click(object sender, EventArgs e)
        {
            var displayRestantieriForm = new DisplayRestantieri();
            displayRestantieriForm.Show();
        }

        private void raportStudentMenuAfisare_Click(object sender, EventArgs e)
        {
            var displayRaportStudent = new DisplayRaportStudent();
            displayRaportStudent.Show();
        }

        private void raportDetaliatMenuAfisare_Click(object sender, EventArgs e)
        {
            var displayRaportDetaliatStudent = new DisplayRaportDetaliatStudent();
            displayRaportDetaliatStudent.Show();
        }

        private void promovabilitateStudentMenuAfisare_Click(object sender, EventArgs e)
        {
            var displayPromovabilitateMaterie = new DisplayPromovabilitateMaterie();
            displayPromovabilitateMaterie.Show();
        }

        private void restanteConsecutiveMenuAfisare_Click(object sender, EventArgs e)
        {
            var displayRestanteConsecutive = new DisplayRestanteConsecutive();
            displayRestanteConsecutive.Show();
        }

        private void prezentariExamenMenuAfisare_Click(object sender, EventArgs e)
        {
            var displayPrezentariExamen = new DisplayPrezentariExamenStudent();
            displayPrezentariExamen.Show();
        }

    }
}
