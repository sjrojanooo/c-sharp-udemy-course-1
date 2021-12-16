using System; 
using static System.Console; 
using System.Collections.Generic; 
using System.Threading.Tasks; 
using System.Text; 

namespace jagged_array_challenge 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a jagged array, which contains 3 "friends array", in which two family memeber should be stored
            // Introduce family memeber from different families to each other via console (three introductions)

            string[][] familyArray = new string[][]
            {
                new string[]{"Michael", "Caity", "Mini"}, 
                new string[]{"Jesus", "Tello","Lalo"}
            };

            // Introducing all of the family members above to one anoher; 
            WriteLine("Hi {0}, I would like to introduce you to {1}", familyArray[0][0], familyArray[1][0]); 
            WriteLine("Hi {0}, I would like to introduce you to {1}", familyArray[0][1], familyArray[1][1]); 
            WriteLine("Hi {0}, I would like to introduce you to {1}", familyArray[0][2], familyArray[1][2]); 
            ReadKey();


        }
    }
}