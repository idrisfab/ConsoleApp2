using System;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static String[,] BoardDisplay = new String [3,3] { 
            { "x", "x ", "x"},
            { "x", "x ", "x"},
            { "x", "x ", "x"}
        };

        static int activeRow, activeCol = 2;

        static int sleepTime = 100;             // in miliseconds 

        static void Main(string[] args)
        {
            //args thread will be created to run function 1 in parallel.
            Thread proc1 = new Thread(DisplayBoard);
            Thread proc2 = new Thread(TakeInFromUser);

            //DisplayBoard();
            proc1.Start();
            proc2.Start();

            // the focus of the program will exit here.
            Console.WriteLine("The main application has exited.");

            //Console.ReadLine();
        }

        static void DisplayBoard()
        {

            for(int row = 0; row < BoardDisplay.GetLength(0); row++)
            {
                for( int col = 0; col < BoardDisplay.GetLength(1); col++)
                {
                    BoardDisplay[row, col] = " ";
                    if(row == activeRow && col == activeCol)
                    {
                        BoardDisplay[row, col] = "X";
                    }
                }
            }

            String active = "x";

            Console.Write(
                    "-----|-----|-----\n" +
                    "   {0} | {1}   |  {2}   \n" +
                    "-----|-----|-----\n" +
                    "   {3} | {4}   |  {5}   \n" +
                    "-----|-----|-----\n" +
                    "   {6} | {7}   |  {8}   \n" +
                    "-----|-----|-----\n" ,
                    BoardDisplay[0, 0],
                    BoardDisplay[0, 1],
                    BoardDisplay[0, 2],
                    BoardDisplay[1, 0],
                    BoardDisplay[1, 1],
                    BoardDisplay[1, 2],
                    BoardDisplay[2, 0],
                    BoardDisplay[2, 1],
                    BoardDisplay[2, 2]
                );
            Thread.Sleep(sleepTime);
            Console.Clear();
            DisplayBoard();
        }


        static void TakeInFromUser()
        {
            Console.Write(".");
            ConsoleKeyInfo userIn = Console.ReadKey();
            
            if(userIn.Key == ConsoleKey.LeftArrow)
            {
                // pressed left
                if (activeCol == 0)
                {
                    // can't move left
                }
                else
                {
                    activeCol = activeCol - 1;
                }
            }


            if (userIn.Key == ConsoleKey.RightArrow)
            {
                // pressed right
                if (activeCol == 2)
                {
                    // can't move right, reached far right.
                }
                else
                {
                    activeCol = activeCol + 1;
                }
            }

            if (userIn.Key == ConsoleKey.DownArrow)
            {
                // pressed left
                if (activeRow == 2)
                {
                    // can't move down
                }
                else
                {
                    activeRow = activeRow + 1;
                }
            }


            if (userIn.Key == ConsoleKey.UpArrow)
            {
                // pressed up
                if (activeRow == 0)
                {
                    // can't move up
                }
                else
                {
                    activeRow = activeRow - 1;
                }
            }



            Console.Write(activeRow + "."+activeRow);
            Thread.Sleep(sleepTime);
            TakeInFromUser();
        }

    }
}
