using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.Persona;
using Integration.BE;
using Integration.DAService;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using System.Transactions;

namespace Integration.BL
{
    public class BL_Personas
    {
		public DataTable ListaPeronas_BycPerApellido(BE_Req_Persona Request)
        {
            DAPersona ObjPersona = new DAPersona();
            return ObjPersona.ListaPersonas_BycPerApellido(Request);
        }
        public DataTable ListaPeronas_BycPerApellido_cPerRelTipo(BE_Req_Persona Request)
        {
            DAPersona ObjPersona = new DAPersona();
            return ObjPersona.ListaPersonas_BycPerCodigo_cPerRelTipo(Request);
        }
        public DataTable ListaPersona_BycPerCodigo(BE_Req_Persona Request)
        {
            DAPersona ObjPersona = new DAPersona();
            return ObjPersona.ListaPersona_BycPerCodigo(Request);
        }
        public SqlDataReader DRListaPeronas_BycPerApellido_cPerRelTipo(BE_Req_Persona Request)
        {
            DAPersona ObjPersona = new DAPersona();
            return ObjPersona.DRListaPersonas_BycPerCodigo_cPerRelTipo(Request);
        }
        public SqlDataReader DRListaDelegados_BycPerCodigo(BE_Req_Persona Request)
        {
            DAPersona ObjPersona = new DAPersona();
            return ObjPersona.DRListaDelegados_BycPerCodigo(Request);
        }
        public BE_Res_Persona getcPerCodigoNew()
        {
            DAPersona ObjPersona = new DAPersona();
            return ObjPersona.getcPerCodigoNew();
        }
        //----------------
        // Persona
        //----------------
        //para Generar nuevo cPerCodigo
        public DataTable Get_NewIdcPerCodigo(BE_ReqPersona Request)
        {
            //Recuperando registros 
            DA_Personas Obj = new DA_Personas();
            return Obj.Get_NewIdcPerCodigo(Request);

        }

        //Get_PersonaAutocompletar
        public DataTable Get_PersonaAutocompletar()
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_Personas Obj = new DA_Personas();
            return Obj.Get_PersonaAutocompletar();

        }

        //para buscar persona
        public DataTable Get_SearhPersona(BE_ReqPersonaSearh  Request)
        {
            //Recuperando registros 
            DA_Personas Obj = new DA_Personas();
            return Obj.Get_SearhPersona(Request);

        }

        //-----------------------------------------------------
        // SearhPersona Android Create: eincio Date: 2016-05-11
        //-----------------------------------------------------
        public DataTable Android_Get_Persona_by_nPerIdeTipo_and_cPerIdeNumero(AndroidPersona Request)
        {
            //Recuperando registros 
            DA_Personas Obj = new DA_Personas();
            return Obj.Android_Get_Persona_by_nPerIdeTipo_and_cPerIdeNumero(Request);

        }

        //para buscar persona by cPerApellido
        public DataTable Get_Persona_by_cPerApellido(BE_ReqPersonaSearh Request)
        {
            DA_Personas Obj = new DA_Personas();
            return Obj.Get_Persona_by_cPerApellido(Request);

        }

        //---------------
        //Insert Persona
        //--------------
        public bool Ins_Persona(BE_ReqPersona  Request)
        {
            DA_Personas Obj = new DA_Personas();
            return Obj.Ins_Persona(Request);
        }

        //-------------------
        //Insert Persona POO
        //-------------------
        public bool Insert_Persona(Persona  Objeto)
        {
            DA_Personas Obj = new DA_Personas();
            return Obj.Insert_Persona(Objeto);
        }

        //-------------------
        //Insert PerIdentifica POO
        //-------------------
        public bool Insert_PerIdentifica(PerIdentifica Objeto)
        {
            DA_Personas Obj = new DA_Personas();
            return Obj.Insert_PerIdentifica(Objeto);
        }

        //-------------------
        //Insert PerNatural POO
        //-------------------
        public bool Insert_PerNatural(PerNatural Objeto)
        {
            DA_Personas Obj = new DA_Personas();
            return Obj.Insert_PerNatural(Objeto);
        }

