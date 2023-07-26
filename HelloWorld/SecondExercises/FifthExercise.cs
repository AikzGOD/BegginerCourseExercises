using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse.SecondExercises
{
    internal class FifthExercise : IExercise
    {
        private readonly IConsoleIO _console;
        public FifthExercise(IConsoleIO console)
        {
            _console = console;
        }

        public void Run()
        {
            int counter = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    counter++;
                }
            }

            _console.WriteLine("In this class, we can see that there are: " + counter.ToString() + " numbers divisible by 3 between 1 and 100");
        }
    }
}
