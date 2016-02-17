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
    public partial class LogIn : UserControl
    {
        public LogIn()
        {
            InitializeComponent();
        }

        //After the sign in  button is clicked.
        private void goButton_Click(object sender, EventArgs e)
        {
            //correct user information brings user to next Form
            if (userText.Text == "Shrek" & passText.Text == "ihatedonkey")
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                Welcome we = new Welcome();
                f.Controls.Add(we);
            }
            //incorrect information prompts tells user they are incorrect.
            else
            {
                statusLabel.Text = "Incorrect user information.";
                statusLabel.BackColor = Color.Red;
            }
        }

        //returns to the first User Form
        private void backButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainScreen ms = new MainScreen();
            f.Controls.Add(ms);
        }
    }
}
