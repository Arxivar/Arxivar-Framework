using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Abletech.Arxivar.Client;

namespace ArxDev
{
    public partial class FormApplication : Form
    {
        private readonly WCFConnectorManager _manager = null;

        public FormApplication(WCFConnectorManager manager)
        {
            if (manager == null)
            {
                throw new ArgumentNullException("manager");
            }

            InitializeComponent();

            _manager = manager;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            _manager.Dispose();
            Close();
        }
    }
}
