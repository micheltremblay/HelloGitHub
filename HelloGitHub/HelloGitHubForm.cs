﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloGitHub
{
    public partial class HelloGitHubForm : Form
    {
        public HelloGitHubForm()
        {
            InitializeComponent();
        }

        private void afficherButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello GitHub! - Modifier par michelt430 - PROG 1236 N-Tier");
        }
    }
}
