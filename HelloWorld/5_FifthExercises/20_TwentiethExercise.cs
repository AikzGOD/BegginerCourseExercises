using BegginerCourse;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse.FifthExercises
{
    internal class TwentiethExercise : IExercise
    {
        private readonly IConsoleIO _console;

        private string[] words;
        
        private readonly StringOperations _stringOperations;


        public TwentiethExercise(IConsoleIO console)
        {
            _console = console;
            _stringOperations = new StringOperations();
        }

        /// <summary>
        /// Write a program that reads a text file and displays
        /// the number of words.
        /// Ask the user file Path for .txt file
        /// </summary>
        public void Run()
        {
            _console.WriteLine("Insert a path for a txt file");
            string userInput = _console.ReadLine();

            if (String.IsNullOrEmpty(userInput))
            {
                _console.Warning("PathInvalid");
                return;
            }

            FileInfo fi = new FileInfo(userInput);

            if (fi.Extension != ".txt")
            {
                _console.Warning("PathInvalid");
                return;
            }
            else
            {
                StreamReader sr = null;
                try
                {
                    sr = new StreamReader(userInput);
                    string line = sr.ReadLine();

                    int wordCount = 0;

                    while (line != null)
                    {
                        Console.WriteLine(line);
                        string [] words = line.Split(' ');
                        wordCount += words.Length;

                        line = sr.ReadLine();
                    }

                    _console.WriteLine("Words in the file: " + wordCount);
                }
                catch (Exception ex)
                {
                    _console.Warning("Error reading the file: " + ex.Message);
                }
                finally
                {
                    sr?.Close();
                }
            }
        }
    }
}
