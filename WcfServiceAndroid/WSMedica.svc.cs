using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


using System.Web.Services.Protocols;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using Integration.BL;
using Integration.BL.GestionarAdmSolPerTokenServicio;
using Integration.BL.BL_Reportes;
using Integration.BL.BL_Android;
using Integration.BE.PerUsuario;
using Integration.BE.AdmSolPerToken;
using Integration.Conection;
using Integration.DataIntegration;
using ServiceWebAplicacion.bean;
using System.Web.Services;

namespace WcfServiceAndroid
{
    [WebService(Namespace = "http://medica.net/SecureWebService/SecureWebService")]

    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        public Login[] LoginUsuario(String user, String password)
        {
            //string msje = "";

            List<Login> login = new List<Login>();
            //Autenticacion auten = new Autenticacion();

            //auten.UsuarioNombre = UsuarioNombre;
            //auten.UsuarioClave = UsuarioClave;

           
                clsCrypt ObjEncrypt = new clsCrypt();

                BE_ReqSearhUsuario objeto = new BE_ReqSearhUsuario();
                BL_PerUsuario BLPer = new BL_PerUsuario();

                //primero de convierte a mayusculas
                string Usuario = user.ToUpper();
                string SrtPass = ObjEncrypt.EncryptByCode(Usuario, password);

                //luego se quitan los espacios
                objeto.PerCodigo = Usuario.Trim();
                objeto.cPerUsuClave = SrtPass;
                objeto.cModulo = "27"; //27-> Modulo Android

                DataTable dt = new DataTable();

                //dt = BLPer.Get_Persona_By_Usuario(objeto);

                dt = BLPer.Android_Get_Persona_By_Usuario(objeto);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    if (row["cClave"].ToString() == SrtPass)
                        //Si todo va bien 
                        login.Add(new Login(
                                Convert.ToString(row[0]),
                                Convert.ToString(row[1]),
                                Convert.ToString(row[2]),
                                Convert.ToString(row[3])
                        ));
                    else
                        //msje = "Error, Usuario no existe o datos incorrectos";
                        login.Add(new Login("Contraseña incorrecta.", "", "", ""));

                }
                else
                    //msje = "Error, Usuario no existe o datos incorrectos";
                    login.Add(new Login("Usuario no registrado.", "", "", ""));
           
            //return msje;
            return login.ToArray();
        }




    }
}
