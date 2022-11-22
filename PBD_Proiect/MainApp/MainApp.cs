using PBD_Proiect.Displays;
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
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iesireMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentMenuAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
        }

        private void notaMenuAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNote addNote = new AddNote();
            addNote.ShowDialog();
        }

        private void restantieriMenuDisplay_Click(object sender, EventArgs e)
        {
            var displayRestantieriForm = new DisplayRestantieri();
            displayRestantieriForm.ShowDialog();
        }

        private void raportStudentMenuAfisare_Click(object sender, EventArgs e)
        {
            var displayRaportStudent = new DisplayRaportStudent();
            displayRaportStudent.ShowDialog();
        }

        private void raportDetaliatMenuAfisare_Click(object sender, EventArgs e)
        {
            var displayRaportDetaliatStudent = new DisplayRaportDetaliatStudent();
            displayRaportDetaliatStudent.ShowDialog();
        }

        private void promovabilitateStudentMenuAfisare_Click(object sender, EventArgs e)
        {
            var displayPromovabilitateMaterie = new DisplayPromovabilitateMaterie();
            displayPromovabilitateMaterie.ShowDialog();
        }

        private void restanteConsecutiveMenuAfisare_Click(object sender, EventArgs e)
        {
            var displayRestanteConsecutive = new DisplayRestanteConsecutive();
            displayRestanteConsecutive.ShowDialog();
        }

        private void prezentariExamenMenuAfisare_Click(object sender, EventArgs e)
        {
            var displayPrezentariExamen = new DisplayPrezentariExamenStudent();
            displayPrezentariExamen.ShowDialog();
        }

    }
}
