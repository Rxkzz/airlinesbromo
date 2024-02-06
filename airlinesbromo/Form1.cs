using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=RIZKI251E;Initial Catalog=BromoAirlines;Integrated Security=True;Encrypt=False");

        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
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

                        String selectData = "SELECT * FROM Akun WHERE Username = @username AND Password = @pass";
                        using (SqlCommand cmd = new SqlCommand(selectData, con))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text);
                            cmd.Parameters.AddWithValue("@pass", login_password.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                int isAdmin = Convert.ToInt32(table.Rows[0]["MerupakanAdmin"]);

                                if (isAdmin == 1)
                                {
                                    MessageBox.Show("Logged In successfully as Admin", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Open the admin form
                                    dashboard adminForm = new dashboard();
                                    adminForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Logged In successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Open the user form
                                    customer userForm = new customer();
                                    userForm.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }
    
    

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp sForm = new SignUp();
            sForm.Show();
        }

        private void sign_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (sign_showPass.Checked)
            {
                login_password.PasswordChar = '\0';
            }
            else
            {
               login_password.PasswordChar = '*';
            }
        }
    }
}
