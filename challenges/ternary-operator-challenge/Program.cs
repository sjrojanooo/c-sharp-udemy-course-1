using System;

namespace ternary_operator_challenge
{
    /*
        Let's create a small application that takes a temperature value as input and checks if the input is an integer or not.

        If the input value is not an integer value, it should print to the console "Not a valid Temperature".

        And if the input value is the valid integer then it should work as mentioned below.

        If input temperature value is <=15 it should write "it is too cold here" to the console.

        If input temperature value is >= 16 and is <=28 it should write "it is ok" to the console.

        If the input temperature value is > 28 it should write "it is hot here" to the console.

        Make sure to use ternary operators and not if statements to check for the three conditions, however you can use if statement for the other conditions like to check if the entered value is a valid integer or not.
    */

    
    class Program
    {

        static string stateofTemperature; 

        //creating another independent challenge that will verify if the user has been approved for credit
        //depending on their credit score 

        static string approvalMessage; 

        static void Main(string[] args)
        {

            //accepting input from the user; 
            Console.WriteLine("What is the temperature today?"); 
            int temperature; 
            //using TryParse to validate the format of the entry; 
            bool success = int.TryParse(Console.ReadLine(), out temperature); 

            //conditionally output a message based on the entry above; 
            if(success)
            {
                //calling temperature method; 
                Temperature(temperature); 
            }
            else
            {
                Console.WriteLine("Not a valid temperature"); 
            }


            //simple programe that displays users credit score message upon entering thier score. 
            //calling the method credit score inside the conditional statement.
            System.Console.WriteLine("please enter your credit score");
            int creditScore; 
            bool successfulInput = int.TryParse(Console.ReadLine(), out creditScore);

            if (successfulInput)
            {
                CreditApproval(creditScore);
            }
            else
            {
                System.Console.WriteLine("Not a valid score.");
            }

            Console.Read(); 

        }

        public static void Temperature(int inputTemp)
        {
            stateofTemperature = inputTemp <= 15 ? 
            //true
            "it is too cold here":  
            //false
            (inputTemp <=28 && inputTemp >=16) ? 
            //true
            "it is ok": 
            //false
            inputTemp > 28 ? 
            //true 
            "it is too cold" : 
            //false
            "";
            Console.WriteLine(stateofTemperature); 
        }
        // decided to run another method to see if the indivdual qualified for a credit car 

        public static void CreditApproval(int num)
        {
            approvalMessage = num >= 850 ? 
            "amazing credit. you have been approved for 20,000":
            (num < 850 && num >= 600) ? 
            "good credit. you have been approved for 10,000": 
            (num < 600 && num >=450) ? 
            "fair credit. you get 2000": 
            num < 450 ?
            "improve your credit score please.":
             "";

            Console.WriteLine(approvalMessage);

        }
    }
}
