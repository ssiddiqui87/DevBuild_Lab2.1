using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the room calculator!");

            // variable to determine if program needs to run again
            char runAgain = 'y'; 

            //Will keep looping if user types 'y'
            while (runAgain == 'y')
            {
                //Get user input for length, width, height
                Console.Write("Please enter the length: ");
                string inputLength = Console.ReadLine();
                Console.Write("Please enter the width: ");
                string inputWidth = Console.ReadLine();
                Console.Write("Please enter the height: ");
                string inputheight = Console.ReadLine();

                //Parse string input to doubles
                double length = double.Parse(inputLength);
                double width = double.Parse(inputWidth);
                double height = double.Parse(inputheight);
                
                //Calculate perimeter, area, and volume
                double perimeter = 2 * (length + width);
                double area = length * width;
                double volume = length * width * height;

                //Output perimeter, area, and volume
                Console.WriteLine("The perimeter is: " + perimeter);
                Console.WriteLine("The area is: " + area);
                Console.WriteLine("The volume is: " + volume);

                //Output room size based on area
                if (area >= 650)
                {
                    Console.WriteLine("The room size is: Large");
                }
                else if (area >= 250)
                {
                    Console.WriteLine("The room size is: Medium");
                }
                else
                {
                    Console.WriteLine("The room size is: Small");
                }

                //Prompt user to see if they want to run again
                Console.Write("Do you want to run the calculator again? (y/n): ");
                string inputRunAgain = Console.ReadLine();

                //Update char value for while loop
                runAgain = char.Parse(inputRunAgain);
            }

            Console.WriteLine("Thank you for using the room calculator!");

        }
    }
}
