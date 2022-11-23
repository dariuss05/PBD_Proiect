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

                tabelStudentNrPrezentari.Rows.Clear();
                tabelStudentNrPrezentari.Columns.Clear();
                SqlConnection sqlConnection = new SqlConnection(DatabaseConnection.databaseConnectionString);
                sqlConnection.Open();

                string selectQuery = "SELECT TOP 1 student.nume, student.prenume, SUM(note.nr_prezentare)" +
                    " AS nrPrezentare, COUNT(DISTINCT (case when note.nota_obtinuta >= 5 then disciplina end))" +
                    " as disciplina from [dbo].[student] INNER JOIN [dbo].[note] ON" +
                    " student.nrLegim = note.nrLegim " +
                    "GROUP BY student.nume, student.prenume, note.nrLegim ORDER BY nrPrezentare DESC";

                tabelStudentNrPrezentari.Columns.Add("nume_student", "Nume student");
                tabelStudentNrPrezentari.Columns.Add("prenume_student", "Prenume student");
                tabelStudentNrPrezentari.Columns.Add("numar_prezentari", "Numar de prezentari");
                tabelStudentNrPrezentari.Columns.Add("numar_discipline", "Numar de discipline");
                tabelStudentNrPrezentari.Columns.Add("rata_prom", "Rata de promovabilitate");

                using (SqlCommand cautare_student = new SqlCommand(selectQuery, sqlConnection))
                {
                    using (SqlDataReader reader = cautare_student.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var procent = (Convert.ToDouble(reader[3]) / Convert.ToDouble(reader[2])) * 100;
                            tabelStudentNrPrezentari.Rows.Add(reader[0], reader[1], reader[2], reader[3], procent.ToString("0.##") + "%");
                        }
                    }
                }
            }
            catch (SqlException message)
            {
                MessageBox.Show(message.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
