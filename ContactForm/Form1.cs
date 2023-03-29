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

            string to = TextTo.Text;
            string from = "someone@email.com";
            MailMessage message = new MailMessage(from, to);
            message.Subject = TextSubject.Text;
            message.Body = TextBody.Text;
            foreach (var fileName in openFileDialog1.FileNames)
            {
                message.Attachments.Add(new Attachment(fileName));
            }
            var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("b84ad7480750e9", "557b3881e9785b"),
                EnableSsl = true
            };


            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string rootPath = @"C:\Users\yingg\source\repos\ContactForm\ContactForm\info\";
           
            StreamWriter newFile = new StreamWriter( rootPath + TextSubject.Text + ".txt");
            newFile.WriteLine("Note to: " + TextTo.Text);
            newFile.WriteLine("\n");
            newFile.WriteLine("Message: " + TextBody.Text);
        }
    }
}

