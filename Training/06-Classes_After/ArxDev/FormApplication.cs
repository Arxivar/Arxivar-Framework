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

            //Disabilitiamo il primo tabPage (quello dedicato delle AOO)
            ((Control)this.tabPageAoo).Enabled = false;
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
                Cursor = Cursors.WaitCursor;

                dgAoo.DataSource = _manager.ARX_DATI.Dm_Aoo_GetData(Dm_Aoo_Mode.Search, "CODICE");
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
                Cursor = Cursors.WaitCursor;

                dgAoo.DataSource = _manager.ARX_DATI.Dm_Aoo_GetData(Dm_Aoo_Mode.Archive, "CODICE");
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
                Cursor = Cursors.WaitCursor;

                dgAoo.DataSource = _manager.ARX_DATI.Dm_Aoo_GetData(Dm_Aoo_Mode.ArchivePa, "CODICE");
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

        #region Classes

        private void buttonClassesForArchive_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                //Mi carico le classi delle AOO di Arxivar Next, ordinate per SYSTEM_ID
                dgClasses.DataSource = _manager. ...qualeServizio.... ...qualeMetodo (
                    ...qualeEnumerativo...,
                    ...qualeCampo...);
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

        private void buttonClassesForSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                //Mi carico le classi delle AOO di Arxivar Next, ordinate per SYSTEM_ID
                dgClasses.DataSource = _manager. ...qualeServizio.... ...qualeMetodo(
                    ...qualeEnumerativo...,
                    ...qualeCampo...);
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

        private void buttonClassesForEditProfile_Click(object sender, EventArgs e)
        {

            try
            {
                Cursor = Cursors.WaitCursor;
                //Mi carico le classi delle AOO di Arxivar Next, ordinate per SYSTEM_ID
                dgClasses.DataSource = _manager. ...qualeServizio.... ...qualeMetodo(
                    ...qualeEnumerativo...,
                    ...qualeCampo...);
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

		private void buttonInfoClasse_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                //1) Anlizzo una classe documentale, indicando il codice della classe documentale
                var documenttype = _manager. ...qualeServizio... . ...qualeMetodo...(textBoxCodiceClasse.Text);
                //2) Visualizzo a video alcune informazioni
                MessageBox.Show("Alcune informazioni di massima della variabili \"documenttype\"\n" +
                    "CODICE: " + documenttype.CODICE + "\n" +
                    "DESCRIZIONE: " + documenttype.DESCRIPTION);
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
