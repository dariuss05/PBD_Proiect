using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PBD_Proiect.Displays
{
    public partial class DisplayRestantieri : Form
    {
        public DisplayRestantieri()
        {
            InitializeComponent();
        }

        private void DisplayRestantieri_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(DatabaseConnection.databaseConnectionString);
                sqlConnection.Open();

                string selectQuery = "SELECT student.*, note.disciplina, note.an_studiu, note.nr_prezentare, note.data_prezentare, note.nota_obtinuta FROM [dbo].[student] INNER JOIN [dbo].[note] ON student.nrLegim = note.nrLegim WHERE note.nota_obtinuta < 5";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, DatabaseConnection.databaseConnectionString);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "student");
                tabelRestantieri.DataSource = dataSet.Tables["student"].DefaultView;
            }
            catch (SqlException message)
            {
                MessageBox.Show(message.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
