using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse
{
    internal class ConsoleIO : IConsoleIO
    {
        public void ClearScreen() { Console.Clear(); }


        public string ReadLine() { return Console.ReadLine(); }

        public void Warning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void WriteLine(string line) { Console.WriteLine(line);}

        
    }
}
