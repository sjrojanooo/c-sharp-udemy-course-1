using static System.Console;
using System.Linq; 
using System.Collections.Generic; 
using System.Text; 
using System.Threading.Tasks; 



namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // using the constructor method to assing property types to our new human; 
            Human brother = new Human("Michal", "Rojano"); 

            // calling the IntroduceMyself method from class Human to output an introduction method; 

            /* 
                similar to using the TryParse constructor method with the int.TryParse(string value, output int)
                we are giving a constructor type which is int - and then proceed by calling the TryParse 
                method, which accepts the string value, and will provide the output variable type if true; 
            */

            brother.IntroduceMyself(); 

            // example of what I explained above; 
            WriteLine("please enter a whole number value"); 
            int inputValue = 0; 
            bool inputSuccess = int.TryParse(ReadLine(), out inputValue); 
            if(inputSuccess)
            {
                WriteLine(inputValue); 
            }
            else
            {
                WriteLine("Format Exception. Please enter a correct value");
            }

            
            // waits for the enter key pressed to exit the program, but still provides and output to the console; 
            ReadKey(); 

        }
    }
}
