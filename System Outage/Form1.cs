using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace SystemOutage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblVersion.Text = "v0." + new System.IO.FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).LastWriteTime.ToString().Remove(9).Remove(5,2).Replace('/','.');
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:mohamed.aabdelfattah@tedata.net?subject=SystemOutage " + lblVersion.Text);
        }

        bool Outage = true;

        private void OutageMail()
        {
            if (checkAutoSendOutage.Checked)
                SendMail();
        }

        private void SendMail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("imail.tedata.net");

                mail.From = new MailAddress("mohamed.aabdelfattah@tedata.net");
                mail.To.Add("mohamed.aabdelfattah@tedata.net");
                mail.Subject = txtServerName.Text + " Down";
                mail.Body = txtServerName.Text + " is down from " + DateTime.Now;

                if (Outage)
                {
                    mail.Subject = txtServerName.Text + " Down";
                    mail.Body = txtServerName.Text + " is down from " + DateTime.Now;
                    listStatus.Items.Add("---> Outage Mail Sent - " + DateTime.Now + " <---");
                    Outage = false;
                }
                else
                {
                    mail.Subject = txtServerName.Text + " is Working now";
                    mail.Body = txtServerName.Text + " is working fine from " + DateTime.Now;
                    listStatus.Items.Add("---> UP Mail Sent - " + DateTime.Now + " <---");
                    Outage = true;
                }

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("mohamed.aabdelfattah", "Xugugx000");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        bool WebSiteIsAvailable(Uri uri)
        {
            HttpWebResponse response = null;
            try
            {
                WebRequest request = System.Net.WebRequest.Create(uri);
                request.Credentials = CredentialCache.DefaultCredentials;
                response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                    return true;
                else
                {
                    OutageMail();
                    return false;
                }
            }
            catch (Exception ex)
            {
                listStatus.Items.Add("ERROR: " + ex.ToString());
                //MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                if (response != null)
                    response.Close();
            }
        }

        public bool GetPingResponse(string IpAddress, int timeout = 3000)
        {
            try
            {
                var ping = new Ping();
                var reply = ping.Send(IpAddress, timeout);
                if (reply.Status == IPStatus.Success)
                    return true;
                else
                {
                    OutageMail();
                    return false;
                }
            }
            catch (Exception ex)
            {
                listStatus.Items.Add("ERROR: " + ex.ToString());
                //MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            if (btnCheck.Text == "Start Monitoring")
            {
                btnCheck.Text = "Stop Monitoring";
                listStatus.Items.Clear();
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                btnCheck.Enabled = false;
                if (backgroundWorker1.IsBusy)
                    backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            listStatus.Items.Add("Starting Server Monitoring - " + DateTime.Now);

            do
            {
                listStatus.Items.Insert(0, "Ping                         - " + GetPingResponse(txtServerIP.Text) + ", " + DateTime.Now);
                listStatus.Items.Insert(0, "WebRequest           - " + WebSiteIsAvailable(new Uri("http://" + txtServerIP.Text)) + ", " + DateTime.Now);

                Thread.Sleep(Convert.ToInt32(txtInterval.Text) * 1000);
            }
            while (!backgroundWorker1.CancellationPending);

            e.Cancel = true;
            return;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnCheck.Text = "Start Monitoring";
            btnCheck.Enabled = true;
            listStatus.Items.Insert(0, "Stopping Server Monitoring - " + DateTime.Now);
        }

        private void btnOutageMail_Click(object sender, EventArgs e)
        {
            btnOutageMail.Enabled = false;
            btnOutageMail.Text = "Sending...";
            backgroundWorker2.RunWorkerAsync();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            SendMail();
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnOutageMail.Text = "Outage Mail";
            btnOutageMail.Enabled = true;
        }

    }
}