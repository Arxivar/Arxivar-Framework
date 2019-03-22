using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Abletech.Arxivar.Client;
using Abletech.Arxivar.Entities;
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

                dgClasses.DataSource = _manager.ARX_DATI.Dm_TipiDocumento_GetData(
                    Dm_TipiDocumento_Mode.Archivia,
                    "SYSTEM_ID");
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

                dgClasses.DataSource = _manager.ARX_DATI.Dm_TipiDocumento_GetData(
                    Dm_TipiDocumento_Mode.Ricerca,
                    "SYSTEM_ID");
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

                dgClasses.DataSource = _manager.ARX_DATI.Dm_TipiDocumento_GetData(
                    Dm_TipiDocumento_Mode.ModificaProfilo,
                    "SYSTEM_ID");
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

        #region States

        private void buttonStates_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                dgStates.DataSource = _manager.ARX_DATI.Dm_Tabelle_Stato_GetData("TRANSLATEDESCRIPTION");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void buttonStatesByClass_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var allStates = _manager.ARX_DATI.Dm_Tabelle_Stato_GetData("TRANSLATEDESCRIPTION");

                var cls = _manager.ARX_DATI.Dm_TipiDocumento_GetDataByCodice(textBoxClassCode.Text);
                if (cls == null)
                {
                    throw new Exception("Class not found: " + textBoxClassCode.Text);
                }

                Dm_TipiDocumento_Stati[] statesCanSetList = _manager.ARX_DATI.Dm_TipiDocumentoStati_GetData_By_DmTipiDocumentoSystemId(cls.SYSTEM_ID, null);

                var filteredClasses = new List<Dm_Tabelle>();
                foreach (Dm_Tabelle dmTabelle in allStates)
                {
                    if (statesCanSetList.Any(x => x.CODICESTATO == dmTabelle.VALORE))
                    {
                        filteredClasses.Add(dmTabelle);
                    }
                }
                dgStates.DataSource = filteredClasses;
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

        #endregion States
    }
}
