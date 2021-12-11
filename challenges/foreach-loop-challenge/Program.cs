using System;
using static System.Console; 
using System.Threading.Tasks; 
using System.Text; 


namespace foreach_loop_challenge
{
    class Program
    {
        static void Main(string[] args)

            // was not able to complete the challenge on my own. 
            // I will be providing an independed challenge program for this exercise; 
        {   
            // takes care of knowing if we are talking about a valid or invalid data type; 
            Boolean valid = false; 
            // will be used catergorize the data type; 
            string inputValueType; 
            
            // requesting input from the user; 
            WriteLine("Enter a value."); 
            WriteLine("-----------------------------------------------"); 
            string inputValue = ReadLine(); 

            WriteLine("Select the data type to validate the input you have entered"); 
            WriteLine("Press 1 for String"); 
            WriteLine("Press 2 for Integer"); 
            WriteLine("Press 3 for Boolean"); 
            WriteLine("-----------------------------------------------"); 
            WriteLine("Enter : "); 

            int inputType = Convert.ToInt32(ReadLine()); 

            // the switch case is dependent on what the user has entered; 
            switch(inputType)
            {
                case 1:
                    // check for a valid string 
                    // will be creating a method for IsAllAlphabetic(); 
                    valid = IsAllAlphabetic(inputValue); 
                    inputValueType = "String"; 
                    break; 

                case 2: 
                    
                    int retValue = 0; 
                    // check for the integer using the TryParse method; 
                    valid = int.TryParse(inputValue, out retValue); 
                    inputValueType="Integer"; 
                    break; 
                
                case 3: 
                    bool retFlag = false; 
                    valid = bool.TryParse(inputValue, out retFlag); 
                    inputValueType = "boolean"; 
                    break; 

                default:
                    WriteLine("No input type detected."); 
                    inputValueType = "unknown"; 
                    break; 
            }
            WriteLine("-----------------------------------------------"); 

            if(valid)
            {
                WriteLine("You have entered a value : {0}", inputValueType); 
                WriteLine("-----------------------------------------------"); 
                WriteLine("Input value is a valid : {0}", inputValueType);
            }
            else
            {
                WriteLine("Entry is not a valid : {0}",  inputValueType);
            }

            ReadKey(); 
            // it is static since we aren't creating an object the class; 
            // method that checks is each character in the input string that the user provides us; 
            // this method will return a bool lean value; 
            // the parameter is the input value given by user; 
            static bool IsAllAlphabetic(string value)
            {
                // for each character in the value, we want to check if the char is a letteer, 
                // and if not a letter then the returned value will be false, otherwise true; 
                // if any character is a non-alphabetic type, the the loop will terminate and return false; 
                foreach(char c in value)
                {
                    if(!char.IsLetter(c))
                        return false; 
                }
                return true; 
            }
        }
    }
}
