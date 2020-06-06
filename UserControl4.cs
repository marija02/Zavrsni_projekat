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
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            if (guna2GradientButton_valid4.Visible==false)
            {
                guna2GradientButton_valid4.Visible = true;
                guna2LinePanel1_valid4.Visible = true;
            }
            else
            {
                guna2GradientButton_valid4.Visible = false;
                guna2LinePanel1_valid4.Visible = false;
            }
        }

        private void guna2GradientButton_valid4_Click(object sender, EventArgs e)
        {
            if (guna2GradientButton_valid4.Visible == false)
            {
                guna2GradientButton_valid4.Visible = true;
                guna2LinePanel1_valid4.Visible = true;
            }
            else
            {
                guna2GradientButton_valid4.Visible = false;
                guna2LinePanel1_valid4.Visible = false;
            }
        }
    }
}
