using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            foreach (var fileName in openFileDialog1.FileNames)
            labelFileName.Text = fileName;

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using(MailMessage mail = new MailMessage("someone@email.com", TextTo.Text, TextSubject.Text, TextBody.Text))
            using (SmtpClient smtp = new SmtpClient("email.com", 587))
            {
                foreach (var fileName in openFileDialog1.FileNames)
                    if (File.Exists(fileName))
                        mail.Attachments.Add(new Attachment(fileName));
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("someone@email.com", "password");
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
        }
    }
}
