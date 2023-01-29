using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Basic_Programs
{
    internal class Power_of_2
    {
        public static void Main()
        {
            Console.WriteLine("enter no. as power of 2");

            int n =int.Parse(Console.ReadLine());
            int number = 2;
            int sum = 1;
            for(int i=0;i<n;i++)
            {
                sum = sum * number;
            }
            Console.WriteLine(sum);
        }
    }
}
