using System;

namespace WhileLoop2
{
    class Program
    {
        /* 
            This is my second attempt at the do while loop challenge, as I wanted to make sure that obtained a firm grasp. 
            I will be creating an interest rate calculator that will calculate the amount of interest owed based on the total 
            purchase amount entered by the user. if the user would like to continue he will enter another value, to quit he will enter q. 
            The program will use try parse to make sure the value entered is in the acceptable format, if not a conditional statement will 
            provide an output to the console, and a continue statement will prevent the program from crashing. 
        */
        static void Main(string[] args)
        {
            string input = "0"; //string variable, will be used to hold input from user;
            int counter = 0; // counter variable used to store the data of the current loop we are on;
            int purchases = 0; // will hold the input value of purchases the user enters;
            int total = 0; // will hold the number of purchases made;
            int totalPurchases = 0;  // The Grand summary of spending given from the users purchases value amounts entered;

            double interest = .169; // interest rate to calculate amount of bill; 

            while(input != "q")
            {
                Console.WriteLine("----------------------------"); 
                Console.WriteLine("Please enter purchase a value for purchase amount."); 
                input = Console.ReadLine(); 
                Console.WriteLine("----------------------------"); 
                Console.WriteLine("To end program enter q, otherwise enter another value"); 

                if(input.Equals("q"))
                {
                    // will initialize the calculation of total amount owed for credit card bill including interest;
                    Console.WriteLine("----------------------------"); 
                    Console.WriteLine("Total Purchases amounts entered {0}: ", total);
                    Console.WriteLine("----------------------------");  
                    Console.WriteLine("Number of purchases {0}", totalPurchases); 
                    Console.WriteLine("----------------------------"); 
                    //looked up the Math.Round() function, as I feel like I will be using this in the future. 
                    double totalAmountOwed = Math.Round((double) total * (1 + interest),2); 
                    Console.WriteLine($"\nCredit Card Bill is ${totalAmountOwed}"); 
                    Console.WriteLine("----------------------------"); 

                }

                if(int.TryParse(input, out purchases) && purchases > 0)
                {
                    // outputs each dollar amount entered by the user; 
                    Console.WriteLine("----------------------------"); 
                    Console.WriteLine("Purchase amount entered {0}", purchases); 
                    total += purchases; 
                    Console.WriteLine("----------------------------"); 
                    //keeping a running total of the amount of purchases made;
                    Console.WriteLine("Current running sum of purchases is {0}", total);
                    totalPurchases++; 

                }
                else
                {
                    // Important if statement that accepts the character input if it is anything other than a q then 
                    // it will request another entry in the correct format. 
                    if(!(input.Equals("q")))
                    {
                        Console.WriteLine("----------------------------"); 
                        Console.WriteLine("Please enter a value in the correct format or press q to quit.");
                        // statement ensures that the program will not crash if this condition results
                        continue;  
                    }
                }
                //initializing counter variable to prevent infinite loop; 
                //this counter will increment in value after all conditions from above have been met. 
                counter++;
            }
            Console.Read(); 


        }
    }
}
