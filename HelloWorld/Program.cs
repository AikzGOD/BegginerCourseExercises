using BegginerCourse.FirstExercises;
using BegginerCourse.SecondExercises;
using BegginerCourse.FifthExercises;
using BegginerCourse.FourthExercises;
using HelloWorld.ThirdExercises;

namespace BegginerCourse
{
    internal partial class Program
    {
        static IConsoleIO console = new ConsoleIO();

        static void Main(string[] args)
        {
           DisplayExerciseMenu();
        }

        static void DisplayExerciseMenu()
        {
            console.WriteLine("Insira o número do exercício que pretende visualizar (1 - 21)");
            console.WriteLine("*Nota - Exercício 20 e 21 precisam de um path para um ficheiro .txt");

            string userInput = console.ReadLine();
            if (int.TryParse(userInput, out int number))
            {
                switch (number)
                {
                    case 1:
                        RunExercise(new FirstExercise(console));
                        break;

                    case 2:
                        RunExercise(new SecondExercise(console));
                        break;

                    case 3:
                        RunExercise(new ThirdExercise(console));
                        break;

                    case 4:
                        RunExercise(new FourthExercise(console));
                        break;

                    case 5:
                        RunExercise(new FifthExercise(console));
                        break;

                    case 6:
                        RunExercise(new SixthExercise(console));
                        break;

                    case 7:
                        RunExercise(new SeventhExercise(console));
                        break;

                    case 8:
                        RunExercise(new EighthExercise(console));
                        break;

                    case 9:
                        RunExercise(new NinthExercise(console));
                        break;

                    case 10:
                        RunExercise(new TenthExercise(console));
                        break;

                    case 11:
                        RunExercise(new EleventhExercise(console));
                        break;

                    case 12:
                        RunExercise(new TwelfthExercise(console));
                        break;

                    case 13:
                        RunExercise(new ThirteenthExercise(console));
                        break;

                    case 14:
                        RunExercise(new FourteenthExercise(console));
                        break;

                    case 15:
                        RunExercise(new FifteenthExercise(console));
                        break; ;

                    case 16:
                        RunExercise(new EighteenthExercise(console));
                        break;

                    case 17:
                        RunExercise(new SeventeenthExercise(console));
                        break;

                    case 18:
                        RunExercise(new EighteenthExercise(console));
                        break;

                    case 19:
                        RunExercise(new NineteenthExercise(console));
                        break;

                    case 20:
                        RunExercise(new TwentiethExercise(console));
                        break;

                    case 21:
                        RunExercise(new TwentyFirstExercise(console));
                        break; ;

                    default:
                        console.ClearScreen();
                        console.Warning("Insira numero válido");
                        DisplayExerciseMenu();
                        break;
                }
                
            }
            else
            {
                console.ClearScreen();
                console.Warning("Insira numero válido");
                DisplayExerciseMenu();
            }
        }

        static void RunExercise(IExercise exercise)
        {
            console.ClearScreen();
            exercise.Run();
        }
    }
}
