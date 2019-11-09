using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Web.Services.Protocols;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ServiceWebAplicacion.bean;

using Integration.BL.BL_CtaCteListaServicio;
using Integration.BL.BL_Campana;
using Integration.BL.BL_Android;
using Integration.BL.BL_Persona;
using Integration.BL.BL_Reportes;
using Integration.DAService.DA_Android;
using Integration.BL;
using Integration.BE.Android;
using Integration.BE.CtasCtes;
using Integration.BE.Persona;
using Integration.BE.Campana;
using Integration.Conection;
using Integration.DataIntegration;

using Integration.BE.PerUsuario;

namespace ServiceWebAplicacion
{
    /// <summary>
    /// Descripción breve de WSMedicaGetMuestra
    /// </summary>
    [WebService(Namespace = "http://medica.net/SecureWebService/SecureWebService")]

    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSMedicaMedicos : ServicioSeguro  //System.Web.Services.WebService
    {
        public static Boolean VerificarPermisos(Autenticacion value)
        {
            CredencialWS credencial = new CredencialWS();

            if (value == null)
            {
                return false;
            }
            else
            {
                //Verifica los permiso Ej. Consulta a BD 
                if (value.UsuarioNombre == credencial.UsuarioNombre && value.UsuarioClave == credencial.UsuarioClave)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public Medico[] ListaMedicoByPromotor(String cPerPromCodigo)
        { //BE_Req_Medico Object) {
            try
            {
                List<Medico> lista = new List<Medico>();

                if (VerificarPermisos(CredencialAutenticacion))
                {

                    BE_Req_Medico Object = new BE_Req_Medico();
                    Object.cPerPromCodigo = cPerPromCodigo;
                    BL_Medico Servicio = new BL_Medico();
                    DataTable dt = new DataTable();

                    dt = Servicio.Android_Get_Medico_By_Promotor(Object);

                    foreach (DataRow row in dt.Rows)
                    {
                        lista.Add(new Medico(
                                Convert.ToString(row[0]),
                                Convert.ToString(row[1]),
                                Convert.ToString(row[2]),
                                Convert.ToString(row[3])
                            ));
                    }
                }
                else
                {
                    //return null;
                    lista.Add(new Medico("", "Credenciales no válidas."));
                }
                return lista.ToArray();
            }
            catch (Exception ex)
            {
                throw new SoapException("Credenciales no válidas.",
                     SoapException.ServerFaultCode, "Error:", ex);
            }
        }

        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public Medico[] ListaAsignacionesByPromotor(String cPerPromCodigo)
        { //BE_Req_Medico Object) {
            try
            {
                List<Medico> lista = new List<Medico>();

                if (VerificarPermisos(CredencialAutenticacion))
                {

                    BE_Req_Medico Object = new BE_Req_Medico();
                    Object.cPerPromCodigo = cPerPromCodigo;
                    BL_Medico Servicio = new BL_Medico();
                    DataTable dt = new DataTable();

                    dt = Servicio.Android_Get_Asignaciones_By_Promotor(Object);

                    foreach (DataRow row in dt.Rows)
                    {
                        lista.Add(new Medico(
                                Convert.ToString(row[0]),
                                Convert.ToString(row[1]),
                                Convert.ToString(row[2]),
                                Convert.ToString(row[3])
                            ));
                    }
                }
                else
                {
                    //return null;
                    lista.Add(new Medico("", "Credenciales no válidas."));
                }
                return lista.ToArray();
            }
            catch (Exception ex)
            {
                throw new SoapException("Credenciales no válidas.",
                     SoapException.ServerFaultCode, "Error:", ex);
            }
        }


        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public MedicoDetalle[] ConsultarMedicoByCodigo(string cPerPromCodigo, string cPerAsigCodigo)
        {
            try
            {
                List<MedicoDetalle> lista = new List<MedicoDetalle>();
                PerAsigPromotor Objeto = new PerAsigPromotor();

                if (VerificarPermisos(CredencialAutenticacion))
                {
                    GestionarPerAsigPromotorServicio Servicio = new GestionarPerAsigPromotorServicio();

                    DataTable dt = new DataTable();

                    Objeto.cPerPromCodigo = cPerPromCodigo;
                    Objeto.cPerAsigCodigo = cPerAsigCodigo;

                    dt = Servicio.Get_DatosMedico_by_cPerPromCodigo_NombresMedico(Objeto);

                    foreach (DataRow row in dt.Rows)
                    {
                        lista.Add(new MedicoDetalle(
                                Convert.ToString(row[0]), 
                                Convert.ToString(row[1]),
                                Convert.ToString(row[2]),
                                Convert.ToString(row[3]),
                                Convert.ToString(row[4]),
                                Convert.ToString(row[5]),
                                Convert.ToString(row[6]),
                                Convert.ToString(row[7]),
                                Convert.ToString(row[8]),
                                Convert.ToDouble(row[9]),
                                Convert.ToInt32(row[10]),
                                Convert.ToString(row[11]),
                                Convert.ToString(row[12]),
                                Convert.ToInt32(row[13])
                            ));
                    }
                }
                else
                {
                    //return null;
                    lista.Add(new MedicoDetalle("", "", "Credenciales no validas.", "", "", "", "", "", "", 0 , 0, "", "", 0));
                }
                return lista.ToArray();

            }
            catch (Exception ex)
            {
                throw new SoapException("Credenciales no validas.",
                     SoapException.ServerFaultCode, "Error:", ex);
            }
        }






        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public String RegistraVisitaMedico(string pcPerPromCodigo, string pcPerAsigCodigo, string pcVisLatitud, string pcVisLongitud, string pcVisObservacion = "")
        {

            string mensaje = "";
            Boolean exito;

            if (VerificarPermisos(CredencialAutenticacion))
            {
                //Insert
                VisitaMedico objeto = new VisitaMedico();
                BL_VisitaMedico servicio = new BL_VisitaMedico();

                
                objeto.cPerPromCodigo = pcPerPromCodigo;
                objeto.cPerAsigCodigo = pcPerAsigCodigo;

                objeto.dVisLatitud = Convert.ToDouble(pcVisLatitud);
                objeto.dVisLongitud = Convert.ToDouble(pcVisLongitud);
                objeto.cVisObservacion = pcVisObservacion;

                exito = servicio.Android_Insert_Visita_Medico(objeto);

                if (!exito)
                {
                    mensaje = "Ha ocurrido un error.";
                }
                else
                {
                    mensaje = "Visita registrada con éxito.!";
                }
            }
            else
            {
                mensaje = "Credenciales no válidas.";
            }

            return mensaje;
        }


        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public VisitaDiaMedico[] ListaVisitaDiariaMedicoByPromotor(String cPerPromCodigo, String cFecha)
        { //BE_Req_Medico Object) {
            try
            {
                List<VisitaDiaMedico> lista = new List<VisitaDiaMedico>();

                if (VerificarPermisos(CredencialAutenticacion))
                {

                    VisitaMedico Objeto = new VisitaMedico();
                    Objeto.cPerPromCodigo = cPerPromCodigo;
                    Objeto.dVisFechaHora = cFecha;
                    BL_VisitaMedico Servicio = new BL_VisitaMedico();
                    DataTable dt = new DataTable();

                    dt = Servicio.Android_Get_VisitaDiariaMedico_by_Promotor(Objeto);

                    foreach (DataRow row in dt.Rows)
                    {
                        lista.Add(new VisitaDiaMedico(
                                Convert.ToString(row[0]),
                                Convert.ToString(row[1]),
                                Convert.ToString(row[2]),
                                Convert.ToString(row[3]),
                                Convert.ToString(row[4])
                            ));
                    }
                }
                else
                {
                    //return null;
                    lista.Add(new VisitaDiaMedico("", "Credenciales no válidas.","","",""));
                }
                return lista.ToArray();
            }
            catch (Exception ex)
            {
                throw new SoapException("Credenciales no válidas.",
                     SoapException.ServerFaultCode, "Error:", ex);
            }
        }


    }
}
