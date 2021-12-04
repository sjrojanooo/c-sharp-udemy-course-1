using System;

namespace tryCatch
{

    //Introduction to try and catch errors
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number"); 
            string userInput = Console.ReadLine(); 

            //using try block to try and run the code, if an error occurs the catch 
            //block will be executed; 

            //if the user enters an int type value the value will be displayed;
            try 
            {
                int userInputAsInt = int.Parse(userInput); 
            }
            //else the catch block will run displaying the error message below; 
            //in this case we will use the format exception; 
            catch(FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time."); 
            }
            //Overflow error when the value has too little or too many value;
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception, the number was too long or too short for an int32."); 
            }
            //When user enters an empty value 
            catch(ArgumentNullException)
            {
                Console.WriteLine("Argument Null Exception, the value was empty (null)."); 
            }
            //this block can be used to start an internet connection or accessing a file and you want to close either; 
            //if an error occurs you want to close the connection using the finally block; 
            finally 
            {
                Console.WriteLine("This is called anyways");
            }
            //makes program wait for a key and prevents the screen until a key is pressed;
            //in this case reading in the user input from above; 
            Console.ReadKey();

            Console.WriteLine("enter a number"); 
            int firstNumber = int.Parse(Console.ReadLine()); 
            Console.WriteLine("enter a second number"); 
            int secondNumber = int.Parse(Console.ReadLine());

            Console.ReadKey();
            

            //Calling the Divide method and using user input as its value parameters. 
            Divide(firstNumber, secondNumber); 

        }

        //method to perform a simple division calculation based on two numbers; 
        //I will use a try catch block to catch a division by zero error; 
        //the finally block will exit the code and stop the program;
        public static void Divide(int num1, int num2)
        {
            try 
            {
                //calculation performed it acceptable values are recieved from user input. 
                int result = num1 / num2; 
                Console.WriteLine(result); 
            }
            //Exception that is thrown when trying to divide an integer by a zero value;
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by Zero"); 
            }
            finally {
                Console.WriteLine("Exiting code"); 
            }
        }
    }
}
