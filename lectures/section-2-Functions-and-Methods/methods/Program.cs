using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
           //Simply writing a string out to the console;
           WriteSomething(); 
           //Calling the method and outputting something specific;
           //This could be used in a situation where you are taking in the user input;
           //or when you want to conditionally display something to them;
           WriteSomethingSpecific("An argument called from a method");
           //Calls the method withint the WriteLine Method and displaying it in the console;
           Console.WriteLine(Add(15,13)); 
           //Calling the add method within the add method and writing it to the console; 
           Console.WriteLine(Add(Add(23,22), Add(25, 80))); 

           //Calling the Multiply method and writing the result; 
           Console.WriteLine((Multiply(25, 25))); 

           //Calling the Divide method and return the result;
           Console.WriteLine((Divide(100,50))); 

           //using two methods simultaneously getting the product of two values and dividing the results;
           Console.WriteLine((Divide(Multiply(100,100),Multiply(20,2)))); 
           //Displays the output onto the console
           Console.Read();  
        }
        // access modifier (static) return type method name (parameter1, parameter2); 
        public static void WriteSomething() 
        {
            Console.WriteLine("String that is being called from a method"); 
        }
        //method that is given a parameter and will be called within the main method;
        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
        // method that will simply add two values, declaring both parameters as integer types;
        public static int Add(int num1, int num2)
        {
            return num1 + num2; 
        }
        // method that multiplies two values and return the result of the calclulation; 
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2; 
        }
        // method that will divide the two parameter given when calling the method;
        public static double Divide(double num1, double num2)
        {
            return num1 / num2; 
        }
    }
}
