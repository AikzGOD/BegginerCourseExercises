using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse
{
    internal interface IConsoleIO
    {
        string ReadLine();
        void WriteLine(string line);
        void ClearScreen();
        void Warning(string message);

        void Write(string line);
    }
}
