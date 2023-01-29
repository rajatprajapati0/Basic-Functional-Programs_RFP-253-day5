using System;



namespace Basic_Programs
{
    internal class Flip_coin
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter even no. how many times you want tos ");
            int tosCount = int.Parse(Console.ReadLine());

            Random rnd= new Random();
            int headcount = 0;
            int tailcount = 0;
            if (tosCount % 2 == 0)
            {
                for (int i = 0; i <= tosCount; i++)
                {
                    int tos = rnd.Next(0, 2);
                    if (tos == 0 && tos <= 20)
                    {
                        Console.WriteLine("Head");

                        headcount++;
                    }

                    else
                    {

                        Console.WriteLine("Tail");
                        tailcount++;

                    }
                }

                Console.WriteLine("Head count " + headcount);
                Console.WriteLine("Tail count " + tailcount);




                if (headcount > tailcount)
                {
                    Console.WriteLine("Head count are more Than Tail count \n \n    **winer is Head**  ");
                }
                else
                {
                    Console.WriteLine("tail count are more Than Head count \n \n    **winer is Tail**  ");

                }
            }
            else if (tosCount > 20)
            {
                Console.WriteLine("you can enter only maximum 20");
            }
            else
            {
                Console.WriteLine("you enterd a odd no. please enter a even no.");

            }
        }
    }
}