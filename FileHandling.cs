using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class Emplyee
    {
        int Id,Age;
        string Name;
        public Emplyee(int Id,string Name,int Age)
        {
            this.Id = Id;
            this.Age = Age;
            this.Name = Name;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return Id;
                else if (index == 1)
                    return Name;
                else if (index == 2)
                    return Age;
                return "";
            }
            set
            {
                if (index == 0)
                    Id = (int)value;
                else if (index == 1)
                    Name = (string)value;
                else if (index == 2)
                    Age = (int)value;
            }
        }
        public object this[string index]
        {
            get
            {
                if (index.ToUpper() == "ID")
                    return Id;
                else if (index.ToUpper() == "NAME")
                    return Name;
                else if (index.ToUpper() == "AGE")
                    return Age;
                return "";
            }
            set
            {
                if (index.ToUpper() == "ID")
                    Id = (int)value;
                else if (index.ToUpper() == "NAME")
                    Name = (string)value;
                else if (index.ToUpper() == "AGE")
                    Age = (int)value;
            }
        }
    }
   
    class FileHandling
    {
        public static void BinaryWriter()
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open("data4.dat", FileMode.OpenOrCreate)))
            {
                //Console.WriteLine("good");
                bw.Write("<a src='google.com'>");
                bw.Write("Google");
                bw.Write(25);
                bw.Write("</a>");
            }
            Console.WriteLine("Binery Writer");

            using (BinaryReader br = new BinaryReader(File.Open(("data4.dat"), FileMode.OpenOrCreate)))
            {
                Console.WriteLine(br.ReadString());
                Console.WriteLine(br.ReadString());
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadString());
            }
            Console.WriteLine("binery reader");
        }
        public static void TextWriter()
        {
            using (TextWriter tw = File.CreateText("data3.txt"))
            {
                tw.WriteLine("kjshfjksngkjhsdfjgnkjfg");
                tw.WriteLine("dfjsglksjhgkjndfgklgkhgf");
            }
            Console.WriteLine("Text writer");
            using (TextReader tr = File.OpenText("data3.txt"))
            {
                Console.WriteLine(tr.ReadToEnd());
            }
            Console.WriteLine("Text reader");
        }
        public static void StreamWriter()
        {
            FileStream f1 = new FileStream("data2.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(f1);
            sw.WriteLine("dmkfjsdkfjskldfjaslkfja;kjfdkljsdfdjf");
            sw.WriteLine("djfjskfksjfkllsjflkajdsfkjskdfjsd");
            sw.Close();
            f1.Close();

            Console.WriteLine();
            Console.WriteLine("StreatWriter File create");

            FileStream f2 = new FileStream("data2.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(f2);
            string s1 = "";

            while((s1=sr.ReadLine())!=null)
            {
                Console.WriteLine(s1);
            }
        }
        public static void FileStream()
        {
            FileStream f1 = new FileStream("data1.txt", FileMode.OpenOrCreate);
            for(int i=65; i<=90; i++)
            {
                Console.Write((char)i);
                f1.WriteByte((byte)i);
            }
            Console.WriteLine();
            f1.Close();
            Console.WriteLine("File is created");
            FileStream f2 = new FileStream("data1.txt", FileMode.OpenOrCreate);
            int j = 0;
            while ((j = f2.ReadByte()) != -1)
            {
                Console.Write((char)j);
            }
            f2.Close();
        }
        static void Main(string[] args)
        {
            FileStream();
            Console.WriteLine();

            StreamWriter();
            Console.WriteLine();

            TextWriter();
            Console.WriteLine();

            BinaryWriter();
            Console.WriteLine();
            

            Emplyee e1 = new Emplyee(1, "sham", 21);
            Console.WriteLine(e1[0]);
            Console.WriteLine(e1[1]);
            Console.WriteLine(e1[2]);

            Console.WriteLine();
            e1[0] = 2;

            Console.WriteLine(e1[0]);
            Console.WriteLine(e1[1]);
            Console.WriteLine(e1[2]);

            Console.WriteLine();


            Console.WriteLine(e1["id"]);
            Console.WriteLine(e1["name"]);
            Console.WriteLine(e1["age"]);
            Console.ReadKey();
        }
    }
}
