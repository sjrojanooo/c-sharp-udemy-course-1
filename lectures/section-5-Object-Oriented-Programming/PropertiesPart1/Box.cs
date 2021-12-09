using System; 
using static System.Console; 
using System.Collections.Generic; 
using System.Text; 


namespace PropertiesPart1
{
    class Box
    {
        // calculating length of a box;
        // creating member variables - these have a direct impact on the whole structure of the box;  

        // making all member variable public results in insecure code; 
        // this can cause problems when running a program or designing a project with a team; 

        /* 
            this is called encapsulation - which is the building of data with the methods that operate on that data or 
            restricts the direct access to an objects components;  
        */ 
        private int length;

        // commenting this public member variable and providing the property value with a getter and setter; 
        // public int width; 
        private int height; 

        private int volume; 

        // defining another property for volume; 

        // volume is never set and is always calculated. it would not make sense to provide a setter method;
        // since the variable is dependent on the value of the other variables; 
        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width;
            }
        }

        // we can even define the property without having a member variable; 
        /*
            the following give a default getter and setter; 

        */
        public int Width{get; set;}

        // the code above is exactly like the following 
        /* 
               public int Width
                {
                    get 
                    {
                        return this.Width;
                    }
                    set
                    {
                        this.Width = value; 
                    }

                }
        */ 
        // creating public property called height 
        public int Height
        {
            get 
            {
                return height; 
            }
            set
            {   
                if(value < 0)
                {
                    // if the value is less than 0, then we are multiplying that value by a negative, resulting in a positive int. 
                    height = -value; 
                }
                else
                {
                // using the value keyword - is a shortcut method to creating a setter and getter method separately; 
                    height = value; 
                }

            }
        }

        public Box(int length, int height, int width)
        {
            this.length = length; 
            this.height = height; 
            Width = width; 


        }

        // creating a setter method to alter the value of the private member variable length; 
        // the method will need a parameter value so that we can set the length to a value
        public void SetLength(int length)
        {
            // we can also double check if it is a correct value; 
            if (length < 0)
            {
                // you can actively set a defualt threshold that a value within your program must have; 
                throw new Exception("Length should be higher than 0"); 
            }
            // using the this keyword to assign the member variable to a new value; 
            // if we tried to simply assing the new value as - length = length - would result in an error; 
            this.length = length; 
        }

        // implementing a getter method to actually be able to access the new value assigned to our length member; 
        // we do not declare length as a parameter in the method since its purpose is to retrieve the new value
        // assigned to the private member variable; 
        // also in order to return the integer value delcare the variable type we are trying to return; 
        // the keyword is in place of void since we are specifying a value we want to return from the method; 
        public int GetLength()
        {
            return this.length; 
        }
        public void DisplayInfo()
        {   
            // notice the volumn is the product of the length * width * height; 
            WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}", length, height, Width, volume = length*height*Width);

        }

    }
}