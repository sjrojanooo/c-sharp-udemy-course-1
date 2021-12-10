using System;
using static System.Console; 
using System.Linq; 
using System.Threading.Tasks;
using System.Text; 


namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {

            // creating our new member; 

            Members member1 = new Members(); 
            // since the boolean is true then it will call the SharingPrivateInfo Method; 
            // this is the only way a class's private method can be called within the program; 
            // We use it by calling the Public method Introducing(), we call it from within a public method; 
            member1.Introducing(true); 
            ReadKey(); 
            
        }
    }
}
