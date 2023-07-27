using BegginerCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse.FourthExercises
{
    internal class FifteenthExercise : IExercise
    {
        private readonly IConsoleIO _console;
        private StringOperations _stringOperations;
        private NumberOperations _numberOperations;

        public FifteenthExercise(IConsoleIO console)
        {
            _console = console;
            _stringOperations = new StringOperations();
            _numberOperations = new NumberOperations();
            
        }

        /// <summary>
        /// Write a program and ask the user to enter a few numbers
        /// separated by a hyphen. Work out if the numbers are consecutive.
        /// For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
        /// Display "Consecutive", otherwise display "Not Consecutive"
        /// </summary>
        public void Run()
        {
            _console.WriteLine(@"Insert list of numbers seperated by hyphen('5-6-7-8-9' or '20-19-18-17-16') : ");
            string userInput = _console.ReadLine();

            if (_numberOperations.NumbersAreConsecutive(userInput.Split('-')))
            {
                _console.WriteLine("Consecutive");
            }
            else
            {
                _console.Warning("Not Consecutive");
            }

        }
    }
}
