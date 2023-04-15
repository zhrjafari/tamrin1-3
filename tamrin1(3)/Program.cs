using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace project
{
    class test1
    {
        public static void Main()
        {
            Console.WriteLine("enter num1 & num2");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Calc(num1, num2);
        }//end main

        private static void Calc(double num1, double num2)
        {
            double Result = Math.Sqrt(Math.Abs(num1)+Math.Pow(num2,2));
            Console.WriteLine(Result);
        }
    }
}