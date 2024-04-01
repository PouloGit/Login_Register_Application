using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Register_Login_WFroms
{
    public partial class LoginScreen : Form
    {
        readonly SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=loginData;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterHere_Click(object sender, EventArgs e)
        {
            SignUpScreen signForm = new SignUpScreen();
            signForm.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Please make sure you fill out blank fields",
                    "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        String selectData = "SELECT * FROM admin WHERE username = @username AND password_hash = @pass_hash";
                        using(SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            string passwordText = passwordTextBox.Text.Trim();
                            var passwordHash = Hasher.HashPassword(passwordText);

                            cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                            cmd.Parameters.AddWithValue("@pass_hash", passwordHash);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if(table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Loggin succesful",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                MainWindow mainWindow = new MainWindow();
                                mainWindow.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", 
                                    "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting to Database: " + ex,
                            "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally { connect.Close(); }
                }
            }
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }

    }
}
