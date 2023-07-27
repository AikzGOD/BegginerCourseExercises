using BegginerCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ThirdExercises
{
    internal class TenthExercise : IExercise
    {
        private readonly IConsoleIO _console;

        private List <string> nameList = new List<string> ();

        public TenthExercise(IConsoleIO console)
        {
            _console = console;
        }

        /// <summary>
        /// When you post a message on Facebook, depending on the number of people who
        /// like your post, facebook displays different information
        /// If no one likes, doesnt display anything
        /// If only one person likes, it displays [Friend's Name] likes your post
        /// If two people like your post, it displays [Friend 1] and [Friend 2] like your post
        /// If more than two : [Friend 1] , [Friend 2] and [Number of other people] others like your post
        /// 
        /// Write a program and continuously ask the user to enter different names, until
        /// the user presses Enter(without supplying a name).
        /// Depending on the number of names provided, display a message based on the above pattern
        /// </summary>
        public void Run()
        {
            string userInput;

            do
            {
                Console.WriteLine("Please insert a name (Or enter to stop)");
                userInput = _console.ReadLine();

                nameList.Add(userInput);

            } while (userInput != "");


            LikesNumOutput(nameList.Count);
        }

        /// <summary>
        /// Select which output will show
        /// </summary>
        /// <param name="numberOfNames">Number of people who liked</param>
        private void LikesNumOutput(int numberOfNames)
        {
            switch (nameList.Count)
            {
                case 1:
                    //Shows nothing
                    break;

                case 2:
                    //Shows Friend name
                    _console.ClearScreen();
                    for (int i = 0; i < nameList.Count - 1; i++)
                    {
                        _console.WriteLine(nameList[i] + " Liked your post");
                    }
                    break;

                case 3:
                    //Shows two friend name

                    _console.ClearScreen(); 

                    for (int i = 0; i < nameList.Count - 1; i++)
                    {

                        _console.WriteLine(nameList[i]);
                    }

                    _console.WriteLine("Liked your post");

                    break;

                default:

                    for (int i = 0; i < 2; i++)
                    {

                        _console.Write(nameList[i] + " , ");
                    }

                    int numberOfLikes = nameList.Count - 3;

                    _console.WriteLine(" and " + numberOfLikes + " other people liked your post");
                    break;

            }
        }
    }
}
