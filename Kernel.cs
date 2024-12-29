using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace TigerOS
{
    public class Kernel : Sys.Kernel
    {
        private const ConsoleColor darkGreen = ConsoleColor.DarkGreen;
        private const ConsoleColor red = ConsoleColor.Red;
        private const ConsoleColor white = ConsoleColor.White;

        protected override void BeforeRun()
        {
            Console.Clear();
            Console.Write("Welcome to ");
            Console.ForegroundColor = darkGreen;
            Console.Write("TigerOS v0.1-alpha");
            Console.ForegroundColor = white;
            Console.WriteLine("!");
            Console.WriteLine("Type the text to get it echoed back.\n");
        }

        protected override void Run()
        {
            Console.Write("tigeros/echo> ");
            var input = Console.ReadLine();
            Console.Write("RECEIVED INPUT: ");
            Console.WriteLine(input + "\n");
        }
    }
}
