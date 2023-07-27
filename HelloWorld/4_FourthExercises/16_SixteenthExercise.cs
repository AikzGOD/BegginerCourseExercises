using BegginerCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse.FourthExercises
{
    internal class SixteenthExercise : IExercise
    {
        private readonly IConsoleIO _console;

        private List<string> _numberList;

        private StringOperations _stringOperations;

        private string[] _numbers;


        public SixteenthExercise(IConsoleIO console)
        {
            _console = console;
            _numberList = new List<string>();
            _stringOperations = new StringOperations();
        }

        /// <summary>
        /// Write a program and ask the user to enter a feew numbers seperated by hyphen.
        /// If the user simply presses Enter, without supplying an input, exit immediately
        /// Otherwise, check to see if there are duplicates. If so, display "Duplicate"
        /// </summary>
        public void Run()
        {
            string userInput;

            do
            {
                _console.WriteLine("Insert numbers seperated by hyphen (1-2-3) (Press enter to leave) : ");
                userInput = _console.ReadLine();

                if (userInput == "")
                    break;

                _numbers = userInput.Split('-');

                for (int i = 0; i < _numbers.Length; i++)
                {
                    if (!_numberList.Contains(_numbers[i]))
                    {
                        _numberList.Add(_numbers[i]);
                    }
                    else
                    {
                        _console.Warning("Duplicate!");
                        continue;
                    }
                }
            } while (userInput == "");
        }
    }
}
