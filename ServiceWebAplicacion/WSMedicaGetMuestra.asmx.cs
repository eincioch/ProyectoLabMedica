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
    public class WSMedicaGetMuestra : ServicioSeguro  //System.Web.Services.WebService
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
        public Muestra[] ConsultarMuestra(string cIntJerarquia="")
        {
            try
            {
                List<Muestra> lista = new List<Muestra>();
                BE_ReqCtaCteServicio Objeto = new BE_ReqCtaCteServicio();

                if (VerificarPermisos(CredencialAutenticacion))
                {
                    BLCtaCteListaServicio Servicio = new BLCtaCteListaServicio();
                    
                    DataTable dt = new DataTable();

                    Objeto.cCtaCteSerJerarquia = cIntJerarquia;

                    dt = Servicio.Get_Android_SQL_Examenes_by_cIntJerarquia(Objeto);

                    foreach (DataRow row in dt.Rows)
                    {
                        lista.Add(new Muestra(
                                Convert.ToString(row[0]),
                                Convert.ToString(row[1]),
                                Convert.ToString(row[2]),
                                Convert.ToDouble(row[3]),
                                Convert.ToString(row[4]),
                                Convert.ToString(row[5]),
                                Convert.ToString(row[6])
                            ));
                    }
                }
                else
                {
                    //return null;
                    lista.Add(new Muestra("", "", "Credenciales no validas.", 0, "", "",""));
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
        public Medico[] ListaMedicoByPromotor(String cPerPromCodigo) { //BE_Req_Medico Object) {
            try
            {
                List<Medico> lista = new List<Medico>();

                if (VerificarPermisos(CredencialAutenticacion)){

                    BE_Req_Medico Object = new BE_Req_Medico();
                    Object.cPerPromCodigo = cPerPromCodigo;
                    BL_Medico Servicio = new BL_Medico();
                    DataTable dt = new DataTable();

                    dt = Servicio.Android_Get_Medico_By_Promotor(Object);

                    foreach (DataRow row in dt.Rows){
                        lista.Add(new Medico(
                                Convert.ToString(row[0]),
                                Convert.ToString(row[1])
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
        public Campana[] ListarCampana(string cPerJurCodigo = "1000098770", string cFlag="C")
        {
            try
            {
                List<Campana> lista = new List<Campana>();
                BE_ReqCampana Objeto = new BE_ReqCampana();

                if (VerificarPermisos(CredencialAutenticacion))
                {
                    BL_Campana Servicio = new BL_Campana();

                    DataTable dt = new DataTable();

                    Objeto.cPerJurCodigo = cPerJurCodigo;
                    Objeto.cFlag = cFlag;

                    dt = Servicio.Android_Get_Campana_actual(Objeto);

                    foreach (DataRow row in dt.Rows)
                    {
                        lista.Add(new Campana(
                                Convert.ToInt32(row[0]),
                                Convert.ToString(row[1]),
                                Convert.ToDouble(row[2])
                            ));
                    }
                }
                else
                {
                    //return null;
                    lista.Add(new Campana(0, "Credenciales no validas", 0));
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
        public String RegistroPersona(string nPerIdeTipo,
                                        string cPerIdeNumero,
                                        string cPerApellido,
                                        string cPerNombre,
                                        string dPerNacimiento){

            string mensaje="";
            Boolean exito;

            if (VerificarPermisos(CredencialAutenticacion))
            {
                //Insert
                AndroidPersona objeto = new AndroidPersona();
                BL_Personas servicio = new BL_Personas();

                objeto.nPerIdeTipo = nPerIdeTipo;
                objeto.cPerIdeNumero = cPerIdeNumero;
                objeto.cPerApellido = cPerApellido;
                objeto.cPerNombre = cPerNombre;
                objeto.dPerNacimiento = dPerNacimiento;

                exito = servicio.Ins_Android_Persona(objeto);

                if (!exito){
                    mensaje = "Ha ocurrido un error.";
                }
                else {
                    mensaje = "Gracias por registrarse, Bienvenido a Médica.";
                }
            }
            else {
                mensaje = "Credenciales no validas.";
            }

            return mensaje;
        }

        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public MovilPersona[] BuscarPersona(string nPerIdeTipo, string cPerIdeNumero)
        {
            try
            {
                List<MovilPersona> personas = new List<MovilPersona>();

                if (VerificarPermisos(CredencialAutenticacion))
                {
                    AndroidPersona Objeto = new AndroidPersona();
                    BL_Personas Servicio = new BL_Personas();

                    DataTable dt = new DataTable();

                    Objeto.nPerIdeTipo = nPerIdeTipo;
                    Objeto.cPerIdeNumero = cPerIdeNumero;

                    dt = Servicio.Android_Get_Persona_by_nPerIdeTipo_and_cPerIdeNumero(Objeto);

                    foreach (DataRow row in dt.Rows)
                    {
                        personas.Add(new MovilPersona(
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
                    personas.Add(new MovilPersona("", "","Credenciales no validas", "",""));
                }
                return personas.ToArray();
            }
            catch (Exception ex)
            {
                throw new SoapException("Credenciales no validas.",
                     SoapException.ServerFaultCode, "Error:", ex);
            }
        }

        /*
        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public string GetCorrelativoProforma(string nPerIdeTipo, string cPerIdeNumero)
        {
            string Correlativo="";
            try
            {
                if (VerificarPermisos(CredencialAutenticacion))
                {
                    int nCorrelativo;

                    Proforma Objeto = new Proforma();
                    BL_Proforma Servicio = new BL_Proforma();

                    Objeto.nPerIdeTipo = Convert.ToInt32(nPerIdeTipo);
                    Objeto.cPerIdeNumero = cPerIdeNumero;

                    nCorrelativo = Servicio.Android_Get_Correlativo_Proforma(Objeto);

                    if (!(nCorrelativo == 0)) {
                        Correlativo = Convert.ToString(nCorrelativo);
                    }
                }

                return Correlativo;
            }
            catch (Exception ex)
            {
                throw new SoapException("Credenciales no validas.",
                     SoapException.ServerFaultCode, "Error:", ex);
            }
        }
        */

        //Guardar Proforma
        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public string GuardarProforma(string nPerIdeTipo, string cPerIdeNumero, string listProforma) // List<Proforma> listProforma)
        {
            string mensaje = "";
            try
            {
                if (VerificarPermisos(CredencialAutenticacion)) {

                    bool exito = false;
                    int correlativo = 0;

                    Proforma proformas = new Proforma();
                    BL_Proforma Servicio1 = new BL_Proforma();

                    //Obtener correlativo de la proforma
                    proformas.nPerIdeTipo = Convert.ToInt32(nPerIdeTipo);
                    proformas.cPerIdeNumero = cPerIdeNumero;
                    
                    correlativo = Servicio1.Android_Get_Correlativo_Proforma(proformas);

                    //enviamos valores a store insert proforma
                    BL_Proforma servicio = new BL_Proforma();

                    proformas.nCorrelativo = correlativo;
                    proformas.ListMuestras = listProforma;

                    exito = servicio.Android_Insert_Proforma(proformas);
                    
                    //DA_Proforma Servicio = new DA_Proforma();

                    //------------------------
                    //Insert Android Proforma
                    //-----------------------
                    /*foreach (Proforma objeto in listProforma)
                    {
                        objeto.nCorrelativo = correlativo; //paso el autogenerado 
                        exito = Servicio.Android_Insert_Proforma(objeto);

                        if (!exito)
                        {
                            break;
                            throw new ApplicationException("Se encontraron errores en la transaccion: [Android].[usp_Android_Insert_Proforma].!");
                        }
                    }*/

                    if (!exito){
                        mensaje = "Ha ocurrido un error.";
                    }
                    else{
                        mensaje = "Proforma ha sido enviada con éxito.";
                    }
                }
                else{
                    mensaje = "Credenciales no validas.";
                }

                return mensaje;

            }
            catch (Exception ex)
            {
                throw new SoapException("Credenciales no validas.",
                     SoapException.ServerFaultCode, "Error:", ex);
            }

        }


        //Obtener resulado EncuestaSatisfacción
        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public EncSatisfaccion[] Get_EncSatisfaccion(string cPerJurCodigo, string dFecIni, string dFecFin, string cFlag="C")
        {
            try
            {
                List<EncSatisfaccion> encSatisfacciones = new List<EncSatisfaccion>();

                if (VerificarPermisos(CredencialAutenticacion))
                {

                    DataTable dt = new DataTable();
                    GestionarEncSatisfaccionServicio gestionarEncSatisfaccionServicio = new GestionarEncSatisfaccionServicio();
                    dt = gestionarEncSatisfaccionServicio.Get_EncSatisfaccion(cPerJurCodigo, dFecIni, dFecFin, cFlag);

                    foreach (DataRow row in dt.Rows)
                    {
                        encSatisfacciones.Add(new EncSatisfaccion(
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
                    encSatisfacciones.Add(new EncSatisfaccion("", "", "Credenciales no válidas", ""));
                }
                return encSatisfacciones.ToArray();
            }
            catch (Exception ex)
            {
                throw new SoapException("No existe información.", SoapException.ServerFaultCode, "Error:", ex);
            }
        }






        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public Login[] LoginUsuarioCliente(String user, String password)
        {
            //string msje = "";

            List<Login> login = new List<Login>();
            //Autenticacion auten = new Autenticacion();

            //auten.UsuarioNombre = UsuarioNombre;
            //auten.UsuarioClave = UsuarioClave;

            if (VerificarPermisos(CredencialAutenticacion))
            {
            
                clsCrypt ObjEncrypt = new clsCrypt();

                BE_ReqSearhUsuario objeto = new BE_ReqSearhUsuario();
                BL_PerUsuario BLPer = new BL_PerUsuario();

                //primero de convierte a mayusculas
                string Usuario = user.ToUpper();
                string SrtPass = ObjEncrypt.EncryptByCode(Usuario, password);

                //luego se quitan los espacios
                objeto.PerCodigo = Usuario.Trim();
                objeto.cPerUsuClave = password;
                objeto.cPerUsuClave2 = SrtPass;

                DataTable dt = new DataTable();

                //dt = BLPer.Get_Persona_By_Usuario(objeto);

                dt = BLPer.Android_Get_Persona_By_UsuarioCliente(objeto);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    //if (row["cClave"].ToString() == SrtPass)
                        //Si todo va bien 
                        login.Add(new Login(
                                Convert.ToString(row[0]),
                                Convert.ToString(row[1]),
                                Convert.ToString(row[2]),
                                Convert.ToString(row[3]),
                                Convert.ToDouble(row[4])
                        ));
                    /*else
                        //msje = "Error, Usuario no existe o datos incorrectos";
                        login.Add(new Login(row["cClave"].ToString(), "", "", "", 0.0));
                    */
                }
                else
                    //msje = "Error, Usuario no existe o datos incorrectos";
                    login.Add(new Login("Usuario y/o contraseña incorrecta.", "", "", "", 0.0));
            }
            else
            {
                login.Add(new Login("Credenciales no validas.", "", "", "", 0.0));
                //msje = "Credenciales no validas.";
            }
            //return msje;
            return login.ToArray();
        }

        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public Login[] LoginUsuarioClienteRequest(BE_ReqCredencialesAndroid Object)
        {
            //string msje = "";

            List<Login> login = new List<Login>();
            
            if (VerificarPermisos(CredencialAutenticacion))
            {

                clsCrypt ObjEncrypt = new clsCrypt();

                BE_ReqSearhUsuario objeto = new BE_ReqSearhUsuario();
                BL_PerUsuario BLPer = new BL_PerUsuario();

                //primero de convierte a mayusculas
                string Usuario = Object.PerCodigo.ToUpper(); //user.ToUpper();
                string Password = Object.cPerUsuClave;
                string SrtPass = ObjEncrypt.EncryptByCode(Usuario, Password);

                //luego se quitan los espacios
                objeto.PerCodigo = Usuario.Trim();
                objeto.cPerUsuClave = Password;
                objeto.cPerUsuClave2 = SrtPass;

                DataTable dt = new DataTable();

                //dt = BLPer.Get_Persona_By_Usuario(objeto);

                dt = BLPer.Android_Get_Persona_By_UsuarioCliente(objeto);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    //if (row["cClave"].ToString() == SrtPass)
                        //Si todo va bien 
                        login.Add(new Login(
                                Convert.ToString(row[0]),
                                Convert.ToString(row[1]),
                                Convert.ToString(row[2]),
                                Convert.ToString(row[3]),
                                Convert.ToDouble(row[4])
                        ));
                    /*else
                        //msje = "Error, Usuario no existe o datos incorrectos";
                        login.Add(new Login("Contraseña incorrecta.", "", "", "", 0.0));
                    */
                }
                else
                    //msje = "Error, Usuario no existe o datos incorrectos";
                    login.Add(new Login("Usuario y/o contraseña incorrecta.", "", "", "", 0.0));
            }
            else
            {
                login.Add(new Login("Credenciales no válidas.", "", "", "", 0.0));
                //msje = "Credenciales no validas.";
            }
            
            //return msje;
            return login.ToArray();
        }




        //-----------------------------------------------
        // Android: Ver Fichas con Resultados Pacientes
        //-----------------------------------------------
        [WebMethod, SoapHeader("CredencialAutenticacion")]
        public FichaResultados[] VerFichasResultados(string cPerCodigo, string cTipo, string FecIni, string FecFin, string cBuscaTexto)
        {
            try
            {
                List<FichaResultados> lista = new List<FichaResultados>();

                if (VerificarPermisos(CredencialAutenticacion))
                {
                    BLRptMaster Servicio = new BLRptMaster();
                    DataTable dt = new DataTable();

                    dt = Servicio.Get_FichaAtencion_By_Per_RFechas(cPerCodigo, cTipo, FecIni, FecFin, cBuscaTexto);

                    foreach (DataRow row in dt.Rows)
                    {
                        lista.Add(new FichaResultados(
                                Convert.ToString(row[0]),
                                Convert.ToString(row[1]),
                                Convert.ToString(row[2]),
                                Convert.ToString(row[3]),
                                Convert.ToString(row[4]),
                                Convert.ToString(row[5]),
                                Convert.ToString(row[6]),
                                Convert.ToString(row[7]),
                                Convert.ToString(row[8]),
                                Convert.ToString(row[9]),
                                Convert.ToString(row[14]),
                                Convert.ToString(row[11]),
                                Convert.ToString(row[12])
                            ));
                    }
                }
                else
                {
                    //return null;
                    lista.Add(new FichaResultados("", "Credenciales no validas", "","","","","","","","","","",""));
                }
                return lista.ToArray();

            }
            catch (Exception ex)
            {
                throw new SoapException("Credenciales no validas.",
                     SoapException.ServerFaultCode, "Error:", ex);
            }
        }





    }
}
