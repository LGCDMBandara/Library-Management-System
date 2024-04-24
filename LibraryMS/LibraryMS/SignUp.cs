using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryMS
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        string mysqlCon = "server=localhost;database='library';uid=root;pwd=\"\";";

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new Form1();
            login.Show();
        }

        private void sign_Click(object sender, EventArgs e)
        {
            MySqlConnection Conn = new MySqlConnection(mysqlCon);
            try
            {
                Conn.Open();

                string uname = UserName.Text;
                string pass = Password.Text;
                string rpass = RePassword.Text;

                if (pass == rpass)
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO login(UName,Password) VALUES (@uname,@pass)", Conn);
                    cmd.Parameters.AddWithValue("@UName", uname);
                    cmd.Parameters.AddWithValue("@pass", pass);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    Form login = new Form1();
                    login.Show();
                }
                else 
                {
                    MessageBox.Show("Password did not match","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("User name already taken","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                if (Conn != null && Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
        }

    }
}
