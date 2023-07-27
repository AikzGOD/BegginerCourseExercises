using BegginerCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse.FourthExercises
{
    internal class NineteenthExercise : IExercise
    {
        private readonly IConsoleIO _console;
        private StringOperations _stringOperations;
        

        public NineteenthExercise(IConsoleIO console)
        {
            _console = console;
            _stringOperations = new StringOperations();
        }

        /// <summary>
        /// Write a program and ask the user to enter an English word.
        /// Count the number of vowels (a,e,i,o,u) in the word. So if
        /// the user enters "inadequate", the program should display 6
        /// on the console.
        /// </summary>
        public void Run()
        {
            string userInput;

            _console.WriteLine("Insert an English word : ");
            userInput = _console.ReadLine();

            if (String.IsNullOrEmpty(userInput))
            {
                _console.WriteLine("Invalid!");
                return;
            }

            userInput = userInput.ToLower().Trim();

            _console.WriteLine("Number of vowels: " + _stringOperations.CountNumberOfVowels(userInput).ToString());


        }
    }
}
