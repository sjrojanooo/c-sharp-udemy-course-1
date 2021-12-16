using System; 
using static System.Console; 
using System.Collections.Generic; 
using System.Threading.Tasks; 

namespace jaggedArrays 
{
    class Program
    {
         static void Main(string[] args)
        {
            // declaring and initializing a jaggedArray 
            int[][] jaggedArray2 = new int [][] 
            {
                new int[] {2,3,5,6,7,8},
                new int[] {0,3,6,9,12}
            }; 

            WriteLine("the value in the middle of the first entry is {0}", jaggedArray2[0][2]); 

            // using a nested for loop to iterate over the jaggedArray to iterate our jagged array 
            // and provide the output of the element and value at there specific position. 

            for(int i = 0; i < jaggedArray2.Length; i++)
            {
                for(int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    WriteLine("Element at ({0}, {1})= {2}", i, j, jaggedArray2[i][j]); 
                }
            }
        }


    }
}
