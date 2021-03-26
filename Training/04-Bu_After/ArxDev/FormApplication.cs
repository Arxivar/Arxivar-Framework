using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Abletech.Arxivar.Client;
using Abletech.Arxivar.Entities.Enums;

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
        
        #region Aoo

        private void buttonAooForSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //Mi faccio ritornare la lista delle AOO di tipo "Search", ordino per il campo "CODICE" e popolo il DataGridView
                Cursor = Cursors.WaitCursor;
                dgAoo.DataSource = _manager. ... . ...(..., "CODICE");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void buttonAooForArchive_Click(object sender, EventArgs e)
        {
            try
            {
                //Mi faccio ritornare la lista delle AOO di tipo "Archivie", ordino per il campo "CODICE" e popolo il DataGridView
                Cursor = Cursors.WaitCursor;
                dgAoo.DataSource = _manager. ... . ...(..., "CODICE");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void buttonAooForArchivePa_Click(object sender, EventArgs e)
        {
            try
            {
                //Mi faccio ritornare la lista delle AOO di tipo "ArchiviePA", ordino per il campo "CODICE" e popolo il DataGridView
                Cursor = Cursors.WaitCursor;
                dgAoo.DataSource = _manager. ... . ...(..., "CODICE");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            
        }

        #endregion Aoo
    }
}
