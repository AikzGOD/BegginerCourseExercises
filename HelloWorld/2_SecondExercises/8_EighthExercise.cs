using BegginerCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse.SecondExercises
{
    internal class EighthExercise : IExercise
    {
        private readonly IConsoleIO _console;

        //Number of tries
        private int numberOfTries = 4;

        //Random number Generated
        private int randomNumber;

        //Result to check if the user Won or lost
        private bool result;

        public EighthExercise(IConsoleIO console)
        {
            _console = console;
        }

        /// <summary>
        /// Write a program that picks a random number between 1 and 10. give the user
        /// 4 chances to guess the number. if the user guesses the number display "You won"
        /// otherwise, display "You lost"
        /// </summary>
        public void Run()
        {
            randomNumber = GenerateRandomNumber();
            _console.WriteLine(randomNumber.ToString() + " (Only showed for tests)");

            for(int i = 0; i < numberOfTries; i++)
            {
                _console.WriteLine("Guess the number between 1 and 10");
                if(_console.ReadLine() == randomNumber.ToString())
                {
                    _console.WriteLine("You Won!!!");
                    result = true;
                    break;
                }

            }

            if (!result)
            {
                _console.Warning("You Lost!");
            }


        }

        /// <summary>
        /// Generate a random number between 1 and 10
        /// </summary>
        /// <returns>Return the random number between 1 and 10</returns>
        private int GenerateRandomNumber()
        {
            Random random = new Random();

            //I put eleven in order to the program also generates the number 10
            int randomNumber = random.Next(1, 11);

            return randomNumber;
        }
    }
}