        //-------------------
        //Insert PerName POO
        //-------------------
        public bool Insert_PerName(PerName Objeto)
        {
            DA_Personas Obj = new DA_Personas();
            return Obj.Insert_PerName(Objeto);
        }


        //---------------------------
        //Create: 2016-05-09 (EINCIO)
        //Insert Android Persona
        //---------------------------
        public bool Ins_Android_Persona(AndroidPersona Request)
        {
            DA_Personas Obj = new DA_Personas();
            return Obj.Ins_Android_Persona(Request); 
        }

        //Update Persona
        public bool Upd_Persona(BE_ReqPersona Request)
        {
            DA_Personas Obj = new DA_Personas();
            return Obj.Upd_Persona(Request);
        }

        //----------------
        // PerDomicilio
        //----------------
        public BE_ResGenerico InsPerDomicilio(BE_ReqPerDomicilio  Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Personas Obj = new DA_Personas();
            Item = Obj.InsPerDomicilio(Request);
            return Item;
        }

        //---------------------
        // Update PerDomicilio
        //--------------------
        public BE_ResGenerico UpdPerDomicilio(BE_ReqPerDomicilio Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Personas Obj = new DA_Personas();
            Item = Obj.UpdPerDomicilio(Request);
            return Item;
        }

        //----------------
        // PerTelefono
        //----------------
        public BE_ResGenerico InsPerTelefono(BE_ReqPerTelefono Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Personas Obj = new DA_Personas();
            Item = Obj.InsPerTelefono(Request);
            return Item;
        }

        //--------------------
        // update PerTelefono
        //-------------------
        public BE_ResGenerico UpdPerTelefono(BE_ReqPerTelefono Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Personas Obj = new DA_Personas();
            Item = Obj.UpdPerTelefono(Request);
            return Item;
        }

        //----------------
        // PerMail
        //----------------
        public BE_ResGenerico InsPerMail(BE_ReqPerMail Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Personas Obj = new DA_Personas();
            Item = Obj.InsPerMail(Request);
            return Item;
        }

        //----------------
        // Update PerMail
        //----------------
        public BE_ResGenerico UpdPerMail(BE_ReqPerMail Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Personas Obj = new DA_Personas();
            Item = Obj.UpdPerMail(Request);
            return Item;
        }

        //----------------
        // PerImagen
        //----------------
        public BE_ResGenerico InsPerImagen(BE_ReqPerPhoto Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Personas Obj = new DA_Personas();
            Item = Obj.InsPerImagen(Request);
            return Item;
        }

        //Obtener Photo x cPercodigo
        public DataTable Get_PerImagen(BE_ReqPerPhoto Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_Personas Obj = new DA_Personas();
            return Obj.Get_PerImagen(Request);

        }

        public Boolean setPersona(BE_Req_Persona Request)
        {
            DAPersona ObjPersona = new DAPersona();
            return ObjPersona.setPersona(Request);
        }

        //----------------
        // PerIdentifica
        //----------------
        public BE_ResGenerico InsPerIdentifica(BE_ReqPerIdentifica  Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Personas Obj = new DA_Personas();
            Item = Obj.InsPerIdentifica(Request);
            return Item;
        }

        //Obtener PerIdentifica
        public DataTable Get_PerIdentifica(BE_ReqPerIdentifica Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_Personas Obj = new DA_Personas();
            return Obj.Get_PerIdentifica(Request);

        }

        //----------------
        // PerJuridica
        //----------------
        public DataTable Get_PerJurTipInversion(BE_ReqPerJurSecEconomico Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_Personas Obj = new DA_Personas();
            return Obj.Get_PerJurTipInversion(Request);

        }

        public string getDelegadoAnduser(BE_Req_Persona Request)
        {
            DAPersona ObjPersona = new DAPersona();
            return ObjPersona.getDelegadoAnduser(Request);
        }

        //-----------
        //PerIdioma
        //-----------
        //Insert PerIdioma
        public BE_ResGenerico InsPerIdioma(BE_ReqPerIdioma Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Personas Obj = new DA_Personas();
            Item = Obj.InsPerIdioma(Request);
            return Item;
        }

        public Boolean setDelegado(BE_Req_Persona Request)
        {
            DAPersona ObjPersona = new DAPersona();
            return ObjPersona.setDelegado(Request);
        }

