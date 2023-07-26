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
                SpeedCamera speedCamera = new SpeedCamera(speedLimit , carSpeed);
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
