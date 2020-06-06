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
    public partial class spageti : Form
    {
        public spageti()
        {
            InitializeComponent();
        }

        private void btnPiletina_Click(object sender, EventArgs e)
        {
            piletina p = new piletina();
            p.ShowDialog();
            p.Dispose();
        }

        private void btnRiba_Click(object sender, EventArgs e)
        {
            riba r = new riba();
            r.ShowDialog();
            r.Dispose();
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

        private void userControl161_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite bolognese?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Spageti;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl162_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite bosciaola?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Spageti;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl163_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite pastu sa piletinom?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Spageti;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl164_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite carbonaru?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Spageti;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl165_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite pastu sa ćuftama?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Spageti;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl166_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite lasagne pastu?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Spageti;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl167_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite pastu sa gaudom i tikvicama?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Spageti;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl168_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite pastu sa ćuretinom?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Spageti;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl169_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite integralnu pastu?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Spageti;
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
