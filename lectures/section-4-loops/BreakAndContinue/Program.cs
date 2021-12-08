using System;

namespace BreakAndContinue
{
    class Program
    {

        // Intro to break and continue statements; 
        static void Main(string[] args)
        {

            // checking if 0 is below 10; 
            // 
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter); 
                // once the iteration equals 3 then the message will output to the console. 
                if(counter == 3)
                {
                    System.Console.WriteLine("At 3 we stop");
                    // this will break out of the for loop once the counter has reached a value of 3; 
                    break; 
                }
            }

            // using the continue statement; 
            for (int counter = 0; counter < 10; counter++)
            {   
                // using the modulo operator to return an odd number; 
                // each time we don't have an odd number, the output will display to the console. 
                if(counter % 2  == 0)
                {
                    Console.WriteLine("now comes an odd number"); 
                    continue; 
                }
                // this output will display the odd number in the iteration. 
                Console.WriteLine(counter); 
            }

            Console.Read(); 

        }
    }
}
