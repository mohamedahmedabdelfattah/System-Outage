namespace SystemOutage
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCheck = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblCheckInterval = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.lblServerIP = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnOutageMail = new System.Windows.Forms.Button();
            this.listStatus = new System.Windows.Forms.ListBox();
            this.checkAutoSendOutage = new System.Windows.Forms.CheckBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.lblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(105, 243);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(124, 39);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Start Monitoring";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lblCheckInterval
            // 
            this.lblCheckInterval.AutoSize = true;
            this.lblCheckInterval.Location = new System.Drawing.Point(43, 214);
            this.lblCheckInterval.Name = "lblCheckInterval";
            this.lblCheckInterval.Size = new System.Drawing.Size(70, 13);
            this.lblCheckInterval.TabIndex = 2;
            this.lblCheckInterval.Text = "Interval (Sec)";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(119, 211);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(94, 20);
            this.txtInterval.TabIndex = 3;
            this.txtInterval.Text = "3";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(119, 185);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(94, 20);
            this.txtServerIP.TabIndex = 5;
            this.txtServerIP.Text = "74.125.206.139";
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Location = new System.Drawing.Point(43, 188);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(51, 13);
            this.lblServerIP.TabIndex = 4;
            this.lblServerIP.Text = "Server IP";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(309, 185);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(94, 20);
            this.txtServerName.TabIndex = 7;
            this.txtServerName.Text = "google.com";
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(234, 188);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(69, 13);
            this.lblServerName.TabIndex = 6;
            this.lblServerName.Text = "Server Name";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1, 292);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(174, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "mohamed.aabdelfattah@tedata.net";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnOutageMail
            // 
            this.btnOutageMail.Location = new System.Drawing.Point(235, 243);
            this.btnOutageMail.Name = "btnOutageMail";
            this.btnOutageMail.Size = new System.Drawing.Size(113, 39);
            this.btnOutageMail.TabIndex = 9;
            this.btnOutageMail.Text = "Outage Mail";
            this.btnOutageMail.UseVisualStyleBackColor = true;
            this.btnOutageMail.Click += new System.EventHandler(this.btnOutageMail_Click);
            // 
            // listStatus
            // 
            this.listStatus.FormattingEnabled = true;
            this.listStatus.HorizontalScrollbar = true;
            this.listStatus.Location = new System.Drawing.Point(12, 12);
            this.listStatus.Name = "listStatus";
            this.listStatus.Size = new System.Drawing.Size(428, 160);
            this.listStatus.TabIndex = 1;
            // 
            // checkAutoSendOutage
            // 
            this.checkAutoSendOutage.AutoSize = true;
            this.checkAutoSendOutage.Location = new System.Drawing.Point(237, 213);
            this.checkAutoSendOutage.Name = "checkAutoSendOutage";
            this.checkAutoSendOutage.Size = new System.Drawing.Size(173, 17);
            this.checkAutoSendOutage.TabIndex = 10;
            this.checkAutoSendOutage.Text = "Automatically send Outage mail";
            this.checkAutoSendOutage.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(392, 294);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(46, 13);
            this.lblVersion.TabIndex = 11;
            this.lblVersion.Text = "v0.0.0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 310);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.checkAutoSendOutage);
            this.Controls.Add(this.btnOutageMail);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.lblServerIP);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.lblCheckInterval);
            this.Controls.Add(this.listStatus);
            this.Controls.Add(this.btnCheck);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Outage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblCheckInterval;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnOutageMail;
        private System.Windows.Forms.ListBox listStatus;
        private System.Windows.Forms.CheckBox checkAutoSendOutage;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label lblVersion;
    }
}

