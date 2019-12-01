using ServerApplication.ModelClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApplication.RequestsClient
{
    class GetFacultySend
    {
        public static string GetTD()
        {
            try
            {
                // сериализация данных
                FacultySend.DataSerializable();
                // счит данных
                return FacultySend.ReadToXml();
            }
            catch (Exception ex)
            {
                return "Ошибка " + ex;
            }
        }
    }
}
