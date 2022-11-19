using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PBD_Proiect.Displays
{
    public partial class DisplayPrezentariExamenStudent : Form
    {
        public DisplayPrezentariExamenStudent()
        {
            InitializeComponent();
        }

        private void DisplayPrezentariExamenStudent_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(DatabaseConnection.databaseConnectionString);
                sqlConnection.Open();

                /* Mai trebuie pusa rata de promovabilitate in tabel */
                string selectQuery = "SELECT student.nume, student.prenume, note.nr_prezentare FROM [dbo].[student] INNER JOIN [dbo].[note] ON student.nrLegim = note.nrLegim WHERE note.nr_prezentare IN (SELECT MAX(note.nr_prezentare) FROM [dbo].[note])";


                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, DatabaseConnection.databaseConnectionString);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "student");
                tabelStudentNrPrezentari.DataSource = dataSet.Tables["student"].DefaultView;
            }
            catch (SqlException message)
            {
                MessageBox.Show(message.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
