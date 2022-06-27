/* This program is designed to prompt the user for possum sizes in inches, 
 * While returning the amount of possum sizes, the sum, and the average.
 * 
 * Written by Tristan Rogers 2021
 * */


using System;

namespace CollectPossumSizes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables
            int possumSize, average, sum;
            int count = 0;
            string inputString;
            // Prompt for first input
            Console.WriteLine("Please enter possum size in inches:");
            inputString = Console.ReadLine();
            possumSize = Convert.ToInt32(inputString);
            count = count + 1;
            sum = possumSize;

            // While loop for other values, with 0 as sentinel
            while(possumSize != 0)
            {
                Console.WriteLine("Please enter the next possum size, or enter 0 to quit:");
                inputString = Console.ReadLine();
                possumSize = Convert.ToInt32(inputString);
                sum += possumSize;

                // Ensures that a possum is not counted for a zero value
                if (possumSize != 0)
                    ++count;
            }
            // Display Output
            Console.WriteLine("The total amount of possum sizes entered is {0}", count);
            Console.WriteLine("The combined total of the possum sizes is {0}\"", sum);
            average = sum / count;
            Console.WriteLine("The average possum size is {0}\"", average);

            // Keeps window open
            Console.ReadKey();
        }
    }
}
