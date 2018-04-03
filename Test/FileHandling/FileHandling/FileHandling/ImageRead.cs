using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace FileHandling
{
    class ImageRead
    {
        static void Main(string[] args)
        {


            //Image img = Image.FromFile(@"F:\SACHIN_SOFTWARES\adobe\2.jpg");
            byte[] imageArray = File.ReadAllBytes(@"F:\SACHIN_SOFTWARES\adobe\2.jpg");
            //foreach (var list in imageArray)
            //{
            //    Console.WriteLine(list);
            //}

            //System.Drawing.Image image = System.Drawing.Image.FromFile(imagefilePath);
            //byte[] imageByte = ImageToByteArraybyImageConverter(image);

            string path = @"G:\MyDir";
            if (Directory.Exists(path))
            {
                Console.WriteLine("That path exists already.");
                return;
            }
            // Try to create the directory.
            DirectoryInfo di = Directory.CreateDirectory(path);

            Image files = null;
            using (MemoryStream mStream = new MemoryStream(imageArray))
            {
                files = Image.FromStream(mStream);
            }
            Bitmap bit = new Bitmap(files);
            bit.Save(@"G:\MyDir\test.png");
            Console.WriteLine("image Converted");
            Console.WriteLine(files);
            //MemoryStream ms = new MemoryStream(imageArray);
            //Image image = Image.FromStream(ms);
            //image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            //image.Save(@"F:\SACHIN_SOFTWARES\imageTest.png");
            //ms.Close();

            



           Console.ReadKey();
            //System.Drawing.Image image = System.Drawing.Image.FromFile(@"F:\SACHIN_SOFTWARES\adobe\2.jpg");
            //byte[] imageByte = ImageToByteArraybyMemoryStream(image);

            //ImageConverter imgCov = new ImageConverter();
        }
    }
}
