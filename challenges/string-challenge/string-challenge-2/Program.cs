using System;

namespace StringChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            //Grabbing input from user; 
            Console.WriteLine("enter a Sring here");
            //String variable assigned to persons name; 
            string input =  Console.ReadLine(); 
            //Searching for the character the user wishes to extract 

            
            Console.WriteLine("please enter character to search: "); 
            char searchIndex = Console.ReadLine()[0]; 

            //gets the index of the special character 
            int inputChar = input.IndexOf(searchIndex); 

            
            //retrieving input from user; 
            Console.WriteLine("Please enter your first name: ");
            string firstName =  Console.ReadLine(); 

            Console.WriteLine("Please enter your last name"); 
            string lastName = Console.ReadLine(); 

            //using the concatenation method to out put the first and last name input with a space between
            string fullName = string.Concat(firstName, " ", lastName);

            Console.WriteLine("Full Name: {0}",fullName);

            //find the index value of the first occurrence of the search index value in  the string
            Console.WriteLine("index of character {0} in string is {1}", searchIndex, inputChar); 





        }
    }
}

