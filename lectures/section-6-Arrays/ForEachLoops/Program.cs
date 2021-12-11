using System;
using static System.Console; 
using System.Threading.Tasks; 
using System.Text; 
using System.Linq; 

namespace ForEachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10]; 

            for(int i = 0; i < 10; i++)
            {
                // incrementing the value of i by 10; 
                // we are also appending 10 values to our int array; 
                nums[i] = i + 10; 

                // creating an output to the console that will show the index and the value at each position; 
                WriteLine("Array Num value at index {0} = {1}", i, nums[i]); 
                
            }
            WriteLine("------------------------------------------------");

            // using the Length property to only loop the maximum length of the nums array; 
            for(int j =0; j < nums.Length; j++)
            {
                WriteLine("Array num value at index {0} = {1}", j, nums[j]); 
            }
            WriteLine("------------------------------------------------");
            // looping through each index in the array; 
            // same concept as above. we can also create a counter to identify the position of the array; 
            int counter = 0; 
            foreach(int k in nums)
            {
                // to ensure the precise index of each value we need to make sure to use the increment operator to 
                // incremement the index position by each time it loop over an index in the array; 
                WriteLine("Element {0} = {1}", counter, k); counter++; 

            }

            WriteLine("------------------------------------------------");
            // in class challenge; 
            // create an array with 5 of your best friends; 
            // create a foreach loop whic greets all of them 

            // did this all on my own baby, whoop!;

            int friendCounter = 0; 

            string[] friendArray = {"Brandon", "Blake", "Michael", "Jesse", "Austin", "Caity"};

            // creating for each loop to loop through each friend and greet them; 

            foreach(string friend in friendArray) 
            {
                WriteLine("Sup {0}", friend); 

                // incrementing counter by one for each iteration; 
                friendCounter++; 
            }

            ReadKey(); 
            

        }
    }
}
