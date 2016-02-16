using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_In
{
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        //closes program
        private void exitButton_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        //takes user to the userform to sign in
        private void signButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            LogIn li = new LogIn();
            f.Controls.Add(li);
            li.Location = new Point((this.Width - li.Width) / 2, (this.Height - li.Height) / 2);
            li.Show();

        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            About ab = new About();
            f.Controls.Add(ab);
            ab.Location = new Point((this.Width - ab.Width) / 2, (this.Height - ab.Height) / 2);
        }
    }
}
