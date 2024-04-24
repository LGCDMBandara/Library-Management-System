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
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }
        string mysqlCon = "server=localhost;database='library';uid=root;pwd=\"\";";

        private void IssueBook_Load(object sender, EventArgs e)
        {
            MySqlConnection Conn = new MySqlConnection(mysqlCon);
            try
            {
                MySqlCommand cmd = new MySqlCommand("select Book_Name from addbook", Conn);
                cmd.Connection = Conn;
                Conn.Open();

                MySqlDataReader data = cmd.ExecuteReader();

                while (data.Read())
                {
                    for (int i = 0; i < data.FieldCount; i++)
                    {
                        BName.Items.Add(data.GetString(i));
                    }
                }
                data.Close();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        int count;
        private void Refresh_Click(object sender, EventArgs e)
        {
            MySqlConnection Conn = new MySqlConnection(mysqlCon);
            try
            {
                Conn.Open();
                if (Search.Text != "")
                {
                    string id = Search.Text;
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = Conn;

                    cmd.CommandText = "select * from addstudent where Id_Number = '" + id + "'";
                    MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    data.Fill(ds);

                    cmd.CommandText = "select count(SID) from irbook where SID = '" + id + "' and Return_Date is null";
                    MySqlDataAdapter data1 = new MySqlDataAdapter(cmd);
                    DataSet ds1 = new DataSet();
                    data.Fill(ds1);

                    count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());

                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        SName.Text = ds.Tables[0].Rows[0][1].ToString();
                        Email.Text = ds.Tables[0].Rows[0][3].ToString();
                        City.Text = ds.Tables[0].Rows[0][4].ToString();

                    }
                    else
                    {
                        SName.Clear();
                        Email.Clear();
                        City.Clear();
                        Date.Value = DateTime.Now;
                        MessageBox.Show("Invalid ID Number. Please registration First!","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    }
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

        private void label2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want Logout the Application ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                Form login = new Form1();
                login.Show();
            }
        }

        private void Issue_Click(object sender, EventArgs e)
        {
            try
            {
                if (SName.Text != "")
                {
                    if (BName.SelectedIndex != -1 && count <= 2)
                    {
                        using (MySqlConnection Conn = new MySqlConnection(mysqlCon))
                        {
                            Conn.Open();

                            string eid = Search.Text;
                            string sname = SName.Text;
                            string email = Email.Text;
                            string bname = BName.Text;
                            string city = City.Text;
                            string date = Date.Value.Date.ToString("yyyy-MM-dd HH:mm");

                            string query = "INSERT INTO irbook(SID, Student_Name, Email, Book_Name, City, Issue_Date) VALUES (@eid, @sname, @email, @bname, @city, @date)";
                            MySqlCommand cmd = new MySqlCommand(query, Conn);

                            cmd.Parameters.AddWithValue("@eid", eid);
                            cmd.Parameters.AddWithValue("@sname", sname);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@bname", bname);
                            cmd.Parameters.AddWithValue("@city", city);
                            cmd.Parameters.AddWithValue("@date", date);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Book Issued Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select Books OR Maximum books have been issued!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Enter a valid ID Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (Search.Text == "")
            {
                SName.Clear();
                Email.Clear();
                City.Clear();
                Date.Value = DateTime.Now;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
