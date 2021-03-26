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
                //1) Preambolo
                String messaggio, classeDocumentaleScelta, buScelta, oggettoProfilo, statoDocumentaleScelto, stringaProtocolloScelta;
                int origineProfilo, codiceProtocolloScelto;
                DateTime dataProtocolloScelta;


                //2) Campi principali: Individuiamo la classe documentale: per esempio GENERIC
                var listaClassiDocumentali = _manager. ... . ... (
                    Dm_TipiDocumento_Mode. ...,
                    "SYSTEM_ID");
                messaggio = "In quale classe documentale vuoi creare il profilo? Immetti il suo codice\n";
                foreach (Dm_TipiDocumento classeDocumentale in listaClassiDocumentali)
                {
                    messaggio += string.Format("{0}: {1}\n", classeDocumentale.CODICE, classeDocumentale.DESCRIPTION);
                }
                classeDocumentaleScelta = Interaction.InputBox(messaggio, "Store di un profilo", "Immetti il valore");
                Dm_Profile_ForInsert insert = _manager. ... . ... (classeDocumentaleScelta);

                //3) Campi principali: Definiamo l'AOO
                var listaBU = _manager. ... . ... (Dm_Aoo_Mode.Archive, "CODICE");
                messaggio = "Su quale BusinessUnit vuoi lavorare?\n";
                foreach (Dm_Aoo bu in listaBU)
                {
                    messaggio += string.Format("{0}: {1}({2})\n", bu.CODICE, bu.DENOMINAZIONE, bu.CODFIS);
                }
                buScelta = Interaction.InputBox(messaggio, "Store di un profilo", "Immetti il valore");
                insert.Aoo = buScelta;

                //4) Campi principali: Definiamo l'oggetto del profilo
                messaggio = "Qual è l\'oggetto del profilo?\n";
                oggettoProfilo = Interaction.InputBox(messaggio, "Store di un profilo", "Immetti il valore");
                insert.DocName = oggettoProfilo;

                //5) Campi principali: Origine del profilo: interno, entrata, uscita
                messaggio = string.Format("Qual è l\'origine del profilo?\n0: {0}\n1: {1}\n2: {2}", 
                    ... . ..., ... . ..., ... . ...);
                origineProfilo = Int32.Parse(Interaction.InputBox(messaggio, "Store di un profilo", "Immetti il valore"));
                switch(origineProfilo)
                {
                    case 0:
                        insert.InOut =  DmProfileInOut.Uscita;
                        break;
                    case 1:
                        insert.InOut = DmProfileInOut.Entrata;
                        break;
                    case 2:
                        insert.InOut = DmProfileInOut.Interno;
                        break;
                    default:
                        insert.InOut = DmProfileInOut.NonValorizzato;
                        break;
                }

                //6) Campi principali: Lista degli stati documentali
                messaggio = "Quale stato documentale desideri?\n";
                var listaStatiDocumentali = _manager. ... . ... ("TRANSLATEDESCRIPTION");
                foreach(Dm_Tabelle statoDocumentale in listaStatiDocumentali)
                {
                    messaggio += string.Format("{0}: {1}\n", statoDocumentale.VALORE, statoDocumentale.TRANSLATEDESCRIPTION);
                }
                statoDocumentaleScelto = Interaction.InputBox(messaggio, "Store di un profilo", "Immetti il valore");
                insert.Stato = statoDocumentaleScelto;


                //7) Campi principali: Settiamo la data del documento a oggi
                insert.DataDoc = DateTime.Now.Date;

                //8) Campi principali: Settiamo l'IDERP del documento
                insert.AssocDoc.IDERP = "id_" + DateTime.Now.Millisecond;

                //9) Campi principali: mittente - destinatario - cc
                insert.From = GetDatiProfilo("m.rossi", Dm_DatiProfilo_Campo.MI);
                insert.To.Add(GetDatiProfilo("b.verdi", Dm_DatiProfilo_Campo.DE));
                insert.To.Add(GetDatiProfilo("b.bianchi", Dm_DatiProfilo_Campo.CC));

                //-----------------------------------------
                // Aggiuntivi -----------------------------
                //-----------------------------------------

                //10)Campo aggiuntivo: stringaProtocollo
                messaggio = "Qual è la stringa-protocollo?";
                Aggiuntivo_String aggStringaProtocollo = insert. ... . ...(
                    x => string.Equals(x.Label, "StringaProtocollo", StringComparison.CurrentCultureIgnoreCase)) as Aggiuntivo_String;
                if (aggStringaProtocollo == null)
                {
                    throw new Exception("Campo aggiuntivo \'StringaProtocollo\' non trovato!");
                }
                stringaProtocolloScelta = Interaction.InputBox(messaggio, "Store di un profilo", "Immetti il valore");
                aggStringaProtocollo.Valore = stringaProtocolloScelta;

                //11)Campo aggiuntivo: codiceProtocollo
                messaggio = "Qual è il codice di protocollo?";
                Aggiuntivo_Int codiceProtocollo = insert. ... . ...(
                    x => string.Equals(x.Label, "CodiceProtocollo", StringComparison.CurrentCultureIgnoreCase)) as Aggiuntivo_Int;
                if (codiceProtocollo == null)
                {
                    throw new Exception("Campo aggiuntivo \'codiceProtocollo\' non trovato!");
                }
                codiceProtocolloScelto = Int32.Parse(Interaction.InputBox(messaggio, "Store di un profilo", "Immetti il valore"));
                codiceProtocollo.Valore = codiceProtocolloScelto;

                //12)Campo aggiuntivo: dataProtocollo
                messaggio = "Qual è la data-protocollo?";
                Aggiuntivo_DateTime dataProtocollo = insert. ... . ...(
                    x => string.Equals(x.Label, "DataProtocollo", StringComparison.CurrentCultureIgnoreCase)) as Aggiuntivo_DateTime;
                if (dataProtocollo == null)
                {
                    throw new Exception("Campo aggiuntivo \'dataProtocollo\' non trovato!");
                }
                dataProtocolloScelta = DateTime.Parse(Interaction.InputBox(messaggio, "Store di un profilo", "2019/05/24"));
                dataProtocollo.Valore = dataProtocolloScelta;

                //13)File del profilo
                insert.File = new Arx_File(@"C:\Temp\test.txt");

                //14) Proviamo a creare il profilo e controlliamo l'esito
                Dm_Profile_Result dmProfileResult = _manager. ... . ...(insert);

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
                        return resultId;
                    }
                }
            }
        }

        private Dm_DatiProfilo GetDatiProfilo(string ragSoc, Dm_DatiProfilo_Campo tipoCampo)
        {
            //Cerchiamo la persona nella rubrica...
            var idContatto = CercaInRubrica(ragSoc);

            //Il contatto è nella rubrica?
            if (idContatto != null)
            {
                //Se sì...
                return _manager.ARX_DATI.Dm_DatiProfilo_GetNewInstance_From_IdContatto(idContatto.Value, tipoCampo);
            }
            else
            {
                //altrimenti...
                return new Dm_DatiProfilo
                {
                    VALORE = ragSoc,
                    CONTATTI = ragSoc,
                    CAMPO = tipoCampo
                };
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                //Preambolo
                String messaggio, nuovoOggettoDelProfilo, nuovaStringaProtocollo;
                int docNumberScelto;

                //1) Recupero il profilo da modificare
                messaggio = "Qual docnumber vuoi modificare?";
                docNumberScelto = Int32.Parse(Interaction.InputBox(messaggio, "Modifica dello store di un profilo", "Immetti valore"));

                //2) Mi carico il profilo in memoria...
                Dm_Profile_ForUpdate profile = _manager. ... . ...(docNumberScelto);

                //3) Cambio l'oggetto del profilo del profilo in memoria...
                messaggio = "Qual è l\'oggetto del profilo?";
                nuovoOggettoDelProfilo = Interaction.InputBox(messaggio, "Modifica dello store di un profilo", "Immetti valore");
                profile.DocName = nuovoOggettoDelProfilo;

                //4) Cambio la stringa-protocollo del profilo in memoria...
                messaggio = "Qual è la nuova stringa-protocollo?";
                Aggiuntivo_String aggiuntivoStringaProtocollo = profile. ... . ...(
                    x => string.Equals(x.Label, "StringaProtocollo", StringComparison.CurrentCultureIgnoreCase)) as Aggiuntivo_String;
                if (aggiuntivoStringaProtocollo == null)
                {
                    throw new Exception("Non ho trovato il campo \'aggiuntivoDataProtocollo\'");
                }
                nuovaStringaProtocollo = Interaction.InputBox(messaggio, "Modifica dello store di un profilo", "Immetti valore");
                aggiuntivoStringaProtocollo.Valore = nuovaStringaProtocollo;

                //5) Aggiorniamo il profilo in Arxivar Next
                Dm_Profile_Result profileResult = _manager. ... . ...(profile, string.Empty);

                //6) L'operazione è andata bene?
                if (profileResult.EXCEPTION != Security_Exception.Nothing)                
                    throw new Exception(string.Format("Error: {0}", profileResult.MESSAGE));                
                else
                    MessageBox.Show("Aggiornamento eseguito con successo!", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
