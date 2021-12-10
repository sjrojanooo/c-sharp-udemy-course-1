using System; 
using static System.Console; 
using System.Threading.Tasks; 
using System.Text; 

namespace property_challenge
{

    /* 
        this challenge was going to continue on with the lecture, but I wanted to have a go 
        at really grasping this concept; 
    */
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(20,30,25);

            WriteLine("--------------------------------------------------------------");
            //accessing the property of width directly
            WriteLine("Box width is " + box.Width);            
            WriteLine("--------------------------------------------------------------");           
            WriteLine("Box length is " + box.Length);     
            WriteLine("--------------------------------------------------------------");           
            WriteLine("Box height is " + box.Height);
            WriteLine("--------------------------------------------------------------");           
            WriteLine("Box volume is " + box.Volume);
            WriteLine("--------------------------------------------------------------");
            WriteLine("Box front surface is " + box.FrontSurface);
            WriteLine("--------------------------------------------------------------");
            box.DispalyInfo(); 
        }
    }
}
