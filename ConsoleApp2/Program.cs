using System;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        String[,] displayBoard;

        static void Main(string[] args)
        {
            //args thread will be created to run function 1 in parallel.
            Thread obj1 = new Thread(Function1);
            obj1.IsBackground = true;
            obj1.Start();

            // the focus of the program will exit here.
            Console.WriteLine("The main application has exited.");
            Console.ReadLine();
        }

        static void Function1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 1 is entered ....");
                Console.ReadLine();     // Wait here
                Console.WriteLine("Function 2 is exited ...."); // This will not now even be 
                // executed because in the main function, the program started then exited 
                // as this is now a background task.
            }
        }


    }
}
