using System;

namespace if_statement_challenge_2
{
    class Program
    {

        /*
        CHALLENGE 2; 
        Create an application with a score, highscore and a highscorePlayer.
        Create a method which has two parameters, one for the score and one for the playerName.
        When ever that method is called, it should be checked if the score of the player is higher than the highscore, if so, "New highscore is + " score" and in another line "New highscore holder is " + playerName - should be written onto the console, if not "The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer.
        Consider which variables are required globally and which ones locally.
        */
        // globally declaring highscore and highscorePlayer to use in multiple parts of the program; 
        static int highscore = 250;
        static string highscorePlayer; 
        

        static void Main(string[] args)
        {
            // accepting user inputs of name and score;
            Console.WriteLine("Please enter your name"); 
            string newPlayer = Console.ReadLine(); 
            Console.WriteLine("Enter the your score"); 
            string stringScore = Console.ReadLine(); 
            int newScore; 
            //using TryParse to verify the correct format was given as the input; 
            bool success = int.TryParse(stringScore, out newScore);
            

            // if success is true the condtion will call the HighScore method created below;
            if(success)
            {
                HighScore(newPlayer, newScore); 
            }
            //else it will return this exception; 
            else
            {
                Console.WriteLine("Value enterd {0}, is not in correct format. please restart program", stringScore); 
            }

            

            //instructor manually entered the score and the strings and did not request the highscore from the user; 
            // had a very similar approach to the method construction; 
            HighScore("Michael", 400); 
            HighScore("Caity", 450); 
            HighScore("Mini", 500); 

            Console.Read(); 

        }

        // method that produces an output conditionally on the score given; 
        public static void HighScore(string player, int score)
        {
            highscorePlayer = "Steven"; 

            if(score > highscore)
            {
                Console.WriteLine("New highscore is {0}", score); 
                Console.WriteLine($"New highscore holder is {player}");
            }
            else
            {
                Console.WriteLine("The old highscore of {0} could not be broken and is still held by {1}",highscore, highscorePlayer);
                Console.WriteLine("Please restart program to try again"); 
            }
        }
    }
}
