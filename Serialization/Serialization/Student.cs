using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    [XmlRoot("STUDENT")]
    public class Student
    {
        [XmlElement("ID")]
        public int Id;
        [XmlElement("NAME")]
        public string Name;
        [XmlElement("AGE")]
        public int Age;
    }
}
