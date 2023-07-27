using BegginerCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ThirdExercises
{
    internal class FourteenthExercise : IExercise
    {
        private readonly IConsoleIO _console;
        private StringOperations _stringOperations;
        private List<int> numberList = new List<int>();


        public FourteenthExercise(IConsoleIO console)
        {
            _console = console;
            _stringOperations = new StringOperations();
        }

        /// <summary>
        /// Write a program and ask the user to supply a list of comma
        /// seperated numbers(5,1,9,2,10). If the list is empty or includes less than 5 numbers
        /// Display "Invalid List" and ask the user to re-try; otherwise, Display the 3 smallest
        /// numbers in the list
        /// </summary>
        public void Run()
        {
            bool listIsCorrect = false;

            while (listIsCorrect == false)
            {
                //Ask user list with numbers
                _console.WriteLine("Insert a list of numbers 5+ seperated by comma (e.g : 1,2,3): ");
                string userInput = _console.ReadLine();

                _stringOperations.SeparateStringValuesWithComma(userInput);

                //check if the array numbers is less than 5
                if (_stringOperations.SeparateStringValuesWithComma(userInput).Length < 5)
                {
                    _console.Warning("Invalid Input");
                    continue;
                }

                for (int i = 0; i < _stringOperations.SeparateStringValuesWithComma(userInput).Length; i++)
                {
                    numberList.Add(int.Parse(_stringOperations.SeparateStringValuesWithComma(userInput)[i]));
                }

                listIsCorrect = true;

            }
            numberList.Sort();

            _console.Write("Smallest numbers : ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(numberList[i].ToString() + ", ");
            }

        }
    }
}
