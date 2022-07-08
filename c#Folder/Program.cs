/* This program is designed to take a number that the user inputs to check if they won the lottery
 * Written by Tristan Rogers 2021
 */

using System;

namespace Lotteria
{
    class Lotteria
    {
        static void Main(string[] args)
        {
            // Create array and variables
            int[] winningNumbers = { 2, 19, 32, 36, 50, 52 };
            int numEntered;
            bool isWinningNumber = false;

            //Prompt user for number input
            Console.WriteLine("Please enter your SINGLE lottery number");
            numEntered = Convert.ToInt32(Console.ReadLine());

            // Loop to search array for matching number
            for(int x = 0; x < winningNumbers.Length; ++x)
            {
                if (numEntered == winningNumbers[x])
                    isWinningNumber = true;
            }

            // Output 
            Console.WriteLine("The date of this lottery drawing is 03/06/2021.");
            if (isWinningNumber)
                Console.WriteLine("Winner! Your number matches!");
            else
                Console.WriteLine("Loser! Better luck next time!");
            
            // Keeps window open
            Console.ReadKey();
        }
    }
}
