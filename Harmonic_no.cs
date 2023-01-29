using System;


namespace Basic_Programs
{
    internal class Harmonic_no
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a no.");
            int num = int.Parse(Console.ReadLine());
            double har = 0;

            for (int i = 1; i < num; i++)
            {
                har = har + (double)1 / i;

                Console.Write(har + "+");
                Console.ReadKey(); 

            }

        }
    }
}