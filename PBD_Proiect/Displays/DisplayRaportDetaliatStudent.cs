using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PBD_Proiect.Displays
{
    public partial class DisplayRaportDetaliatStudent : Form
    {
        public DisplayRaportDetaliatStudent()
        {
            InitializeComponent();
        }

        private void btnNume_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(DatabaseConnection.databaseConnectionString);
                sqlConnection.Open();

                string selectQuery = "SELECT student.nume, student.prenume, student.nrLegim, note.an_studiu, note.disciplina, note.nota_obtinuta FROM [dbo].[student] INNER JOIN [dbo].[note] on student.nrLegim = note.nrLegim WHERE note.nota_obtinuta >= 5 ORDER BY student.nume";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, DatabaseConnection.databaseConnectionString);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "student");
                listaDetaliataStudent.DataSource = dataSet.Tables["student"].DefaultView;
            }
            catch (SqlException message)
            {
                MessageBox.Show(message.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrenume_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(DatabaseConnection.databaseConnectionString);
                sqlConnection.Open();

                string selectQuery = "SELECT student.nume, student.prenume, student.nrLegim, note.an_studiu, note.disciplina, note.nota_obtinuta FROM [dbo].[student] INNER JOIN [dbo].[note] on student.nrLegim = note.nrLegim WHERE note.nota_obtinuta >= 5 ORDER BY student.prenume";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, DatabaseConnection.databaseConnectionString);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "student");
                listaDetaliataStudent.DataSource = dataSet.Tables["student"].DefaultView;
            }
            catch (SqlException message)
            {
                MessageBox.Show(message.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnStudiu_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(DatabaseConnection.databaseConnectionString);
                sqlConnection.Open();

                string selectQuery = "SELECT student.nume, student.prenume, student.nrLegim, note.an_studiu, note.disciplina, note.nota_obtinuta FROM [dbo].[student] INNER JOIN [dbo].[note] on student.nrLegim = note.nrLegim WHERE note.nota_obtinuta >= 5 ORDER BY note.an_studiu";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, DatabaseConnection.databaseConnectionString);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "student");
                listaDetaliataStudent.DataSource = dataSet.Tables["student"].DefaultView;
            }
            catch (SqlException message)
            {
                MessageBox.Show(message.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisciplina_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(DatabaseConnection.databaseConnectionString);
                sqlConnection.Open();

                string selectQuery = "SELECT student.nume, student.prenume, student.nrLegim, note.an_studiu, note.disciplina, note.nota_obtinuta FROM [dbo].[student] INNER JOIN [dbo].[note] on student.nrLegim = note.nrLegim WHERE note.nota_obtinuta >= 5 ORDER BY note.disciplina";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, DatabaseConnection.databaseConnectionString);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "student");
                listaDetaliataStudent.DataSource = dataSet.Tables["student"].DefaultView;
            }
            catch (SqlException message)
            {
                MessageBox.Show(message.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
