using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppZaNaručivanjeHrane
{
    public partial class logIn : Form
    {
        public logIn()
        {
            InitializeComponent();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            if (tbKorisnickoIme.Text == "Marija Stopa")
            {
                if (tbLozinka.Text == "123")
                {
                  DialogResult odgovor = MessageBox.Show("Uspešno ste se prijavili", "Obaveštenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (odgovor==DialogResult.OK)
                    {
                        piletina p = new piletina();
                        p.ShowDialog();
                        p.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Uneli ste netačnu lozinku", "GREŠKA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbLozinka.Clear();
                    tbLozinka.Focus();
                }
            }
            else
            {
                MessageBox.Show("Uneli ste netačno korisničko ime", "GREŠKA",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbKorisnickoIme.Clear();
                tbKorisnickoIme.Focus();
            }
        }

        private void cbPrikaziLozinku_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPrikaziLozinku.Checked)
            {
                tbLozinka.UseSystemPasswordChar = false;
            }
            else
            {
                tbLozinka.UseSystemPasswordChar = true;
            }
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            tbKorisnickoIme.Clear();
            tbLozinka.Clear();
        }

        private void guna2GradientTileButton3_Click(object sender, EventArgs e)
        {
            mail m = new mail();
            m.ShowDialog();
            m.Dispose();
        }
    }
}
