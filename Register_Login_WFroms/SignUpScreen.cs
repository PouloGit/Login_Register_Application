using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Register_Login_WFroms
{
    public partial class SignUpScreen : Form
    {
        readonly SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=loginData;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public SignUpScreen()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginHere_Click(object sender, EventArgs e)
        {
            LoginScreen loginForm = new LoginScreen();
            loginForm.Show();
            this.Hide();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "" || confirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please make sure you fill out blank fields",
                    "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        String checkUsername = "SELECT * FROM admin WHERE username = '" + usernameTextBox.Text.Trim() + "'";

                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(usernameTextBox.Text + " already exists, please try a different one.",
                                   "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO admin (username, password_hash, date_created) " +
                                    "VALUES(@username, @pass_hash, @date)";

                                DateTime date = DateTime.Today;
                                string passwordText = passwordTextBox.Text.Trim();
                                string confirmPassword = confirmPasswordTextBox.Text.Trim();
                                bool matchingPassword = Equals(passwordText, confirmPassword);

                                if (matchingPassword)
                                {
                                    var passwordHash = Hasher.HashPassword(passwordText);

                                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                    {
                                        cmd.Parameters.AddWithValue("@username", usernameTextBox.Text.Trim());
                                        cmd.Parameters.AddWithValue("@pass_hash", passwordHash);
                                        cmd.Parameters.AddWithValue("@date", date);

                                        cmd.ExecuteNonQuery();

                                        MessageBox.Show("Your account has been created",
                                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        LoginScreen loginScreen = new LoginScreen();
                                        loginScreen.Show();
                                        this.Hide();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("The passwords entered do not match. Please ensure that both passwords match and try again.",
                                        "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
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
            if(ShowPasswordCheckBox.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void ShowPasswordCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox2.Checked)
            {
                confirmPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                confirmPasswordTextBox.PasswordChar = '*';
            }
        }
    }
}
