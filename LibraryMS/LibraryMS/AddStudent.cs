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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }
        string mysqlCon = "server=localhost;database='library';uid=root;pwd=\"\";";

        private void label1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want Logout the Application ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                Form login = new Form1();
                login.Show();
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            MySqlConnection Conn = new MySqlConnection(mysqlCon);

            if (ID.Text != "" && SName.Text != "" && Email.Text != "" && City.Text != "")
            {
                try
                {
                    Conn.Open();

                    string id = ID.Text;
                    string sname = SName.Text;
                    string date = Date.Value.Date.ToString("yyyy-MM-dd HH:mm");
                    string email = Email.Text;
                    string city = City.Text;

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO addstudent(ID_Number, Student_Name, Joined_Date, Email, City) VALUES (@id, @sname, @date, @email, @city)", Conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@sname", sname);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@city", city);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Student is already entered the system. Please use View Option and Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (Conn != null && Conn.State == ConnectionState.Open)
                    {
                        Conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all of Informations", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ID.Clear();
            SName.Clear();
            Email.Clear();
            Date.Value = DateTime.Now;
            City.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
