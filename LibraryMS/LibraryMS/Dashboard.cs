using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want Logout the Application ?","Logout",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Form login = new Form1();
                login.Show();
            }
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBook AddBook = new AddBook();
            AddBook.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewBook ViewBook = new ViewBook();
            ViewBook.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudent AddStudent = new AddStudent();
            AddStudent.Show();
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStudent ViewStudent = new ViewStudent();
            ViewStudent.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            IssueBook IssueBook = new IssueBook();
            IssueBook.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnBook ReturnBook = new ReturnBook();
            ReturnBook.Show();
        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompleteBook CompleteBook = new CompleteBook();
            CompleteBook.Show();
        } 
    }
}
