using static System.Console;
using System.Linq;  
using System.Threading.Tasks; 
using System.Text; 


namespace MultipleConstructors
{
    class Human
    {
        // private member variables; 
        private string firstName; 
        private string lastName; 
        private string eyeColor; 
        private int age; 

        // default constuctor; 
        public Human() 
        {
            WriteLine("Constructor called. Object created."); 
        }

        /* 
            IN CLASS CHALLENGE: 
            Create two more constructors that will have the following parameters: 
            1. With only first and last name; 
            2. With only first name; 
        */


        // constructor used to grab user information that only have a first name;
        public Human(string firstName)
        {
            this.firstName = firstName; 
        }

        // constructor used to retrieve first and last name;
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName; 
            this.lastName = lastName; 
        }
        // contructor to retrieve first name, last name, and age; 
        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName; 
            this.lastName = lastName; 
            this.age = age; 

        }

        // Parameterized constructor that creates a human that doesnt have an age; 
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName; 
            this.lastName = lastName; 
            this.eyeColor = eyeColor; 

        }
        // parameterized constructor that capture all necessary member variables of user; 
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName; 
            this.lastName = lastName; 
            this.eyeColor = eyeColor; 
            this.age = age; 
        }


        /* 
            conditionally formatting output based on the information captured from the data source. 
            this would be useful if we are scanning an api and run accross instances where users did not provide 
            the information upon registration.
        */ 
        public void IntroduceMyself()
        {
            if(age != 0 && lastName != null && firstName != null && eyeColor != null)
            
                WriteLine("Hello my name is {0} {1}, I have {2} colored eyes, and I am {3} year old.",firstName, lastName, eyeColor, age);

            else if (lastName != null && firstName != null && eyeColor != null)
            {
                WriteLine("Hello my name is {0} {1} and I have {2} colored eyes.",firstName, lastName, eyeColor); 

            }
            else if (lastName != null && firstName != null && age != 0)
            {
                WriteLine("Hello my name is {0} {1} and I am {2} years old.",firstName , lastName, age); 
            } 
            else if (lastName != null && firstName != null)
            {
                WriteLine("Hello my name is {0} {1}.",firstName , lastName); 
            }
            else if (firstName != null)
            {
                WriteLine("Hello my name is {0}.",firstName); 
            }  
            else
            {
                WriteLine("Hello my name is {0} {1}, I have {2} colored eyes.",firstName, lastName, eyeColor); 
            }

        }

    }
}