using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicioHIS;
using Integration.BE.Servicios;

namespace ServicioHIS
{
    public class ConsumoServicioHIS
    {
        public Resultado_HIS EnviarTramaWS(string cTrama){

            Resultado_HIS Res_HIS = new Resultado_HIS();
            try
            {
                ServicioHIS.WS_HIS.BiomedServicesClient HIS = new ServicioHIS.WS_HIS.BiomedServicesClient();
                ServicioHIS.WS_HIS.serviceResponse SResponse;

                SResponse = HIS.proccessRequest(cTrama.Replace("chr(10)","chr(13)"));
                //SResponse = HIS.proccessRequest(cTrama);
                
                Res_HIS.Code = SResponse.code;
                Res_HIS.Descripcion = SResponse.description;

                //if (SResponse.code == "0"){
                //    cResultado = SResponse.description;
                //}
                //else{
                //    cResultado = SResponse.code + " " + SResponse.description;
                //}

            }
            catch (Exception)
            {
                throw;
            }
            //finally
            //{
            //    throw new ApplicationException(cTrama);
            //}

            return Res_HIS;
        }

    }
}
