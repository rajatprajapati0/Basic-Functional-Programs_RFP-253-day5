using System;


namespace Basic_Programs
{
    internal class Leap_year
    {
        
        public static void Main(string[]args)
        {
            Console.WriteLine("enter a year ");
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 )
            {
                Console.WriteLine(year+" is leap year");


            }
            
            else if(year%400==0) 
            {
                Console.WriteLine(year+" is leap year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine(year+" is not leap year");
            }
            else
            {
                {
                    Console.WriteLine(year + " is not leap year");
                }
            }
        }
    }
}*/
