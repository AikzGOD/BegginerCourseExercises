using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse.FirstExercises
{
    internal class FourthExercise  : IExercise
    {
        private readonly IConsoleIO _console;
        private readonly NumberValidator _numberValidator;

        public FourthExercise(IConsoleIO console)
        {
            _console = console;
            _numberValidator = new NumberValidator();
        }

        /// <summary>
        /// Write a program for a speed camera. Ask the user for the speed limit and once set,
        /// ask the user for the speed of a car. if the value is less than the limit display "Ok"
        /// if the value is above the limit the program should calculate the number of demerit
        /// points. For every 5km/hr above the speed limit, 1 demerit point should be incurred
        /// and displayed. If the number of the demerit points is above 12, the program should
        /// display "License Suspended"
        /// </summary>
        public void Run()
        {
            //Ask the car Speed
            _console.WriteLine("Insert the car speed: ");
            string carSpeedInput = _console.ReadLine();

            //Ask the speed limit
            _console.WriteLine("Insert the speed limit: ");
            string speedLimitInput = _console.ReadLine();

            //Verify if the userInputs are numbers
            if (_numberValidator.IsNumberValid(carSpeedInput, out int carSpeed) && _numberValidator.IsNumberValid(speedLimitInput, out int speedLimit))
            {
                SpeedCamera speedCamera = new SpeedCamera(carSpeed , speedLimit);
                _console.WriteLine(speedCamera.RunSpeedCamera());
            }
            else
            {
                _console.ClearScreen();
                _console.Warning("Invalid Input!");
                Run();
            }
        }
    }
}
