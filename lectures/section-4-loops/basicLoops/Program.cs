using System;
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 


namespace basicLoops
{
    class Program
    {
        /*
            Advantages of Loops 
            * Saves Time
            * Quick and easy repition of code 
            * Allows you to work with huge amounts of data 
            * Allows you too loop through arrays 
            
            Loop Types 
            * for loop 
                for(start value; condition ; increment)
                    code body
                    {
                        
                    }
            * while loop 
                countVariable = 0; 
                while (condition)
                {
                    - code that will be executed 
                    - need to have the counter variable in the body so that you don't confron an infinite loop
                    counterVariable++
                }
                will execute code as long as the condition is met

            * do while loop (does first then checks)
                counterVariable = 0; 
                - while loop will always run once. 
                do
                {
                    - execute some code 
                    counterVariable++
                }
                *while will only run if the condition is met. maybe to request data from a source. for instance on a time change of date change. 
                while(condition)

            * foreach loop (runs through arrays an list)
                - runs through an array 
                - only as long as there is content 
                - we will discuss this in the array chapter. 
        */
        static void Main(string[] args)
        {
            /* 
                1. set counter to a value;
                2. the condition tha the counter will meet. in is cas it will stop at 9;
                3. the incremenet will increase by 1;
            */
            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter); 
            };

            // this for loop will end at 45 since it is incrementing by 5 everytime; 
            for (int counter = 0; counter < 50; counter+=5)
            {
                Console.WriteLine(counter + " is lower than 50");
            };

            //in class challenge. Please write a for loop that only prints out the odd numbers from 0-20 
            for( int counter = 1; counter < 20; counter+=2)
            {
                Console.WriteLine(counter);
            };

            //Instructor solution -- Woo! got the same solution. almost thought we were going to use the modulo. 
            // but i remember that it will only return the remainder of the quotient. 
            
            for( int counter = 1; counter < 20; counter+=2)
            {
                Console.WriteLine(counter); 
            }; 

            Console.Read(); 
        }
    }
}
