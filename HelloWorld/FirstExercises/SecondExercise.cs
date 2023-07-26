using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse.FirstExercises
{
    internal class SecondExercise : IExercise
    {
        private readonly IConsoleIO _console;
        private readonly NumberValidator _numberValidator;


        public SecondExercise(IConsoleIO console)
        {
            _console = console;
            _numberValidator = new NumberValidator();

        }

        public void Run()
        {
            string number1,number2;


            _console.WriteLine("Insert Number 1: ");
            number1 = _console.ReadLine();
            if(!_numberValidator.IsNumberValid(number1, out int number))
            {
                _console.WriteLine($"Number {number1} is not valid.");
                _console.ClearScreen();
                Run();
            }
            else
            {
                _console.WriteLine("Insert Number 2: ");
                number2 = _console.ReadLine();
                if (!_numberValidator.IsNumberValid(number2, out int correctNumber))
                {
                    _console.WriteLine($"Number {number2} is not valid.");
                    _console.ClearScreen();
                    Run();
                }
                else
                {
                    if(_numberValidator.IsIdentical(number , correctNumber))
                    {
                        _console.WriteLine(number + " = " + correctNumber);
                        
                    }
                    else if(_numberValidator.IsGreaterThan(number, correctNumber))
                    {
                         _console.WriteLine(number + " > " + correctNumber);
                    }
                    else
                    {
                        _console.WriteLine(number + " < " + correctNumber);
                    }
                }
            }
            
        }
    }
}
