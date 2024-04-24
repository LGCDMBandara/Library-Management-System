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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }
        string mysqlCon = "server=localhost;database='library';uid=root;pwd=\"\";";

        private void Refresh_Click(object sender, EventArgs e)
        {
            MySqlConnection Conn = new MySqlConnection(mysqlCon);
            try
            {
                Conn.Open();

                string id = Search.Text;
                string query = "select * from irbook where SID = @id AND Return_Date = ''";
                MySqlCommand cmd = new MySqlCommand(query, Conn);
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable(); 
                data.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    Data.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Invalid ID number or No Book Issued!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                if (Conn != null && Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
        }

        private void Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < Data.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < Data.Columns.Count)
            {
                try
                {
                    DataGridViewRow row = Data.Rows[e.RowIndex];

                    if (row != null)
                    {
                        string rowid = row.Cells[0].Value.ToString();
                        BName.Text = row.Cells[4].Value.ToString(); 
                        IDate.Text = row.Cells[6].Value.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            MySqlConnection Conn = new MySqlConnection(mysqlCon);
            try
            {
                Conn.Open();

                string studentId = Search.Text;
                string returnDate = RDate.Text;
                string bookName = BName.Text;

                string query = "update irbook set Return_Date = @returnDate where Book_Name = @bookName";
                MySqlCommand cmd = new MySqlCommand(query, Conn);

                cmd.Parameters.AddWithValue("@returnDate", returnDate);
                cmd.Parameters.AddWithValue("@bookName", bookName);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Book Returned Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Search.Text != "")
            {
                Search.Clear();
                Data.DataSource = null;
                BName.Clear();
                IDate.Clear();
                RDate.Value = DateTime.Now;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want Logout the Application ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                Form login = new Form1();
                login.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
