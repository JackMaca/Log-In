using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_In
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            LogIn li = new LogIn();
            li.Location = new Point((this.Width - li.Width) / 2, (this.Height - li.Width) / 2);
            li.Show();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {

        }
        //closes program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
