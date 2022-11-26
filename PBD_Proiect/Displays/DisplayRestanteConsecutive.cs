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

                string selectQuery = "SELECT student.nrLegim AS 'Numar Legitimatie', student.nume AS 'Nume', student.prenume AS 'Prenume', note.nota_obtinuta AS 'Nota Obtinuta', SUM(note.an_studiu) as 'Anii in care s-au obtinut notele' FROM [dbo].[student] INNER JOIN [dbo].[note] on student.nrLegim = note.nrLegim group by student.nrLegim, student.nume, student.prenume, note.nota_obtinuta HAVING (note.nota_obtinuta < 5 AND (SUM(note.an_studiu) = 3) OR SUM(note.an_studiu) = 5 OR SUM(note.an_studiu) = 6)";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, DatabaseConnection.databaseConnectionString);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "student");
                tabelRestanteCons.DataSource = dataSet.Tables["student"].DefaultView;
                DataSet dataSet_cloned = dataSet.Clone();
                dataSet_cloned.Tables[0].Columns[4].DataType = typeof(string);

                dataAdapter.Fill(dataSet_cloned, "student");
                tabelRestanteCons.DataSource = dataSet_cloned.Tables["student"].DefaultView;

                foreach (DataGridViewRow dgvRow in tabelRestanteCons.Rows)
                {
                    if (dgvRow.Cells[4].FormattedValue.ToString() == "3")
                        dgvRow.Cells[4].Value = "1, 2";
                    if (dgvRow.Cells[4].FormattedValue.ToString() == "5")
                        dgvRow.Cells[4].Value = "(2, 3)";
                    if (dgvRow.Cells[4].FormattedValue.ToString() == "6")
                        dgvRow.Cells[4].Value = "(1, 2, 3)";
                }

            }
            catch (SqlException message)
            {
                MessageBox.Show(message.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
