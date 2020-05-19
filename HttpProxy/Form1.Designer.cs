namespace HttpProxy
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
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.txtCacheTimeOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxContentCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxContentFilter = new System.Windows.Forms.CheckBox();
            this.checkBoxChangeHeaders = new System.Windows.Forms.CheckBox();
            this.checkBoxBasicAuth = new System.Windows.Forms.CheckBox();
            this.txtBufferSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxLoggingRequestHeaders = new System.Windows.Forms.CheckBox();
            this.checkBoxLoggingResponseHeaders = new System.Windows.Forms.CheckBox();
            this.checkBoxLoggingContentIn = new System.Windows.Forms.CheckBox();
            this.checkBoxLoggingContentOut = new System.Windows.Forms.CheckBox();
            this.checkBoxLoggingClient = new System.Windows.Forms.CheckBox();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.txtProxyPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(502, 10);
            this.btnStartStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(163, 87);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.Text = "Start/stop proxy";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(9, 374);
            this.btnClearLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(262, 33);
            this.btnClearLog.TabIndex = 1;
            this.btnClearLog.Text = "Clear log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // txtCacheTimeOut
            // 
            this.txtCacheTimeOut.Location = new System.Drawing.Point(502, 126);
            this.txtCacheTimeOut.Margin = new System.Windows.Forms.Padding(2);
            this.txtCacheTimeOut.Name = "txtCacheTimeOut";
            this.txtCacheTimeOut.Size = new System.Drawing.Size(163, 20);
            this.txtCacheTimeOut.TabIndex = 4;
            this.txtCacheTimeOut.Text = "300 (0=no cache)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Proxy port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "P1.a) Cache time out in seconds";
            // 
            // checkBoxContentCheck
            // 
            this.checkBoxContentCheck.AutoSize = true;
            this.checkBoxContentCheck.Location = new System.Drawing.Point(375, 153);
            this.checkBoxContentCheck.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxContentCheck.Name = "checkBoxContentCheck";
            this.checkBoxContentCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxContentCheck.Size = new System.Drawing.Size(293, 17);
            this.checkBoxContentCheck.TabIndex = 7;
            this.checkBoxContentCheck.Text = "P1.b) Zet check op gewijzigde content op server aan/uit";
            this.checkBoxContentCheck.UseVisualStyleBackColor = true;
            // 
            // checkBoxContentFilter
            // 
            this.checkBoxContentFilter.AutoSize = true;
            this.checkBoxContentFilter.Location = new System.Drawing.Point(509, 178);
            this.checkBoxContentFilter.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxContentFilter.Name = "checkBoxContentFilter";
            this.checkBoxContentFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxContentFilter.Size = new System.Drawing.Size(159, 17);
            this.checkBoxContentFilter.TabIndex = 8;
            this.checkBoxContentFilter.Text = "P2) Zet content filter aan/uit";
            this.checkBoxContentFilter.UseVisualStyleBackColor = true;
            // 
            // checkBoxChangeHeaders
            // 
            this.checkBoxChangeHeaders.AutoSize = true;
            this.checkBoxChangeHeaders.Location = new System.Drawing.Point(441, 198);
            this.checkBoxChangeHeaders.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxChangeHeaders.Name = "checkBoxChangeHeaders";
            this.checkBoxChangeHeaders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxChangeHeaders.Size = new System.Drawing.Size(227, 30);
            this.checkBoxChangeHeaders.TabIndex = 9;
            this.checkBoxChangeHeaders.Text = "P4.a) Zet het wijzigen van headers aan/uit\r\n-> Toon de headers ook in de log";
            this.checkBoxChangeHeaders.UseVisualStyleBackColor = true;
            // 
            // checkBoxBasicAuth
            // 
            this.checkBoxBasicAuth.AutoSize = true;
            this.checkBoxBasicAuth.Location = new System.Drawing.Point(426, 230);
            this.checkBoxBasicAuth.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBasicAuth.Name = "checkBoxBasicAuth";
            this.checkBoxBasicAuth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxBasicAuth.Size = new System.Drawing.Size(242, 17);
            this.checkBoxBasicAuth.TabIndex = 10;
            this.checkBoxBasicAuth.Text = "P4.b) Zet basic access authentication aan/uit";
            this.checkBoxBasicAuth.UseVisualStyleBackColor = true;
            // 
            // txtBufferSize
            // 
            this.txtBufferSize.Location = new System.Drawing.Point(502, 266);
            this.txtBufferSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtBufferSize.Name = "txtBufferSize";
            this.txtBufferSize.Size = new System.Drawing.Size(162, 20);
            this.txtBufferSize.TabIndex = 11;
            this.txtBufferSize.Text = "1024";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "T4, T8) Buffer size";
            // 
            // checkBoxLoggingRequestHeaders
            // 
            this.checkBoxLoggingRequestHeaders.AutoSize = true;
            this.checkBoxLoggingRequestHeaders.Checked = true;
            this.checkBoxLoggingRequestHeaders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLoggingRequestHeaders.Location = new System.Drawing.Point(488, 297);
            this.checkBoxLoggingRequestHeaders.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxLoggingRequestHeaders.Name = "checkBoxLoggingRequestHeaders";
            this.checkBoxLoggingRequestHeaders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxLoggingRequestHeaders.Size = new System.Drawing.Size(180, 17);
            this.checkBoxLoggingRequestHeaders.TabIndex = 13;
            this.checkBoxLoggingRequestHeaders.Text = "Logging request headers aan/uit";
            this.checkBoxLoggingRequestHeaders.UseVisualStyleBackColor = true;
            // 
            // checkBoxLoggingResponseHeaders
            // 
            this.checkBoxLoggingResponseHeaders.AutoSize = true;
            this.checkBoxLoggingResponseHeaders.Location = new System.Drawing.Point(480, 318);
            this.checkBoxLoggingResponseHeaders.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxLoggingResponseHeaders.Name = "checkBoxLoggingResponseHeaders";
            this.checkBoxLoggingResponseHeaders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxLoggingResponseHeaders.Size = new System.Drawing.Size(188, 17);
            this.checkBoxLoggingResponseHeaders.TabIndex = 14;
            this.checkBoxLoggingResponseHeaders.Text = "Logging response headers aan/uit";
            this.checkBoxLoggingResponseHeaders.UseVisualStyleBackColor = true;
            // 
            // checkBoxLoggingContentIn
            // 
            this.checkBoxLoggingContentIn.AutoSize = true;
            this.checkBoxLoggingContentIn.Location = new System.Drawing.Point(514, 339);
            this.checkBoxLoggingContentIn.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxLoggingContentIn.Name = "checkBoxLoggingContentIn";
            this.checkBoxLoggingContentIn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxLoggingContentIn.Size = new System.Drawing.Size(154, 17);
            this.checkBoxLoggingContentIn.TabIndex = 15;
            this.checkBoxLoggingContentIn.Text = "Logging content IN aan/uit";
            this.checkBoxLoggingContentIn.UseVisualStyleBackColor = true;
            // 
            // checkBoxLoggingContentOut
            // 
            this.checkBoxLoggingContentOut.AutoSize = true;
            this.checkBoxLoggingContentOut.Location = new System.Drawing.Point(507, 361);
            this.checkBoxLoggingContentOut.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxLoggingContentOut.Name = "checkBoxLoggingContentOut";
            this.checkBoxLoggingContentOut.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxLoggingContentOut.Size = new System.Drawing.Size(161, 17);
            this.checkBoxLoggingContentOut.TabIndex = 16;
            this.checkBoxLoggingContentOut.Text = "Logging content UIT aan/uit";
            this.checkBoxLoggingContentOut.UseVisualStyleBackColor = true;
            // 
            // checkBoxLoggingClient
            // 
            this.checkBoxLoggingClient.AutoSize = true;
            this.checkBoxLoggingClient.Location = new System.Drawing.Point(435, 385);
            this.checkBoxLoggingClient.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxLoggingClient.Name = "checkBoxLoggingClient";
            this.checkBoxLoggingClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxLoggingClient.Size = new System.Drawing.Size(233, 17);
            this.checkBoxLoggingClient.TabIndex = 17;
            this.checkBoxLoggingClient.Text = "Logging client (which browser is connected)";
            this.checkBoxLoggingClient.UseVisualStyleBackColor = true;
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(9, 10);
            this.listBoxLog.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(263, 355);
            this.listBoxLog.TabIndex = 18;
            // 
            // txtProxyPort
            // 
            this.txtProxyPort.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtProxyPort.Location = new System.Drawing.Point(502, 102);
            this.txtProxyPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtProxyPort.Name = "txtProxyPort";
            this.txtProxyPort.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtProxyPort.Size = new System.Drawing.Size(163, 20);
            this.txtProxyPort.TabIndex = 3;
            this.txtProxyPort.Text = "9000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 418);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.checkBoxLoggingClient);
            this.Controls.Add(this.checkBoxLoggingContentOut);
            this.Controls.Add(this.checkBoxLoggingContentIn);
            this.Controls.Add(this.checkBoxLoggingResponseHeaders);
            this.Controls.Add(this.checkBoxLoggingRequestHeaders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBufferSize);
            this.Controls.Add(this.checkBoxBasicAuth);
            this.Controls.Add(this.checkBoxChangeHeaders);
            this.Controls.Add(this.checkBoxContentFilter);
            this.Controls.Add(this.checkBoxContentCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCacheTimeOut);
            this.Controls.Add(this.txtProxyPort);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnStartStop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Proxy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.TextBox txtCacheTimeOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxContentCheck;
        private System.Windows.Forms.CheckBox checkBoxContentFilter;
        private System.Windows.Forms.CheckBox checkBoxChangeHeaders;
        private System.Windows.Forms.CheckBox checkBoxBasicAuth;
        private System.Windows.Forms.TextBox txtBufferSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxLoggingRequestHeaders;
        private System.Windows.Forms.CheckBox checkBoxLoggingResponseHeaders;
        private System.Windows.Forms.CheckBox checkBoxLoggingContentIn;
        private System.Windows.Forms.CheckBox checkBoxLoggingContentOut;
        private System.Windows.Forms.CheckBox checkBoxLoggingClient;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.TextBox txtProxyPort;
    }
}

