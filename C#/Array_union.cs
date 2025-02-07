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
            int[] arr1 = { 5, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, };
            int[] arr2 = { 4, 5, 6, 7, 8, 9, 10, 65, 54, 90, 100 };

            Console.WriteLine(string.Join(",",arr1.Union(arr2).Where(x => x >= 0)));
        }
    /* public static void Main(string[] args)
      {
     int[] arr1 = { 5, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, };
     int[] arr2 = { 4, 5, 6, 7, 8, 9, 10, 65, 54, 90, 100 };

     int[] arr3 = arr1.Union(arr2).ToArray();

     foreach (int i in arr3)
     {
         Console.Write(i+ " ,");
     }
     Console.ReadKey();
     }
  */
    }
}
