using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class Folder1
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"F:\Angular2\app1\");
            DirectoryInfo[] dirInfos = dirInfo.GetDirectories();

            foreach (var dir in dirInfos)
            {
                Console.WriteLine(dir);
            }
            FileInfo[] files = dirInfo.GetFiles();
            foreach(var file in files)
            {
                Console.WriteLine(file +"\t"+file.CreationTime+"\t"+file.Extension+"\t"+file.Length);
            }
            foreach (var file in files)
            {
                if ("package.json" == file.ToString())
                {
                    Console.WriteLine("---------------");
                    Console.WriteLine(file);
                    Console.WriteLine("---------------");
                }
            }
            Console.ReadKey();
        }
    }
}
