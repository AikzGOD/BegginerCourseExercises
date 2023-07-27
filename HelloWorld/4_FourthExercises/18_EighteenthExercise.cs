using BegginerCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse.FourthExercises
{
    internal class EighteenthExercise : IExercise
    {
        private readonly IConsoleIO _console;

        private StringOperations _stringOperations;

        private readonly string[] userWords;

        public EighteenthExercise(IConsoleIO console)
        {
            _console = console;
            _stringOperations = new StringOperations();

        }

        /// <summary>
        /// Write a program and ask the user to enter a few words seperated by a space.
        /// Use the words to create a variable name with PascalCase.
        /// For example, if the user types:  "number of students", display "NumberOfStudents"
        /// Make sure that the program is not dependent on the input. SO if the user types
        /// "NUMBER OF STUDENTS", the program should still display "NumberOfStudents"
        /// </summary>
        public void Run()
        {
            string userInput;

            _console.WriteLine("Write a few words seperated by a space (e.g 'Number of students') : ");
            userInput = _console.ReadLine();

            if (String.IsNullOrEmpty(userInput))
            {
                _console.Warning("Invalid!");
                return;
            }

            userInput = userInput.ToLower();

            string[] userWords = userInput.Split(' ');

            //put the rest of the letters excluding the first one to lower of each word
            for (int i = 0; i < userWords.Length; i++)
            {
                userWords[i] = char.ToUpper(userWords[i][0]) + userWords[i].Substring(1).ToLower();
            }

            //Put the words all together.
            string pascalCase = string.Join("", userWords);

            _console.WriteLine(pascalCase);

        }
    }
}
