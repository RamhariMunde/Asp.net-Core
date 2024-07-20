using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1107
{
    internal class Program
    {
        static void strReverse(string name)
        {
            for(int i=name.Length-1;i>=0; i--)
            {
                Console.Write(name[i]);
            }
            Console.Write(" ");
        }
       
        static void Main(string[] args)
        {

            /*     task 1) 
    1. ToUpper()
    2. ToLower()
    3. Substring()
    4. Concat()
    5. Contains()
    6. Equals()
    7. Split()
    8. Join()
    9. IndexOf()
    10. LastIndexOf()


                Console.WriteLine("Enter the string: ");
                string str = Console.ReadLine();
                Console.WriteLine("Enter secong string: ");
                string str2 = Console.ReadLine();

                //Console.WriteLine(str.ToUpper());  // upper case translate
                //Console.WriteLine(str.ToLower());  // lower case translate
                //Console.WriteLine(str.Substring(2,5));  // substring is how many letter print, you give a range
                //Console.WriteLine(string.Concat(str,str2));  // to add a two stings
                //bool result = str.Contains(str2);        // contains is use to the find the string in this is my main string 
                //Console.WriteLine(result);               // Ex: my str is Rammunde find the munde in this str like this.

                // char str3 =' ';
                //Console.WriteLine(string.Equals(str,str2) );  // cheack the equal
                //string[] w=str.Split(str3);
                //foreach (string c in w)
                //{
                //    Console.WriteLine(c);   // split used to ex(Ram krishna hari) this is our string split fun seprate the word by word
                //                            // like hi print first ram, second krishna, third hari
                //}

                string[] words = { 

                "apple", "banana", "cherry" };
                string result = string.Join(", ", words);
                Console.WriteLine(result); // Output: apple, banana, cherry 

                Console.WriteLine(str.LastIndexOf('R'));  // finding the last index number
                Console.WriteLine(str.IndexOf('R'));  // finding the index number

                */
            /*
Task#3.
I/p: welcome to naresh it
o/p: emoclew ot hseran ti

                         string str = "ram munde";
                        string[] words = str.Split(' ');
                        for (int i=0;i<=words.Length-1;i++)
                        {
                            strReverse(words[i]);
                        }
                        Console.ReadKey();
                  */
            /*
Task#2.
I/p: welcome to naresh it
O/p: it naresh to welcome 
          */
            string name = "ram munde";
            string str = str1Reverse(name);
            Console.WriteLine(str);

        }
        public static string str1Reverse(string name1)
        {
            string[] word = name1.Split(' ');
            Array.Reverse(word);
            return string.Join(" ", word);
        }
    }
}
