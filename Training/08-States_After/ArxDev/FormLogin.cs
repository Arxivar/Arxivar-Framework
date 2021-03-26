using System;
using System.Windows.Forms;
using Abletech.Arxivar.Client;
using Abletech.Arxivar.Entities;
using Abletech.Arxivar.Entities.Enums;

namespace ArxDev
{
    public partial class FormLogin : Form
    {

        // Preambolo

        public FormLogin()
        {
            InitializeComponent();
        }

        private delegate void SafeCallDelegate(string text);

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
        // Fine preambolo


        //Parametri della macchina di Arxivar Next (ClientID, ClientSecret, Host del Wcf e Porta del WCF)
        private const string AppName = "clientIdTest"; //clientID
        private const string AppSecret = "B2521AABA4EB4B88"; //ClientSecret
        private const string WcfHost = "VM05-NextCorso"; //nome della macchina in cui è installato il WCF Arxivar Next
        private const string WcfPort = "8740"; //porta del WCF di Arxivar Next

        //Mi creo l'ogetto che farà da "ponte" verso il WCF: _manager
        private WCFConnectorManager _manager = null;



        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //1) Creazione dell'URI del WCF di Arxivar Next
                var wcfUrl = string.Format("net.tcp://{0}:{1}/Arxivar/Push", WcfHost, WcfPort);

                //2) Mi creo l'oggetto del logon al WCF di Arxivar Next
                var logonRequest = new ArxLogonRequest
                {
                    ClientId = AppName, //ci mettiamo il ClientID
                    ClientSecret = AppSecret, //ci mettiamo il ClientSecret
                    EnablePushEvents = true, //con EnablePushEvent a true, resto in "ascolto" di eventi dal WCF
                    Username = textBoxUsername.Text, //username dell'utente in Arxivar Next
                    Password = textBoxPassword.Text //password dell'utente in Arxivar Next
                };

                //3) Istanzio l'oggetto "_manager"
                _manager = new WCFConnectorManager(wcfUrl, logonRequest)
                {
                    AutoChunk = true,      //Vogliamo l'auto-chunck automatico? Se sì, impostiamo a true
                    AutoReconnect = true,  //Vogliamo che il nosto connettore-custom verso Arxivar Next si riconnetta, in caso di problemi? Se sì, impostiamo a true
                    Lang = "EN"
                };

                //4) Con "channelOpening" e "channelOpened", resto in ascolto degli eventi sul canale
                _manager.ChannelOpening += _manager_ChannelOpening;
                _manager.ChannelOpened += _manager_ChannelOpened;

                try
                {
                    //5) Proviamo a fare logon ad Arxivar Next
                    ArxLogOnResult logonResult = _manager.Logon();

                    //6) Il logon ad Arxivar Next, è andato bene senza errori?
                    if (logonResult.LogOnError == ArxLogOnErrorType.None)
                    {
                        //6A) OK, logon effettuato correttamente!
                        MessageBox.Show("Login Ok!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        WriteTextSafe("Login ok al WCF di Arxivar Next");
                        //6B) Nascondiamo il login e lanciamo la finestra principale
                        Hide();
                        using (var fApp = new FormApplication(_manager))
                        {
                            fApp.ShowDialog();
                        }
                        Close();
                    }
                    else
                    {
                        //6B) KO, logon fallito per qualche motivo...
                        MessageBox.Show("Login fallito: " + logonResult.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        WriteTextSafe("Login fallito al WCF di Arxivar Next");
                    }
                }
                finally
                {
                    //Restiamo in ascolto degli eventi...
                    _manager.ChannelOpening -= _manager_ChannelOpening;
                    _manager.ChannelOpened -= _manager_ChannelOpened;
                }
            }
            catch (Exception exception)
            {
                //Qualcosa, prima di effettuare login è andato male
                MessageBox.Show(exception.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
