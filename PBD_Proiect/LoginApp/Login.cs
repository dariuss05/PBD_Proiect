using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PBD_Proiect
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnSignUP_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == String.Empty)
            {
                MessageBox.Show("Introduceti un username", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == String.Empty)
            {
                MessageBox.Show("Introduceti o parola", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection sqlConnection = new SqlConnection(DatabaseConnection.databaseConnectionString);

                sqlConnection.Open();

                String selectUsersQuery = "SELECT password FROM conturi WHERE username='" + txtUsername.Text + "'";

                SqlCommand sqlCommand = new SqlCommand(selectUsersQuery, sqlConnection);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    if (reader[0].ToString() == txtPassword.Text)
                    {
                        this.Hide();
                        var mainAppForm = new MainApp();
                        mainAppForm.FormClosed += (s, args) => this.Close();
                        mainAppForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or password incorrect!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
