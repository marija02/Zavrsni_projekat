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
    public partial class milksejk : Form
    {
        public milksejk()
        {
            InitializeComponent();
        }

        private void btnAlkohol_Click(object sender, EventArgs e)
        {
            alkohol a = new alkohol();
            a.ShowDialog();
            a.Dispose();
        }

        private void btnKafa_Click(object sender, EventArgs e)
        {
            kafa k = new kafa();
            k.ShowDialog();
            k.Dispose();
        }

        private void btnMilkshake_Click(object sender, EventArgs e)
        {
            milksejk m = new milksejk();
            m.ShowDialog();
            m.Dispose();
        }

        private void btnSokovi_Click(object sender, EventArgs e)
        {
            sokovi s = new sokovi();
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

        private void userControl81_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite milkshake banana-jabuka?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Milksejk;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl82_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite milkshake banana-plazma?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Milksejk;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl83_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite milkshake breskva-lešnik?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Milksejk;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl84_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite milkshake Stracciatella?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Milksejk;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl85_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite milkshake jagoda-malina?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Milksejk;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl86_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite milkshake karamela-čokolada?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Milksejk;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl87_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite milkshake banana-malina?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Milksejk;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl88_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite milkshake Oreo?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Milksejk;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl89_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite milkshake banana-plazma-med?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Milksejk;
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
