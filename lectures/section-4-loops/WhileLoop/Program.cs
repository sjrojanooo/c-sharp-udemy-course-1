using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 0; 

            // the while loop checks first before it does anything; 
            while(counter < 10)
            {
                System.Console.WriteLine(counter);
                counter++; 
            }

            // this will keep a running count of people aboarding a bus. It will break out once the user enters anything
            // but an empty string; 
            int peopleCounter = 0; 
            string enteredText = ""; 
            
            enteredText = Console.ReadLine(); 

            while(enteredText.Equals(""))
            {
                System.Console.WriteLine("press enter to continue, of any character to quit.", peopleCounter);
                enteredText = Console.ReadLine(); 
                peopleCounter++; 
                Console.WriteLine("Total of {0} on the bus today", peopleCounter);
            }
            Console.Read(); 

        }
    }
}
