using BegginerCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse.SecondExercises
{
    internal class SixthExercise : IExercise
    {
        private readonly IConsoleIO _console;
        private readonly NumberValidator _numberValidator;
        private List<int> numberList = new List<int>();



        public SixthExercise(IConsoleIO console)
        {
            _console = console;
            _numberValidator = new NumberValidator();
        }

        public void Run()
        {

            while (true)
            {

                _console.Warning("Insert a number or write 'ok' to leave");
                string userInput = _console.ReadLine();

                if (userInput.ToLower().Equals("ok"))
                {
                    break;
                }

                //check if it's a number
                if(_numberValidator.IsNumberValid(userInput, out int newNumber))
                {
                    numberList.Add(newNumber);
                }
                else
                {
                    _console.Warning("Wrong input!");
                }


            }

            NumberOperations numberOperations = new NumberOperations();

            for (int i = 0; i < numberList.Count; i++)
            {
                numberOperations.SumThemAll(numberList);
            }

            _console.WriteLine("The sum of all numbers inputed is: " + numberOperations.SummedNumbers().ToString());


        }
    }
}
