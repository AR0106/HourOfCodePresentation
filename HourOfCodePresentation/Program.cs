using System;

namespace HourOfCodePresentation
{
    internal class Program
    {
        public static int currentPos = 0;

        public static string[] options = {
            "Option 1",
            "Option 2",
            "Option 3",
            "Option 4"
            };

        public static void DrawMenu()
        {
            Console.Clear();

            for (int i = 0; i < options.Length; i++)
            {
                if (i == currentPos)
                {
                    // Highlight
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine(options[i]);

                    // Back to Normal
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else
                {
                    Console.WriteLine(options[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            DrawMenu();

            var k = Console.ReadKey();

            while (k.Key != ConsoleKey.Escape)
            {
                // Navigate Menu Up
                if (k.Key == ConsoleKey.UpArrow)
                {
                    if (currentPos != 0)
                    {
                        currentPos--;
                    }
                }
                // Navigate Menu Down
                else if (k.Key == ConsoleKey.DownArrow)
                {
                    if (currentPos < options.Length - 1)
                    {
                        currentPos++;
                    }
                }

                DrawMenu();

                k = Console.ReadKey();
            }
        }
    }
}
