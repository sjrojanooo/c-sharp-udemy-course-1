using System;

namespace user_input
{
    //Introduction to user input 
    class Program
    {
        static void Main(string[] args)
        {
            //Calling the method to run the program. 
            Calculate(); 
            Console.Read(); 
            
        }

        //Method that will calculate two value inputs from the user.
        public static void Calculate()
        {

            //retrieving user input for values
            Console.WriteLine("Please enter the first number"); 
            string number1Input = Console.ReadLine(); 
            Console.WriteLine("Please enter the second number"); 
            string number2Input = Console.ReadLine(); 

            //converting the string values into integers;
            int num1 = int.Parse(number1Input); 
            int num2 = int.Parse(number2Input); 

            //Calculating the users two input values; 
            int result = num1 +num2; 
            
            //Writing out the result to the console 
            Console.WriteLine(result); 
        }
    }
}
