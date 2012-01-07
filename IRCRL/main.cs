using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Meebey.SmartIrc4net;
using System.Net;
using System.Collections.Specialized;
using IRCRealtimeLogger.Properties;

namespace WindowsFormsApplication1
{
    public partial class main : Form
    {
        IrcClient _ircClient;
        Thread ListenThread;
        int nummsg = 0;
        int oldnummsg = 0;


        public main()
        {

            InitializeComponent();
            _ircClient = new IrcClient();
            _ircClient.OnError += new ErrorEventHandler(OnError);
            _ircClient.OnRawMessage += new IrcEventHandler(OnRawMessage);
            _ircClient.OnQueryMessage += new IrcEventHandler(OnQueryMessage);
            _ircClient.OnConnected += new  EventHandler(OnConnected);
            _ircClient.OnDisconnected += new EventHandler(OnDisconnected);


        }
        ~main()
        {

            _ircClient.Disconnect();
            
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();
            
            nummsg = 0;
            oldnummsg = 0;
            
            if(_ircClient.IsConnected){
                _ircClient.Disconnect();
            }
            _ircClient.SendDelay = 200;
            _ircClient.ActiveChannelSyncing = true;

            AddItemToLog("Connecting to " + txtServer.Text);
            try
            {
                _ircClient.Connect(txtServer.Text, 6667);
                grpIRCCONFIG.Enabled = false;
                grpLOGCONFIG.Enabled = false;
                StatsTimer.Interval = Convert.ToInt32(txtLogInterval.Text);
            }
            catch (ConnectionException ex)
            {
                AddItemToLog("couldn't connect! Reason: " + ex.Message);
            }

        }

        public void OnError(object sender, ErrorEventArgs e)
        {
            AddItemToLog("Error: " + e.ErrorMessage);
        }
        public void OnRawMessage(object sender, IrcEventArgs e)
        {
            AddItemToLog("Received: " + e.Data.RawMessage);
            if (e.Data.Type == ReceiveType.ChannelMessage)
            {
                nummsg = nummsg + 1;
            }
        }
        public void OnQueryMessage(object sender, IrcEventArgs e)
        {
            AddItemToLog("Received: " + e.Data.Message);
        }


        public void AddItemToLog(string text)
        {	
            if (this.lstLog.InvokeRequired)
			{	
				   Invoke(new MethodInvoker(
                   delegate { lstLog.Items.Add(text);
                   lstLog.SelectedIndex = lstLog.Items.Count - 1;
                   }
                   ));
			}
			else
			{
				this.lstLog.Items.Add(text);
			}
        }

        void OnConnected(object sender, EventArgs e)
        {
            try
            {
                _ircClient.Login(txtNick.Text, txtNick.Text, 0, txtNick.Text);
                _ircClient.RfcJoin(txtChannel.Text);
                ListenThread = new Thread(new ThreadStart(_ircClient.Listen));
                ListenThread.Start();
                StatsTimer.Start();

            }
            catch
            {
            }
        }
        void OnDisconnected(object sender, EventArgs e)
        {
            try
            {
                ListenThread.Abort();
            }
            catch
            {
            }
        }   
        private void StatsTimer_Tick(object sender, EventArgs e)
        {
            if (_ircClient.IsConnected)
            {
                if (_ircClient.JoinedChannels.Count > 0)
                {
                    lblUserNum.Text = _ircClient.GetChannel(txtChannel.Text).Users.Count.ToString();
                    lblOpsNum.Text = _ircClient.GetChannel(txtChannel.Text).Ops.Count.ToString();
                    lblVoicedNum.Text = _ircClient.GetChannel(txtChannel.Text).Voices.Count.ToString();
                    lblMsg.Text = nummsg.ToString();
                    lblMsgM.Text = (nummsg - oldnummsg).ToString();
                    oldnummsg = nummsg;
                    try
                    {
                        WebClient wc = new WebClient();
                        wc.Headers.Add("X-PachubeApiKey", txtPachubeKey.Text);
                        string data = " { " +
                                      " \"version\":\"1.0.0\", " +
                                      " \"datastreams\":[ " +
                                      "  {\"id\":\"users\", \"current_value\":\"" + lblUserNum.Text + "\"}, " +
                                      "  {\"id\":\"ops\", \"current_value\":\"" + lblOpsNum.Text + "\"}, " +
                                     "   {\"id\":\"voiced\", \"current_value\":\"" + lblVoicedNum.Text + "\"} " +
                         "]" +
                       "}";
                        wc.UploadString("http://api.pachube.com/v2/feeds/" + txtPachubeFeed.Text, "PUT", data);
                        AddItemToLog("DATA UPLOADED");
                    }
                    catch
                    {
                        AddItemToLog("ERROR WHILE UPLOAD!");
                    }
                }
            }
        }
        private void CloseForm(object sender, EventArgs e)
        {
            try
            {
                ListenThread.Abort();
                _ircClient.RfcQuit("Bye");
            }
            catch
            {
            }
            Settings.Default.IrcServer = txtServer.Text;
            Settings.Default.Channel = txtChannel.Text;
            Settings.Default.Nick = txtNick.Text;
            Settings.Default.PachubeKey = txtPachubeKey.Text;
            Settings.Default.PachubeFeed = txtPachubeFeed.Text;
            Dispose();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                _ircClient.RfcQuit("Bye");
                _ircClient.Disconnect();
                grpIRCCONFIG.Enabled = true;
                grpLOGCONFIG.Enabled = true;
            }
            catch
            {
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            txtServer.Text =  Settings.Default.IrcServer;
            txtChannel.Text = Settings.Default.Channel;
            txtNick.Text = Settings.Default.Nick;
            txtPachubeKey.Text = Settings.Default.PachubeKey;
            txtPachubeFeed.Text = Settings.Default.PachubeFeed;

        }

    }
}
