using BegginerCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ThirdExercises
{
    internal class ThirteenthExercise : IExercise
    {
        private readonly IConsoleIO _console;

        private List<int> numbers = new List<int>();
        private List<int> uniqueNumbers = new List<int>();
        private readonly NumberValidator _numberValidator;

        public ThirteenthExercise(IConsoleIO console)
        {
            _console = console;
            _numberValidator = new NumberValidator();
        }

        /// <summary>
        /// Write a program and ask the user to keep entering a number until type Quit
        /// The list of numbers may incluide duplicates. Display the unique numbers that the user has entered
        /// Ask the user a number ( if the user types "Quit" he will quit the app)
        /// </summary>
        public void Run()
        {
            string userInput = "";

            while (userInput != "quit")
            {
                _console.WriteLine("Insert a number (Or type 'Quit' to exit)");
                userInput = _console.ReadLine();
                userInput.ToLower();

                if (!userInput.Equals("quit"))
                {
                    if(_numberValidator.IsNumberValid(userInput , out int number))
                    {
                        numbers.Add(number);
                    }
                    else
                    {
                        _console.Warning("Wrong Input");
                    }
                }

            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!uniqueNumbers.Contains(numbers[i]))
                {
                    uniqueNumbers.Add(numbers[i]);
                }
            }

            _console.Write("Unique Numbers: ");

            for (int i = 0; i < uniqueNumbers.Count; i++)
            {
                _console.Write(uniqueNumbers[i].ToString() + " , ");
            }
            _console.WriteLine("");
        }
    }
}
