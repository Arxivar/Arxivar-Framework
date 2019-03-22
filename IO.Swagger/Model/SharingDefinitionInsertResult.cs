/* 
 * Abletech.Arxivar.Server.WebApi.Services
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// SharingDefinitionInsertResult
    /// </summary>
    [DataContract]
    public partial class SharingDefinitionInsertResult :  IEquatable<SharingDefinitionInsertResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharingDefinitionInsertResult" /> class.
        /// </summary>
        /// <param name="SharingDefinition">Created or updated Sharing definition..</param>
        /// <param name="Exception">Possible values:  0: Nothing  1: Document_Not_Exist  2: Document_Not_Avaiable  3: Document_Is_Archived  4: Document_Has_Running_Process  5: Document_Opened_By_Another_User  6: Document_Pa  7: User_Cannot_Write_In_This_Class  8: User_Cannot_Write_In_This_Document  9: State_Cannot_Permit_Edit  10: Document_as_been_Extracted  11: Cannot_Edit_For_Task_Associated  12: Cannot_Find_ProcessDoc  13: User_Not_Exist  14: User_Cannot_Delete_Documents  15: User_Cannot_Delete_This_Document  16: User_IsNotInAutoreMittenteDestinatari  17: Mail_Address_Is_Not_Unique  18: Mail_Address_NotFound  19: UserName_Is_Not_Unique  20: UserName_Not_Exist  21: UserName_Mail_Is_Not_Unique  22: User_AlreadyExist  23: User_AlreadyExist_In_HiddenState  24: User_AlreadyExist_Not_Active  25: Dm_StringaConnessione_Fail  26: Dm_AssociaFolder_UsedIn_SRP  27: Dm_AssociaFolder_UsedIn_Folders  28: Dm_AssociaFolder_UsedIn_DefaultProfile  29: Dm_AssociaFolder_UsedIn_Mask  30: Dm_StringaConnessione_UsedIn_Dm_VariabiliProcesso  31: Dm_StringaConnessione_UsedIn_Dm_CampiQuery  32: Dm_StringaConnessione_UsedIn_Dm_ElencoCampiTabella  33: Dm_Combo_Gruppi_UsedIn_Dm_CampiSpecifici  34: Dm_Combo_Gruppi_UsedIn_Dm_VariabiliProcesso  35: Dm_CampiSpecGrp_UsedIn_Dm_Campispecifici  36: Dm_Tipidocumento_Invalid_systemId  37: Dm_Tipidocumento_Is_Not_Leaf  38: Dm_Tipidocumento_Contains_Specific_Fields  39: Dm_Tipidocumento_Exist_Profiles  40: Dm_Tipidocumento_Dm_Links_Contains_SystemId  41: State_Cannot_Permit_Revision  42: State_Cannot_Permit_OverWrite  43: Dm_Utenti_Categoria_Must_Be_U  44: Dm_Utenti_User_Is_In_Org  45: Dm_Utenti_Invalid_Aoo  46: Dm_Aoo_Not_Exist  47: Profile_Is_Locked_By_Other_User  48: RenameDocument_Invalid_FileName  49: RenameDocument_Invalid_Extension  50: Dm_Files_Log_Acces_Denied  51: Dm_Emergenza_Tipo_Invalid  52: Dm_Emergenza_Default_DocumentType_Not_Set  53: Dm_TipiDocumento_Not_Found  54: Dm_TipiDocumento_Is_Not_Pa  55: User_Is_Not_In_Role  56: Dm_Sql_UsedIn_Dm_CampiQuery  57: Dm_Fascicoli_Id_Not_Found  58: Dm_Fascioli_Delete_Principale  59: Access_Is_Denied  60: Dm_Fascioli_Has_Childs  61: Dm_Fascicoli_Contains_Docs  62: Dm_Fileinfolde_Not_Found  63: Profile_Entity_Not_Validate  64: Profile_Duplicate_Field  65: Aoo_Null  66: Aoo_Not_Found  67: Dm_Tipidocumento_Invalid_State  68: Dm_Tipidocumento_User_Can_Not_Write  69: Dm_ElencoPratiche_Not_Found  70: Profile_Pa_CanNotModify_Field  71: Dm_CampiSpecifici_Required  72: Dm_CampiSpecifici_NotFound  73: File_Required  74: File_Name_Required  75: Dm_Profile_Insert_Barcode_Incompatible_Class  76: Uniqueness_Rule_Violate  77: Dm_Profile_Update_DATADOC_Greather_Than_DATAPROT  78: Dm_Profile_Update_UnderPa_CanNotModifyAoo  79: Dm_Profile_Update_UnderPa_CanNotModifyState  80: Dm_Profile_Update_UnderPa_CanNotModifyObject  81: Dm_Profile_Update_UnderPa_CanNotModifyInOut  82: Dm_Profile_Update_UnderPa_CanNotModifyDocumentType  83: Dm_Profile_Update_UnderPa_CanNotModifyFrom  84: Dm_Profile_Update_UnderPa_CanNotModifyTo  85: DatiEnte_Spedizione_Invalid  86: Profile_DataProt_Invalid  87: Dm_Profile_Insert_Ivalid_InOut  88: Dm_Setup_Invalid_StatoRegistra  89: Dm_Profile_Insert_Barcode_AlreadyExist  90: Dm_TaskWork_Task_Not_In_Charge  91: Dm_TaskWork_Set_ReadOnly_To_Document  92: Dm_NoteWork_Does_Not_Exist  93: User_Is_Not_Owner  94: Dm_AllegatiWork_Id_Not_Found  95: Document_Is_Opened  96: DmComandiTask_Required  97: DmTaskDoc_Required  98: Dm_VariabiliTask_Required  99: Dm_FigureTask_Required  100: Password_Required  101: TCondEsiti_Execute  102: Dm_Links_Missing  103: Document_Is_Empty  104: Dm_ComandiTask_ClientSide  105: System_Diagnostic_Exception  106: Certificate_Not_Found  107: Sign_Exception  108: SIgn_Service_not_Found  109: Dm_Combo_Gruppi_UsedIn_Dm_VariabiliQuery  110: Dm_RicQuick_Campi_VB6ManageRicQuickFail  111: Dm_Processi_Can_Not_EditDoc  112: Stamps_Are_Not_Available  113: Dm_Profile_Has_No_File  114: Arx_Stamp_Apply_Error  115: FILE_NULL_AFTER_STAMP_APPLY  116: Profile_Pa_Reserved_FromIsRequire  117: Profile_Pa_Reserved_ToIsRequire  118: Profile_Pa_Reserved_AooIsRequire  119: Profile_Pa_Reserved_DocNameIsRequire  120: Dm_Profile_Update_EvasionePa_ClassNoPaException  121: User_Is_Not_Admin  122: Dm_Rubrica_Used_In_AssociaFolder  123: Invalid_Task_Outcome  124: Profile_Insert_Error  125: Dm_Tipidocumento_NoFile  126: LicenseBaseMissing  127: File_Already_Present  128: Generic  129: Dm_Profile_Not_Found  130: Dm_Profile_Is_Not_CheckedOut  131: User_Cannot_Read_This_Document  132: State_Not_Exist  133: Sign_Not_Verified  134: Dm_Barcode_IdBarcode_Not_Found  135: User_Cannot_Use_Barcode  136: Dm_Rubrica_User_CanNotDelete  137: Dm_Rubrica_User_CanNotUpdate  138: Password_Faulted  139: User_Cannot_Read_Any_Document  140: User_Cannot_Read_Some_Document  141: Dm_TipiDocumento_Is_Not_Aos  142: Dm_Profile_IsAos  143: Certificate_LoginFailed  144: Dm_Tipidocumento_RequireFileMustBeOptional  145: Dm_Taskwork_User_Cannot_Lock_Task  146: Dm_Taskwork_Already_Locked_By_Another_User  147: Dm_Taskwork_Already_Locked_By_User_Other_Session  148: Dm_LogonProvider_Association_Missing  149: Dm_Links_Command_IsClient  150: Dm_Collaboration_Is_Read_Only  151: Dm_Collaboration_User_Is_Not_Detail  152: Dm_Collaboration_Not_Have_Master  153: Dm_Collaboration_Not_Exist  154: Ws_DocToIx_Cannot_Delete_Documents  155: Ws_DocToIxCe_Cannot_Delete_Documents  156: Dm_MansioniDynTask_Required  157: Dm_Collaboration_Isnt_Takeoff  158: Dm_Collaboration_Is_Terminated  159: Dm_Collaboration_Master_Not_In_Collaboration  160: Dm_Collaboration_User_Already_TakedOff  161: Dm_Collaboration_Master_not_Exist  162: Dm_Collaboration_Detail_not_Exist  163: Dm_WfSign_Required  164: After_Profile_Insert_Error  165: Ws_Conflict  166: Dm_Taskwork_Not_Found  167: Dm_ApiCall_UsedIn_Dm_CampiQuery .</param>
        /// <param name="Message">Error Message..</param>
        public SharingDefinitionInsertResult(SharingDefinitionDTO SharingDefinition = default(SharingDefinitionDTO), int? Exception = default(int?), string Message = default(string))
        {
            this.SharingDefinition = SharingDefinition;
            this.Exception = Exception;
            this.Message = Message;
        }
        
        /// <summary>
        /// Created or updated Sharing definition.
        /// </summary>
        /// <value>Created or updated Sharing definition.</value>
        [DataMember(Name="sharingDefinition", EmitDefaultValue=false)]
        public SharingDefinitionDTO SharingDefinition { get; set; }

        /// <summary>
        /// Possible values:  0: Nothing  1: Document_Not_Exist  2: Document_Not_Avaiable  3: Document_Is_Archived  4: Document_Has_Running_Process  5: Document_Opened_By_Another_User  6: Document_Pa  7: User_Cannot_Write_In_This_Class  8: User_Cannot_Write_In_This_Document  9: State_Cannot_Permit_Edit  10: Document_as_been_Extracted  11: Cannot_Edit_For_Task_Associated  12: Cannot_Find_ProcessDoc  13: User_Not_Exist  14: User_Cannot_Delete_Documents  15: User_Cannot_Delete_This_Document  16: User_IsNotInAutoreMittenteDestinatari  17: Mail_Address_Is_Not_Unique  18: Mail_Address_NotFound  19: UserName_Is_Not_Unique  20: UserName_Not_Exist  21: UserName_Mail_Is_Not_Unique  22: User_AlreadyExist  23: User_AlreadyExist_In_HiddenState  24: User_AlreadyExist_Not_Active  25: Dm_StringaConnessione_Fail  26: Dm_AssociaFolder_UsedIn_SRP  27: Dm_AssociaFolder_UsedIn_Folders  28: Dm_AssociaFolder_UsedIn_DefaultProfile  29: Dm_AssociaFolder_UsedIn_Mask  30: Dm_StringaConnessione_UsedIn_Dm_VariabiliProcesso  31: Dm_StringaConnessione_UsedIn_Dm_CampiQuery  32: Dm_StringaConnessione_UsedIn_Dm_ElencoCampiTabella  33: Dm_Combo_Gruppi_UsedIn_Dm_CampiSpecifici  34: Dm_Combo_Gruppi_UsedIn_Dm_VariabiliProcesso  35: Dm_CampiSpecGrp_UsedIn_Dm_Campispecifici  36: Dm_Tipidocumento_Invalid_systemId  37: Dm_Tipidocumento_Is_Not_Leaf  38: Dm_Tipidocumento_Contains_Specific_Fields  39: Dm_Tipidocumento_Exist_Profiles  40: Dm_Tipidocumento_Dm_Links_Contains_SystemId  41: State_Cannot_Permit_Revision  42: State_Cannot_Permit_OverWrite  43: Dm_Utenti_Categoria_Must_Be_U  44: Dm_Utenti_User_Is_In_Org  45: Dm_Utenti_Invalid_Aoo  46: Dm_Aoo_Not_Exist  47: Profile_Is_Locked_By_Other_User  48: RenameDocument_Invalid_FileName  49: RenameDocument_Invalid_Extension  50: Dm_Files_Log_Acces_Denied  51: Dm_Emergenza_Tipo_Invalid  52: Dm_Emergenza_Default_DocumentType_Not_Set  53: Dm_TipiDocumento_Not_Found  54: Dm_TipiDocumento_Is_Not_Pa  55: User_Is_Not_In_Role  56: Dm_Sql_UsedIn_Dm_CampiQuery  57: Dm_Fascicoli_Id_Not_Found  58: Dm_Fascioli_Delete_Principale  59: Access_Is_Denied  60: Dm_Fascioli_Has_Childs  61: Dm_Fascicoli_Contains_Docs  62: Dm_Fileinfolde_Not_Found  63: Profile_Entity_Not_Validate  64: Profile_Duplicate_Field  65: Aoo_Null  66: Aoo_Not_Found  67: Dm_Tipidocumento_Invalid_State  68: Dm_Tipidocumento_User_Can_Not_Write  69: Dm_ElencoPratiche_Not_Found  70: Profile_Pa_CanNotModify_Field  71: Dm_CampiSpecifici_Required  72: Dm_CampiSpecifici_NotFound  73: File_Required  74: File_Name_Required  75: Dm_Profile_Insert_Barcode_Incompatible_Class  76: Uniqueness_Rule_Violate  77: Dm_Profile_Update_DATADOC_Greather_Than_DATAPROT  78: Dm_Profile_Update_UnderPa_CanNotModifyAoo  79: Dm_Profile_Update_UnderPa_CanNotModifyState  80: Dm_Profile_Update_UnderPa_CanNotModifyObject  81: Dm_Profile_Update_UnderPa_CanNotModifyInOut  82: Dm_Profile_Update_UnderPa_CanNotModifyDocumentType  83: Dm_Profile_Update_UnderPa_CanNotModifyFrom  84: Dm_Profile_Update_UnderPa_CanNotModifyTo  85: DatiEnte_Spedizione_Invalid  86: Profile_DataProt_Invalid  87: Dm_Profile_Insert_Ivalid_InOut  88: Dm_Setup_Invalid_StatoRegistra  89: Dm_Profile_Insert_Barcode_AlreadyExist  90: Dm_TaskWork_Task_Not_In_Charge  91: Dm_TaskWork_Set_ReadOnly_To_Document  92: Dm_NoteWork_Does_Not_Exist  93: User_Is_Not_Owner  94: Dm_AllegatiWork_Id_Not_Found  95: Document_Is_Opened  96: DmComandiTask_Required  97: DmTaskDoc_Required  98: Dm_VariabiliTask_Required  99: Dm_FigureTask_Required  100: Password_Required  101: TCondEsiti_Execute  102: Dm_Links_Missing  103: Document_Is_Empty  104: Dm_ComandiTask_ClientSide  105: System_Diagnostic_Exception  106: Certificate_Not_Found  107: Sign_Exception  108: SIgn_Service_not_Found  109: Dm_Combo_Gruppi_UsedIn_Dm_VariabiliQuery  110: Dm_RicQuick_Campi_VB6ManageRicQuickFail  111: Dm_Processi_Can_Not_EditDoc  112: Stamps_Are_Not_Available  113: Dm_Profile_Has_No_File  114: Arx_Stamp_Apply_Error  115: FILE_NULL_AFTER_STAMP_APPLY  116: Profile_Pa_Reserved_FromIsRequire  117: Profile_Pa_Reserved_ToIsRequire  118: Profile_Pa_Reserved_AooIsRequire  119: Profile_Pa_Reserved_DocNameIsRequire  120: Dm_Profile_Update_EvasionePa_ClassNoPaException  121: User_Is_Not_Admin  122: Dm_Rubrica_Used_In_AssociaFolder  123: Invalid_Task_Outcome  124: Profile_Insert_Error  125: Dm_Tipidocumento_NoFile  126: LicenseBaseMissing  127: File_Already_Present  128: Generic  129: Dm_Profile_Not_Found  130: Dm_Profile_Is_Not_CheckedOut  131: User_Cannot_Read_This_Document  132: State_Not_Exist  133: Sign_Not_Verified  134: Dm_Barcode_IdBarcode_Not_Found  135: User_Cannot_Use_Barcode  136: Dm_Rubrica_User_CanNotDelete  137: Dm_Rubrica_User_CanNotUpdate  138: Password_Faulted  139: User_Cannot_Read_Any_Document  140: User_Cannot_Read_Some_Document  141: Dm_TipiDocumento_Is_Not_Aos  142: Dm_Profile_IsAos  143: Certificate_LoginFailed  144: Dm_Tipidocumento_RequireFileMustBeOptional  145: Dm_Taskwork_User_Cannot_Lock_Task  146: Dm_Taskwork_Already_Locked_By_Another_User  147: Dm_Taskwork_Already_Locked_By_User_Other_Session  148: Dm_LogonProvider_Association_Missing  149: Dm_Links_Command_IsClient  150: Dm_Collaboration_Is_Read_Only  151: Dm_Collaboration_User_Is_Not_Detail  152: Dm_Collaboration_Not_Have_Master  153: Dm_Collaboration_Not_Exist  154: Ws_DocToIx_Cannot_Delete_Documents  155: Ws_DocToIxCe_Cannot_Delete_Documents  156: Dm_MansioniDynTask_Required  157: Dm_Collaboration_Isnt_Takeoff  158: Dm_Collaboration_Is_Terminated  159: Dm_Collaboration_Master_Not_In_Collaboration  160: Dm_Collaboration_User_Already_TakedOff  161: Dm_Collaboration_Master_not_Exist  162: Dm_Collaboration_Detail_not_Exist  163: Dm_WfSign_Required  164: After_Profile_Insert_Error  165: Ws_Conflict  166: Dm_Taskwork_Not_Found  167: Dm_ApiCall_UsedIn_Dm_CampiQuery 
        /// </summary>
        /// <value>Possible values:  0: Nothing  1: Document_Not_Exist  2: Document_Not_Avaiable  3: Document_Is_Archived  4: Document_Has_Running_Process  5: Document_Opened_By_Another_User  6: Document_Pa  7: User_Cannot_Write_In_This_Class  8: User_Cannot_Write_In_This_Document  9: State_Cannot_Permit_Edit  10: Document_as_been_Extracted  11: Cannot_Edit_For_Task_Associated  12: Cannot_Find_ProcessDoc  13: User_Not_Exist  14: User_Cannot_Delete_Documents  15: User_Cannot_Delete_This_Document  16: User_IsNotInAutoreMittenteDestinatari  17: Mail_Address_Is_Not_Unique  18: Mail_Address_NotFound  19: UserName_Is_Not_Unique  20: UserName_Not_Exist  21: UserName_Mail_Is_Not_Unique  22: User_AlreadyExist  23: User_AlreadyExist_In_HiddenState  24: User_AlreadyExist_Not_Active  25: Dm_StringaConnessione_Fail  26: Dm_AssociaFolder_UsedIn_SRP  27: Dm_AssociaFolder_UsedIn_Folders  28: Dm_AssociaFolder_UsedIn_DefaultProfile  29: Dm_AssociaFolder_UsedIn_Mask  30: Dm_StringaConnessione_UsedIn_Dm_VariabiliProcesso  31: Dm_StringaConnessione_UsedIn_Dm_CampiQuery  32: Dm_StringaConnessione_UsedIn_Dm_ElencoCampiTabella  33: Dm_Combo_Gruppi_UsedIn_Dm_CampiSpecifici  34: Dm_Combo_Gruppi_UsedIn_Dm_VariabiliProcesso  35: Dm_CampiSpecGrp_UsedIn_Dm_Campispecifici  36: Dm_Tipidocumento_Invalid_systemId  37: Dm_Tipidocumento_Is_Not_Leaf  38: Dm_Tipidocumento_Contains_Specific_Fields  39: Dm_Tipidocumento_Exist_Profiles  40: Dm_Tipidocumento_Dm_Links_Contains_SystemId  41: State_Cannot_Permit_Revision  42: State_Cannot_Permit_OverWrite  43: Dm_Utenti_Categoria_Must_Be_U  44: Dm_Utenti_User_Is_In_Org  45: Dm_Utenti_Invalid_Aoo  46: Dm_Aoo_Not_Exist  47: Profile_Is_Locked_By_Other_User  48: RenameDocument_Invalid_FileName  49: RenameDocument_Invalid_Extension  50: Dm_Files_Log_Acces_Denied  51: Dm_Emergenza_Tipo_Invalid  52: Dm_Emergenza_Default_DocumentType_Not_Set  53: Dm_TipiDocumento_Not_Found  54: Dm_TipiDocumento_Is_Not_Pa  55: User_Is_Not_In_Role  56: Dm_Sql_UsedIn_Dm_CampiQuery  57: Dm_Fascicoli_Id_Not_Found  58: Dm_Fascioli_Delete_Principale  59: Access_Is_Denied  60: Dm_Fascioli_Has_Childs  61: Dm_Fascicoli_Contains_Docs  62: Dm_Fileinfolde_Not_Found  63: Profile_Entity_Not_Validate  64: Profile_Duplicate_Field  65: Aoo_Null  66: Aoo_Not_Found  67: Dm_Tipidocumento_Invalid_State  68: Dm_Tipidocumento_User_Can_Not_Write  69: Dm_ElencoPratiche_Not_Found  70: Profile_Pa_CanNotModify_Field  71: Dm_CampiSpecifici_Required  72: Dm_CampiSpecifici_NotFound  73: File_Required  74: File_Name_Required  75: Dm_Profile_Insert_Barcode_Incompatible_Class  76: Uniqueness_Rule_Violate  77: Dm_Profile_Update_DATADOC_Greather_Than_DATAPROT  78: Dm_Profile_Update_UnderPa_CanNotModifyAoo  79: Dm_Profile_Update_UnderPa_CanNotModifyState  80: Dm_Profile_Update_UnderPa_CanNotModifyObject  81: Dm_Profile_Update_UnderPa_CanNotModifyInOut  82: Dm_Profile_Update_UnderPa_CanNotModifyDocumentType  83: Dm_Profile_Update_UnderPa_CanNotModifyFrom  84: Dm_Profile_Update_UnderPa_CanNotModifyTo  85: DatiEnte_Spedizione_Invalid  86: Profile_DataProt_Invalid  87: Dm_Profile_Insert_Ivalid_InOut  88: Dm_Setup_Invalid_StatoRegistra  89: Dm_Profile_Insert_Barcode_AlreadyExist  90: Dm_TaskWork_Task_Not_In_Charge  91: Dm_TaskWork_Set_ReadOnly_To_Document  92: Dm_NoteWork_Does_Not_Exist  93: User_Is_Not_Owner  94: Dm_AllegatiWork_Id_Not_Found  95: Document_Is_Opened  96: DmComandiTask_Required  97: DmTaskDoc_Required  98: Dm_VariabiliTask_Required  99: Dm_FigureTask_Required  100: Password_Required  101: TCondEsiti_Execute  102: Dm_Links_Missing  103: Document_Is_Empty  104: Dm_ComandiTask_ClientSide  105: System_Diagnostic_Exception  106: Certificate_Not_Found  107: Sign_Exception  108: SIgn_Service_not_Found  109: Dm_Combo_Gruppi_UsedIn_Dm_VariabiliQuery  110: Dm_RicQuick_Campi_VB6ManageRicQuickFail  111: Dm_Processi_Can_Not_EditDoc  112: Stamps_Are_Not_Available  113: Dm_Profile_Has_No_File  114: Arx_Stamp_Apply_Error  115: FILE_NULL_AFTER_STAMP_APPLY  116: Profile_Pa_Reserved_FromIsRequire  117: Profile_Pa_Reserved_ToIsRequire  118: Profile_Pa_Reserved_AooIsRequire  119: Profile_Pa_Reserved_DocNameIsRequire  120: Dm_Profile_Update_EvasionePa_ClassNoPaException  121: User_Is_Not_Admin  122: Dm_Rubrica_Used_In_AssociaFolder  123: Invalid_Task_Outcome  124: Profile_Insert_Error  125: Dm_Tipidocumento_NoFile  126: LicenseBaseMissing  127: File_Already_Present  128: Generic  129: Dm_Profile_Not_Found  130: Dm_Profile_Is_Not_CheckedOut  131: User_Cannot_Read_This_Document  132: State_Not_Exist  133: Sign_Not_Verified  134: Dm_Barcode_IdBarcode_Not_Found  135: User_Cannot_Use_Barcode  136: Dm_Rubrica_User_CanNotDelete  137: Dm_Rubrica_User_CanNotUpdate  138: Password_Faulted  139: User_Cannot_Read_Any_Document  140: User_Cannot_Read_Some_Document  141: Dm_TipiDocumento_Is_Not_Aos  142: Dm_Profile_IsAos  143: Certificate_LoginFailed  144: Dm_Tipidocumento_RequireFileMustBeOptional  145: Dm_Taskwork_User_Cannot_Lock_Task  146: Dm_Taskwork_Already_Locked_By_Another_User  147: Dm_Taskwork_Already_Locked_By_User_Other_Session  148: Dm_LogonProvider_Association_Missing  149: Dm_Links_Command_IsClient  150: Dm_Collaboration_Is_Read_Only  151: Dm_Collaboration_User_Is_Not_Detail  152: Dm_Collaboration_Not_Have_Master  153: Dm_Collaboration_Not_Exist  154: Ws_DocToIx_Cannot_Delete_Documents  155: Ws_DocToIxCe_Cannot_Delete_Documents  156: Dm_MansioniDynTask_Required  157: Dm_Collaboration_Isnt_Takeoff  158: Dm_Collaboration_Is_Terminated  159: Dm_Collaboration_Master_Not_In_Collaboration  160: Dm_Collaboration_User_Already_TakedOff  161: Dm_Collaboration_Master_not_Exist  162: Dm_Collaboration_Detail_not_Exist  163: Dm_WfSign_Required  164: After_Profile_Insert_Error  165: Ws_Conflict  166: Dm_Taskwork_Not_Found  167: Dm_ApiCall_UsedIn_Dm_CampiQuery </value>
        [DataMember(Name="exception", EmitDefaultValue=false)]
        public int? Exception { get; set; }

        /// <summary>
        /// Error Message.
        /// </summary>
        /// <value>Error Message.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharingDefinitionInsertResult {\n");
            sb.Append("  SharingDefinition: ").Append(SharingDefinition).Append("\n");
            sb.Append("  Exception: ").Append(Exception).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SharingDefinitionInsertResult);
        }

        /// <summary>
        /// Returns true if SharingDefinitionInsertResult instances are equal
        /// </summary>
        /// <param name="input">Instance of SharingDefinitionInsertResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharingDefinitionInsertResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SharingDefinition == input.SharingDefinition ||
                    (this.SharingDefinition != null &&
                    this.SharingDefinition.Equals(input.SharingDefinition))
                ) && 
                (
                    this.Exception == input.Exception ||
                    (this.Exception != null &&
                    this.Exception.Equals(input.Exception))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SharingDefinition != null)
                    hashCode = hashCode * 59 + this.SharingDefinition.GetHashCode();
                if (this.Exception != null)
                    hashCode = hashCode * 59 + this.Exception.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
