using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace airlinesbromo
{
    
    public partial class SignUp : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RIZKI251E;Initial Catalog=BromoAirlines;Integrated Security=True;Encrypt=False");
        public SignUp()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sSignUp = new Form1();
            sSignUp.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (signup_username.Text == "" || signup_nama.Text == "" || signup_tgl.Text == "" || signup_tlp.Text == ""
                || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();
                        String checkUsername = "SELECT * FROM Akun WHERE username = '"
                            + signup_username.Text.Trim() + "'"; // admin is our table name

                        using (SqlCommand checkUser = new SqlCommand(checkUsername, con))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(signup_username.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO Akun (Username, Password, Nama, TanggalLahir, NomorTelepon, MerupakanAdmin) " +
                                    "VALUES(@username, @pass, @nama, @date, @tlp, 0)";
                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, con))
                                {
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@nama", signup_nama.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue(@"tlp", signup_tlp.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);


                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // TO SWITCH THE FORM 
                                    Form1 lForm = new Form1();
                                    lForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }

            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (signup_showPass.Checked)
            {
                signup_password.PasswordChar = '\0';
            }
            else
            {
                signup_password.PasswordChar = '*';
            }
        }

        private void signup_tlp_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
