using System; 
using static System.Console;
using System.Collections.Generic;
using System.Text; 

namespace PropertiesPart1
{
    class Program
    {
        static void Main(string[] args)
        {

            // creating a object of the class 
            Box box = new Box(3,4,5);

            // now there is no need to set the properties directly, we can just create the object in the class; 
            // box.SetLength(4);
            // now the height is accessible just like a property in C# 
            // box.Height = -4; 
            // box.Width = 5; 

            WriteLine("--------------------------------------------------------------");
            //accessing the property of width directly
            WriteLine("Box height is " + box.Width);            
            WriteLine("--------------------------------------------------------------");
            // WriteLine("Box height is " + box.Height);
            // WriteLine("-----------------");
            // now that we have applied both a setter and getter method we can now display the output to the console; 
            // WriteLine("Box length is " + box.GetLength()); 
            // WriteLine("-----------------");
            // after creating the getter GetVolume we can now call that method to access the value of the boxes volume; 
            // we aren't giving the value of the volume itself, but instead we are providing the result of the calculation; 
            // could be useful when providing some summarized totals that should not be altered; 


            // we are now accessing the volume property directly;
            WriteLine("Box volume is " + box.Volume); 
            WriteLine("--------------------------------------------------------------");
            box.DisplayInfo(); 

            ReadKey();  
        }
    }
}
