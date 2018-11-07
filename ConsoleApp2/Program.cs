using System;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        String[,] displayBoard;

        static void Main(string[] args)
        {
            //Thread th = Thread.CurrentThread;
            //th.Name = "MainThread";

            //Console.WriteLine("This is {0}", th.Name);
            //Console.ReadKey();

            Function1();
            Function2();


            Console.ReadLine();
        }

        static void Function1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value form Function 1 is {0} ", i);
            }
        }

        static void Function2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value form Function 2 is {0} ", i);
            }
        }
    }
}
