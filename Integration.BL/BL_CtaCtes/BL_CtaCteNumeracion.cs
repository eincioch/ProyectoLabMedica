using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.CtasCtes;
using Integration.BE;
using Integration.DAService;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL
{
    public class BL_CtaCteNumeracion
    {
        //------------------------
        //Insert CtaCteNumeracion
        //------------------------
        public BE_ResGenerico InsCtaCteNumeracion(BE_ReqCtaCteNumeracion Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_CtaCteNumeracion Obj = new DA_CtaCteNumeracion();
            Item = Obj.InsCtaCteNumeracion(Request);
            return Item;
        }

        //UpdCtaCteNumeracion
        public BE_ResGenerico UpdCtaCteNumeracion(BE_ReqCtaCteNumeracion Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_CtaCteNumeracion Obj = new DA_CtaCteNumeracion();
            Item = Obj.UpdCtaCteNumeracion(Request);
            return Item;
        }

        //Get_CtaCteNumeracion
        public DataTable Get_CtaCteNumeracion(BE_ReqCtaCteNumeracion Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_CtaCteNumeracion Obj = new DA_CtaCteNumeracion();
            return Obj.Get_CtaCteNumeracion(Request);

        }


        //Obtener Correlativo "CtaCteNumeracion" por tipo docu.
        //Update 2016-07-15 (EINCIO)
        public string Get_CtaCteNumCorrelativo(string StrcPerJuridica, long nCajCodigo, long nComCodigo, string cCtaCteSerie)
        {
            BE_ReqCtaCteNumeracion Request = new BE_ReqCtaCteNumeracion();
            DA_CtaCteNumeracion Obj = new DA_CtaCteNumeracion();

            Request.cPerJurCodigo = StrcPerJuridica;
            Request.nCajCodigo = nCajCodigo;
            Request.nComCodigo = nComCodigo;
            Request.cCtaCteSerie = cCtaCteSerie;

            return Obj.Get_CtaCteNumCorrelativo(Request);

        }

        //Update Correlativo Docu-Venta 
        //2016-07-15 (EINCIO)
        public bool Upd_CtaCteNumeracion_nCtaCteNumero(string cPerJurCodigo, long nCajCodigo, long nCtaCteComCodigo, long cCtaCteComNumero, string cCtaCteSerie)
        {
            BE_ReqUpdCtaCteNumeracion Request = new BE_ReqUpdCtaCteNumeracion();
            DA_CtaCteNumeracion da = new DA_CtaCteNumeracion();

            Request.cPerJurCodigo = cPerJurCodigo;
            Request.nCajCodigo = nCajCodigo;
            Request.nCtaCteComCodigo = nCtaCteComCodigo;
            Request.cCtaCteComNumero = cCtaCteComNumero;
            Request.cCtaCteSerie = cCtaCteSerie;

            return da.Upd_CtaCteNumeracion_nCtaCteNumero(Request);  
        }

        //Add 2015-11-26 (eincio)

        //------------------------------------
        // Medica.CtaCteDatosImpresora
        //------------------------------------

        //Get_Medica_CtaCteDatosImpresora_by_cPerJurCodigo
        public DataTable Get_Medica_CtaCteDatosImpresora_by_cPerJurCodigo(BE_ReqCtaCteNumeracion Request)
        {
            DataTable dt = new DataTable();
            DA_CtaCteNumeracion Obj = new DA_CtaCteNumeracion();
            return Obj.Get_Medica_CtaCteDatosImpresora_by_cPerJurCodigo(Request);

        }

        public bool Ins_Medica_CtaCteDatosImpresora(BE_ReqCtaCteNumeracion Objeto)
        {
            DA_CtaCteNumeracion da = new DA_CtaCteNumeracion();
            return da.Ins_Medica_CtaCteDatosImpresora(Objeto);
        }

        public bool Upd_Medica_CtaCteDatosImpresora(BE_ReqCtaCteNumeracion Objeto)
        {
            DA_CtaCteNumeracion da = new DA_CtaCteNumeracion();
            return da.Upd_Medica_CtaCteDatosImpresora(Objeto);
        }
    }
}
