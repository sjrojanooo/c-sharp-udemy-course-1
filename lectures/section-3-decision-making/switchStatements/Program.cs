using System;

namespace switchStatements
{
    class Program
    {
        //introduction to switch and case statements
        static void Main(string[] args)
        {
            int age = 15; 

            switch(age)
            {   
                // if the age is 15 then the message will write out to the console;
                case 15: 
                    Console.WriteLine("Too young to party in the club"); 
                    //Break statement, otherwise the case will return an error; 
                    break; 
                case 25: 
                    Console.WriteLine("Good to go"); 
                    break; 

                // this is called whenever none of the others is true; 
                default:
                    Console.WriteLine("How old are you"); 
                    break; 
            }

            // instruction paused. We are asked to reproduce this as an if statement; 

            //decided to have some practice with the try parse method; 
            //if the value entered is incorrectly formatted then the user will restart the program; 
            Console.WriteLine("How old are you?");
            string input = Console.ReadLine(); 
            int ageEntered; 
            bool success = int.TryParse(input, out ageEntered);
            
            //will output to the console as either true or false; 
            Console.WriteLine("result is {0}", success); 
            
            // built a method that will conditionally output the message to the user; 
            if(success)
            {   
                //Calling the method age group; 
                AgeGroup(ageEntered); 
            }
            else
            {
                Console.WriteLine("input is {0} and is in the incorrect format. no fake id here. please restart program.", input); 
            }


            //Instructor solution 
            if (age == 15)
            {
                Console.WriteLine("Too young to party in the club."); 
            }
            else if (age == 15)
            {
                Console.WriteLine("Good to go"); 
            }
            else 
            {
                Console.WriteLine("How old are you then"); 
            }

            // switch statement that uses strings; 
            // these can be used not only with strings and integers but other data types as well; 
            string username = "Steven"; 

            switch(username)
            {
                case "Steven":
                Console.WriteLine("username is Steven"); 
                break; 

                case "root": 
                Console.WriteLine("username is root");
                break; 

                default: 
                Console.WriteLine("username is unknown."); 
                break; 

            }

            // will output the code above to the console; 
            Console.Read(); 
        }

        // paused lecture. building a method that will create an if statement in relation to the 
        // switch case statemetn above 

        public static void AgeGroup(int age)
        {
            if(age >= 21)
            {
                Console.WriteLine("admission to the night life."); 
            }
            else if ((age  >= 18 && age < 21))
            {
                Console.WriteLine("stick to homecoming you human"); 
            }
            else
            {
                Console.WriteLine("back home to mama you go."); 
            }
        }
    }
}
