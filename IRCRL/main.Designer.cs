namespace WindowsFormsApplication1
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.grpIRCCONFIG = new System.Windows.Forms.GroupBox();
            this.lblNick = new System.Windows.Forms.Label();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.lblChannel = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Stats = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblMsgM = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVoicedNum = new System.Windows.Forms.Label();
            this.lblOpsNum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblmsgs = new System.Windows.Forms.Label();
            this.lblUserNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpLOGCONFIG = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPachubeFeed = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPachubeKey = new System.Windows.Forms.TextBox();
            this.txtLogInterval = new System.Windows.Forms.TextBox();
            this.StatsTimer = new System.Windows.Forms.Timer(this.components);
            this.grpIRCCONFIG.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Stats.SuspendLayout();
            this.grpLOGCONFIG.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(11, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(73, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Start";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(67, 22);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(187, 20);
            this.txtServer.TabIndex = 1;
            this.txtServer.Text = "irc.freenode.net";
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(67, 48);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(187, 20);
            this.txtChannel.TabIndex = 2;
            this.txtChannel.Text = "#logbottest";
            // 
            // grpIRCCONFIG
            // 
            this.grpIRCCONFIG.Controls.Add(this.lblNick);
            this.grpIRCCONFIG.Controls.Add(this.txtNick);
            this.grpIRCCONFIG.Controls.Add(this.lblChannel);
            this.grpIRCCONFIG.Controls.Add(this.lblServer);
            this.grpIRCCONFIG.Controls.Add(this.txtServer);
            this.grpIRCCONFIG.Controls.Add(this.txtChannel);
            this.grpIRCCONFIG.Location = new System.Drawing.Point(13, 73);
            this.grpIRCCONFIG.Name = "grpIRCCONFIG";
            this.grpIRCCONFIG.Size = new System.Drawing.Size(260, 104);
            this.grpIRCCONFIG.TabIndex = 3;
            this.grpIRCCONFIG.TabStop = false;
            this.grpIRCCONFIG.Text = "IRC-CONFIG";
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Location = new System.Drawing.Point(7, 77);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(29, 13);
            this.lblNick.TabIndex = 6;
            this.lblNick.Text = "Nick";
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(67, 74);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(187, 20);
            this.txtNick.TabIndex = 5;
            this.txtNick.Text = "robint91_log";
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(7, 51);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(46, 13);
            this.lblChannel.TabIndex = 4;
            this.lblChannel.Text = "Channel";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(7, 25);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(38, 13);
            this.lblServer.TabIndex = 3;
            this.lblServer.Text = "Server";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(90, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(74, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.HorizontalScrollbar = true;
            this.lstLog.Location = new System.Drawing.Point(278, 12);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(325, 329);
            this.lstLog.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 55);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LogControl";
            // 
            // Stats
            // 
            this.Stats.Controls.Add(this.label13);
            this.Stats.Controls.Add(this.label14);
            this.Stats.Controls.Add(this.label15);
            this.Stats.Controls.Add(this.label16);
            this.Stats.Controls.Add(this.lblMsgM);
            this.Stats.Controls.Add(this.lblMsg);
            this.Stats.Controls.Add(this.label7);
            this.Stats.Controls.Add(this.label2);
            this.Stats.Controls.Add(this.lblVoicedNum);
            this.Stats.Controls.Add(this.lblOpsNum);
            this.Stats.Controls.Add(this.label6);
            this.Stats.Controls.Add(this.label5);
            this.Stats.Controls.Add(this.lblmsgs);
            this.Stats.Controls.Add(this.lblUserNum);
            this.Stats.Controls.Add(this.label1);
            this.Stats.Controls.Add(this.label4);
            this.Stats.Location = new System.Drawing.Point(13, 347);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(591, 116);
            this.Stats.TabIndex = 7;
            this.Stats.TabStop = false;
            this.Stats.Text = "STATS";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(472, 45);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(114, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "0";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(471, 20);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(114, 25);
            this.label14.TabIndex = 26;
            this.label14.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(405, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 25);
            this.label15.TabIndex = 25;
            this.label15.Text = "KiB/s";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(405, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 25);
            this.label16.TabIndex = 24;
            this.label16.Text = "KiB";
            // 
            // lblMsgM
            // 
            this.lblMsgM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgM.Location = new System.Drawing.Point(314, 45);
            this.lblMsgM.Name = "lblMsgM";
            this.lblMsgM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMsgM.Size = new System.Drawing.Size(91, 25);
            this.lblMsgM.TabIndex = 23;
            this.lblMsgM.Text = "0";
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(291, 20);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMsg.Size = new System.Drawing.Size(114, 25);
            this.lblMsg.TabIndex = 22;
            this.lblMsg.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(215, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Msg/int";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Msg";
            // 
            // lblVoicedNum
            // 
            this.lblVoicedNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoicedNum.Location = new System.Drawing.Point(91, 70);
            this.lblVoicedNum.Name = "lblVoicedNum";
            this.lblVoicedNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblVoicedNum.Size = new System.Drawing.Size(118, 25);
            this.lblVoicedNum.TabIndex = 18;
            this.lblVoicedNum.Text = "0";
            // 
            // lblOpsNum
            // 
            this.lblOpsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpsNum.Location = new System.Drawing.Point(91, 45);
            this.lblOpsNum.Name = "lblOpsNum";
            this.lblOpsNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOpsNum.Size = new System.Drawing.Size(118, 25);
            this.lblOpsNum.TabIndex = 17;
            this.lblOpsNum.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Voiced";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ops";
            // 
            // lblmsgs
            // 
            this.lblmsgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsgs.Location = new System.Drawing.Point(398, -25);
            this.lblmsgs.Name = "lblmsgs";
            this.lblmsgs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblmsgs.Size = new System.Drawing.Size(165, 25);
            this.lblmsgs.TabIndex = 11;
            this.lblmsgs.Text = "0";
            // 
            // lblUserNum
            // 
            this.lblUserNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNum.Location = new System.Drawing.Point(95, 20);
            this.lblUserNum.Name = "lblUserNum";
            this.lblUserNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserNum.Size = new System.Drawing.Size(114, 25);
            this.lblUserNum.TabIndex = 9;
            this.lblUserNum.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, -25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Msg/m";
            // 
            // grpLOGCONFIG
            // 
            this.grpLOGCONFIG.Controls.Add(this.label3);
            this.grpLOGCONFIG.Controls.Add(this.txtPachubeFeed);
            this.grpLOGCONFIG.Controls.Add(this.label12);
            this.grpLOGCONFIG.Controls.Add(this.label11);
            this.grpLOGCONFIG.Controls.Add(this.txtPachubeKey);
            this.grpLOGCONFIG.Controls.Add(this.txtLogInterval);
            this.grpLOGCONFIG.Location = new System.Drawing.Point(13, 184);
            this.grpLOGCONFIG.Name = "grpLOGCONFIG";
            this.grpLOGCONFIG.Size = new System.Drawing.Size(259, 157);
            this.grpLOGCONFIG.TabIndex = 8;
            this.grpLOGCONFIG.TabStop = false;
            this.grpLOGCONFIG.Text = "LOG-CONFIG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pachube feed";
            // 
            // txtPachubeFeed
            // 
            this.txtPachubeFeed.Location = new System.Drawing.Point(89, 71);
            this.txtPachubeFeed.Name = "txtPachubeFeed";
            this.txtPachubeFeed.Size = new System.Drawing.Size(160, 20);
            this.txtPachubeFeed.TabIndex = 11;
            this.txtPachubeFeed.Text = "43697";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Pachube key";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Log Interval";
            // 
            // txtPachubeKey
            // 
            this.txtPachubeKey.Location = new System.Drawing.Point(89, 45);
            this.txtPachubeKey.Name = "txtPachubeKey";
            this.txtPachubeKey.Size = new System.Drawing.Size(160, 20);
            this.txtPachubeKey.TabIndex = 9;
            this.txtPachubeKey.Text = "ZmzBYWUdoBqlsK_34GT-HGavUx5b9L7Nk0rFCug4D1aJz0mhkUX5d9EcB4NtBGYOV8kNOLdYmSuXqMepy" +
                "uK9aOvfD7X1JERMqfTFp29Ytq0M6XMTqw837tsjIirGWikw";
            // 
            // txtLogInterval
            // 
            this.txtLogInterval.Location = new System.Drawing.Point(89, 19);
            this.txtLogInterval.Name = "txtLogInterval";
            this.txtLogInterval.Size = new System.Drawing.Size(160, 20);
            this.txtLogInterval.TabIndex = 4;
            this.txtLogInterval.Text = "15000";
            // 
            // StatsTimer
            // 
            this.StatsTimer.Interval = 1000;
            this.StatsTimer.Tick += new System.EventHandler(this.StatsTimer_Tick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 473);
            this.Controls.Add(this.grpLOGCONFIG);
            this.Controls.Add(this.Stats);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.grpIRCCONFIG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "IRC LOGGER";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseForm);
            this.Load += new System.EventHandler(this.main_Load);
            this.grpIRCCONFIG.ResumeLayout(false);
            this.grpIRCCONFIG.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.Stats.ResumeLayout(false);
            this.Stats.PerformLayout();
            this.grpLOGCONFIG.ResumeLayout(false);
            this.grpLOGCONFIG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.GroupBox grpIRCCONFIG;
        private System.Windows.Forms.Label lblNick;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox Stats;
        private System.Windows.Forms.GroupBox grpLOGCONFIG;
        private System.Windows.Forms.Label lblUserNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmsgs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer StatsTimer;
        private System.Windows.Forms.Label lblVoicedNum;
        private System.Windows.Forms.Label lblOpsNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPachubeKey;
        private System.Windows.Forms.TextBox txtLogInterval;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblMsgM;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPachubeFeed;
    }
}

