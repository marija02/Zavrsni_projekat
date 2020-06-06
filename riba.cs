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
    public partial class riba : Form
    {
        public riba()
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

        private void userControl151_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite ribu Fish Dish?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Riba;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl152_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite tuna salatu?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Riba;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl153_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite dimljenu pastrmku?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Riba;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl154_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite rakove?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Riba;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl155_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite filet lososa?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Riba;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl156_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite pastrmku?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Riba;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl157_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite filet?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Riba;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl158_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite ribu šaran?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Riba;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl159_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite riblje spacijalitete?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Riba;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl1510_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite ribu oradu?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Riba;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl1511_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite riblje specijalitete sa povrćem?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Riba;
                label.Text = Class1.Ukupno.ToString("n2");
            }
            else
            {
                MessageBox.Show("Odustali ste od kupovine!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userControl1512_DoubleClick(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li želite da kupite filet brancina?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (odgovor == DialogResult.Yes)
            {
                Class1.Ukupno += Class1.Riba;
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
