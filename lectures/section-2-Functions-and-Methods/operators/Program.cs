using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5; 
            int num2 = 3; 
            int num3; 

            //unary operators;
            num3 = -num1; 
            Console.WriteLine("num3 is {0}", num3); 

            bool isSunny = true; 
            //output to the console will display as a it's original true value;
            Console.WriteLine("is it  sunny? {0}", isSunny);
            //to negate and output the opposite value of the initial bool value we will use
            //the ! operator. This is used to negate the value and present the opposite; 
            Console.WriteLine("Is it sunny? {0}", !isSunny); 

            //Increment operators; 
            int num = 0; 

            num++; 
            Console.WriteLine("num is {0}", num); //output: 1; 
            //post-increment operator;
            Console.WriteLine("num is {0}", num++); //output of the variable num will still be 1; 
            //pre-increment operator; 
            Console.WriteLine("num is {0}", ++num); //output to the console is now 3; 
            //pre-decrement operator; 
            Console.WriteLine("num is {0}", --num); //output: 2; 
            
            int result; 
            result = num1 + num2; 
            Console.WriteLine("result of num1 + num2 is {0}", result); 
            
            result = num1 - num2; 
            Console.WriteLine("result of num1 + num2 is {0}", result); 
            // returns the product
            result = num1 * num2; 
            Console.WriteLine("result of num1 * num2 is {0}", result);
            // "/" operator will return the quotient of two values;
            result = num1 / num2; 
            Console.WriteLine("result of num1 * num2 is {0}", result); 

            //Modulo operator will return the remainder of the quotient;
            //I've only grazed this operator in skim reading but its always stood out to me;
            //Instructor does say it is very useful in programming so I'm eager to see the specific use cases it will provide. 
            result = num1 % num2; 
            Console.WriteLine("result of num1 % num2 is {0}", result);
            
            // relational and type operators;
            bool isLower; 
            isLower = num1 < num2; //will output a true or false stirng once the condition is met; 
            Console.WriteLine("result of num1 < num2 is {0}", isLower);//output: False;

            bool isEqual; 
            isEqual = num1 == num2; 
            Console.WriteLine("result of num1 == num2 {0}", isEqual); //output: False; 

            // conditional operators; 
            bool isLowerAndSunny; 
            // && and conditional operator, both conditions must be met in order to result as true; 
            isLowerAndSunny = isLower && isSunny; 
            Console.WriteLine("result of isLower && isSunny {0}", isLowerAndSunny); 
            // || or conditional operators if any condition is true then the result will be true; 
            isLowerAndSunny = isLower || isSunny; 
            Console.WriteLine("result of isLower || isSunny {0}", isLowerAndSunny); 
            Console.ReadKey(); 
        }
    }
}
