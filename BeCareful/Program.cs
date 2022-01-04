using System;
using System.IO;
using System.Text;

namespace BeCareful
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileInfo fI = new FileInfo(@"C:\Users\BEAUCOUPDARGENT\Documents\VS CODE\Selas-Solutions\Temp.xml");
            string dir = @"C:\Users\BEAUCOUPDARGENT\Desktop\Be_Careful";
            DateTime dT = fI.LastWriteTime;
            Console.WriteLine(fI.FullName);

            Console.WriteLine(dT);

            if (! Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                
            }

            FileStream lvFS = null;
            MemoryStream lvMS = null;

            string lvFile_1 = @"C:\Users\BEAUCOUPDARGENT\Desktop\Be_Careful\Fluppe_1.TXT";
            string lvFile_2 = @"C:\Users\BEAUCOUPDARGENT\Desktop\Be_Careful\Fluppe_2.TXT";
            string lvFile_3 = @"C:\Users\BEAUCOUPDARGENT\Desktop\Be_Careful\Fluppe_3.TXT";
            string text = "Fluppe";
            byte[] lvBytes = new byte[] { 70, 76, 85, 80, 80, 69 };

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            if (File.Exists(lvFile_1))
            {
                Directory.CreateDirectory(dir);
                File.Delete(lvFile_1);
            }

            if (File.Exists(lvFile_2))
            {
                Directory.CreateDirectory(dir);
                File.Delete(lvFile_2);
            }

            if (File.Exists(lvFile_3))
            {
                Directory.CreateDirectory(dir);
                File.Delete(lvFile_3);
            }

            // Write
            File.WriteAllBytes(lvFile_1, lvBytes);
            File.WriteAllText(lvFile_2, text, Encoding.Unicode);
            // via Stream ( minder gebruikt )
            lvFS = File.Create(lvFile_3);
            lvFS.Write(lvBytes);
            lvFS.Flush();
            lvFS.Close();

            // Read
            lvBytes = File.ReadAllBytes(lvFile_1); // opens binary, reads in byte array
            Console.WriteLine(Encoding.UTF8.GetString(lvBytes));
            text = File.ReadAllText(lvFile_2); // opens text, reads text file 
            Console.WriteLine(text);
            lvFS = File.OpenRead(lvFile_3);
            Console.WriteLine(lvFS);
        }
    }
}
