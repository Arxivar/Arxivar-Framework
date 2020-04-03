using System;
using System.Windows.Forms;
using Abletech.Arxivar.Client;
using Abletech.Arxivar.Entities;
using Abletech.Arxivar.Entities.Enums;

namespace ArxDev
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private const string AppName = "NEXTDEV";
        private const string AppSecret = "9D31F802ECD642C0";

        private const string WcfHost = "localhost";
        private const string WcfPort = "8740";
        private WCFConnectorManager _manager = null;

        private delegate void SafeCallDelegate(string text);

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var wcfUrl = string.Format("net.tcp://{0}:{1}/Arxivar/Push", WcfHost, WcfPort);

                var logonRequest = new ArxLogonRequest
                {
                    ClientId = AppName,
                    ClientSecret = AppSecret,
                    EnablePushEvents = true,
                    Username = textBoxUsername.Text,
                    Password = textBoxPassword.Text
                };

                _manager = new WCFConnectorManager(wcfUrl, logonRequest)
                {
                    AutoChunk = true,      //default a true
                    AutoReconnect = true,  //default a true
                    Lang = "EN"
                };

                _manager.ChannelOpening += _manager_ChannelOpening;
                _manager.ChannelOpened += _manager_ChannelOpened;

                try
                {
                    Cursor = Cursors.WaitCursor;

                    ArxLogOnResult logonResult = _manager.Logon();

                    if (logonResult.LogOnError == ArxLogOnErrorType.None)
                    {
                        MessageBox.Show("Login Ok!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        WriteTextSafe("Login Ok");
                    }
                    else
                    {
                        MessageBox.Show("Login error: " + logonResult.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                finally
                {
                    Cursor = Cursors.Default;

                    _manager.ChannelOpening -= _manager_ChannelOpening;
                    _manager.ChannelOpened -= _manager_ChannelOpened;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Login", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void _manager_ChannelOpened(string message)
        {
            WriteTextSafe(message);
        }

        private void _manager_ChannelOpening(string message)
        {
            WriteTextSafe(message);
        }

        private void WriteTextSafe(string text)
        {
            if (strip.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                Invoke(d, new object[] { text });
            }
            else
            {
                strip.Items[0].Text = text;
            }
        }
    }
}
