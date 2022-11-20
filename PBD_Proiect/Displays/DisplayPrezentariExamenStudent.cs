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

                
                string selectQuery = "SELECT TOP 1 student.nume, student.prenume, SUM(note.nr_prezentare) AS nrPrezentare FROM [dbo].[student] INNER JOIN [dbo].[note] ON student.nrLegim = note.nrLegim GROUP BY student.nume, student.prenume, note.nrLegim ORDER BY nrPrezentare DESC";


                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, DatabaseConnection.databaseConnectionString);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "student");
                tabelStudentNrPrezentari.DataSource = dataSet.Tables["student"].DefaultView;
                tabelStudentNrPrezentari.Columns.Add("rataPromovabilitate", "Rata promovabilitate");
                tabelStudentNrPrezentari.Rows[0].Cells[3].Value = ((double.Parse(tabelStudentNrPrezentari.Rows[0].Cells[2].Value.ToString()) / 6) * 100).ToString("0.##") + "%";

            }
            catch (SqlException message)
            {
                MessageBox.Show(message.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
