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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            if (guna2GradientButton_valid.Visible == false)
            {
                guna2GradientButton_valid.Visible = true;
                guna2LinePanel_valid.Visible = true;
            }
            else
            {
                guna2GradientButton_valid.Visible = false;
                guna2LinePanel_valid.Visible = false;
            }
        }

        private void guna2LinePanel_valid_Click(object sender, EventArgs e)
        {
            if (guna2GradientButton_valid.Visible == false)
            {
                guna2GradientButton_valid.Visible = true;
                guna2LinePanel_valid.Visible = true;
            }
            else
            {
                guna2GradientButton_valid.Visible = false;
                guna2LinePanel_valid.Visible = false;
            }
        }
    }
}
