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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lg.Width += 5;

            if (lg.Width >= 599)
            {
                timer1.Stop();
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }

        }
    }
}
