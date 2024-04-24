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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        string mysqlCon = "server=localhost;database='library';uid=root;pwd=\"\";";
            
        private void label1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want Logout the Application ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Form login = new Form1();
                login.Show();
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            MySqlConnection Conn = new MySqlConnection(mysqlCon);

            if (BName.Text != "" && BAName.Text != "" && Price.Text != "")
            {
                try
                {
                    Conn.Open();

                    string bname = BName.Text;
                    string baname = BAName.Text;
                    string date = Date.Value.Date.ToString("yyyy-MM-dd HH:mm");
                    int quantity = int.Parse(Quantity.Text);
                    string price = Price.Text;

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO addbook(Book_Name, Book_Aurthor_Name, Publication_Date, Quantity, Price) VALUES (@bname, @baname, @date, @quantity, @price)", Conn);
                    cmd.Parameters.AddWithValue("@bname", bname);
                    cmd.Parameters.AddWithValue("@baname", baname);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@price", price);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Book is already entered the system. Please use View Option and Update","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            BName.Clear();
            BAName.Clear();
            Price.Clear();
            Date.Value = DateTime.Now;
            Quantity.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
 