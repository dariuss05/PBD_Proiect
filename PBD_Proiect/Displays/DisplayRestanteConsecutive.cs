using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PBD_Proiect.Displays
{
    public partial class DisplayRestanteConsecutive : Form
    {
        public DisplayRestanteConsecutive()
        {
            InitializeComponent();
        }

        private void DisplayRestanteConsecutive_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(DatabaseConnection.databaseConnectionString);
                sqlConnection.Open();

                string selectQuery = "SELECT student.nrLegim, student.nume, student.prenume, note.nota_obtinuta, SUM(note.an_studiu) as sumaAn FROM [dbo].[student] INNER JOIN [dbo].[note] on student.nrLegim = note.nrLegim group by student.nrLegim, student.nume, student.prenume, note.nota_obtinuta HAVING (note.nota_obtinuta < 5 AND (SUM(note.an_studiu) = 3) OR SUM(note.an_studiu) = 5 OR SUM(note.an_studiu) = 6)";

                string selectQuery2 = "SELECT student.nrLegim, note.an_studiu FROM [dbo].[student] INNER JOIN [dbo].[note] on student.nrLegim = note.nrLegim WHERE note.nota_obtinuta < 5 GROUP BY student.nrLegim, note.an_studiu ORDER BY student.nrLegim";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, DatabaseConnection.databaseConnectionString);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "student");
                tabelRestanteCons.DataSource = dataSet.Tables["student"].DefaultView;
                for (int i = 0; i < tabelRestanteCons.Rows.Count; i++)
                {
                    if (tabelRestanteCons.Rows[i].Cells["sumaAn"].Value == (object)3)
                    {
                        tabelRestanteCons.Rows[i].Cells["sumaAn"].Value +=(tabelRestanteCons.Rows[i].Cells["sumaAn"].Value.ToString() + " (1, 2)");
                    }
                }

                SqlDataAdapter dataAdapter2 = new SqlDataAdapter(selectQuery2, DatabaseConnection.databaseConnectionString);
                DataSet dataSet2 = new DataSet();
                dataAdapter2.Fill(dataSet2, "note");
                tabelAnStudiu.DataSource = dataSet2.Tables["note"].DefaultView;

            }
            catch (SqlException message)
            {
                MessageBox.Show(message.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
