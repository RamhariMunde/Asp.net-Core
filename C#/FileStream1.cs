using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1607
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Task#1. Write a program to copy data from Hello1.txt to Hello2.txt using two file streams.
             */
            try
            {
                FileStream fs1 = new FileStream(@"F:\Naresh IT\new.txt.txt", FileMode.Open, FileAccess.Read);
                string filename;
                Console.WriteLine("Enter file name to copy : ");
                filename = Console.ReadLine();

                FileStream fs2 = new FileStream(@"F:\Naresh IT\" + filename, FileMode.Create, FileAccess.Write);
                StreamReader sr = new StreamReader(fs1);
                StreamWriter sw = new StreamWriter(fs2);
                {
                    fs1.CopyTo(fs2);
                }
                string data;
                data = sr.ReadToEnd();
                sw.Write(data);

                sr.Close();
                fs1.Close();
                fs2.Close();
                Console.WriteLine("File copy Success...Check " + filename);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
