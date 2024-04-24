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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }

        string mysqlCon = "server=localhost;database='library';uid=root;pwd=\"\";";

        private void Login_Click(object sender, EventArgs e)
        {
            MySqlConnection Conn = new MySqlConnection(mysqlCon);

            try
            {
                Conn.Open();

                MySqlCommand cmd = new MySqlCommand("select * from login where UName = '" + UName.Text + "' and Password = '" + Password.Text + "'", Conn);
                MySqlDataAdapter data = new MySqlDataAdapter(cmd);

                DataTable ds = new DataTable();
                data.Fill(ds);

                if (ds.Rows.Count != 0)
                {
                    this.Hide();
                    Form dashboard = new Dashboard();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Wrong User Name or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally
            {
                if (Conn != null && Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form signup = new SignUp();
            signup.Show();
        }
    }
}
