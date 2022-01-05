using System;
using System.IO;

namespace BeCareful
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region sandBoxOne
                string rootPath = @"C:\Users\BEAUCOUPDARGENT\Desktop\Be_Careful";

                //// Get directories
                //string[] dirs = Directory.GetDirectories(rootPath,"*", SearchOption.AllDirectories);

                //foreach (string dir in dirs)
                //{
                //    Console.WriteLine(dir);
                //}

                //// Get Files
                string[] files = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
                string[] ExcellFiles = Directory.GetFiles(rootPath, "*.xlsx", SearchOption.AllDirectories);

                //foreach (string file in files)
                //{
                //    //Console.WriteLine(file);
                //    //Console.WriteLine(Path.GetFileName(file));
                //    //Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                //    //Console.WriteLine(Path.GetDirectoryName(file));
                //    var info = new FileInfo(file);
                //    Console.WriteLine($"{ (Path.GetFileName(file)) }: { info.Length } bytes");
                //}

                foreach (string Excelleke in ExcellFiles)
                {
                    Console.WriteLine(Excelleke);
                }

                // // Create New Directory 

                //string NewPath = @"C:\Users\BEAUCOUPDARGENT\Desktop\Be_Careful\SubFolderA\SubSubFolderD";
                //bool directoryExists = Directory.Exists(NewPath);

                //if (directoryExists)
                //{
                //    Console.WriteLine("The directory exists");
                //}
                //else
                //{
                //    Console.WriteLine("The directory does not exist");
                //    Directory.CreateDirectory(NewPath);
                //}

                // Copying Files
                //string[] files = Directory.GetFiles(rootPath);
                //string destinationFolder = @"C:\Users\BEAUCOUPDARGENT\Desktop\Be_Careful\SubFolderA";

                //foreach (string file in files)
                //{
                //    File.Copy(file, $"{destinationFolder}{ Path.GetFileName(file) }", true); // bool is optional, override
                //}
                // // Rename and Overwrite
                //for ( int i = 0; i < files.Length; i++)
                //{
                //    File.Copy(files[i], $"{destinationFolder}{i}.txt");
                //}
                // // Move
                //foreach (string file in files)
                //{
                //    File.Move(file, $"{destinationFolder}{ Path.GetFileName(file) }"); 
                //}
                #endregion

                #region stringbuilder
                // Write 5000 lines with StringBuilder
                //DateTime d1 = DateTime.Now;

                //StringBuilder sb = new StringBuilder();
                //for (int i = 0; i < 5000; i++)
                //{
                //    sb.AppendLine("Voice le lijn " + i.ToString());
                //}

                //Console.WriteLine(sb.ToString());
                //DateTime d2 = DateTime.Now;

                //Console.WriteLine(d1.ToString());
                //Console.WriteLine(d2.ToString());
                #endregion
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Great Succes ! ! ! ");
            }
        }

    }
}
