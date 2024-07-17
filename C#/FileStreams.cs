using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace File_Streams1
{
    internal class Program
    {
        /*
File is a collection of data on a particular area in the Disk.
Stream is a flow of data from one direction to another direction.
There are two types of Streams.

1. Input Stream - to read data from user from keyboard
2. Output Stream – to display to the user on the screen
File stream is used to work with files. We can write data into a new file or to read
data from an existing file.

Classes used in FileStreams
1. FileStream
2. StreamWriter
3. StreamReader
4. BinaryWriter
5. BinraryReader
6. FileInfo
7. DirectoryInfo

FileStream:- In this class we need to specify file name,path,file mode, file access.

File Modes:
1) Create – It will create a new file. If the file already exists it will overwrite
2) CreateNew - It will create a new file. If the file already exists it will throw an IOException.
3) Append – to add data to an existing file (from the end of the file it will start writing)
4) Open – to open an existing file
5) OpenOrCreate – If the file is there it will open an existing file otherwise it will create a new file
6) Truncate – to delete the contents of the file.

FileAccess:
1) Write - only for writing
2) Read - only for reading
3) ReadWrite - for both reading and writing

StreamWriter:- It is used to write data into text file
StreamReader:- It is used to read data from an existing text file

Ex:-
         // create a new file and write data into the file
            FileStream fs = new FileStream("Hello.txt",FileMode.Create,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            string data;
            Console.WriteLine("enter some text :");
            data = Console.ReadLine();
            sw.Write(data);
            sw.Flush();
            sw.Close();
            fs.Close();
            Console.WriteLine("File creation Success");

        */
        static void Main(string[] args)
        {
            // appending data to an existing file
            FileStream fs = new FileStream("Hello.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            string data;
            Console.WriteLine("Enter some text : ");
            data = Console.ReadLine();
            sw.Write(data); // writing data into file
            sw.Flush();  // clearing buffer
            sw.Close();  //to colse the stream write
            fs.Close (); // to close the file stream

            Console.WriteLine("File appending Success");
        }
        private static void ReadingDataFromFile()
        {
            try
            {
                // reading data from existing file
                FileStream fs = new FileStream("Hello.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string data;
                data = sr.ReadToEnd(); // reading data till end of file.
                Console.WriteLine("Reading data from file...");
                Console.WriteLine(data);
            }
            catch(FileNotFoundException f)
            {
                Console.WriteLine(f.Message);
            }
        }
    }
}
