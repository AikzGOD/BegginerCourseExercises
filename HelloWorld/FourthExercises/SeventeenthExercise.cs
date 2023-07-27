using BegginerCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse.FourthExercises
{
    internal class SeventeenthExercise : IExercise
    {
        private readonly IConsoleIO _console;

        private readonly StringOperations _stringOperations;

        private string[] _userDate;

        public SeventeenthExercise(IConsoleIO console)
        {
            _console = console;
            _stringOperations = new StringOperations();
        }

        /// <summary>
        /// Write a program and ask the user to enter a time value in the
        /// 24 - hour time format (e.g 19:00). A valid time should be between
        /// 00:00 and 23:59. If the time is valid, display "Ok"; otherwise,
        /// display "Invalid Time". If the user doesn't provide any values,
        /// consider it as invalid time.
        /// </summary>
        public void Run()
        {

            string userInput;

            //Ask the user Input for the time date
            _console.WriteLine("Enter a time value in hour time format (e.g 19:00) : ");
            userInput = _console.ReadLine();

            if (String.IsNullOrEmpty(userInput))
            {
                _console.Warning("Invalid Time");
                return;
            }

            _userDate = _stringOperations.SeparateStringValuesWithColon(userInput);

            if (_userDate.Length != 2)
            {
                _console.Warning("Invalid Time");
                return;
            }

            if (int.Parse(_userDate[0]) >= 00 && int.Parse(_userDate[0]) <= 23 && int.Parse(_userDate[1]) >= 00 && int.Parse(_userDate[1]) < 59)
            {
                _console.WriteLine("Ok");
            }
            else
            {
                _console.Warning("Invalid Time");
            }

        }
    }
}
