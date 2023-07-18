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
            Exercise4();
        }

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

    }




}
