using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace paper1
{
    internal class Program
    {/* // string occurraence
            Console.WriteLine("Enter the string : ");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);

            }
            Console.WriteLine();
            Console.ReadKey();*/
       
        static void Main(string[] args)
        {
          
                Console.Write("Enter the number of rows: ");
                int r = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the number of columns: ");
                int c = Convert.ToInt32(Console.ReadLine());

                int[,] array = new int[r, c];

                // Input the elements of the array
                for (int i = 0; i < r; i++)
                {
                    for (int col = 0; col < c; col++)
                    {
                        array[i, col] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                int[] Sums = new int[c];

                // Calculate the sum of each column
                for (int col = 0; col < c; col++)
                {
                    int sum = 0;
                    for (int row = 0; row < r; row++)
                    {
                        sum += array[row, col];
                    }
                    Sums[col] = sum;
                }

                // Print the sum of each column
                Console.WriteLine("Sum of each column:");
                for (int col = 0; col < c; col++)
                {
                    Console.WriteLine($"Column {col + 1}: {Sums[col]}");
                }
     



    }
}
}
