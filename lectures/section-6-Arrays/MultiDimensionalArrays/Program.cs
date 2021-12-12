using static System.Console; 
using System;
using System.Linq; 
using System.Threading.Tasks; 
using System.Text; 
using System.Collections.Generic; // provides access to the List<T> class



namespace MultiDimensionalArrays
{
    class Program
    {

        // decided to review the C# documentation prior to each lecture; 
        static void Main(string[] args)
        {
            // I am going to create a name array that contains four rows and two columns 
            // I will use it as a name and age array 

            // two dimensional array 
            // initializing array upon declaration; 
            int[,] unspecified2DArray = new int[,]{{1,2}, {3,4}, {5,6}, {7,8}};
            // the same array with dimensions specified; 
            int[,] specified2DArray = new int[4,2] {{1,2}, {3,4}, {5,6}, {7,8}};

            // Three dimensional array. 
            int[,,] unspecified3DArray = new int [,,] {{{1,2,3}, {4,5,6}, {7,8,9}, {10,11,12}}};

            // specified thrree dimensional array. 
            int[,,] specified3DArray = new int[2,2,3] {{{1,2,3}, {4,5,6}}, {{7,8,9}, {10,11,12}}};

            int[,] rank2DArray = new int[3,2]; 
            // comma separator clarifies the dimensions of the array 
            // array has 
            int[,,] rank3DArray = new int[3,4,3]; 

            int lengthOf2D = rank2DArray.Length; 

            WriteLine(":::Getting rank of an array elements:::\n");
            // to return the dimensions of an array we reference the Rank Property in C#; 
            WriteLine("The array has {0} dimensions", rank2DArray.Rank); // output will be 2 
            WriteLine("The array has {0} dimensions", rank3DArray.Rank); // output will be 3; 
            
            WriteLine(":::Accessing array elements:::\n");
            // you can access array elements by providing the index position;
            WriteLine(specified2DArray[0,0]); // will output 1 & 2 from the specified2DArray; 
            // accessing a value in our specified 3D array; 
            /*
                to access values in a 3d array - you need to provide the following information; 
                1. Table Number - located by quotes = int["2",2,3]; 
                2. Row Number; - located by quotes = int[2,"2",3]; 
                3. Column Number; - located by quotes = int[2,2,"3"]; 

                the 3D array above has 2 tables, 2 rows, and 3 columns; 
            */ 

            WriteLine(specified3DArray[0,1,2]); // output is 6; 
            WriteLine(specified3DArray[0,0,1]); // output is 2; 
            WriteLine(specified3DArray[1,1,2]); // output will be 12; 
            WriteLine(specified3DArray[0,1, 1]); // output is 5; 

            // we can also change the value of a position; 
            specified3DArray[0,1,1] = 20; 
            WriteLine(specified3DArray[0,1, 1]); // output is 20; 

            // we can also assign a value of the array element to a variable 

            int elementValue = specified3DArray[1,0,1]; // accessing the first index in table 2 under column 2; 

            WriteLine("the value retrived is : {0}", elementValue); // output is 8; 

            WriteLine(":::Jagged Array Declaration:::\n");

            int [][] jaggedArray3 = 
            {
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6},
                new int[] {11,22}
            }; 

            // for loop will display the array elements; 

            // the initial for loop will the rows of the jagged array; 
            for(int i = 0; i < jaggedArray3.Length; i++)
            {
                WriteLine("Element ({0}): ", i); 

                // the nested for loop will loop through each column of the jagged array; 
                for(int j = 0; j < jaggedArray3[i].Length; j++)
                {
                    WriteLine("{0}", jaggedArray3[i][j]);
                }
                WriteLine(); 
            }

            // foreach loop to loop through a 2 Dimensional array; 
            // the int variable is a storage variable and not the value itself. 
            // this is the disadvantage of the foreach loop, as you can alter the state of the value in the array; 
            foreach( int i in unspecified2DArray)
            {
                WriteLine("{0} ",i); 
            }

            WriteLine(":::Constructing a Collection using the List Class:::\n");

            // want to make a list of employee IDs and assign weekly hours to them 
            // going to put them in 2 Dimensional array; 

            var employeeHours = new List<EmployeeHours>
                {
                    new EmployeeHours () {empID = "HD5004", hoursWorked = 48},
                    new EmployeeHours () {empID = "HD5005", hoursWorked = 55},
                    new EmployeeHours () {empID = "HD5006", hoursWorked = 20},
                    new EmployeeHours () {empID = "HD5006", hoursWorked = 35}
                };

            // foreach loop on the collection above; 
            foreach(EmployeeHours allEmpHours in employeeHours)
            {
                WriteLine("Employee ID: " + allEmpHours.empID + " " + "Hours Worked: " + allEmpHours.hoursWorked); 
            }



            WriteLine("press any key to quit."); 
            ReadKey(); 
            // public class to get and set the values of our employee name and hours; 
        }


        // class of EmployeeHours that contains getter and setter methods for employee id and hours; 
        public class EmployeeHours
        {
            public string empID{get; set;}
            public int hoursWorked{get; set;}
        }
    }

}
