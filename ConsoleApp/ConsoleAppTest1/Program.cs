using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppTest1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;
            */

            // Add title of App
            Console.Title = " 你好";

            // Console.Beep(500, 1000);
            Console.Write("What is your name?");
            Console.WriteLine();
            string name = Console.ReadLine();

            // set text position - middle of the screen.
            Console.SetCursorPosition(45, 15);

            Console.Clear();  // clear above text
            Console.WriteLine("Hello " + name + "!");

            Console.WriteLine();
            Console.WriteLine("Press any key to quit!");
            Console.ReadKey();
        }
    }
}
