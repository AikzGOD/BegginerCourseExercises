using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using static System.Net.Mime.MediaTypeNames;

namespace HelloWorld
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o numero do exercicio que pretende visualizar (1 - 21)\n");
            Console.WriteLine("*Nota - Exercicio 20 e 21 precisam de um path para um ficheiro .txt");

            string userInput = Console.ReadLine();
            int choosedExercise;
            if (int.TryParse(userInput, out choosedExercise) && choosedExercise > 0 && choosedExercise <= 21)
            {
                switch (choosedExercise)
                {
                    case 1:
                        Console.Clear();
                        Exercise1();
                        break;

                    case 2:
                        Console.Clear();
                        Exercise2(1,2);
                        break;

                    case 3:
                        Console.Clear();
                        Exercise3();
                        break;

                    case 4:
                        Console.Clear();
                        Exercise4();
                        break;

                    case 5:
                        Console.Clear();
                        Exercise5();
                        break;

                    case 6:
                        Console.Clear();
                        Exercise6();
                        break;

                    case 7:
                        Console.Clear();
                        Exercise7();
                        break;

                    case 8:
                        Console.Clear();
                        Exercise8();
                        break;

                    case 9:
                        Console.Clear();
                        Exercise9();
                        break;

                    case 10:
                        Console.Clear();
                        Exercise10();
                        break;

                    case 11:
                        Console.Clear();
                        Exercise11();
                        break;

                    case 12:
                        Console.Clear();
                        Exercise12();
                        break;

                    case 13:
                        Console.Clear();
                        Exercise13();
                        break;

                    case 14:
                        Console.Clear();
                        Exercise14();
                        break;

                    case 15:
                        Console.Clear();
                        Exercise15();
                        break;

                    case 16:
                        Console.Clear();
                        Exercise16();
                        break;

                    case 17:
                        Console.Clear();
                        Exercise17();
                        break;

                    case 18:
                        Console.Clear();
                        Exercise18();
                        break;

                    case 19:
                        Console.Clear();
                        Exercise19();
                        break;

                    case 20:
                        Console.Clear();
                        Exercise20();
                        break;

                    case 21:
                        Console.Clear();
                        Exercise21();
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Insira um numero válido");
                Console.ResetColor();

                Main(args);
            }



        }

        #region First Exercises

        #region Exercise 1

        public static void Exercise1()
        {
            #region Exercise 1

            //Exercise Write a program that asks a number between 1 and 10, if the inserted 
            //number is valid, display "Valid" on the console. Otherwise, display "Invalid"
            //No Verification needed (Assume that the user enters a value in the format the program expects)


            //Mocked Value
            int userNumber;

            Console.WriteLine("Insert a number between 1 and 10");

            string userInput = Console.ReadLine();

            userNumber = int.Parse(userInput);


            //If statement to check if userNuber is higher than 10, or less than 0
            if (userNumber < 0 || userNumber > 10)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("Valid");
            }

            #endregion
        }

        #endregion

        #region Exercise 2
        public static void Exercise2(int number1, int number2)
        {
            #region Exercise 2

            //Exercise : Write a program which takes two numbers from the console
            //and displays the maximum of the two.

            if (number1 > number2)
            {
                Console.WriteLine("{0} > {1} \nMax is {0}", number1, number2);
            }
            else if(number1 == number2){
                Console.WriteLine("{1} = {0} \n They are equal", number1, number2);
            }
            else
            {
                Console.WriteLine("{1} > {0} \nMax is {1}", number1, number2);
            }

            #endregion

        }

        #endregion

        #region Exercise 3
        public static void Exercise3()
        {
            #region Exercise 3

            //Write a program and ask the user to enter the width and height of an Image.
            //Then tell if the image is landscape or portrait

            //Ask the user the height of the image
            Console.WriteLine("Please insert the image Height");
            string imageHeightInput = Console.ReadLine();

            //Ask the user the width of the image
            Console.WriteLine("Please insert the image Width");
            string imageWidthInput = Console.ReadLine();

            //Convert the user Insert to int
            int imageHeight = int.Parse(imageHeightInput);
            int imageWidth = int.Parse(imageWidthInput);


            if(imageHeight > imageWidth)
            {
                Console.WriteLine("The image is: " + Image.Portrait);
            }
            else
            {
                Console.WriteLine("The image is: " + Image.Landscape);
            }

            #endregion

        }

        #endregion

        #region Exercise 4
        public static void Exercise4()
        {
            #region Exercise 4

            //Write a program for a speed camera. Ask the user for the speed limit and once set,
            //ask the user for the speed of a car. if the value is less than the limit display "Ok"
            //if the value is above the limit the program should calculate the number of demerit
            //points. For every 5km/hr above the speed limit, 1 demerit point should be incurred
            //and displayed. If the number of the demerit points is above 12, the program should
            //display "License Suspended"

            //Variable for the car Speed
            int carSpeed;

            //Variable for the speed Limit
            int speedLimit;

            //Ask the car Speed
            Console.WriteLine("Insert the car speed: ");
            string carSpeedInput = Console.ReadLine();

            //Ask the speed limit
            Console.WriteLine("Insert the speed limit: ");
            string speedLimitInput = Console.ReadLine();

            //Convert the input data
            carSpeed = int.Parse(carSpeedInput);
            speedLimit = int.Parse(speedLimitInput);

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {

                int demeritPoints = CalculateDemeritPoints(carSpeed,speedLimit);
                if(demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("Demerit Points: {0}" , demeritPoints);
                }
               
            }



            #endregion
        }

        public static int CalculateDemeritPoints(int carSpeed , int speedLimit)
        {
            const int kmPerDemeritPoint = 5;

            int demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;

            return demeritPoints;
            
        }

        #endregion

        #endregion

        #region Second Exercises

        #region Exercise 5

        public static void Exercise5()
        {
            #region Exercise 5

            //Write a program to count how many numbers between 1 and 100 are divisible
            //by 3 with no remainder. Displayh the count

            int counter = 0;

            for (int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);


            #endregion
        }

        #endregion

        #region Exercise 6

        public static void Exercise6()
        {
            #region Exercise 6

            //Write a program and continuously ask the user to enter
            //a number or ok to exit. Calculate the sum of all the previously entered
            //numberrs and display it on the console.

            int sum = 0;

            string userInput = "";


            while (true)
            {
                Console.WriteLine("Insert a number or write 'ok' to leave");
                userInput = Console.ReadLine();

                if (userInput.ToLower().Equals("ok"))
                {
                    break;
                }

                sum = sum + int.Parse(userInput);
            }

            Console.WriteLine("The sum of all numbers is : {0}" , sum);




            Environment.Exit(0);




            #endregion
        }

        #endregion

        #region Exericise7

        public static void Exercise7()
        {
            #region Exercise 7

            //Write a program and ask the user to enter a number.
            //Compute the factorial of the number and print it on the console.
            //For example, if the user enters 5, the program should create 5x4x3x2x1
            //and the display it as 5! = 120.


            //Ask the user a number
            Console.WriteLine("Please insert a number: ");
            string input = Console.ReadLine();

            int factorial = 1;


            int[] numbers = new int[int.Parse(input) + 1];

            for(int i = 1;  i < numbers.Length; i++)
            {
                numbers[i] = i;


                factorial = factorial * numbers[i];

            }

            Console.WriteLine("The factorial of {0} is : {1}" ,input, factorial);

            #endregion

        }

        #endregion

        #region Exercise 8

        public static void Exercise8()
        {
            #region Exercise 8

            //Write a program that picks a random number between 1 and 10. give the user
            //4 chances to guess the number. if the user guesses the number display "You won"
            //otherwise, display "You lost"

            Random random = new Random();

            //I put eleven in order to the program also generates the number 10
            int randomNumber = random.Next(1,11);

            //Number of tries
            int userTries = 4;

            string userInput = "";

            Console.WriteLine("Random number generated : " + randomNumber);

            

            for(int i = 0;  i < userTries; i++)
            {
                //Ask the user to guess the number
                Console.WriteLine("Guess the number between 1 and 10");
                userInput = Console.ReadLine();

                if (userInput == randomNumber.ToString())
                {
                    Console.WriteLine("You Won!!!");
                    break;
                }

            }
            
            if(userInput != randomNumber.ToString())
            Console.WriteLine("You Lost!!!");



            #endregion
        }


        #endregion

        #region Exercise 9

        public static void Exercise9()
        {
            #region Exercise 9

            //Write a program and ask the user to enter a series of numbers
            //seperated by comma. Find the maximum of the numbers and display it
            //on the console. For example, if the user enters "5,3,8,1,4" the program should
            //display 8.


            Console.WriteLine("Insert numbers divided by a comma");

            string input = Console.ReadLine();

            string[] numbers = input.Split(',');

            int max = 0;

            foreach (string numero in numbers)
            {
                int number = int.Parse(numero);

                if (number > max)
                {
                    max = number;

                }
            }

            Console.WriteLine("Max is {0} " , max);

            #endregion
        }

        #endregion

        #endregion

        #region Third Exercises

        #region Exercise 10

        public static void Exercise10()
        {
            #region Exercise 10

            //When you post a message on Facebook, depending on the number of people who
            //like your post, facebook displays different information
            //If no one likes, doesnt display anything
            //If only one person likes, it displays [Friend's Name] likes your post
            //If two people like your post, it displays [Friend 1] and [Friend 2] like your post
            //If more than two : [Friend 1] , [Friend 2] and [Number of other people] others like your post
            //
            //Write a program and continuously ask the user to enter different names, until
            //the user presses Enter(without supplying a name).
            //Depending on the number of names provided, display a message based on the above pattern

            List<string> names = new List<string>();

            string userInput;

            do
            {
                Console.WriteLine("Please insert a name (Or enter to stop)");
                userInput = Console.ReadLine();

                names.Add(userInput);

            } while (userInput != "");


            Console.WriteLine(names.Count);



            switch (names.Count)
            {
                case 1:
                    //Shows nothing
                    break;

                case 2:
                    //Shows Friend name
                    Console.Clear();
                    for(int i = 0; i < names.Count -1; i++)
                    {
                        Console.WriteLine(names[i] + " Liked your post");
                    }
                    break;

                case 3:
                    //Shows two friend name

                    Console.Clear();

                    for (int i = 0; i < names.Count - 1; i++)
                    {

                        Console.WriteLine(names[i]);
                    }

                    Console.WriteLine("Liked your post");

                    break;

                default:

                    for (int i = 0; i < 2; i++)
                    {

                        Console.Write(names[i] + " , ");
                    }

                    int numberOfLikes = names.Count - 3;

                    Console.WriteLine(" and {0} other people liked your post" , numberOfLikes);


                    break;


                   

            }


            #endregion
        }

        #endregion

        #region Exercise 11

        public static void Exercise11()
        {
            //Write a program and ask the user to enter their name. Use an array to reverse
            //the name and then store the result in a new string. Display the reversed name on the console

            List<string> names = new List<string>();

            string userInput;

            //Ask the user for a name
            Console.WriteLine("Insert a name to reverse");
            userInput = Console.ReadLine();

            char[] letters = userInput.ToCharArray();


            for(int i = 0; i < letters.Length;i++)
            {
                names.Add(letters[i].ToString());
            }

            names.Reverse();

            for(int i = 0;i < letters.Length; i++)
            {
                Console.Write(names[i]);
            }
            Console.WriteLine("");

        }

        #endregion

        #region Exercise 12

        public static void Exercise12()
        {
            #region Exercise 12

            //Write a program and ask the user to enter 5 numbers. If a number has been previously
            //entered, display an error message and ask the user to re-try. Once the user
            //Successfully enters 5 unique numbers, sort them and display the result on the console

            List <int> numbers = new List<int>();

            int userInput;


            for(int i = 0; i < 5; i++)
            {
                //Ask number to user
                Console.WriteLine("Insert a number: ");
                userInput = int.Parse(Console.ReadLine());

                if (numbers.Contains(userInput))
                {
                    Console.WriteLine("Number already in the list!");
                    i--;
                }
                else
                {
                    numbers.Add(userInput);
                }

                //Check if the number already exists
            }

            numbers.Sort();

            for(int i  =0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i]);
            }






            #endregion
        }

        #endregion

        #region Exercise 13

        public static void Exercise13()
        {
            #region Exercise 13

            //Write a program and ask the user to keep entering a number until type Quit
            //The list of numbers may incluide duplicates. Display the unique numbers that the user has entered

            //Ask the user a number ( if the user types "Quit" he will quit the app)

            List<int> numbers = new List<int>();
            List<int> uniqueNumbers = new List<int>();


            string userInput ="";

            while(userInput != "quit")
            {
                Console.WriteLine("Insert a number (Or type 'Quit' to exit)");
                userInput = Console.ReadLine();
                userInput.ToLower();

                if (!userInput.Equals("quit")) {
                    numbers.Add(int.Parse(userInput));
                }

            }

            for(int i =0  ; i < numbers.Count ; i++)
            {
                if (!uniqueNumbers.Contains(numbers[i])){
                    uniqueNumbers.Add(numbers[i]);
                }
            }

            for(int i =  0 ; i < uniqueNumbers.Count ; i++)
            {
                Console.WriteLine(uniqueNumbers[i]);
            }




            









            #endregion
        }

        #endregion

        #region Exercise 14

        public static void Exercise14()
        {
            //Write a program and ask the user to supply a list of comma
            //seperated numbers(5,1,9,2,10). If the list is empty or includes less than 5 numbers
            //Display "Invalid List" and ask the user to re-try; otherwise, Display the 3 smallest
            //numbers in the list

            string userInput = "";

            bool listIsCorrect = false;

            List<int> numberList = new List<int>();

            while (listIsCorrect == false)
            {
                //Ask user list with numbers
                Console.WriteLine("Insert a list of numbers 5+ seperated by comma (e.g : 1,2,3): ");
                userInput = Console.ReadLine();

                string[] numbers = userInput.Split(',');

                //check if the array numbers is less than 5
                if(numbers.Length < 5)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid List, try again");
                    continue;
                }

                for( int i = 0 ; i < numbers.Length ; i++)
                {
                    numberList.Add(int.Parse(numbers[i]));
                }
                
                listIsCorrect = true;

            }
            numberList.Sort();
            

            for(int i =0 ; i < 3 ; i++)
            {
                Console.WriteLine(numberList[i].ToString());
            }


        }

        #endregion


        #endregion

        #region Fourth Exercises

        #region Exercise 15
        public static void Exercise15()
        {
            #region Exercise 15

            //Write a program and ask the user to enter a few numbers
            //separated by a hyphen. Work out if the numbers are consecutive.
            //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
            //Display "Consecutive, otherwise display not Consecutive

            string userInput;

            //Ask the user for numbers
            Console.WriteLine(@"Insert list of numbers seperated by hyphen('5-6-7-8-9' or '20-19-18-17-16') : ");
            userInput = Console.ReadLine();
            string[] numbers = userInput.Split('-');

            for(int i = 0 ; i < numbers.Length - 1 ;i++)
            {
                int expectedNumber = int.Parse(numbers[i]);
                //Check if it is consecutive
                if (int.Parse(numbers[i + 1]) == (expectedNumber + 1))
                {
                    Console.WriteLine("Consecutive");
                }
                else if (int.Parse(numbers[i+1]) == (expectedNumber - 1)){
                    Console.WriteLine("Consecutive");
                }
                else
                {
                    Console.WriteLine("Not Consecutive");
                }
                
            }


            #endregion
        }

        #endregion

        #region Exercise 16

        public static void Exercise16()
        {
            #region Exercise 16

            //Write a program and ask the user to enter a feew numbers seperated by hyphen.
            //If the user simply presses Enter, without supplying an input, exit immediately
            //Otherwise, check to see if there are duplicates. If so, display "Duplicate"

            string userInput = "";

            do
            {
                Console.WriteLine("Insert numbers seperated by hyphen (1-2-3) (Press enter to leave) : ");
                userInput = Console.ReadLine();

                if (userInput == "")
                    break;

                string[] numbers = userInput.Split('-');

                List<string> numberList = new List<string>();

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (!numberList.Contains(numbers[i]))
                    {
                        numberList.Add(numbers[i]);
                    }
                    else
                    {
                        Console.WriteLine("Duplicate!");
                        continue;
                    }
                }
            } while (userInput == "");






            #endregion
        }

        #endregion

        #region Exercise 17
        public static void Exercise17()
        {
            #region Exercise 17

            //Write a program and ask the user to enter a time value in the
            //24 - hour time format (e.g 19:00). A valid time should be between
            //00:00 and 23:59. If the time is valid, display "Ok"; otherwise,
            //display "Invalid Time". If the user doesn't provide any values,
            //consider it as invalid time.

            string userInput;

            //Ask the user Input for the time date
            Console.WriteLine("Enter a time value in hour time format (e.g 19:00) : ");
            userInput = Console.ReadLine();

            if (String.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            string[] userDate = userInput.Split(':');

            if (userDate.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            if (int.Parse(userDate[0]) >= 00 && int.Parse(userDate[0]) <= 23 && int.Parse(userDate[1]) >= 00 && int.Parse(userDate[1]) < 59)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }


            #endregion
        }

        #endregion

        #region Exercise 18

        public static void Exercise18()
        {
            #region Exercise 18

            //Write a program and ask the user to enter a few words seperated by a space.
            //Use the words to create a variable name with PascalCase.
            //For example, if the user types:  "number of students", display "NumberOfStudents"
            //Make sure that the program is not dependent on the input. SO if the user types
            // "NUMBER OF STUDENTS", the program should still display "NumberOfStudents"

            string userInput;

            Console.WriteLine("Write a few words seperated by a space (e.g 'Number of students') : ");
            userInput = Console.ReadLine();

            if (String.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Invalid!");
                return;
            }

            userInput = userInput.ToLower();

            string[] userWords = userInput.Split(' ');

            for(int i = 0; i < userWords.Length; i++)
            {
                userWords[i] = char.ToUpper(userWords[i][0]) + userWords[i].Substring(1).ToLower();
            }

            string pascalCase = string.Join("", userWords);

            Console.WriteLine(pascalCase);










            #endregion
        }

        #endregion

        #region Exercise 19

        public static void Exercise19()
        {
            //Write a program and ask the user to enter an English word.
            //Count the number of vowels (a,e,i,o,u) in the word. So if
            //the user enters "inadequate", the program should display 6
            //on the console.

            string userInput;

            Console.WriteLine("Insert an English word : ");
            userInput = Console.ReadLine();

            if (String.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Invalid!");
                return;
            }

            userInput = userInput.ToLower().Trim();


            int numberOfVowels = 0;

            char[] vowels = new char[] {'a','e', 'i' , 'o' , 'u' };

            for(int i = 0; i < userInput.Length; i++)
            {
                if (vowels.Contains(userInput[i]))
                {
                    numberOfVowels++;
                }
            }

            Console.WriteLine(numberOfVowels);




        }

        #endregion




        #endregion

        #region Fifth Exercises

        #region Exercise 20
        public static void Exercise20()
        {
            #region Exercise 20

            //Write a program that reads a text file and displays
            //the number of words.

            //Ask the user file Path for .txt file

            Console.WriteLine("Insert a path for an txt file");
            string userInput = Console.ReadLine();
            string path = @"";

            path = path + userInput;

            if (String.IsNullOrEmpty(userInput))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("PathInvalid");
                Console.ResetColor();

                path = @"";


                Exercise20();
            }

            FileInfo fi = new FileInfo(path);


            if(fi.Extension != ".txt")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("PathInvalid");
                Console.ResetColor();

                Exercise20();
            }
            else
            {
                StreamReader sr = new StreamReader(path);

                string line = sr.ReadLine();

                string[] words = null;


                while (line != null)
                {
                    Console.WriteLine(line);
                    words = line.Split(' ');

                    line = sr.ReadLine();
                }

                sr.Close();

                Console.WriteLine("Words in the file : {0}", words.Length);
            }

            

            #endregion

        }

        #endregion

        #region Exercise 21

        public static void Exercise21()
        {
            //Write a program that reads a text file and displays
            //the longest word in the file

            Console.WriteLine("Insert a path for an txt file");
            string userInput = Console.ReadLine();
            string path = @"";

            path = path + userInput;

            if (String.IsNullOrEmpty(userInput))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("PathInvalid");
                Console.ResetColor();

                path = @"";


                Exercise21();
            }

            FileInfo fi = new FileInfo(path);

            if (fi.Extension != ".txt")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("PathInvalid");
                Console.ResetColor();

                Exercise21();
            }
            else
            {
                StreamReader sr = new StreamReader(path);

                string line = sr.ReadLine();

                string[] words = null;


                while (line != null)
                {
                    Console.WriteLine(line);
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

                Console.WriteLine("Maior palavra : " + words[higherIndex].ToString());
            }
        }

        #endregion

        #endregion



    }




}
