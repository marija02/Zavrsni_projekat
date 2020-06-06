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
    public partial class palacinke : Form
    {
        public palacinke()
        {
            InitializeComponent();
        }

        private void btnPalacinke_Click(object sender, EventArgs e)
        {
            palacinke p = new palacinke();
            p.ShowDialog();
            p.Dispose();
        }

        private void btnSalata_Click(object sender, EventArgs e)
        {
            salata s = new salata();
            s.ShowDialog();
            s.Dispose();
        }

        private void btnSendvici_Click(object sender, EventArgs e)
        {
            sendvici se = new sendvici();
            se.ShowDialog();
            se.Dispose();
        }

        private void btnVocniKup_Click(object sender, EventArgs e)
        {
            vocniKup v = new vocniKup();
            v.ShowDialog();
            v.Dispose();
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

        private void userControl101_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite palačinku nutella-plazma?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Palacinke;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl102_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite palačinku nutella-plazma-šumsko voće?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Palacinke;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl103_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite palačinku banana-plazma-malina?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Palacinke;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl104_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite palačinku banana-malina?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Palacinke;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl105_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite palačinku Cocoloco?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Palacinke;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl106_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite palačinku Snikers?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Palacinke;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl107_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite palačinku plazma-banana-lešnik?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Palacinke;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl108_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite palačinku kajsija-kikiriki?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Palacinke;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl109_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite palačinku pistaći-nutella-jagoda?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Palacinke;
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
