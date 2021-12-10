using System; 
using static System.Console; 
using System.Threading.Tasks; 
using System.Text; 

namespace property_challenge
{

    // challenge is to create a read only property "FrontSurface" which calculates the 
    // font surface based on height and length; 

    class Box
    {
        // declaring my private member variables height, width length, volume;
        private int height; 
        private int width; 
        private int volume; 
        private int length;

        private int frontSurface;   


        public Box(int length, int width, int height)
        {
            Length = length; 
            Width = width; 
            Height = height; 
        }
        // creating property values for the class box; 
        
        // Volume will only perform a get function since it will be returning a product value based on the other three 
        // variables; 

        public int FrontSurface
        {
            get 
            {
                return this.height * this.length; 
            }
        }

        // creating a getter and setter property for height;
        public int Height
        {
            get
            {
                // created a method that normalizes the value in a situation the input value is below 0; 

                return height;
            }
            set
            {
                // created a method that normalizes the value in a situation the input value is below 0; 
                height = value; 
                
            }
        }

        // creating a getter and setter property for width; 
        public int Width
        {
            get
            {
                // created a method that normalizes the value in a situation the input value is below 0; 
                return width; 
            }
            set
            {
                width = value;
                
            }
        }

        // creating a getter and setter property for length; 
        public int Length
        {
            get
            {
                // created a method that normalizes the value in a situation the input value is below 0; 
                return length; 
            }
            set
            {
                length = value;
            }
        }

        // creating a property for volume that is a read only and will be used to calculate
        public int Volume
        {
            get
            {
                return this.height * this.width * this.length; 
            }
            
        }

        public void DispalyInfo()
        {
            WriteLine("--------------------------");
            WriteLine("Length is {0}, Height is {1}, Width is {2}, and calculated volume is {3}", width, length, height, volume = length*width*height);
            WriteLine("The front surface of the box is {0}", frontSurface = height * length);
        }
    }    
}