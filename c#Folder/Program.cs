using System;

namespace SalaryMonster
{
    class SalaryMonster
    {
        static void Main(string[] args)
        {
            // Define variables
            double salary, amountPercent;
            int amountRaise;
            string salaryString, amountString;
            // Prompt user input
            Console.WriteLine("Please enter the salary: ");
            salaryString = Console.ReadLine();
            salary = Convert.ToDouble(salaryString);

            Console.WriteLine("Please enter the raise amount or raise percent:");
            amountString = Console.ReadLine();
            // if statement based on user input 
            if (amountString.Contains(".")){
                amountPercent = Convert.ToDouble(amountString);
                Calculate(salary, amountPercent);
            }
            else
            {
                amountRaise = Convert.ToInt32(amountString);
                Calculate(salary, amountRaise);
            }
            
        }

        private static double Calculate(double salary, double rate)
        {
            double raise = salary * rate;
            double newSalary = salary + raise;
            Console.WriteLine("The initial salary is: ${0}", salary);
            Console.WriteLine("The raise amount is ${0}", raise);
            Console.WriteLine("The new salary is ${0}", newSalary);
            return newSalary;
        }

        private static double Calculate(double salary, int amount)
        {
            double newSalary = salary + amount;
            Console.WriteLine("The initial salary is: ${0}", salary);
            Console.WriteLine("The raise amount is ${0}", amount);
            Console.WriteLine("The new salary is ${0}", newSalary);
            return newSalary;
        }
    }

}
