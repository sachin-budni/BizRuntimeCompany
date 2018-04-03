using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class Folder
    {
        public static void CopyFiles()
        {
            string fileName = "test.txt";
            string sourcePath = @"G:\JavaFundamental";
            string targetPath = @"G:\MyDir";

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            //if (!System.IO.Directory.Exists(targetPath))
            //{
            //    System.IO.Directory.CreateDirectory(targetPath);
            //}

            //// To copy a file to another location and 
            //// overwrite the destination file if it already exists.
            //System.IO.File.Copy(sourceFile, destFile, true);

            // To copy all the files in one directory to another directory.
            // Get the files in the source folder. (To recursively iterate through
            // all subfolders under the current directory, see
            // "How to: Iterate Through a Directory Tree.")
            // Note: Check for target path was performed previously
            //       in this code example.
            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
            else
            {
                Console.WriteLine("Source path does not exist!");
            }

        }

        public static List<string> GetXMLFiles(string directory)
        {
            List<string> files = new List<string>();

            try
            {
                files.AddRange(Directory.GetFiles(directory, "*.jpg", SearchOption.AllDirectories));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return files;
        }
        static void Main()
            {
                // You can also use System.Environment.GetLogicalDrives to
                // obtain names of all logical drives on the computer.

                System.IO.DriveInfo di = new System.IO.DriveInfo(@"F:\");
                Console.WriteLine(di.TotalFreeSpace);
                Console.WriteLine(di.VolumeLabel);

                // Get the root directory and print out some information about it.
                System.IO.DirectoryInfo dirInfo = di.RootDirectory;
            Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine(dirInfo.Attributes.ToString());

                // Get the files in the directory and print out some information about them.
                System.IO.FileInfo[] fileNames = dirInfo.GetFiles("*.*");


                foreach (System.IO.FileInfo fi in fileNames)
                {
                    Console.WriteLine("{0}: {1}: {2}", fi.Name, fi.LastAccessTime, fi.Length);
                }

                // Get the subdirectories directly that is under the root.
                // See "How to: Iterate Through a Directory Tree" for an example of how to
                // iterate through an entire tree.
                System.IO.DirectoryInfo[] dirInfos = dirInfo.GetDirectories("*.*");
            Console.WriteLine("------------------------------------------------------------------");
                foreach (System.IO.DirectoryInfo d in dirInfos)
                {
                    Console.WriteLine(d.Name+"-"+d.CreationTime+"-"+d.Extension);
                }

                // The Directory and File classes provide several static methods
                // for accessing files and directories.

                // Get the current application directory.
                string currentDirName = System.IO.Directory.GetCurrentDirectory();
                Console.WriteLine(currentDirName);

                // Get an array of file names as strings rather than FileInfo objects.
                // Use this method when storage space is an issue, and when you might
                // hold on to the file name reference for a while before you try to access
                // the file.
                string[] files = System.IO.Directory.GetFiles(currentDirName, "*.txt");

                foreach (string s in files)
                {
                    // Create the FileInfo object only when needed to ensure
                    // the information is as current as possible.
                    System.IO.FileInfo fi = null;
                    try
                    {
                        fi = new System.IO.FileInfo(s);
                    }
                    catch (System.IO.FileNotFoundException e)
                    {
                        // To inform the user and continue is
                        // sufficient for this demonstration.
                        // Your application may require different behavior.
                        Console.WriteLine(e.Message);
                        continue;
                    }
                    Console.WriteLine("{0} : {1}", fi.Name, fi.Directory);
                }

                // Change the directory. In this case, first check to see
                // whether it already exists, and create it if it does not.
                // If this is not appropriate for your application, you can
                // handle the System.IO.IOException that will be raised if the
                // directory cannot be found.
                if (!System.IO.Directory.Exists(@"F:\Angular2\app1\"))
                {
                    System.IO.Directory.CreateDirectory(@"F:\Angular2\app1\");
                }

                System.IO.Directory.SetCurrentDirectory(@"F:\Angular2\app1\");

                currentDirName = System.IO.Directory.GetCurrentDirectory();
                Console.WriteLine(currentDirName);

                // Keep the console window open in debug mode.
                Console.WriteLine("Press any key to exit.");
                            CopyFiles();
            List<string> lists= GetXMLFiles(@"G:\krishna");
            foreach(var list in lists)
            {
                Console.WriteLine(list);
            }
            if (System.IO.File.Exists(@"G:\MyDir\test - Copy.png"))
            {
                System.IO.File.Delete(@"G:\MyDir\test - Copy.png");
                Console.WriteLine("Deleted File");
            }

            Console.ReadKey();
                
            }
    }
}