        public DataTable Get_PerIdioma(BE_ReqPerIdioma Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_Personas Obj = new DA_Personas();
            return Obj.Get_PerIdioma(Request);

        }

        public Boolean delDelegado(BE_Req_Persona Request)
        {
            DAPersona ObjPersona = new DAPersona();
            return ObjPersona.delDelegado(Request);
        }

        //Get_AfiliacionFondo
        public DataTable Get_AfiliacionFondo(BE_ReqAfilicacion Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_Personas Obj = new DA_Personas();
            return Obj.Get_AfiliacionFondo(Request);

        }

        //[usp_Get_ExistePerIdentifica]
        public int Get_ExistePerIdentifica(BE_ReqPerIdentifica Request)
        {
            DA_Personas Obj = new DA_Personas();
            return Obj.Get_ExistePerIdentifica(Request);

        }

        //---------------------
        //Obtener Calculo Edad
        //---------------------
        public string Get_ObtenerEdad(DateTime dFecnaci) 
        {
            BE_ReqPersona Request = new BE_ReqPersona();
            DA_Personas Obj = new DA_Personas();
            Request.dFecha = dFecnaci;
            return Obj.Get_ObtenerEdad(Request);

        }

        //---------------------------------
        //Obtener NewIdPersona for Sucursal
        //---------------------------------
        public string Get_NewIdcPerCodigo_Out(String cPerJurCodigo)
        {
            BE_ReqPersona Request = new BE_ReqPersona();
            DA_Personas Obj = new DA_Personas();
            Request.cPerJurCodigo = cPerJurCodigo;
            return Obj.Get_NewIdcPerCodigo_Out(Request);

        }

        //---------------------------------------------
        // Get Persona con PerRelacion for nPerRelTipo 
        //---------------------------------------------
        public DataTable Get_List_Persona_PerRelacion_for_nPerRelTipo(int nPerRelTipo)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();

            BE_Req_Persona Request = new BE_Req_Persona();
            DA_Personas Obj = new DA_Personas();

