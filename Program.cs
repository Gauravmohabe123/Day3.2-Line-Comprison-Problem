using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Transactions;

namespace Line_comparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            equal();
            
            
        }
        public static void equal()
        {
            double one = 0;
            double two = 0;
            for (int i = 1; i <= 2; i++)

            {
                if (i == 1)
                {
                    Console.WriteLine("Enter the value for first line:");
                    one = line();
                    Console.WriteLine(one + " Leangth of one line  and leangth of two..... ");
                }
                else
                {
                    Console.WriteLine("Enter the value of second line");
                    one = line();
                    Console.WriteLine(two + " Leangth of the one line and leangth of two....");
                }
                if (one == two)
                {
                    Console.WriteLine("The two Lines are equal");
                    one= line();
                }
                else if(one>two)
                {
                    Console.WriteLine("Line one is grater than line two");
                    one= line();
                }
                else
                {
                    Console.WriteLine("Line two is grater than line one");
                }
            }
        }
        static double line()
        {
            Console.WriteLine(" Give some inputs on model line");
            Console.WriteLine("Enter the leangths of  first two numbrs X1 and Y1");
            Console.WriteLine("Enter X1");
            double X1=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y1");
            double Y1=double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the leangths of  first two numbrs X2 and Y2");
            Console.WriteLine("Enter X2");
            double X2=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y2");
            double Y2=double.Parse(Console.ReadLine());

            double LenghtofLine = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            Console.WriteLine( " Leangth of the Line is:" +LenghtofLine);
            return LenghtofLine;




        }
    }
}
