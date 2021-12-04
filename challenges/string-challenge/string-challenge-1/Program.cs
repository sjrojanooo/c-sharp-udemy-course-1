using System;

namespace StringChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Grabbing input from user; 
            Console.WriteLine("Please Enter your name");
            //String variable assigned to persons name; 
            string myName =  Console.ReadLine(); 

            Console.WriteLine("please enter desired username"); 
            string userName = Console.ReadLine(); 

            //String input with special characers for example an email address; 
            Console.WriteLine("Please enter email address "); 
            string emailAddress = Console.ReadLine(); 
            
            //retrieving birthday in mm/dd/yyyy format to ignore all white spaces and special characters
            Console.WriteLine("Please enter date of birth in mm/dd/yyyy format"); 
            string birthDate = Console.ReadLine(); 
            //Will be using this to display a verbatim string which ignores special characters 

            Console.WriteLine("hello {0} ",String.Format(myName.ToUpper())); // Converts the name to all upper cased values 
            Console.WriteLine("hello {0}", String.Format(myName.ToLower())); //Converts the name entered to an all lower case value
            Console.WriteLine(@"Hello " + String.Format(emailAddress).Trim()); //Trims all white spaces from email address 
            Console.WriteLine(@"Birthday is: " + String.Format(birthDate).Trim()); // Trims all white spaces and read the date as a string value
            Console.WriteLine("Username: {0}", String.Format(userName.Substring(0,5))); // starts reading the value from the first position of the string 




        }
    }
}

