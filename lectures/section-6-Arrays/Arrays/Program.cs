using System;
using static System.Console; 
using System.Text; 
using System.Threading.Tasks; 


namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5]; 

            grades[0] = 80; 
            grades[1] = 90; 
            grades[2] = 100; 
            grades[3] = 95; 
            grades[4] = 60;

            // assing value to array grades at index 0; 
            WriteLine("grades at index 0 : {0}", grades[0]); // output will be 0; 
            ReadKey(); 

            string input = ReadLine(); 
            
            // assing value to array grades at index 0; 
            grades[0] = int.Parse(input); 

            WriteLine("grades at index 0: {0}", grades[0]); 

            ReadKey(); 

            // another way of initializing an array;
            int [] gradesOfMathStudentsA = {80, 90, 95, 85, 100}; 
            // third way of initializing an array;
            int [] gradesOfMathStudentB = new int[] {90, 95,85,100,100}; 

            // obtaining the length of gradesOfMathStudentsA array; 
            WriteLine("Length of gradesOfMathStudentsA : {0}", gradesOfMathStudentsA.Length); 
            

        }   
    }
}
