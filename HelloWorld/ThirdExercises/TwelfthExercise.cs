using BegginerCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ThirdExercises
{
    internal class TwelfthExercise : IExercise
    {
        private readonly IConsoleIO _console;
        private readonly NumberValidator _numberValidator;
        List<int> numbers = new List<int>();


        public TwelfthExercise(IConsoleIO console)
        {
            _console = console;
            _numberValidator = new NumberValidator();
        }

        /// <summary>
        /// Write a program and ask the user to enter 5 numbers. If a number has been previously
        /// entered, display an error message and ask the user to re-try. Once the user
        /// Successfully enters 5 unique numbers, sort them and display the result on the console
        /// </summary>
        public void Run()
        {
            _console.WriteLine("Let's Insert 5 numbers.");
            for (int i = 0; i < 5; i++)
            {
                //Ask number to user
                _console.WriteLine("Insert a number (Enter to stop): ");
                string userInput = _console.ReadLine();

                if(_numberValidator.IsNumberValid(userInput, out int number))
                {
                    if (numbers.Contains(number))
                    {
                        //Check if the number already exists
                        _console.WriteLine("Number already in the list!");
                        i--;
                    }
                    else
                    {
                        //Add number to the list
                        numbers.Add(number);
                    }
                }
                else
                {
                    _console.Warning("Wrong Input!");
                }
            }

            numbers.Sort();

            for (int i = 0; i < numbers.Count; i++)
            {
                _console.Write(numbers[i] + ",");
            }
        }
    }
}
