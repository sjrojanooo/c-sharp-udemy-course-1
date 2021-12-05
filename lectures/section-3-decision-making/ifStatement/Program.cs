using System;

namespace ifStatement
{
    class Program
    {
        //Conditional if statements; in this lecture the instructor is only going over 
        //the if statement, but I decided to incorporate my knowledge of else if statements.; 
        static void Main(string[] args)
        {
            //Instructor example; 
            int temperature = 10; 

            if (temperature < 10)
            {
                Console.WriteLine("Take the coat"); 
            }
            if(temperature == 10)
            {
                Console.WriteLine("It's 10 Degrees"); 
            }
            if(temperature > 10)
            {
                Console.WriteLine("Cozy and warm"); 
            }

            /* 
            In class student practice. I decided to recieve an input from the user 
            and applying a try catch block to handle errors if the user were to input 
            a null value or string character. I decided to use the FormatException
            with message that will output "Input value was not in the correct format" The finally
            block will make sure to exit the program. The following code was done on my own; 
            */

            Console.WriteLine("What is temperature outside?"); 
            int weatherInput = int.Parse(Console.ReadLine()); 
            // Listening for the enter input for value; 
            try
            {
                if(weatherInput < 60)
                {
                    Console.WriteLine("We are not in Yuma anymore.");
                }

                else if(weatherInput >= 60 && weatherInput < 80)
                {
                    Console.WriteLine("Blue skys, clear eyes, full hearts. Perfect day."); 
                }
                else
                {
                    Console.WriteLine("Beach Day baby!");
                }

                
            }
            catch (FormatException)
            {   
                Console.WriteLine("Input value was not in the correct format");
            }
            finally
            {
                Console.WriteLine("Exit Code"); 
            }
            // Providng the output to the console;
            

            // Wanted to try and have some practice with methods and simply placing 
            // the method within the try block;

            //applyting the call back method within this new tryCatch block; 
            //Code looks much cleaner with the call back method approach; 
            try 
            {
                WeatherReaction(weatherInput);
            }
            catch (FormatException)
            {   
                Console.WriteLine("Input value was not in the correct format");
            }
            finally
            {
                Console.WriteLine("Exit Code"); 
            }
            
            //Ensure Console.Read() is listed at the end of the script to provide console with all ouptuts; 
            Console.ReadKey(); 
            Console.Read();
            
        }

        // The method is public which mean it can be used anywhere in the program; 
        // I will not have a return type so I will be using void to return the message; 
        // The name of the method is WeatherReaction and finally my paramter that will be used is 
        // an int variable for weatherInput recieved from the user. 

        public static void WeatherReaction(int temp)
        {
            //same concept from above but instead of potentially having to re-write the conditional statement out everytime 
            //I will call this method and return the message; 
            if(temp < 60)
            {
                Console.WriteLine("We are not in Yuma anymore.");
            }
            else if((temp == 60) && (temp < 80))
            {
                Console.WriteLine("Blue skys, clear eyes, full hearts. Perfect day."); 
            }
            else
            {
                Console.WriteLine("Beach Day baby!");
            }
        }
    }
}
