using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ServerApplication.ModelClient
{
    [Serializable]
    public class FacultySend
    {
        public int КодФакульт { get; set; }
        public string Факультет { get; set; }
        public string Руководитель { get; set; }
        public string Адрес { get; set; }

        public static List<FacultySend> GetData()
        {
            List<FacultySend> facultySends = new List<FacultySend>();

            using (ModelDB db = new ModelDB())
            {
                foreach (Факультеты t in db.Факультеты)
                {
                    facultySends.Add(
                        new FacultySend()
                        {
                            КодФакульт = t.КодФакульт,
                            Факультет = t.Факультет,
                            Руководитель = t.Руководитель,
                            Адрес = t.Адрес
                        }
                        );
                }
            }

            return facultySends;
        }

        public static void DataSerializable()
        {
            List<FacultySend> facultySends = GetData();

            XmlSerializer formatter = new XmlSerializer(typeof(List<FacultySend>));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("SerializableFile/FacultySend.xml", FileMode.Create))
            {
                formatter.Serialize(fs, facultySends);
            }
        }

        public static string ReadToXml()
        {
            string xmlData = null;

            using (StreamReader reader = new StreamReader("SerializableFile/FacultySend.xml"))
            {
                xmlData = reader.ReadToEnd();
            }

            return xmlData;
        }
    }
}
