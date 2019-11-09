using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE;
using Integration.BE.PerUsuario;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService
{
    public class DA_PerUsuario
    {
        DataTable dt = new DataTable();

        public DataTable Get_Persona_By_Usuario(BE_ReqSearhUsuario Request)
        {
            //string Item = "";
            
            try
            {
                clsConection Obj = new clsConection();
                
                string Cadena = Obj.GetConexionString("Naylamp");
                //string Cadena = "Server=10.0.0.10\\SRVDATOSMED; DataBase = BDDatos; Uid = android; Pwd =C2879442C28147B;Integrated Security=False; Pooling = False";

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "usp_Acceso_Get_Persona_By_Usuario";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerUsuCodigo", Request.PerCodigo);
                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public DataTable Android_Get_Persona_By_Usuario(BE_ReqSearhUsuario Request)
        {
            //string Item = "";

            try
            {
                clsConection Obj = new clsConection();
                //string Cadena = Obj.GetConexionString("Naylamp");
                string Cadena = "Server=10.0.0.10\\SRVDATOSMED; DataBase = BDDatos; Uid = android; Pwd =C2879442C28147B;Integrated Security=False; Pooling = False";

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "usp_Android_Acceso_Get_Persona_By_Usuario";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerUsuCodigo", Request.PerCodigo);
                        cm.Parameters.AddWithValue("cModulo", Request.cModulo);
                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public DataTable Android_Get_Persona_By_UsuarioCliente(BE_ReqSearhUsuario Request)
        {
            //string Item = "";

            try
            {
                clsConection Obj = new clsConection();
                //string Cadena = Obj.GetConexionString("Naylamp");
                string Cadena = "Server=10.0.0.10\\SRVDATOSMED; DataBase = BDDatos; Uid = android; Pwd =C2879442C28147B;Integrated Security=False; Pooling = False";

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "Android_USP_Admision_Get_ValidarUsuario_by_Usu";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerUsuCodigo", Request.PerCodigo);
                        cm.Parameters.AddWithValue("@cPerUsuClave", Request.cPerUsuClave);
                        cm.Parameters.AddWithValue("@cPerUsuClave2", Request.cPerUsuClave2);
                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }




        public DataTable Get_SearhUsuario(BE_ReqSearhUsuario  Request)
        {
            //string Item = "";
            
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "usp_Get_PerUsuario";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.PerCodigo);
                        cm.Parameters.AddWithValue("cPerUsuClave", Request.cPerUsuClave);
                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public BE_ResGenerico UpdChangePassword(BE_ReqSearhUsuario Request)
        {
            BE_ResGenerico Item = new BE_ResGenerico();
            long Resultado = 0;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "usp_Upd_ChangePasswordPerUsuario";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.PerCodigo );
                        cm.Parameters.AddWithValue("cPerUsuClaveNew", Request.cPerUsuClave );
                        cm.Connection = cn;
                        Resultado = cm.ExecuteNonQuery();
                        Item.Resultado = Resultado;
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return Item;
        }

        public DataTable Get_CboListUsuario(BE_ReqSearhUsuario Request)
        {
            //string Item = "";
            //DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "usp_Acceso_Usuarios_By_Modulo";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cModulo", Request.cModulo);
                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }


        //Obtiene Usuario con permisos especiales
        public DataTable Get_CboListUsuarioAutorizado(BE_ReqSearhUsuario Request)
        {
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Acceso_Get_Usuarios_By_Mod_PermisoEsp]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nSisGruCodigo", Request.nSisGruCodigo);
                        cm.Parameters.AddWithValue("nObjCodigo", Request.nObjCodigo);
                        cm.Connection = cn;
                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        //Valida acceso a Usuario con acceso especiales
        public DataTable Get_UsuarioAutorizado(BE_ReqSearhUsuario Request)
        {
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Acceso_Get_Persona_By_Usuario_PermEsp]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerUsuCodigo", Request.cPerUsuCodigo);
                        cm.Parameters.AddWithValue("nSisGruCodigo", Request.nSisGruCodigo);
                        cm.Parameters.AddWithValue("nObjCodigo", Request.nObjCodigo);
                        cm.Connection = cn;
                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        //Obtener clave token
        public DataTable ADMISION_Get_Token_By_Per_Sede_Tipo(BE_ReqSearhUsuario Request)
        {
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[USP_ADMISION_Get_Token_By_Per_Sede_Tipo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPercodigo );
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nTipo", Request.nObjCodigo);
                        cm.Connection = cn;
                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }


        public BE_ResGenerico Insert_PerUsuarioCliente(BE_ReqSearhUsuario Request)
        {
            BE_ResGenerico Item = new BE_ResGenerico();
            long Resultado = 0;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "usp_Admision_Insert_PerUsuarioCliente";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.PerCodigo);
                        cm.Connection = cn;
                        Resultado = cm.ExecuteNonQuery();
                        Item.Resultado = Resultado;
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return Item;
        }

    }
}
