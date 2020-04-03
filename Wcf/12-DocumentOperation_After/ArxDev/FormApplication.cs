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
using Abletech.Arxivar.Entities.Exceptions;
using Abletech.Arxivar.Entities.Libraries;
using Abletech.Arxivar.Entities.Search;

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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                var statesCanSetList = _manager.ARX_DATI.Dm_TipiDocumentoStati_GetData_By_DmTipiDocumentoSystemId(cls.SYSTEM_ID, null);

                var filteredClasses = new List<Dm_Tabelle>();
                foreach (var state in allStates)
                {
                    if (statesCanSetList.Any(x => x.CODICESTATO == state.VALORE))
                    {
                        filteredClasses.Add(state);
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

        private void buttonArchive_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                Dm_Profile_ForInsert insert = _manager.ARX_DATI.Dm_Profile_ForInsert_Get_New_Instance_ByDocumentTypeCodice("TEST.DEV");
                insert.Aoo = "DEMO";
                insert.DocName = "My C# Application";
                insert.InOut = DmProfileInOut.Interno;
                insert.Stato = "VALID";
                insert.DataDoc = DateTime.Now.Date; // new DateTime(2018,04,30);
                //insert.ProtocolloInterno = "AR\\0019";
                //insert.AssocDoc.IDERP = "989";


                // Mi - De - Cc
                insert.From = GetDatiProfilo("ABLETECH", Dm_DatiProfilo_Campo.MI);
                insert.To.Add(GetDatiProfilo("MAURO BIAGGIO", Dm_DatiProfilo_Campo.DE));
                insert.To.Add(GetDatiProfilo("GIULIANO ROVERSI", Dm_DatiProfilo_Campo.DE));
                insert.To.Add(GetDatiProfilo("YARI MELZANI", Dm_DatiProfilo_Campo.DE));

                //-----------------------------------------
                // Aggiuntivi -----------------------------
                //-----------------------------------------

                //Campo data acquisto
                Aggiuntivo_String aggTarga = insert.Aggiuntivi.FirstOrDefault(
                    x => string.Equals(x.ExternalId, "TARGA", StringComparison.CurrentCultureIgnoreCase)) as Aggiuntivo_String;
                if (aggTarga == null)
                {
                    throw new Exception("External id 'TARGA' not found");
                }
                aggTarga.Valore = "ZR009IU"; //DEMO VALUE

                // Campo data
                Aggiuntivo_DateTime agData = insert.Aggiuntivi.FirstOrDefault(
                    x => string.Equals(x.ExternalId, "DATAA", StringComparison.CurrentCultureIgnoreCase)) as Aggiuntivo_DateTime;
                if (agData == null)
                {
                    throw new Exception("External id 'DATAA' not found");
                }
                agData.Valore = new DateTime(2016, 5, 5);

                // Campo importo
                Aggiuntivo_Double agImporto = insert.Aggiuntivi.FirstOrDefault(
                    x => string.Equals(x.ExternalId, "IMPORTO", StringComparison.CurrentCultureIgnoreCase)) as Aggiuntivo_Double;
                if (agImporto == null)
                {
                    throw new Exception("External id 'IMPORTO' not found");
                }
                agImporto.Valore = 1200;

                // Campo finanziamento
                Aggiuntivo_Bool agFinanziamento = insert.Aggiuntivi.FirstOrDefault(
                x => string.Equals(x.ExternalId, "CONFINANZIAMENTO", StringComparison.CurrentCultureIgnoreCase)) as Aggiuntivo_Bool;
                if (agFinanziamento == null)
                {
                    throw new Exception("External id 'CONFINANZIAMENTO' not found");
                }
                agFinanziamento.Valore = true;

                // Campo agente (Nell'esempio è un campo combo con LimitToList -> Il valore indicato DEVE esistere)
                Aggiuntivo_String aggAgente = insert.Aggiuntivi.FirstOrDefault(
                    x => string.Equals(x.ExternalId, "COD_AGENTE", StringComparison.CurrentCultureIgnoreCase)) as Aggiuntivo_String;
                if (aggAgente == null)
                {
                    throw new Exception("External id 'COD_AGENTE' not found");
                }
                aggAgente.Valore = "AG_002";

                // Campo Tags
                Aggiuntivo_MultiValue aggTags = insert.Aggiuntivi.FirstOrDefault(
                   x => string.Equals(x.ExternalId, "TAGS", StringComparison.CurrentCultureIgnoreCase)) as Aggiuntivo_MultiValue;
                if (aggTags == null)
                {
                    throw new Exception("External id 'TAGS' not found");
                }
                aggTags.Values = new EntitiesCollection<string> { "C#", "DEV", "CORSO" };


                //File del profilo
                insert.File = new Arx_File(@"C:\Temp\test.txt");
                var dmProfileResult = _manager.ARX_DATI.Dm_Profile_Insert(insert);

                /* E se volessimo fare un'achiviazione per il ciclo passivo ?
                   è sufficiente eseguire 
                        Dm_Profile_Insert_For_Barcode 
                   al posto di 
                        Dm_Profile_Insert
                   il parametro barcode è opzione, se non viene indicato ARXivar utilizza le sue regole per creare un codice barcode
                */

                //var dmProfileResult = _manager.ARX_DATI.Dm_Profile_Insert_For_Barcode(insert, "");

                if (dmProfileResult.EXCEPTION != Security_Exception.Nothing)
                {
                    MessageBox.Show(
                        dmProfileResult.MESSAGE,
                        "Store",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(
                        "Store Ok. SystemId: " + dmProfileResult.PROFILE.DOCNUMBER,
                        "Store",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private int? CercaInRubrica(string ragioneSociale)
        {
            using (var select = new Dm_Contatti_Select())
            {
                using (var search = new Dm_Contatti_Search())
                {
                    select.DM_RUBRICA_RAGIONE_SOCIALE.Selected = true;
                    select.DM_RUBRICA_SYSTEM_ID.Selected = true;
                    select.CONTATTO.Selected = true;
                    select.ID.Selected = true;

                    search.Dm_Rubrica.RAGIONE_SOCIALE.SetFilter(Dm_Base_Search_Operatore_String.Uguale, ragioneSociale);
                    search.Dm_Rubrica.RAGIONE_SOCIALE.forceCaseInsensitive = true;

                    search.CONTATTO.SetFilter(Dm_Base_Search_Operatore_String.Nullo_o_Vuoto, "");

                    using (var ds = _manager.ARX_SEARCH.Dm_Contatti_GetData(search, select))
                    {
                        var dt = ds.GetDataTable(0);

                        if (dt.Rows.Count == 0)
                        {
                            return null;
                        }

                        var resultId = System.Convert.ToInt32(dt.Rows[0]["ID"]);
                        //var resultId = System.Convert.ToInt32(dt.Rows[0]["DM_RUBRICA_SYSTEM_ID"]);
                        return resultId;
                    }
                }
            }
        }

        private Dm_DatiProfilo GetDatiProfilo(string ragSoc, Dm_DatiProfilo_Campo tipoCampo)
        {
            var idContatto = CercaInRubrica(ragSoc);

            if (idContatto != null)
            {
                return _manager.ARX_DATI.Dm_DatiProfilo_GetNewInstance_From_IdContatto(idContatto.Value, tipoCampo);
            }

            return new Dm_DatiProfilo
            {
                VALORE = ragSoc,
                CONTATTI = ragSoc,
                CAMPO = tipoCampo
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                // Recupero il profilo da modificare
                Dm_Profile_ForUpdate profile = _manager.ARX_DATI.Dm_Profile_ForUpdate_GetNewInstance(920);

                profile.DocName = "Subject edited from C# application";

                //.... campi agg...


                var profileResult = _manager.ARX_DATI.Dm_Profile_Update(profile, string.Empty);
                if (profileResult.EXCEPTION != Security_Exception.Nothing)
                {
                    throw new Exception(string.Format("Error: {0}", profileResult.MESSAGE));
                }
                MessageBox.Show("Edit success!", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void buttonOpenDocument_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var arxFile = _manager.ARX_DOCUMENTI.Dm_Profile_GetDocument(System.Convert.ToInt32(textBoxOpenDocument.Text));

                var folder = System.IO.Path.GetTempPath();
                var fileName = Guid.NewGuid().ToString("N").Substring(1, 6) + "_" + arxFile.FileName;
                arxFile.SaveTo(folder, fileName);

                System.Diagnostics.Process.Start(System.IO.Path.Combine(folder, fileName));
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

        private void buttonEditFile_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var filePath = @"C:\Temp\test2.txt";

                ArxGenericException age;
                var esito = _manager.ARX_DOCUMENTI.Dm_Profile_SetDocument_Advanced(
                    out age,
                    new Arx_File(filePath),
                    System.Convert.ToInt32(textBoxEditDocument.Text),
                    string.Empty);

                if (esito)
                {
                    MessageBox.Show("Edit Ok!", "Edit document", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    age.RaiseGenericException();
                }
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

        private void buttonOverwriteFile_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                var filePath = @"C:\Temp\Image.jpg";

                ArxGenericException age;
                var esito = _manager.ARX_DOCUMENTI.Dm_Profile_SetDocument_With_Option_Advanced(
                    out age,
                    new Arx_File(filePath),
                    System.Convert.ToInt32(textBoxOverWrite.Text),
                    string.Empty, 
                    Dm_Profile_Set_Document_State_Option.ForceOverWrite);

                if (esito)
                {
                    MessageBox.Show("Edit file Ok", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    age.RaiseGenericException();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void buttonDeleteDocument_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                var docDeleteId = System.Convert.ToInt32(textBoxDelete.Text);
                ArxGenericException canDelete = _manager.ARX_SECURITY.Dm_Profile_Can_Delete_Advanced(docDeleteId);
                if (canDelete.Exception != Security_Exception.Nothing)
                {
                    MessageBox.Show(canDelete.ErrorMessage, "Delete document", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                _manager.ARX_DATI.Dm_Profile_Delete(docDeleteId);
                MessageBox.Show("Delete Ok!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        
    }
}
