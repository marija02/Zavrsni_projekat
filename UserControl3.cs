using System;
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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Click(object sender, EventArgs e)
        {
            if (guna2GradientButton_valid3.Visible==false)
            {
                guna2GradientButton_valid3.Visible = true;
                guna2LinePanel1_valid3.Visible = true;
            }
            else
            {
                guna2GradientButton_valid3.Visible = false;
                guna2LinePanel1_valid3.Visible = false;
            }
        }

        private void guna2LinePanel1_valid3_Click(object sender, EventArgs e)
        {
            if (guna2GradientButton_valid3.Visible == false)
            {
                guna2GradientButton_valid3.Visible = true;
                guna2LinePanel1_valid3.Visible = true;
            }
            else
            {
                guna2GradientButton_valid3.Visible = false;
                guna2LinePanel1_valid3.Visible = false;
            }
        }
    }
}
