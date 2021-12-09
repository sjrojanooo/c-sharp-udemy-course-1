using static System.Console; // changing the way I am calling my directives. Will result a some cleaner code
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 

namespace FirstClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating an object of my class;
            // an instance of Human;
            Human steven = new Human();
            
            // accessing the public variable from our Human Class, and even changing the string value; 
            steven.firstName = "Steven"; 
            steven.lastName = "Rojano"; 

            // Calling the method from another class; 
            steven.IntroduceMyself(); 
            
            /*
                notice I no longer have to type our the whole Console.Readkey(); 
                I am able to access static memeber without having to qualify acces the name type. 
            */
            ReadKey(); 

        }
    }
}
