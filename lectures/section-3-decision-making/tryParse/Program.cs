using System;

namespace tryParse
{
    class Program
    {
        // TryParse Lecture; 
        static void Main(string[] args)
        {
            //TryParse the string (returns a boolean)

            string numberAsString = "128"; 
            string numberFailed = "18xyz";

            int parseValue; 

            bool success;

            success = int.TryParse(numberFailed, out parseValue); 

            if (success)
            {
                Console.WriteLine("Parsing successful - number is {0}",parseValue); 
            }
            else
                Console.WriteLine("Parsing failed.");
            

            //Using tryParse with float data types; 
            //We want to make the TryParse case specific to the data type we want to look at; 

            float parsedValue; 
            success = float.TryParse(numberAsString, out parsedValue); 
            if (success)
            {
                Console.WriteLine("Parsing successful - number is {0}",parseValue); 
            }
            else
                Console.WriteLine("Parsing failed.");

            //Using the try parse method to handle incorrect format input from user
            //We are using the same example as we did for the decision making process for the weather. 

            Console.WriteLine("What is the temperature today?"); 
            string temperature = Console.ReadLine(); 
            int numTemp; 
            int number; 
            bool userEnteredNumber = int.TryParse(temperature, out number);

            //if the boolean returns a value of true then we will assign the numTemp variable
            //to the input given by the user; 
            if(userEnteredNumber)
            {
                numTemp = number; 
            }
            // else we assing the a value of 0 to the numTemp variable; 
            else
            {
                numTemp = 0; 
                Console.WriteLine("Value entered, was no number. 0 set as temperature");
            }

            if(numTemp < 60)
            {
                Console.WriteLine("Take a coat"); 
            }
            else if (numTemp >= 60 && numTemp < 80)
            {
                Console.WriteLine("No need for a coat today"); 
            }
            else
            {
                Console.WriteLine("Sleevless kind of day."); 
            }

            // the returned boolean is true when parsing was successful; 
            Console.Read();


        }
    }
}
