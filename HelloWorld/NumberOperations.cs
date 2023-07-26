using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse
{
    internal class NumberOperations : INumberOperations
    {
        private int _sumOfNumbers;
        

        public int CalculateFactorialNumber(int number)
        {
            int factorial = 1;

            int[] numbers = new int[(number) + 1];

            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = i;


                factorial = factorial * numbers[i];

            }

            return factorial;

        }

        public int SummedNumbers()
        {
            return _sumOfNumbers;
        }

        public int SumThemAll(List<int> numberList)
        {
            int sum = 0;
            foreach (int number in numberList)
            {
                sum += number;
            }
            _sumOfNumbers = sum;
            return sum;
        }
    }
}
