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
    public partial class piletina : Form
    {
        public piletina()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnRiba_Click(object sender, EventArgs e)
        {
            riba r = new riba();
            r.ShowDialog();
            r.Dispose();
           // piletina p = new piletina();
           // p.Close();
        }

        private void btnPiletina_Click(object sender, EventArgs e)
        {
            piletina p = new piletina();
            p.ShowDialog();
            p.Dispose();
        }

        private void btnPica_Click(object sender, EventArgs e)
        {
            pizza pica = new pizza();
            pica.ShowDialog();
            pica.Dispose();
        }

        private void btnSpageti_Click(object sender, EventArgs e)
        {
            spageti s = new spageti();
            s.ShowDialog();
            s.Dispose();
        }

        private void guna2GradientTileButton6_Click(object sender, EventArgs e)
        {
            piletina p = new piletina();
            p.ShowDialog();
            p.Dispose();
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            kafa k = new kafa();
            k.ShowDialog();
            k.Dispose();
        }

        private void guna2GradientTileButton3_Click(object sender, EventArgs e)
        {
            palacinke p = new palacinke();
            p.ShowDialog();
            p.Dispose();
        }

        private void guna2GradientTileButton4_Click(object sender, EventArgs e)
        {
            torta t = new torta();
            t.ShowDialog();
            t.Dispose();
        }

        private void userControl131_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite Tornado?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Piletina;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl132_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite piletinu sa spanaćem?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Piletina;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl133_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite piletinu makaronama?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Piletina;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl134_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite punjenu piletinu?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Piletina;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl135_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite sendvič sa piletinom?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Piletina;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl136_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite piletinu u sosu?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Piletina;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl137_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite piletinu sa povrćem?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Piletina;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (odgovor == DialogResult.Yes)
                {
                    Class1.Ukupno += Class1.Piletina;
                    label.Text = Class1.Ukupno.ToString("n2");
                }
                else
                {
                    MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void userControl138_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite piletinu u sosu?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Piletina;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (odgovor == DialogResult.Yes)
                {
                    Class1.Ukupno += Class1.Piletina;
                    label.Text = Class1.Ukupno.ToString("n2");
                }
                else
                {
                    MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void userControl139_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite piletinu u sosu sa paradajzom?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Piletina;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                Class1.Ukupno *= 0.80;
                label.Text = Class1.Ukupno.ToString("n2");
            }
        }
    }
}
