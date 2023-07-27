using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse
{
    internal interface INumberValidator
    {
        bool IsMainNumberValid(string value, out int number);
        bool IsNumberValid(string input, out int number);
        bool IsGreaterThan(int numberOne, int numberTwo);
        bool IsIdentical(int numberOne, int numberTwo);
    }
}
