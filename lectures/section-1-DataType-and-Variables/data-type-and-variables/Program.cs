using System;

namespace data_type_and_variables
{
    class Program
    {

        // constants as fields
        const double PI = 3.141592655359; 
        const int weeks = 52, month = 12; 
        //Create a constant of type string with your birthday as its value 
        const string birthDay = "06.18.1991"; 


        static void Main(string[] args)
        {
            
            Console.WriteLine("My birthday is: {0} ", birthDay); 
            Console.ReadKey(); 
        }
    }
}
