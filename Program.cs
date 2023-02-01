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

            double obj=Program.line();
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
