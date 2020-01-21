using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the room calculator!");
            char runAgain = 'y';

            while (runAgain == 'y')
            {
                Console.Write("Please enter the length: ");
                string inputLength = Console.ReadLine();
                Console.Write("Please enter the width: ");
                string inputWidth = Console.ReadLine();
                Console.Write("Please enter the height: ");
                string inputheight = Console.ReadLine();

                double length = double.Parse(inputLength);
                double width = double.Parse(inputWidth);
                double height = double.Parse(inputheight);
                double perimeter = 2 * (length + width);
                double area = length * width;
                double volume = length * width * height;

                Console.WriteLine("The perimeter is: " + perimeter);
                Console.WriteLine("The area is: " + area);
                Console.WriteLine("The volume is: " + volume);

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

                Console.Write("Do you want to run the calculator again? (y/n): ");
                string inputRunAgain = Console.ReadLine();
                runAgain = char.Parse(inputRunAgain);
            }

            Console.WriteLine("Thank you for using the room calculator!");

        }
    }
}
