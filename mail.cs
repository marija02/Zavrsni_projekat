using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail; 
using System.Net;

namespace AppZaNaručivanjeHrane
{
    public partial class mail : Form
    {
        public mail()
        {
            InitializeComponent();
        }

        private string fajl;
        private void btnPosalji_Click(object sender, EventArgs e)
        {
            MailAddress posiljalac = new MailAddress(tbPosiljaocAdr.Text, tbPosiljaocIme.Text);

            MailAddress primalac = new MailAddress(tbPrimaoc.Text);

            MailMessage poruka = new MailMessage();
            poruka.From = posiljalac; 
            poruka.To.Add(primalac); 
            poruka.Subject = tbNaslov.Text; 
            poruka.Body = rtbTekstPoruke.Text; 
                                             
            Attachment at = new Attachment(fajl);
            poruka.Attachments.Add(at);

            SmtpClient mailClient = new SmtpClient("smtp.gmail.com");
            mailClient.EnableSsl = true; 
            mailClient.Port = 465; 
            mailClient.Credentials = new NetworkCredential(tbPosiljaocAdr.Text, tbPosiljaocLoz.Text);

            try
            {
                mailClient.Send(poruka); 
                MessageBox.Show("Poruka je poslata");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fajl = openFileDialog1.InitialDirectory.ToString() + openFileDialog1.FileName.ToString();
            }
        }
    }
}
