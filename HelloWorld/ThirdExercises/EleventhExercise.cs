using BegginerCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ThirdExercises
{
    internal class EleventhExercise : IExercise
    {
        private readonly IConsoleIO _console;
        private readonly StringOperations _stringOperations;

        public EleventhExercise(IConsoleIO console)
        {
            _console = console;
            _stringOperations = new StringOperations();

        }

        /// <summary>
        /// Write a program and ask the user to enter their name. Use an array to reverse
        /// the name and then store the result in a new string. Display the reversed name on the console
        /// </summary>
        public void Run()
        {
            //Ask the user for a name
            _console.WriteLine("Insert a name to reverse");
            string userInput = _console.ReadLine();

            _console.Write("\nReversed Name: ");
            _console.Warning(_stringOperations.ReverseString(userInput));
            _console.WriteLine("");
        }
    }
}
