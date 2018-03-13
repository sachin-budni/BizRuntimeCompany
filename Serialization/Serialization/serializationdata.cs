using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [DataContract]
    class BlogSite
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
    class serializationdata
    {

        static void ddata()
        {
            BlogSite bsObj = new BlogSite()
            {
                Name = "C-sharpcorner",
                Description = "Share Knowledge"
            };
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(BlogSite));
            MemoryStream msObj = new MemoryStream();
            js.WriteObject(msObj, bsObj);
            msObj.Position = 0;
            StreamReader sr = new StreamReader(msObj);

            // "{\"Description\":\"Share Knowledge\",\"Name\":\"C-sharpcorner\"}"  
            string json = sr.ReadToEnd();
            Console.WriteLine(json);

            sr.Close();
            msObj.Close();
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            ddata();
        }
    }
}
