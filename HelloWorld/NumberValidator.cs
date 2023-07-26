using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse
{
    public class NumberValidator : INumberValidator
    {
        public bool IsNumberValid(string value , out int number)
        {
            return int.TryParse(value, out number);
        }

        public bool IsMainNumberValid(string value, out int number)
        {
            return int.TryParse(value , out number) && number >= 1 && number <= 21;
        }

        public bool IsGreaterThan(int numberOne, int numberTwo)
        {
            return numberOne > numberTwo;
        }

        public bool IsIdentical(int numberOne, int numberTwo)
        {
            if(numberOne == numberTwo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
