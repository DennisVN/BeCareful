using System;
using System.IO;
using System.Text;

namespace BeCareful
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region sandBoxGetPath
                //string rootPath = @"C:\Users\BEAUCOUPDARGENT\Desktop\Be_Careful";

                //// Get directories
                //string[] dirs = Directory.GetDirectories(rootPath,"*", SearchOption.AllDirectories);

                //foreach (string dir in dirs)
                //{
                //    Console.WriteLine(dir);
                //}

                //// Get Files
                //string[] files = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
                //string[] ExcellFiles = Directory.GetFiles(rootPath, "*.xlsx", SearchOption.AllDirectories);

                //foreach (string file in files)
                //{
                //    //Console.WriteLine(file);
                //    //Console.WriteLine(Path.GetFileName(file));
                //    //Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                //    //Console.WriteLine(Path.GetDirectoryName(file));
                //    var info = new FileInfo(file);
                //    Console.WriteLine($"{ (Path.GetFileName(file)) }: { info.Length } bytes");
                //}

                //foreach (string Excelleke in ExcellFiles)
                //{
                //    Console.WriteLine(Excelleke);
                //}

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

                #region sandBoxIO
                DirectoryInfo myDir = new DirectoryInfo(@"C:\Users\BEAUCOUPDARGENT\Desktop\Be_Careful");
                // Read Directory info
                Console.WriteLine(myDir.FullName);
                Console.WriteLine(myDir.Name);
                Console.WriteLine(myDir.Parent);
                Console.WriteLine(myDir.Attributes);
                Console.WriteLine(myDir.CreationTime);

                DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\BEAUCOUPDARGENT\Desktop\Be_Careful\UsbDrive");
                //// Create new directory if it doesnt exists
                //if (!Directory.Exists(dataDir.ToString()))
                //{
                //    Directory.CreateDirectory(dataDir.ToString());
                //}
                //// String to add
                //string[] gameFiles =
                //{
                //    "Doom2016.exe",
                //    "Minecraft.exe",
                //    "GTA_V.exe"
                //};
                //// Create new text file path for gameFiles
                //string textFilePath = @"C:\Users\BEAUCOUPDARGENT\Desktop\Be_Careful\UsbDrive\GameFiles.txt";
                //// Write gameFiles to the path
                //File.WriteAllLines(textFilePath, gameFiles);

                //foreach (string game in File.ReadAllLines(textFilePath))
                //{
                //    Console.WriteLine($"Game : {game}");
                //}
                // Get information from file

                DirectoryInfo myDataDir = new DirectoryInfo(@"C:\Users\BEAUCOUPDARGENT\Desktop\Be_Careful\UsbDrive");

                FileInfo[] txtFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);
                Console.WriteLine("Matches : {0}", txtFiles.Length);

                foreach(FileInfo file in txtFiles)
                {
                    Console.WriteLine(file.Name);
                    Console.WriteLine(file.Length); // # bytes
                }

                // FILESTREAM : when you want to read and write byte / array of bytes

                string txtFilePath2 = @"C:\Users\BEAUCOUPDARGENT\Desktop\Be_Careful\UsbDrive\Soundtracks.txt";
                // Create file
                FileStream fs = File.Open(txtFilePath2, FileMode.Create);

                string stSoundtrack = "Fireworks - Katy Perry";
                byte[] btSoundtrackArray = Encoding.Default.GetBytes(stSoundtrack);

                fs.Write(btSoundtrackArray, 0, btSoundtrackArray.Length); // 0 is index where to start
                // change index position back to the start 
                fs.Position = 0;
                // Create byteArray to hold fileData
                byte[] fileByteArray = new byte[btSoundtrackArray.Length];

                // Put bytes inside Array
                for (int i = 0; i < btSoundtrackArray.Length; i++)
                {
                    fileByteArray[i] = (byte)fs.ReadByte(); // cast to byte
                }
                // Convert byte to string for output 
                Console.WriteLine(Encoding.Default.GetString(fileByteArray));
                // Close Stream
                fs.Close();

                // StreamWriter and Reader when strings
                string txtFilePath3 = @"C:\Users\BEAUCOUPDARGENT\Desktop\Be_Careful\UsbDrive\ReadMe.txt";
                // use SW to Write text to the following path
                StreamWriter sw = File.CreateText(txtFilePath3);

                sw.WriteLine(@"¯\_(ツ)_/¯¯\_(ツ)_/¯¯\_(ツ)_/¯¯\_(ツ)_/¯");
                sw.WriteLine("README.TXT");
                sw.WriteLine(@"¯\_(ツ)_/¯¯\_(ツ)_/¯¯\_(ツ)_/¯¯\_(ツ)_/¯");
                // Close StreamWriter
                sw.Close();
                // Open file for reading :
                StreamReader sr = File.OpenText(txtFilePath3);

                Console.WriteLine("Peek first char: {0}", Convert.ToChar(sr.Peek()));
                Console.WriteLine("1st string : {0}", sr.ReadLine());
                Console.WriteLine("Everything : {0}", sr.ReadToEnd());
                sr.Close();

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
