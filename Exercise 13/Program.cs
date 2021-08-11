using System;

namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {

            bool exitCondition = true;  // set initial state of exit condition
            while (exitCondition)
            {
                Console.WriteLine("Enter a number:");
                int inputNumber = int.Parse(Console.ReadLine());  // read user input
                for (int i = 0; i <= inputNumber; i++)
                {
                    int outputNumber = inputNumber - i; // calculate output value
                    Console.WriteLine(outputNumber);  // write output value
                }


                Console.WriteLine("Would you like to continue (y/n)?"); // prompt user to continue or exit

                if (Console.ReadLine().ToLower() != "y") // user input to continue or exit
                {
                    exitCondition = false;  // change condition to exit if user input other than y
                    Console.WriteLine("Goodbye!");
                }
            }


        }
    }
}
