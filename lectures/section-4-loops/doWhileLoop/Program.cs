using System;

namespace doWhileLoop
{
    class Program
    {
        // Introduction to the do while loop
        static void Main(string[] args)
        {
            int counter = 15; 
            
            do 
            {
                Console.WriteLine(counter); 
                // it is important to create a counter or difinitive statment 
                // that will finish or else you can create an infinite loop; 
                counter++; 
            }
            while( counter < 5); 


            int lengthOfText = 0; 
            string wholeText = ""; 

            do
            {
                Console.WriteLine("Please enter the name of a friend"); 
                string nameOfAFriend = Console.ReadLine(); 
                // returns the length of the text that user has entered; 
                int currentLength = nameOfAFriend.Length; 
                lengthOfText += currentLength; 
                wholeText += nameOfAFriend; 

            } while(lengthOfText < 20 && lengthOfText > 0); 
            // once the length of the text reaches a count of 20 characters this outpute will display to the user; 
            Console.WriteLine("Thanks, that was enough");
            
            Console.Read(); 


        }
    }
}
