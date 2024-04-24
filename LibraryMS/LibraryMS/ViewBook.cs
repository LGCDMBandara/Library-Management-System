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
    public partial class ViewBook : Form
    {
        public ViewBook()
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
        
        private void ViewBook_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection Conn = new MySqlConnection(mysqlCon);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conn;

                cmd.CommandText = "select * from addbook";
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
        Int64 id;
        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Int64.Parse(Table.SelectedRows[0].Cells[0].Value.ToString());
                BName.Text = Table.SelectedRows[0].Cells[1].Value.ToString();
                BAName.Text = Table.SelectedRows[0].Cells[2].Value.ToString();
                Date.Text = Table.SelectedRows[0].Cells[3].Value.ToString();
                Quantity.Text = Table.SelectedRows[0].Cells[4].Value.ToString();
                Price.Text = Table.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BName.Clear();
            BAName.Clear();
            Price.Clear();
            Date.Value = DateTime.Now;
            Quantity.Clear();
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

                    cmd.CommandText = "select * from addbook where Book_Name LIKE @SearchTerm";
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

                    cmd.CommandText = "select * from addbook";
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
                string bname = BName.Text;
                string baname = BAName.Text;
                string date = Date.Value.Date.ToString("yyyy-MM-dd HH:mm");
                int quantity = int.Parse(Quantity.Text);
                string price = Price.Text;

                try
                {
                    MySqlConnection Conn = new MySqlConnection(mysqlCon);
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = Conn;

                    cmd.CommandText = "UPDATE addbook SET Book_Name = @bname, Book_Aurthor_Name = @baname, Publication_Date = @date, Quantity = @quantity, Price = @price WHERE ID = @id;";
                    cmd.Parameters.AddWithValue("@bname", bname);
                    cmd.Parameters.AddWithValue("@baname", baname);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@price", price);
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted. Confirmed?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string bname = BName.Text;
                string baname = BAName.Text;
                string date = Date.Value.Date.ToString("yyyy-MM-dd HH:mm");
                int quantity = int.Parse(Quantity.Text);
                string price = Price.Text;

                try
                {
                    MySqlConnection Conn = new MySqlConnection(mysqlCon);
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = Conn;

                    cmd.CommandText = "DELETE from addbook where ID = @id;";
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
