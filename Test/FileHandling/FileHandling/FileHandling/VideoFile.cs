using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Json;

namespace FileHandling
{
    public class Document
    {
        //public int DocId { get; set; }
        public string DocName { get; set; }
        public byte[] DocContent { get; set; }
    }
    class VideoFile
    {
        public Document FileToByteArray(string fileName)
        {
            byte[] fileContent = null;

            FileStream fs = new FileStream(fileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fs);

            long byteLength = new FileInfo(fileName).Length;
            fileContent = binaryReader.ReadBytes((Int32)byteLength);
            //foreach(var arr in fileContent)
            //{
            //    Console.WriteLine(arr);
            //}
            Document document= new Document();
            document.DocName = fileName;
            Console.WriteLine(fileName);
            document.DocContent = fileContent;
            Console.WriteLine(fileContent);
            Console.WriteLine(document.DocContent);
            //var serial = new JavaScriptSerializer().Serialize(document);
            //Console.WriteLine(serial);
            fs.Close();
            binaryReader.Close();
            
            DataContractJsonSerializer json = new DataContractJsonSerializer(document.GetType());
            MemoryStream stream = new MemoryStream();
            json.WriteObject(stream, document);
            stream.Position = 0;
            StreamReader reader = new StreamReader(stream);
            string s1 = reader.ReadToEnd();
            char[] chars = s1.ToCharArray();
            byte[] bytes = Encoding.ASCII.GetBytes(chars);
            //Console.WriteLine(bytes);
            
           // string data = Encoding.ASCII.GetString(bytes);
            //Console.WriteLine(data);


            foreach (var list in bytes)
            {
                Console.WriteLine(list);
            }
            // Console.WriteLine(s1);
            StreamWriter writer = new StreamWriter("datacontactjson.json");
            writer.WriteLine(bytes);
           // writer.WriteLine(data);

            //Console.WriteLine("DataContractJsonSerializer from the Output");
            reader.Close();
            writer.Close();
            stream.Close();
            return document;
        }
        static void Main(string[] args)
        {
            VideoFile v1 = new VideoFile();
            v1.FileToByteArray("G:\\JOB INTERVIEW\\cartoon.mp4");
            Console.ReadKey();
        }
    }
}
