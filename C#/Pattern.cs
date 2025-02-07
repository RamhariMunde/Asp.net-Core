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
            int i, j;
            for ( i = 1; i <= 5; i++)
            {
                for(j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
          
        }
    }
}
/*
54321
5432
543
54
5
*/
