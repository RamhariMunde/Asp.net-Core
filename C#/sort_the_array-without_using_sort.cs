using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ALL_IN_OnePracticeC_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 5, 9, 1, 3, 26, 7, 8, 9, 10, 65 };

            sortarray(arr1);
            Console.WriteLine(string.Join(", ", arr1));
        }
        static void sortarray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

        }
    }
}

