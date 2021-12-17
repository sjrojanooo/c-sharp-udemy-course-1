using System; 
using static System.Console; 
using System.Collections.Generic; 
using System.Threading.Tasks; 
using System.Text; 
using System.Linq; // linq reference gives access to the max and min properties of array types; 

namespace arrayAsParameters
{

    

    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[]{20, 30, 50,50,45,35}; 

            WriteLine("the class average is {0}", getAverage(grades));
            WriteLine("the highest score is {0}", getMaxScore(grades)); 
            WriteLine("the lowest score is {0}", getMinScore(grades)); 

            int[] happinessScore = {2,4,6,8,10}; 

            happinessMethod(happinessScore); 

            foreach(int x in happinessScore)
            {
                WriteLine("new happiness score is {0}", x);
            }


            ReadKey(); 

        }


        // Method that will accept an array as a parameter and return a value of the average as a double; 
        static double getAverage(int[] gradeArray)
        {
            int size = gradeArray.Length; 
            int sum = 0; 

            for (int i = 0; i < size; i++)
            {
                sum += gradeArray[i]; 
            }

            return sum / size; 
        }

        static int getMaxScore(int[] gradeArray)
        {
            return gradeArray.Max(); 
        }

        static int getMinScore(int[] gradeArray)
        {
            return gradeArray.Min(); 
        }

        // IN CLASS CHALLENGE; 

        // Create an array of Happiness in the matin method and assing 5 values to it
        // Create a method which as an array of type in as its parameter
        // this method should increase the argument given by 2, for each entry 
        // Call this method in the main method use happiness as the argument 
        // create a for each loop in the main method to write all values into the console


        static void happinessMethod(int [] x)
        {
            for(int i = 0; i < x.Length; i++)
            {
                x[i] += 2; 

            }
        }

    }
}