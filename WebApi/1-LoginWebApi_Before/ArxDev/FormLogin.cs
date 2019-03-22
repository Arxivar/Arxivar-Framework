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
        private const string ApiUrl = "http://localhost/ARXivarNextWebApi/";

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
               

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Login", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
