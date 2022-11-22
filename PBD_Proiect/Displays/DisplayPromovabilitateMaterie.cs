using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PBD_Proiect.Displays
{
    public partial class DisplayPromovabilitateMaterie : Form
    {
        public DisplayPromovabilitateMaterie()
        {
            InitializeComponent();
        }

        private void DisplayPromovabilitateMaterie_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(DatabaseConnection.databaseConnectionString);
                sqlConnection.Open();


                string selectQuery = "SELECT DISTINCT disciplina from [dbo].[note]";
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);

                using (SqlCommand afisareMaterii = new SqlCommand(selectQuery, sqlConnection))
                {
                    using (SqlDataReader reader = afisareMaterii.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaMaterii.Items.Add(reader[0]);
                        }
                    }
                }
            }
            catch (SqlException message)
            {
                MessageBox.Show(message.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            tabelPromovabilitate.Rows.Clear();
            tabelPromovabilitate.Columns.Clear();
            if(listaMaterii.SelectedIndex == -1)
            {
                MessageBox.Show("Selectati o materie din lista!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(DatabaseConnection.databaseConnectionString);
                    sqlConnection.Open();

                    //nume procedura
                    SqlCommand cmd = new SqlCommand("CalculPromovabilitate", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //parametru, numele disciplinei
                    cmd.Parameters.Add(new SqlParameter("@disciplina", listaMaterii.SelectedItem.ToString()));

                    tabelPromovabilitate.Columns.Add("nume_materie", "Nume materie");
                    tabelPromovabilitate.Columns.Add("rata_promovabilitate", "Rata promovabilitate");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var procent = Convert.ToDouble(reader[0]);
                            tabelPromovabilitate.Rows.Add(listaMaterii.SelectedItem.ToString(), procent.ToString("0.##") + "%");
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
}