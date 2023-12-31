﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse
{
    public class NumberOperations : INumberOperations
    {

        private List<int> _numbers;

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

        public int SumThemAll(List<int> numberList)
        {
            int sum = 0;
            foreach (int number in numberList)
            {
                sum += number;
            }
            
            return sum;

            
        }

        public bool NumbersAreConsecutive(string[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int currentNumber = int.Parse(numbers[i]);
                int nextNumber = int.Parse(numbers[i + 1]);

                //Check if it is consecutive
                if (nextNumber != currentNumber + 1 && nextNumber != currentNumber - 1)
                {
                    return false;
                }
            }

            return true;


        }

        
    }
}