            Request.nPerRelTipo = nPerRelTipo;
            return Obj.Get_List_Persona_PerRelacion_for_nPerRelTipo(Request);

        }


        public DataTable Get_ListPer_By_cPerRelTipo(string pcPerRelTipo)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();

            BE_Req_Persona Request = new BE_Req_Persona();
            DA_Personas Obj = new DA_Personas();

            Request.cPerRelTipo = pcPerRelTipo;
            return Obj.Get_ListPer_By_cPerRelTipo(Request);

        }
        


        //-----------------------------------------------------------------------------
        // Get Persona con PerJuridica for nPerJurTipInversion and nPerJurSecEconomico 
        //-----------------------------------------------------------------------------
        public DataTable Get_List_Persona_PerJuridica_for_nPerJurTipInversion_and_nPerJurSecEconomico(int nPerJurTipInversion, int nPerJurSecEconomico)
        {
            DataTable dt = new DataTable();

            BE_ReqPerJuridica Request = new BE_ReqPerJuridica();
            DA_Personas Obj = new DA_Personas();

            Request.nPerJurTipInversion = nPerJurTipInversion;
            Request.nPerJurSecEconomico = nPerJurSecEconomico;
            return Obj.Get_List_Persona_PerJuridica_for_nPerJurTipInversion_and_nPerJurSecEconomico(Request);

        }


        //----------------
        //Insert PerMedico
        //----------------
        public bool Ins_PerMedico(BE_ReqPersona Request)
        {
            DA_Personas Obj = new DA_Personas();
            return Obj.Ins_PerMedico(Request);
        }

        //----------------
        //Insert Médico Detalle
        //----------------
        public bool Ins_PerMedicoDetalle(BE_ReqPersona Request)
        {
            DA_Personas Obj = new DA_Personas();
            return Obj.Ins_PerMedicoDetalle(Request);
        }

        /*
         * Create: Enrique Incio
         * Fecha: 2016-05-16
         * Coments: Servicio para Guardar Persona aplicando POO
         */
        public bool GuardarPersona(string cPerCodigo, string cPerApellido, string cPerNombre, int nPerTipo, DateTime dPerNacimiento, string cUbiGeoCodigo, int nUbiGeoCodigo,
                                    int nPerIdeTipo, string cPerIdeNumero,
                                    string cPerApellPaterno, string cPerApellMaterno, string cPerPriNombre, string cPerSegNombre, string cPerTerNombre, int nPerTratamiento,
                                    int nPerNatSexo, int nPerNatEstCivil = 0, int nPerNatTipResidencia = 0, int nPerNatSitLaboral=0, int nPerNatOcupacion=0)
        {
            bool exito = false;

            try
            {
                using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required)) {

                    Persona objPersona = new Persona();

                    objPersona.cPerCodigo = cPerCodigo;
                    objPersona.cPerApellido = cPerApellido;
                    objPersona.cPerNombre = cPerNombre;
                    objPersona.nPerTipo = nPerTipo;
                    objPersona.dPerNacimiento = dPerNacimiento;
                    objPersona.cUbiGeoCodigo = cUbiGeoCodigo;
                    objPersona.nUbiGeoCodigo = nUbiGeoCodigo;

                    if(!Insert_Persona(objPersona)){
                        throw new ApplicationException("Se encontraron errores en la transaccion: Insert_Persona.!");
                    }

                    PerIdentifica objPerIdentifica = new PerIdentifica();

                    objPerIdentifica.cPerCodigo = cPerCodigo;
                    objPerIdentifica.nPerIdeTipo = nPerIdeTipo;
                    objPerIdentifica.cPerIdeNumero = cPerIdeNumero;

                    if (!Insert_PerIdentifica(objPerIdentifica))
                    {
                        throw new ApplicationException("Se encontraron errores en la transaccion: Insert_PerIdentifica.!");
                    }

                    PerNatural objPerNatural = new PerNatural();

                    objPerNatural.cPerCodigo = cPerCodigo;
                    objPerNatural.nPerNatSexo = nPerNatSexo;
                    objPerNatural.nPerNatEstCivil = nPerNatEstCivil;
                    objPerNatural.nPerNatTipResidencia = nPerNatTipResidencia;
                    objPerNatural.nPerNatSitLaboral = nPerNatSitLaboral;
                    objPerNatural.nPerNatOcupacion = nPerNatOcupacion;

                    if (!Insert_PerNatural(objPerNatural))
                    {
                        throw new ApplicationException("Se encontraron errores en la transaccion: Insert_PerNatural.!");
                    }

                    PerName objPerName = new PerName();

                    objPerName.cPerCodigo = cPerCodigo;
                    objPerName.cPerApellPaterno = cPerApellPaterno;
                    objPerName.cPerApellMaterno = cPerApellMaterno;
                    objPerName.cPerPriNombre = cPerPriNombre;
                    objPerName.cPerSegNombre = cPerSegNombre;
                    objPerName.cPerTerNombre = cPerTerNombre;
                    objPerName.nPerTratamiento = nPerTratamiento;

                    if (!Insert_PerName(objPerName))
                    {
                        throw new ApplicationException("Se encontraron errores en la transaccion: Insert_PerName.!");
                    }
   
                    exito = true;

                    tx.Complete();
                }
                
            }
            catch (Exception)
            {
                
                throw;
            }

            return exito;
        }


        public DataTable Get_Busqueda_Terceros_By_Tipo_Descr(BE_Req_Persona Request)
        {
            DAPersona ObjPersona = new DAPersona();
            return ObjPersona.Get_Busqueda_Terceros_By_Tipo_Descr(Request);
        }


        public BE_ReqPersona Get_Trabajador_By_TipoDoc_DocId(BE_ReqPerIdentifica Request)
        {
            BE_ReqPersona obj = new BE_ReqPersona();
            DA_Personas ObjPersona = new DA_Personas();
            DataTable dt = new DataTable();
            dt = ObjPersona.Get_Trabajador_By_TipoDoc_DocId(Request);
            
            foreach (DataRow row in dt.Rows)
            {
                obj.cPerCodigo = row["cPerCodigo"].ToString();
                obj.cNombreCompleto = row["cNombres"].ToString();
                obj.cPerIdeNumero = row["cPerIdeNumero"].ToString();
            }

            return obj;
        }

    }
}
