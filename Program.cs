using System;
using static System.Console;


namespace ToDo
{
    class Program
    {
        static void Main(string[] args)
        {

            CursorVisible = false;

            WriteLine("1. Add Task");
            WriteLine("2. List Tasks");
            WriteLine("3. Exit");

            ConsoleKeyInfo input;
            bool invalidChoice;

            do
            {
                input = ReadKey(true);

                invalidChoice = !(input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1
                               || input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2
                               || input.Key == ConsoleKey.D3 || input.Key == ConsoleKey.NumPad3);

            } while (invalidChoice);

            CursorVisible = true;

            Clear();

            bool shouldNotExit = true;

            do
            {
                switch (input.Key)
                {
                    case ConsoleKey.D1:

                        break;

                    case ConsoleKey.D2:

                        break;

                    case ConsoleKey.D3:

                        break;
                }

            } while (shouldNotExit);

        }
    }
}
