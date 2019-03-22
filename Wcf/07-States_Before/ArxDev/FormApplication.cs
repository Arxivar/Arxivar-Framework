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

        private void tabPageAoo_Click(object sender, EventArgs e)
        {

        }

        #region Aoo

        private void buttonAooForSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                dgAoo.DataSource = _manager.ARX_DATI.Dm_Aoo_GetData(Dm_Aoo_Mode.Search, "CODICE");
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
                Cursor = Cursors.WaitCursor;

                dgAoo.DataSource = _manager.ARX_DATI.Dm_Aoo_GetData(Dm_Aoo_Mode.Archive, "CODICE");
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
                Cursor = Cursors.WaitCursor;

                dgAoo.DataSource = _manager.ARX_DATI.Dm_Aoo_GetData(Dm_Aoo_Mode.ArchivePa, "CODICE");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            
        }

        #endregion Aoo

        #region Classes

        private void buttonClassesForArchive_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                dgClasses.DataSource = _manager.ARX_DATI.Dm_TipiDocumento_GetData(
                    Dm_TipiDocumento_Mode.Archivia,
                    "SYSTEM_ID");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void buttonClassesForSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                dgClasses.DataSource = _manager.ARX_DATI.Dm_TipiDocumento_GetData(
                    Dm_TipiDocumento_Mode.Ricerca,
                    "SYSTEM_ID");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void buttonClassesForEditProfile_Click(object sender, EventArgs e)
        {

            try
            {
                Cursor = Cursors.WaitCursor;

                dgClasses.DataSource = _manager.ARX_DATI.Dm_TipiDocumento_GetData(
                    Dm_TipiDocumento_Mode.ModificaProfilo,
                    "SYSTEM_ID");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void buttonInfoClasse_Click(object sender, EventArgs e)
        {
			Cursor = Cursors.WaitCursor;
            try
            {
                var documenttype = _manager.ARX_DATI.Dm_TipiDocumento_GetDataByCodice(textBoxCodiceClasse.Text);
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

        #endregion Classes


    }
}
