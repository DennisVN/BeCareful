using System;
using System.IO;
using System.Collections;
using System.Text;

namespace BeCareful
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.IO.FileInfo fI = new FileInfo(@"C:\Users\BEAUCOUPDARGENT\Documents\VS CODE\Selas-Solutions\Temp.xml");
            //DateTime dT = fI.LastWriteTime;
            //Console.WriteLine(fI.FullName);
            //Console.WriteLine(dT);

            try
            {
                #region sandBoxOne
                FileStream lvFS = null;
                MemoryStream lvMS = null;

                string dir = @"C:\Users\BEAUCOUPDARGENT\Desktop\Be_Careful";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

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

                //// Write FLUPPE & FTW in fluppe_1 (UTF-8)
                File.WriteAllBytes(lvFile_1, lvBytes);
                File.AppendAllText(lvFile_1, "\r\n FTW");

                // Write fluppe in fluppe_2 (UTF-16 LE)
                File.WriteAllText(lvFile_2, text, Encoding.Unicode);


                //// Write FLUPPE via Stream in fluppe_3(UTF-8) ( minder gebruikt )
                lvFS = File.Create(lvFile_3);
                lvFS.Write(lvBytes);
                lvFS.Flush();
                lvFS.Close();

                //// Read as text
                lvBytes = File.ReadAllBytes(lvFile_1); // opens binary, reads in byte array
                Console.WriteLine(Encoding.UTF8.GetString(lvBytes));
                //text = File.ReadAllText(lvFile_2); // opens text, reads text file 
                //Console.WriteLine(text);

                //lvFS = File.OpenRead(lvFile_1);
                //Console.WriteLine("result lvFS: {0}", lvFile_1);
                //lvMS = new MemoryStream();
                //lvFS.CopyTo(lvMS);
                //Console.WriteLine("result MemoryStream ToArray:");
                //Console.WriteLine(Encoding.UTF8.GetString(lvMS.ToArray()));
                #endregion

                #region sandBoxTwo

                //// list all files inside a bigger directory -> GetFiles();
                //DateTime d1 = DateTime.Now;
                //Console.WriteLine(d1);
                //foreach (string s in Directory.GetFiles(@"C:\Users\BEAUCOUPDARGENT\Documents\BEAUCOUPDARGENT 2018", "*", SearchOption.AllDirectories))
                //{
                //    Console.WriteLine(s);
                //}
                //DateTime d2 = DateTime.Now;
                //Console.WriteLine(d2);
                // list all files inside a huge directory ASAP -> Enumerator - starts and processes faster for huge files;

                //DateTime d3 = DateTime.Now;

                //IEnumerator e = Directory.EnumerateFiles(@"C:\Users\BEAUCOUPDARGENT\Documents\BEAUCOUPDARGENT 2018", "*", SearchOption.AllDirectories).GetEnumerator();
                //while (e.MoveNext())
                //{
                //    // Console.WriteLine(DateTime.Now.ToString("HH:mm:ss.fffffff"));
                //    Console.WriteLine(e.Current);
                //}

                //DateTime d4 = DateTime.Now;

                //Console.WriteLine(d3.ToString("HH:mm:ss.fffffff"));
                //Console.WriteLine(d4.ToString("HH:mm:ss.fffffff"));

                #endregion

                #region sandBoxThree
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

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                //try { lvFS?.Dispose(); } catch { };
                //try { lvMS?.Dispose(); } catch { };
                Console.WriteLine("Great Succes ! ! ! ");
            }
        }

    }
}
