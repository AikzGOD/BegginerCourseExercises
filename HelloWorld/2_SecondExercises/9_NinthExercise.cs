using BegginerCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse.SecondExercises
{
    internal class NinthExercise : IExercise
    {
        private readonly IConsoleIO _console;
        private readonly StringOperations _stringOperations;

        public NinthExercise(IConsoleIO console)
        {
            _console = console;
            _stringOperations = new StringOperations();
        }

        /// <summary>
        /// Write a program and ask the user to enter a series of numbers
        /// seperated by comma. Find the maximum of the numbers and display it
        /// on the console. For example, if the user enters "5,3,8,1,4" the program should
        /// display 8.
        /// </summary>
        public void Run()
        {
            //Int to find the max number inside the array
            int max = 0;

            _console.WriteLine("Insert numbers divided by a comma");

            //Get userInput
            string userInput = _console.ReadLine();
            var numbers = userInput.Split(',');

            foreach (string numero in numbers)
            {
                int number = int.Parse(numero);

                if (number > max)
                {
                    max = number;

                }
            }
            _console.WriteLine("Max is: " + max);

        }
    }
}
