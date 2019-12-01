using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClientApplication.Model
{
    [Serializable]
    public class FacultySend
    {
        public int КодФакульт { get; set; }
        public string Факультет { get; set; }
        public string Руководитель { get; set; }
        public string Адрес { get; set; }

        // запись в xml
        public static void WriteToXml(string words)
        {
            File.Delete("DeserializeFile/FacultySend.xml");
            using (StreamWriter writer = new StreamWriter("DeserializeFile/FacultySend.xml"))
            {
                writer.Write(words);
            }
        }

        public static List<FacultySend> DeserializeFileXml()
        {
            using (FileStream fs = new FileStream("DeserializeFile/FacultySend.xml", FileMode.Open))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<FacultySend>));

                return (List<FacultySend>)formatter.Deserialize(fs);
            }
        }
    }
}
