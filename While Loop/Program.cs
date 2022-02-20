using System;
namespace SIX
{
    class program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 1001; i++)
            {
                {
                    if (i % 2 == 1)
                        continue;

                    else if (i % 6 == 0 && i % 9 == 0)
                    {
                        Console.WriteLine("SIXNINE");
                    }
                    else if (i % 6 == 0)
                    {
                        Console.WriteLine("SIX");
                    }
                    else if (i % 9 == 0)
                    {
                        Console.WriteLine("NINE");
                    }
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}


                   
