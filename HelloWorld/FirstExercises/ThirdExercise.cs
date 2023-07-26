using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse.FirstExercises
{
    internal class ThirdExercise : IExercise
    {
        private readonly IConsoleIO _console;
        private readonly NumberValidator _numberValidator;


        public ThirdExercise(IConsoleIO console)
        {
            _console = console;
            _numberValidator = new NumberValidator();
        }

        public void Run()
        {
            //Ask the user the height of the image
            _console.WriteLine("Please insert the image Height");
            string imageHeightInput = _console.ReadLine();

            //Ask the user the width of the image
            _console.WriteLine("Please insert the image Width");
            string imageWidthInput = _console.ReadLine();

            //Verify if the image dimensions are numbers.
            if (_numberValidator.IsNumberValid(imageHeightInput, out int imgHeight) && _numberValidator.IsNumberValid(imageWidthInput, out int imgWidth)){

                ImageFunctions imageFunctions = new ImageFunctions(imgHeight,imgWidth);

                _console.WriteLine(imageFunctions.ImageType());
            }
            else
            {
                _console.ClearScreen();
                _console.WriteLine("Invalid Input!");
                Run();
            }

        }
    }
}
