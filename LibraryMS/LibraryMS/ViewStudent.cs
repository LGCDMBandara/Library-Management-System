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
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }
        string mysqlCon = "server=localhost;database='library';uid=root;pwd=\"\";";

        private void label2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want Logout the Application ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                Form login = new Form1();
                login.Show();
            }
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection Conn = new MySqlConnection(mysqlCon);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conn;

                cmd.CommandText = "select * from addstudent";
                MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                data.Fill(ds);

                Table.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex.Message);
            }
        }

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID.Text = Table.SelectedRows[0].Cells[0].Value.ToString();
                SName.Text = Table.SelectedRows[0].Cells[1].Value.ToString();
                Date.Text = Table.SelectedRows[0].Cells[2].Value.ToString();
                Email.Text = Table.SelectedRows[0].Cells[3].Value.ToString();
                City.Text = Table.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ID.Clear();
            SName.Clear();
            Email.Clear();
            Date.Value = DateTime.Now;
            City.Clear();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (Search.Text != "")
            {
                try
                {
                    MySqlConnection Conn = new MySqlConnection(mysqlCon);
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = Conn;

                    cmd.CommandText = "select * from addstudent where Student_Name LIKE @SearchTerm";
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + Search.Text + "%");

                    MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    data.Fill(ds);

                    Table.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            else
            {
                try
                {
                    MySqlConnection Conn = new MySqlConnection(mysqlCon);
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = Conn;

                    cmd.CommandText = "select * from addstudent";
                    MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    data.Fill(ds);

                    Table.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Search.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Updated. Confirmed?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string id = ID.Text;
                string sname = SName.Text;
                string date = Date.Value.Date.ToString("yyyy-MM-dd HH:mm");
                string email = Email.Text;
                string city = City.Text;

                try
                {
                    MySqlConnection Conn = new MySqlConnection(mysqlCon);
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = Conn;

                    cmd.CommandText = "UPDATE addstudent SET ID_Number = @id, Student_Name = @sname, Joined_Date = @date, Email = @email, City = @city WHERE ID_Number = @id;";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@sname", sname);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@city", city);

                    MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    data.Fill(ds);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted. Confirmed?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string id = ID.Text;
                string sname = SName.Text;
                string date = Date.Value.Date.ToString("yyyy-MM-dd HH:mm");
                string email = Email.Text;
                string city = City.Text;

                try
                {
                    MySqlConnection Conn = new MySqlConnection(mysqlCon);
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = Conn;

                    cmd.CommandText = "DELETE from addstudent where ID_Number = @id;";
                    cmd.Parameters.AddWithValue("@id", id);

                    MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    data.Fill(ds);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
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
