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
        private string firstName; 
        private string lastName; 

        // private variables added for challenge; 
        private string eyeColor; 
        public int age; 

        // constructor; 
        // creates the properties of a human; 
        // each time somebody creates a human they need to have these variable types; 
        // constructor is like a method called whenever an object is created; 


        /*
            IN CLASS CHALLENGE: 
            add two more variables to "Human" - eyeColor and age; 
            adjus the constructor, so it requires all of the four values to be used, when creating an object of Human; 
            create two object of type Human; 

            P.S. - I have the video paused at 7:04;
        */
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            // this - keyword, is saying that it wants to have the first and last name from this object; 
            // 
            this.firstName = firstName; 
            this.lastName = lastName; 
            this.eyeColor = eyeColor; 
            this.age = age; 

        }

        // Class member method; 

        // first you have to add the age parameter to identifty the persons age; 

        public void IntroduceMyself()
        {
            // challenge output a conditional method that will make years plurals if more than 1 year old. 
            if(age > 1)
            {
                WriteLine("Hi, I'm {0} {1}. I am {2} years old and have {3} eyes.", firstName, lastName, age, eyeColor); 
            }
            else
            {
                WriteLine("Hi, I'm {0} {1}. I am {2} year old and have {3} eyes.", firstName, lastName, age, eyeColor); 
            }

            
        }
    }
}
