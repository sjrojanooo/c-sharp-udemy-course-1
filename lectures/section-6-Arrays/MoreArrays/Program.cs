using System;
using static System.Console; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text;



namespace MoreArrays
{
    class Program
    {
        static void Main(string[] args)

        {
            // creating a 2 Dimensional array 
            int[,] new2DArray = {{1,2,3}, {4,5,6}, {7,8,9}, {10,11,12}}; 
            int[,,] new3DArray = {{{1,2,3}, {4,5,6}}, {{7,8,9}, {10,11,12}}};

            // getting the dimension value using the Rank property
            WriteLine(new3DArray.Rank); 

            WriteLine("::: Print 2Dimensional Array:::\n");
            // passing the array into the Display2DArray method 
            Display2DArray(new2DArray);
            // passing a 2 Dimensional array into a method to display even numbers in the array
            WriteLine("\n::: Print Even Numbers in 2 Dimensional Array:::\n");
            DisplayEvenNumbers(new2DArray); 
            // passing 
            WriteLine("\n::: Print Diagonal Elements in an Array:::\n");
            PrintDiagonalElements(new2DArray); 
            // printing diagonal elements of the array in reverse order, 
            // from  top right to bottom left; 
            WriteLine("\n::: Print Diagonal Elements in an Array:::\n");
            PrintDiagonalElementsInReverse(new2DArray); 
            ReadKey(); 

        }

        // creating a method that will return the position of each element in an array; 
        static void  Display2DArray(int[,] arr)
        {
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    WriteLine("Element at ({0}, {1}) = {2}", i, j, arr[i,j]); 
                }
            }    
        }

        // nested loop method that will only print even numbers in a 2 dimensional array 
        static void DisplayEvenNumbers(int [,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    if(arr[i,j] % 2 == 0)
                    {
                        WriteLine(arr[i,j] + " "); 
                    }
                    else
                    {
                        WriteLine(" "); 
                    }
                }
            }
        }

        // method to print the Diagonal element in an array; 
        static void PrintDiagonalElements(int[,] arr)
        {   
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        WriteLine("Diagonal element is at position ({0}, {1}) = {2} ",i,j, arr[i,j]); 
                    }
                    else
                    {
                        WriteLine(" "); 
                    }
                    WriteLine(""); 
                }
            }
        }

        // Print 

        // method that will print the diagonal elements in reverse order; 
        static void PrintDiagonalElementsInReverse(int[,] arr)
        {
            try
            {
                for (int i = 0, j = 2; i < arr.GetLength(0); i++ , j--)
                {
                    // threw in this conditional statement to make sure that the column variable
                    // stays within the bounds of the matrice. 
                    if( j >= 0)
                    {
                        WriteLine(arr[i,j]);
                    }
                }

            }
            // decided to put a try catch block in the method in order to satisfy when the index out 
            // of range exception; 
            catch(IndexOutOfRangeException)
            {
                WriteLine("Index out of range"); 
            }
            finally
            {
                WriteLine("iteration complete."); 
            }

        }
    }
}
