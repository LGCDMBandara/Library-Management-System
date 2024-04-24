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
    public partial class CompleteBook : Form
    {
        public CompleteBook()
        {
            InitializeComponent();
        }

        string mysqlCon = "server=localhost;database='library';uid=root;pwd=\"\";";

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want Logout the Application ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Form login = new Form1();
                login.Show();
            }
        }

        private void CompleteBook_Load_1(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection Conn = new MySqlConnection(mysqlCon);
                Conn.Open();

                MySqlDataAdapter data = new MySqlDataAdapter();

                data.SelectCommand = new MySqlCommand("select * from irbook where Return_Date = ''", Conn);
                DataSet dsIssued = new DataSet();
                data.Fill(dsIssued);
                IData.DataSource = dsIssued.Tables[0];

                data.SelectCommand = new MySqlCommand("select * from irbook where Return_Date != ''", Conn);
                DataSet dsReturned = new DataSet();
                data.Fill(dsReturned);
                RData.DataSource = dsReturned.Tables[0];

                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
