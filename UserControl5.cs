﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppZaNaručivanjeHrane
{
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
        }

        private void guna2LinePanel_valid5_Click(object sender, EventArgs e)
        {
            if (guna2GradientButton_valid5.Visible==false)
            {
                guna2GradientButton_valid5.Visible = true;
                guna2LinePanel_valid5.Visible = true;
            }
            else
            {
                guna2GradientButton_valid5.Visible = false;
                guna2LinePanel_valid5.Visible = false;
            }
        }
    }
}
