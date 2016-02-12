﻿using System;
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

            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);

            ms.Location = new Point((Screen.PrimaryScreen.Bounds.Width - ms.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - ms.Height) / 2);
            ms.Show();
        }
    }
}
