using System;


namespace Basic_Programs
{
    internal class Check_Even_Odd
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a no.for checking it is odd or even");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine(a+" even no.");

            }
            else
            {
                Console.WriteLine(a + " odd no.");
            }

        }
    }
}