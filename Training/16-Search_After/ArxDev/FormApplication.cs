﻿using System;
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

using Microsoft.VisualBasic;

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

            ((Control)this.tabPageAoo).Enabled = false;
            ((Control)this.tabPageClasses).Enabled = false;
            ((Control)this.tabPageStates).Enabled = false;
            ((Control)this.tabPageStore).Enabled = false;
            ((Control)this.tabPageDocumentOperation).Enabled = false;
            ((Control)this.tabPageContacts).Enabled = false;
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
                agData.Valore = DateTime.Now.Date;

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
                    // Recuperaro il fascicolo Dev1
                    int idFolder = 0;

                    using (var folderSelect = new Dm_Fascicoli_Select())
                    using (var folderSearch = new Dm_Fascicoli_Search())
                    {
                        folderSelect.ID.Selected = true;

                        folderSearch.NOME.SetFilter(Dm_Base_Search_Operatore_String.Uguale, "DEV2");
                        folderSearch.NOME.forceCaseInsensitive = true;

                        using (var dsFolder = _manager.ARX_SEARCH.Dm_Fascicoli_GetData(folderSearch, folderSelect))
                        {
                            var dtFolder = dsFolder.GetDataTable(0);
                            if (dtFolder.Rows.Count ==0)
                            {
                                throw new Exception("Non ho trovato il fascicolo DEV2");
                            }

                            idFolder = System.Convert.ToInt32(dtFolder.Rows[0]["ID"]);
                        }
                    }

                    // Inserisco il documento nel fascicolo
                    _manager.ARX_DATI.Dm_FileInFolder_Insert(idFolder, dmProfileResult.PROFILE.DOCNUMBER);

                    
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
                Dm_Profile_ForUpdate profile = _manager.ARX_DATI.Dm_Profile_ForUpdate_GetNewInstance(19);

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
                    string.Empty, Dm_Profile_Set_Document_State_Option.ForceOverWrite);

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

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                dgContacts.DataSource = _manager.ARX_DATI.Dm_CatRubriche_Get_Data("RUBRICA");
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

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                var catRubricheList = _manager.ARX_DATI.Dm_CatRubriche_Get_Data("");
                var generale = catRubricheList.First(x => string.Equals(x.RUBRICA, "GENERALE", StringComparison.CurrentCultureIgnoreCase));

                var insert = new Dm_Rubrica_ForInsert
                {
                    CATEGORIA = generale.ID,
                    RAGIONE_SOCIALE = "NEW ELEMENT",
                    MAIL = "info@newelement.it",
                    INDIRIZZO = "via XX Settembre",
                    TEL = "0009900990996"
                };

                var contact1 = new Dm_Contatti_ForInsert
                {
                    CONTATTO = "helpdesk",
                    EMAIL = "helpdesk@newelement.it"
                };
                insert.Contatti.Add(contact1);

                var contact2 = new Dm_Contatti_ForInsert
                {
                    CONTATTO = "backoffice",
                    EMAIL = "backoffice@newelement.it"
                };
                insert.Contatti.Add(contact2);

                var result = _manager.ARX_DATI.Dm_Rubrica_Insert(insert);

                textBoxEditContact.Text = result.SYSTEM_ID.ToString();

                MessageBox.Show("Insert with id: " + result.SYSTEM_ID, "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void buttonEditContact_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                var update = _manager.ARX_DATI.Dm_Rubrica_ForUpdate_GetNewInstance_By_SystemId(System.Convert.ToInt32(textBoxEditContact.Text));
                update.CELL = "3491111110";

                _manager.ARX_DATI.Dm_Rubrica_Update(update);

                MessageBox.Show("Update Ok", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonSearchProfile_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                using (var profileSelect = new ...())
                using (var profileSearch = new ...())
                {

                    //Prendiamo 30 righe al massimo
                    profileSelect.MaxRowCount = 30;

                    //Prendiamo il campo DOCNUMBER e diciamo:
                    //1) Mostriamolo in output
                    //2) Nella lista sarà l'elemento di posizione "0"
                    //3) Inidichiamo che l'elemento è il primo da ordinare
                    //4) Indichiamo che l'elemento sia ordinato in modo ascendente
                    profileSelect.DOCNUMBER. ... = true;
                    profileSelect.DOCNUMBER. ... = 0;
                    profileSelect.DOCNUMBER. ... . ...  = 0;
                    profileSelect.DOCNUMBER. ... . ....= EOrderByDirection.Ascending;

                    //Prendiamo il campo DOCNAME e diciamo:
                    //1) Mostriamolo in output
                    //2) Nella lista sarà l'elemento di posizione "1"
                    //3) Inidichiamo che l'elemento è il secondo da ordinare
                    //4) Indichiamo che l'elemento sia ordinato in modo ascendente
                    profileSelect.DOCNAME.... = true;
                    profileSelect.DOCNAME.... = 1;
                    profileSelect.DOCNAME..... . .. = 1;
                    profileSelect.DOCNAME.... . ... = EOrderByDirection.Descending;

                    //Prendiamo il campo ORIGINALE e diciamo:
                    //1) Mostriamolo in output
                    //2) Nella lista sarà l'elemento di posizione "2"
                    profileSelect.ORIGINALE.Selected = true;
                    profileSelect.ORIGINALE.Index = 2;

                    //Chiediamo all'utente quale parola deve ricercare
                    String parolaDaRicercare = Interaction.InputBox("Quale parola devi trovare nel campo \"OGGETTO\"?", "Ricerche con WCF", "Immetti un valore");
                    profileSearch.DocName.SetFilter(Dm_Base_Search_Operatore_String. ..., parolaDaRicercare);
                    
                    //Esecuzione della ricerca, mostrando il risultato nella DataGridLayout
                    using (var ds = _manager. ... . ...(profileSearch, profileSelect, 0))
                    {
                        dgSearch.DataSource = ds.GetDataTable(0);
                    }
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

        private void buttonSearchTask_Click(object sender, EventArgs e)
        {
            try
            {
                using (var profileSelect = _manager. ... . ...("GENERIC"))
                using (var profileSearch = _manager. ... . ...("GENERIC"))
                {

                    //Prendiamo 30 righe al massimo
                    profileSelect.MaxRowCount = 30;

                    //Prendiamo il campo DOCNUMBER e diciamo:
                    //1) Mostriamolo in output
                    //2) Nella lista sarà l'elemento di posizione "0"
                    //3) Inidichiamo che l'elemento è il primo da ordinare
                    //4) Indichiamo che l'elemento sia ordinato in modo ascendente
                    profileSelect.DOCNUMBER.Selected = true;
                    profileSelect.DOCNUMBER.Index = 0;
                    profileSelect.DOCNUMBER.OrderBy.Index = 0;
                    profileSelect.DOCNUMBER.OrderBy.Direction = EOrderByDirection.Ascending;

                    //Prendiamo il campo DOCNAME e diciamo:
                    //1) Mostriamolo in output
                    //2) Nella lista sarà l'elemento di posizione "1"
                    //3) Inidichiamo che l'elemento è il secondo da ordinare
                    //4) Indichiamo che l'elemento sia ordinato in modo ascendente
                    profileSelect.DOCNAME.Selected = true;
                    profileSelect.DOCNAME.Index = 1;
                    profileSelect.DOCNAME.OrderBy.Index = 1;
                    profileSelect.DOCNAME.OrderBy.Direction = EOrderByDirection.Descending;

                    //Prendiamo il campo ORIGINALE e diciamo:
                    //1) Mostriamolo in output
                    //2) Nella lista sarà l'elemento di posizione "2"
                    profileSelect.ORIGINALE.Selected = true;
                    profileSelect.ORIGINALE.Index = 2;

                    //Gestiamo i campi aggiuntivi
                    foreach(Aggiuntivo_Selected campoAggiuntivo in profileSelect.Aggiuntivi)
                    {
                        if(campoAggiuntivo. ... . ...("StringaProtocollo") == true)
                        {
                            campoAggiuntivo. ...  = true;
                            campoAggiuntivo. ...  = 3;
                            campoAggiuntivo. ... . ... = 3;
                            campoAggiuntivo. ... . ... = EOrderByDirection. ...;
                        }
                    }

                    //Chiediamo all'utente quale "StringaProtocollo" deve ricercare
                    String stringaProtocolloScelta = Interaction.InputBox("Quale StringaProtocollo cerchi?", "Ricerche con WCF", "Immetti un valore");

                    //Cerco il campo aggiuntivo "StringProtocollo" e, se lo trovo, cerco quei profili che contengono la parola StringaProtocolloScelta
                    Field_String campoAggiuntivoProtocolloScelta = 
                        profileSearch.Aggiuntivi.FirstOrDefault(
                            x => String.Equals(x.... , ..., StringComparison.CurrentCultureIgnoreCase)) as Field_String;
                    //Ma questo campo aggiuntivo esiste?
                    if(campoAggiuntivoProtocolloScelta == null)
                    {
                        throw new Exception("Campo \'StringProtocollo\' non trovato!");
                    }
                    else
                    {
                        campoAggiuntivoProtocolloScelta. ... (
                            Dm_Base_Search_Operatore_String. ..., 
                            stringaProtocolloScelta);
                    }

                    //Esecuzione della ricerca, mostrando il risultato nella DataGridLayout
                    using (var ds = _manager.ARX_SEARCH.Dm_Profile_GetData(profileSearch, profileSelect, 0))
                    {
                        dgSearch.DataSource = ds.GetDataTable(0);
                    }
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

        private void buttonSearchProfile2_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                using (var profileSelect = new Dm_Profile_Select())
                using (var profileSearch = new Dm_Profile_Search())
                {

                    //Prendiamo 30 righe al massimo
                    profileSelect.MaxRowCount = 30;

                    //Prendiamo il campo DOCNUMBER e diciamo:
                    //1) Mostriamolo in output
                    //2) Nella lista sarà l'elemento di posizione "0"
                    //3) Inidichiamo che l'elemento è il primo da ordinare
                    //4) Indichiamo che l'elemento sia ordinato in modo ascendente
                    profileSelect.DOCNUMBER. ...  = true;
                    profileSelect.DOCNUMBER. ...  = 0;
                    profileSelect.DOCNUMBER. ... . ... = 0;
                    profileSelect.DOCNUMBER. ... . ... = EOrderByDirection.Ascending;

                    //Prendiamo il campo DOCNAME e diciamo:
                    //1) Mostriamolo in output
                    //2) Nella lista sarà l'elemento di posizione "1"
                    //3) Inidichiamo che l'elemento è il secondo da ordinare
                    //4) Indichiamo che l'elemento sia ordinato in modo ascendente
                    profileSelect.DOCNAME. ... = true;
                    profileSelect.DOCNAME. ...  = 1;
                    profileSelect.DOCNAME. ... . ... = 1;
                    profileSelect.DOCNAME. ... . ... = EOrderByDirection.Descending;

                    //Prendiamo il campo ORIGINALE e diciamo:
                    //1) Mostriamolo in output
                    //2) Nella lista sarà l'elemento di posizione "2"
                    profileSelect.ORIGINALE. ...  = true;
                    profileSelect.ORIGINALE. ... = 2;

                    //Chiediamo all'utente quale parola deve ricercare
                    int docNumberScelto = (Int32.Parse(Interaction.InputBox("Quale DOCNUMBER cerchi?", "Ricerche con WCF", "Immetti un valore")));
                    profileSearch. ... . ...(... . ..., docNumberScelto);

                    //Esecuzione della ricerca, mostrando il risultato nella DataGridLayout
                    using (var ds = _manager. ... . ...(profileSearch, profileSelect, 0))
                    {
                        dgSearch.DataSource = ds.GetDataTable(0);
                    }
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

        private void buttonSearchFolder_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                using (var profileSelect = _manager. ... . ... ("GENERIC"))
                using (var profileSearch = _manager. ... . ....("GENERIC"))
                {

                    //Prendiamo 30 righe al massimo
                    profileSelect.MaxRowCount = 30;

                    //Prendiamo il campo DOCNUMBER e diciamo:
                    //1) Mostriamolo in output
                    //2) Nella lista sarà l'elemento di posizione "0"
                    //3) Inidichiamo che l'elemento è il primo da ordinare
                    //4) Indichiamo che l'elemento sia ordinato in modo ascendente
                    profileSelect.DOCNUMBER.Selected = true;
                    profileSelect.DOCNUMBER.Index = 0;
                    profileSelect.DOCNUMBER.OrderBy.Index = 0;
                    profileSelect.DOCNUMBER.OrderBy.Direction = EOrderByDirection.Ascending;

                    //Prendiamo il campo DOCNAME e diciamo:
                    //1) Mostriamolo in output
                    //2) Nella lista sarà l'elemento di posizione "1"
                    //3) Inidichiamo che l'elemento è il secondo da ordinare
                    //4) Indichiamo che l'elemento sia ordinato in modo ascendente
                    profileSelect.DOCNAME.Selected = true;
                    profileSelect.DOCNAME.Index = 1;
                    profileSelect.DOCNAME.OrderBy.Index = 1;
                    profileSelect.DOCNAME.OrderBy.Direction = EOrderByDirection.Descending;

                    //Prendiamo il campo ORIGINALE e diciamo:
                    //1) Mostriamolo in output
                    //2) Nella lista sarà l'elemento di posizione "2"
                    profileSelect.ORIGINALE.Selected = true;
                    profileSelect.ORIGINALE.Index = 2;

                    //Gestiamo i campi aggiuntivi
                    foreach (Aggiuntivo_Selected campoAggiuntivo in profileSelect.Aggiuntivi)
                    {
                        if (campoAggiuntivo. ... . ...("CodiceProtocollo") == true)
                        {
                            campoAggiuntivo.Selected = true;
                            campoAggiuntivo.Index = 3;
                            campoAggiuntivo.OrderBy.Index = 3;
                            campoAggiuntivo.OrderBy.Direction = EOrderByDirection.Ascending;
                        }
                    }

                    //Chiediamo all'utente quale valore minimi di "CodiceProtocollo" deve ricercare
                    int codiceProtocolloScelta = Int32.Parse(Interaction.InputBox("Quali profili con valore minimo di CodiceProtocollo cerchi?", "Ricerche con WCF", "Immetti un valore"));
                    Field_Int campoAggiuntivoCodiceProtocolloScelta =
                        profileSearch.Aggiuntivi.FirstOrDefault(
                            x => String.Equals(x...., ..., StringComparison.CurrentCultureIgnoreCase)) as Field_Int;

                    //Ma questo campo aggiuntivo esiste?
                    if (campoAggiuntivoCodiceProtocolloScelta == null)
                    {
                        throw new Exception("Campo \'CodiceProtocollo\' non trovato!");
                    }
                    else
                    {
                        campoAggiuntivoCodiceProtocolloScelta.SetFilter(... . ..., codiceProtocolloScelta);
                    }

                    //Esecuzione della ricerca, mostrando il risultato nella DataGridLayout
                    using (var ds = _manager. ... . ...(profileSearch, profileSelect, 0))
                    {
                        dgSearch.DataSource = ds.GetDataTable(0);
                    }
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (var profileSelect = _manager. ... . ...("GENERIC"))
                using (var profileSearch = _manager. ... . ...("GENERIC"))
                {

                    //Prendiamo 30 righe al massimo
                    profileSelect.MaxRowCount = 30;

                    //Prendiamo il campo DOCNUMBER e diciamo:
                    //1) Mostriamolo in output
                    //2) Nella lista sarà l'elemento di posizione "0"
                    //3) Inidichiamo che l'elemento è il primo da ordinare
                    //4) Indichiamo che l'elemento sia ordinato in modo ascendente
                    profileSelect.DOCNUMBER.Selected = true;
                    profileSelect.DOCNUMBER.Index = 0;
                    profileSelect.DOCNUMBER.OrderBy.Index = 0;
                    profileSelect.DOCNUMBER.OrderBy.Direction = EOrderByDirection.Ascending;

                    //Prendiamo il campo DOCNAME e diciamo:
                    //1) Mostriamolo in output
                    //2) Nella lista sarà l'elemento di posizione "1"
                    //3) Inidichiamo che l'elemento è il secondo da ordinare
                    //4) Indichiamo che l'elemento sia ordinato in modo ascendente
                    profileSelect.DOCNAME.Selected = true;
                    profileSelect.DOCNAME.Index = 1;
                    profileSelect.DOCNAME.OrderBy.Index = 1;
                    profileSelect.DOCNAME.OrderBy.Direction = EOrderByDirection.Descending;

                    //Prendiamo il campo ORIGINALE e diciamo:
                    //1) Mostriamolo in output
                    //2) Nella lista sarà l'elemento di posizione "2"
                    profileSelect.ORIGINALE.Selected = true;
                    profileSelect.ORIGINALE.Index = 2;

                    //Gestiamo i campi aggiuntivi
                    foreach (Aggiuntivo_Selected campoAggiuntivo in profileSelect.Aggiuntivi)
                    {
                        if (campoAggiuntivo. ... . ...("CodiceProtocollo") == true)
                        {
                            campoAggiuntivo.Selected = true;
                            campoAggiuntivo.Index = 3;
                            campoAggiuntivo.OrderBy.Index = 3;
                            campoAggiuntivo.OrderBy.Direction = EOrderByDirection.Ascending;
                        }
                    }

                    //Chiediamo all'utente quale range di valore "CodiceProtocollo" deve ricercare
                    int codiceProtocolloMinimoScelta = Int32.Parse(
                        Interaction.InputBox("Quali profili con valore minimo di CodiceProtocollo cerchi?", "Ricerche con WCF", "Immetti un valore"));
                    int codiceProtocolloMassimoScelta = Int32.Parse(
                        Interaction.InputBox("Quali profili con valore massimo di CodiceProtocollo cerchi?", "Ricerche con WCF", "Immetti un valore"));


                    Field_Int campoAggiuntivoCodiceProtocolloScelta =
                        profileSearch.Aggiuntivi.FirstOrDefault(
                            x => String.Equals(x. ..., ..., StringComparison.CurrentCultureIgnoreCase)) as Field_Int;
                    //Ma questo campo aggiuntivo esiste?
                    if (campoAggiuntivoCodiceProtocolloScelta == null)
                    {
                        throw new Exception("Campo \'CodiceProtocollo\' non trovato!");
                    }
                    else
                    {
                        campoAggiuntivoCodiceProtocolloScelta.SetFilter(
                            ... . ..., 
                            codiceProtocolloMinimoScelta, 
                            codiceProtocolloMassimoScelta);
                    }

                    //Esecuzione della ricerca, mostrando il risultato nella DataGridLayout
                    using (var ds = _manager. ... . ...(profileSearch, profileSelect, 0))
                    {
                        dgSearch.DataSource = ds.GetDataTable(0);
                    }
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
    } 
}
