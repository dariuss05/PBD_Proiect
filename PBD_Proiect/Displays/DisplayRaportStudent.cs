using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PBD_Proiect.Displays
{
    public partial class DisplayRaportStudent : Form
    {
        public DisplayRaportStudent()
        {
            InitializeComponent();
        }

        private void DisplayRaportStudent_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(DatabaseConnection.databaseConnectionString);
                sqlConnection.Open();

                string selectQuery = "SELECT student.nume, student.prenume, MAX(note.an_studiu) AS an_studiu, student.nrLegim FROM [dbo].[student] INNER JOIN [dbo].[note] ON student.nrLegim = note.nrLegim GROUP BY student.nume, student.prenume, student.nrLegim";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, DatabaseConnection.databaseConnectionString);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "student");
                tabelRaportStudenti.DataSource = dataSet.Tables["student"].DefaultView;
            }
            catch (SqlException message)
            {
                MessageBox.Show(message.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
