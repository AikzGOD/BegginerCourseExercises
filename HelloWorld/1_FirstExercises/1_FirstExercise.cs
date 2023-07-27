using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse.FirstExercises
{
    internal class FirstExercise : IExercise
    {
        private readonly IConsoleIO _console;
        private readonly NumberValidator _numberValidator;


        public FirstExercise(IConsoleIO console)
        {
            _console = console;
            _numberValidator = new NumberValidator();
        }

        /// <summary>
        /// Exercise Write a program that asks a number between 1 and 10, if the inserted
        /// number is valid, display "Valid" on the console. Otherwise, display "Invalid"
        /// No Verification needed (Assume that the user enters a value in the format the program expects)
        /// </summary>
        public void Run()
        {
            _console.WriteLine("Insert a number between 1 and 10");

            string userInput = _console.ReadLine();

            //Check if it is number
            if (_numberValidator.IsNumberValid(userInput, out int number))
            {
                //If statement to check if userNuber is higher than 10, or less than 0
                if (number < 0 || number > 10)
                {
                    _console.Warning("Invalid");
                }
                else
                {
                    _console.WriteLine("Valid");
                }
            }
            else
            {
                _console.ClearScreen();
                Run();
            }
            
        }

        
    }
}
