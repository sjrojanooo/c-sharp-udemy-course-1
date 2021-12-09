using static System.Console; // changing the way I am calling my directives. Will result a some cleaner code
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 

namespace FirstClass
{
    // this class is a blueprint for a datatype; 
    class Human
    {
        // creating member variables for human 
        public string firstName; // adding the public makes this variable accessible from outside of this class
        public string lastName; 

        // if you were to make a private string that would be constant member variable that can't be altered;
        // we could make a string variable company, if we were welcoming them to a company upon acceptance; 
        private string company = "SJR-Analytics"; 
        // member 
        public void IntroduceMyself()
        {
            WriteLine("Introducing {0} {1}, founder of {2}. Let's automate your tasks together.", firstName, lastName, company); 
        }
    }
}