using BegginerCourse;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse.FifthExercises
{
    internal class TwentyFirstExercise : IExercise
    {
        private readonly IConsoleIO _console;
        private readonly StringOperations _stringOperations;

        public TwentyFirstExercise(IConsoleIO console)
        {
            _console = console;
            _stringOperations = new StringOperations();
        }

        /// <summary>
        /// Write a program that reads a text file and displays
        /// the longest word in the file
        /// </summary>
        public void Run()
        {
            _console.WriteLine("Insert a path for an txt file");
            string userInput = _console.ReadLine();
            string path = @"";

            path = path + userInput;

            if (String.IsNullOrEmpty(userInput))
            {
                _console.Warning("PathInvalid");

                path = @"";

                Run();
            }

            FileInfo fi = new FileInfo(path);

            if (fi.Extension != ".txt")
            {
                _console.Warning("PathInvalid");

                Run();
            }
            else
            {
                StreamReader sr = new StreamReader(path);

                string line = sr.ReadLine();

                string[] words = null;


                while (line != null)
                {
                    _console.WriteLine(line);
                    words = line.Split(' ');

                    line = sr.ReadLine();
                }

                sr.Close();

                int higherIndex = 0;

                for (int i = 0; i < words.Length - 1; i++)
                {
                    if (words[i].Length > words[i + 1].Length)
                    {
                        higherIndex = i;
                    }
                    else
                    {
                        higherIndex = i + 1;
                    }
                }

                _console.WriteLine("Maior palavra : " + words[higherIndex].ToString());
            }
        }
    }
}
