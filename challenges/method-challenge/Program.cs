using System;

namespace method_challenge
{
    //creating the constant variables that will hold the names of friends
    
    class Program
    {
        //Declaring the friend names as constants as their values will not change throughout the program; 
        const string firstFriend = "Michael"; 
        const string secondFriend = "Caity"; 
        const string thirdFriend = "Brandon"; 
        
        static void Main(string[] args)
        {
            string chosenFriend; 
            //asking for user input to display the name of friend behind the ranking;
            Console.WriteLine("please enter a number 1-3 to display friend behind ranking");
            //parsing the input as an integer; 
            int ranking = Int32.Parse(Console.ReadLine()); 

            //conditional statement that takes in the value and return the string;
            //I parse the in value ranking as string to display it into the console as a message; 
            if (ranking == 1)
            {
                chosenFriend = firstFriend; 
                GreetFriend(chosenFriend, ranking.ToString());
            }
            else if (ranking == 2)
            {
                chosenFriend = secondFriend; 
                GreetFriend(chosenFriend,ranking.ToString());
            }
            else
            {
                chosenFriend = thirdFriend; 
                GreetFriend(chosenFriend,ranking.ToString());
            }

            // finally just calling the method to greet all three friends 
            GreetAllFriends(firstFriend, secondFriend, thirdFriend); 

            Console.Read(); 
        }

        //constructing method to display the ranked value of the friend; 
        public static void GreetFriend(string friend, string rankedValue)
        {
            Console.WriteLine("Hi {0}, my friend you are ranked {1}!!", friend, rankedValue);
        }

        //greeting all three friends within the same method 
        public static void GreetAllFriends(string friend1, string friend2, string friend3)
        {
            Console.WriteLine("Hi {0}, my friend!!", friend1);
            Console.WriteLine("Hi {0}, my friend!!", friend2);
            Console.WriteLine("Hi {0}, my friend!!", friend3);

        }
    }
}
