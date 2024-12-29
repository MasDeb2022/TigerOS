using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace TigerOS
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("TigerOS v0.1-alpha");
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
