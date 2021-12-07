using System;
using System.Collections.Generic;
using System.Text;

namespace HourOfCodePresentation
{
    internal class Page
    {
        public string[] information;

        public string[] options;

        public void DrawMenu()
        {
            Console.Clear();

            for (int i = 0; i < options.Length; i++)
            {
                if (i == Program.currentPos)
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
    }
}
