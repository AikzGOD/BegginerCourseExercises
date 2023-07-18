using System;
using System.ComponentModel;

namespace HelloWorld
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2(1,2);
            //Exercise3();
            //Exercise4();
            //Exercise5();
            //Exercise6();
            //Exercise7();
            //Exercise8();
            Exercise9();


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

            //string input = Console.ReadLine();

            //string[] inputArray = input.Split(',');

            //int[] inputNumbers = new int[input.Length];

            //Console.WriteLine(inputArray);

            Console.WriteLine("Insert numbers divided by a comma");
            string input = Console.ReadLine();

            string[] numbers = input.Split(',');

            // Assume the first number is the max 
            int max = 0;

            foreach (string numero in numbers)
            {
                int number = int.Parse(numero);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max is {0} " , max);









            #endregion
        }

        #endregion

        #endregion



    }




}
