using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace paper1
{
    internal class Program
    {       
        static void Main(string[] args)
        {
              //Matrix Addition Demo
            int[,] A = new int[2, 2];
            int[,] B = new int[2, 2];
            int[,] C = new int[2, 2];
            Console.WriteLine("enter 4 elements into Matrix A: ");
            for (int i = 0; i < 2; i++)
{
                for (int j = 0; j< 2; j++)
{
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("enter 4 elements into Matrix B: ");
            for (int i = 0; i < 2; i++)
{
                for (int j = 0; j < 2; j++)
{
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Sum of Matrix A and B
            for (int i = 0; i < 2; i++)
{
                for (int j = 0; j < 2; j++)
{
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
            Console.WriteLine("\n Elements of Matrix A: ");
            for (int i = 0; i< 2; i++)
{
                for (int j = 0; j < 2; j++)
{
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n Elements of Matrix B: ");
            for (int i = 0; i < 2; i++)
{
                for (int j = 0; j < 2; j++)
{
                    Console.Write(B[i, j] + "\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n A+B Matrix is :");
            for (int i = 0; i< 2; i++)
{
                for (int j = 0; j < 2; j++)
{
                    Console.Write(C[i, j] + "\t ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
    }
}
}

/*
// this is for subtraction of two Array 

  int[,]A = new int[2, 2];   
  int[,]B = new int[2, 2];
  int[,]C = new int[2, 2];

  Console.WriteLine("Enter the 4 Elements of Array A: ");
  for (int i = 0; i < 2; i++) 
  {
    for(int j = 0; j < 2; j++)
      {
          A[i,j] =Convert.ToInt32(Console.ReadLine());
      }
  }

  Console.WriteLine("Enter the 4 Elements of Array B: ");
  for(int i=0; i<2; i++)
  {
      for(int j=0; j<2; j++)
      {
          B[i,j] = Convert.ToInt32(Console.ReadLine());
      }
  }

 for(int i= 0; i<2;i++)
  {
      for(int j=0 ; j<2 ; j++)
      {
          C[i,j] = A[i,j]-B[i,j];
      }
  }
  Console.WriteLine("this is Array of A: ");
  for(int i=0;i<2; i++)
  {
      for(int j=0;j<2; j++)
      {
          Console.Write(A[i,j]+"\t");
      }
      Console.WriteLine();
  }

  Console.WriteLine("this is Array of B :");
  for(int i=0;i<2; i++)
  {
      for(int j=0 ; j<2; j++)
      {
          Console.Write(B[i,j]+"\t");
      }
      Console.WriteLine();
  }

  Console.WriteLine("this is a substraction of A and B Array : ");
  for(int i=0; i< 2; i++)
  {
      for(int j=0;j<2; j++)
      {
          Console.Write(C[i,j]+"\t");
      }
      Console.WriteLine();
  }
  Console.ReadLine();
*/
