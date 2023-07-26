using BegginerCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.SecondExercises
{
    internal class SeventhExercise : IExercise
    {

        private readonly IConsoleIO _console;

        public SeventhExercise(IConsoleIO console)
        {
            _console = console;
        }

        public void Run()
        {
            //Ask the user a number
            _console.WriteLine("Please insert a number: ");
            string userInput = _console.ReadLine();

            NumberOperations numberOperations = new NumberOperations();
            NumberValidator numberValidator = new NumberValidator();

            //Validate if userInput is a number
            if (numberValidator.IsNumberValid(userInput, out int factorial))
            {
                _console.WriteLine("The factorial of [" + factorial + "] , is : " + numberOperations.CalculateFactorialNumber(factorial));
            }
            else
            {
                _console.Warning("Wrong Input!");
            }
            
          

            


            
        }
    }
}
