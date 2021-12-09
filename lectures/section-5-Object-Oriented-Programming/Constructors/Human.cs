using static System.Console; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks; 
using System.Text; 

namespace Constructors
{
    class Human 
    {
        // member variables; 
        public string firstName; 
        public string lastName; 

        // constructor; 
        // creates the properties of a human; 
        // each time somebody creates a human they need to have these variable types; 
        // constructor is like a method called whenever an object is created; 
        public Human(string firstName, string lastName)
        {
            // this - keyword, is saying that it wants to have the first and last name from this object; 
            // 
            this.firstName = firstName; 
            this.lastName = lastName; 
            
        }

        // Class member method; 
        public void IntroduceMyself()
        {
            WriteLine("Hi, I'm {0} {1}", firstName, lastName); 
        }
    }
}
