using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IO.Swagger.Model;

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
        private const string ApiUrl = "http://127.0.0.1:82/";

        private string _authToken;
        private string _refreshToken;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Inizialize Authentication api (Authentication api not require authentication token)
                var authApi = new IO.Swagger.Api.AuthenticationApi(ApiUrl);
                //Login to obtain a valid token (and a refresh token)
                var reqdto = new AuthenticationTokenRequestDTO(
                    textBoxUsername.Text,  // Username
                    textBoxPassword.Text, // Password
                    AppName, // Application name
                    AppSecret); // Application secret
                AuthenticationTokenDTO resultToken = authApi.AuthenticationGetToken(reqdto);

                _authToken = resultToken.AccessToken;
                _refreshToken = resultToken.RefreshToken;

                MessageBox.Show("Succes login!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Login", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
