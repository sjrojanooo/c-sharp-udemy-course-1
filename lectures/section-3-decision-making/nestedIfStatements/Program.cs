using System;

namespace nestedIfStatements
{
    class Program
    {

        // building a login system 
        static void Main(string[] args)
        {
            bool isAdmin = false; 
            bool isRegistered = true; 
            string userName = "";
            Console.WriteLine("Please enter your username"); 
            userName = Console.ReadLine(); 

            // using a nested if statement approach to conditionally output decisions to the console; 
            if (isRegistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi there, registered user.");
                if(userName != "")
                {
                    Console.WriteLine("Hi there, {0}", userName); 
                    if(userName.Equals("Admin"))
                    {
                        Console.WriteLine("Hi there, Admin"); 
                    }
                } 
            }

            // Same concept as above but using an and statement to satify the same condition as above;
            if (isRegistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi there, registered user"); 
                Console.WriteLine("Hi there, {0}", userName);
                Console.WriteLine("Hi there, Admin"); 
            }

            // using the or statement to check if the person is admin or is registered; 
            // if either condition is true then the condition will be satisfied and the message will output to the console; 
            if(isAdmin || isRegistered )
            {
                Console.WriteLine("You are logged in"); 
            }
            Console.Read(); 
        }
    }
}
