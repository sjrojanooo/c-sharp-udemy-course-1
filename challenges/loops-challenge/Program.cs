using System;

namespace loops_challenge
{
    class Program
    {

        /*
            Imagine you are a developer and get a job in which you need to create a program for a teacher. He needs a program written in c# that calculates the average score of his students. So he wants to be able to enter each score individually and then get the final average score once he enters -1.
            So the tool should check if the entry is a number and should add that to the sum. Finally once he is done entering scores, the program should write onto the console what the average score is.
            The numbers entered should only be between 0 and 20. Make sure the program doesn't crash if the teacher enters an incorrect value.
            Test your program thoroughly.
        */
        static void Main(string[] args)
        {
            // declares the input variable as a string
            string input = "0"; 
            int count = 0; 
            int total = 0; 
            int currentNumber = 0; 

            while(input != "-1")
            {
                Console.WriteLine("Last number was {0}", currentNumber); 
                Console.WriteLine("Please enter the next score"); 
                Console.WriteLine("Current amount of entries {0}", count); 
                Console.WriteLine("Please enter -1 to calculate the average");

                input = Console.ReadLine(); 
                // if the input string value is -1 then the average will be calculated below; 
                if(input.Equals("-1"))
                {
                    Console.WriteLine("-----------------"); 
                    // calculate average and let the teacher know; 
                    double classAverage = (double) total / (double) count; 
                    Console.WriteLine("class average is {0}", classAverage); 
                } 
                // if the input value is and integer and the value is greateer than 0 and less than 100 
                // we will increment the total running sum by each value entered; 
                if(int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 100)
                {
                    total += currentNumber; 
                }
                // if the value entered is not a valid character and does not equal -1 then we request a valid 
                // input from the user; 
                else 
                {
                    if(!(input.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a value between 1 and 100"); 
                    }
                    // continue will continue with the program until the while statement is satisfied; 
                    continue; 
                }
                // count is incremented is only when all conditions are satisfied; 
                count++; 
            }
            Console.Read(); 

        }
    }
}
