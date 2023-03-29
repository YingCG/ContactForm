
namespace ContactForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TextTo = new System.Windows.Forms.TextBox();
            this.TextBody = new System.Windows.Forms.TextBox();
            this.TextSubject = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelFileName = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send Email:";
            // 
            // TextTo
            // 
            this.TextTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextTo.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextTo.Location = new System.Drawing.Point(83, 73);
            this.TextTo.Multiline = true;
            this.TextTo.Name = "TextTo";
            this.TextTo.Size = new System.Drawing.Size(625, 44);
            this.TextTo.TabIndex = 1;
            this.TextTo.Text = "To";
            // 
            // TextBody
            // 
            this.TextBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBody.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBody.Location = new System.Drawing.Point(83, 223);
            this.TextBody.Multiline = true;
            this.TextBody.Name = "TextBody";
            this.TextBody.Size = new System.Drawing.Size(625, 195);
            this.TextBody.TabIndex = 2;
            this.TextBody.Text = "Messages:";
            // 
            // TextSubject
            // 
            this.TextSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextSubject.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextSubject.Location = new System.Drawing.Point(83, 129);
            this.TextSubject.Multiline = true;
            this.TextSubject.Name = "TextSubject";
            this.TextSubject.Size = new System.Drawing.Size(625, 44);
            this.TextSubject.TabIndex = 3;
            this.TextSubject.Text = "Subject";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ForeColor = System.Drawing.Color.SpringGreen;
            this.linkLabel1.LinkColor = System.Drawing.Color.Fuchsia;
            this.linkLabel1.Location = new System.Drawing.Point(596, 26);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(134, 32);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Attach File";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFileName.LinkColor = System.Drawing.Color.Fuchsia;
            this.labelFileName.Location = new System.Drawing.Point(83, 188);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(0, 32);
            this.labelFileName.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Fuchsia;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSend.Location = new System.Drawing.Point(596, 427);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(112, 45);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnWrite.FlatAppearance.BorderSize = 0;
            this.btnWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWrite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWrite.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnWrite.Location = new System.Drawing.Point(431, 427);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(159, 45);
            this.btnWrite.TabIndex = 7;
            this.btnWrite.Text = "Save as file";
            this.btnWrite.UseVisualStyleBackColor = false;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(67)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.TextSubject);
            this.Controls.Add(this.TextBody);
            this.Controls.Add(this.TextTo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextTo;
        private System.Windows.Forms.TextBox TextBody;
        private System.Windows.Forms.TextBox TextSubject;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel labelFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnWrite;
    }
}

