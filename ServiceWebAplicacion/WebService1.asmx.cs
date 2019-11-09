using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Integration.BL;
using Integration.BL.BL_Reportes;
using Integration.BE.PerUsuario;
using Integration.Conection;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace ServiceWebAplicacion
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://medica.net/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Bienvenidos soy un WebService Médica.";
        }

        [WebMethod]
        public String LoginUsuario(String user, String password)
        {
            string msje = "";
            clsCrypt ObjEncrypt = new clsCrypt();

            BE_ReqSearhUsuario objeto = new BE_ReqSearhUsuario();
            BL_PerUsuario BLPer = new BL_PerUsuario();

            //primero de convierte a mayusculas
            string Usuario = user.ToUpper();
            string SrtPass = ObjEncrypt.EncryptByCode(Usuario, password);

            //luego se quitan los espacios
            objeto.PerCodigo = Usuario.Trim();
            objeto.cPerUsuClave = SrtPass;
            objeto.cModulo = "27";
            DataTable dt = new DataTable();

            dt = BLPer.Android_Get_Persona_By_Usuario(objeto);

            if (dt.Rows.Count > 0 ){
                DataRow row = dt.Rows[0];
                if (row["cClave"].ToString() == SrtPass)
                    msje = "Gracias por Iniciar Sesión";
                else
                    msje="Error, Usuario no existe o datos incorrectos";
            }
            else
                msje = "Error, Usuario no existe o datos incorrectos";

            return msje;
        }


        
        [WebMethod]
        public Ventas[] VerVentas(string FecIni, string FecFin)
        {

            BLRptMaster Servicio = new BLRptMaster();

            DataTable dt = new DataTable();

            dt = Servicio.Get_Venta_by_cPerJurCodigo_and_fecini_fecfin_01("", "2015/12/10'", "2015/12/10'");

            List<Ventas> lista = new List<Ventas>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Ventas(
                        Convert.ToString(row[0]),
                        Convert.ToString(row[1]),
                        Convert.ToInt32(row[2]),
                        Convert.ToInt32(row[3]),
                        Convert.ToDouble(row[4]),
                        Convert.ToDouble(row[5]),
                        Convert.ToString(row[6]),
                        Convert.ToDouble(row[7]),
                        Convert.ToDouble(row[8]),
                        Convert.ToDouble(row[9]),
                        Convert.ToDouble(row[10]),
                        Convert.ToDouble(row[11]),
                        Convert.ToDouble(row[12]),
                        Convert.ToDouble(row[13]),
                        Convert.ToDouble(row[14])
                    ));
            }

            return lista.ToArray();
        }
        
    }
}
