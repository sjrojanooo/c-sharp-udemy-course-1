using System;

namespace if_statement_challenge
{
    class Program
    {
        /* 
        Creating a user login system where the user will register and then login;
        the program will check if the user entered the correct username and password upon login;
        */

        // will be building an object of the username and password for the individual; 
        // string password; 

        //Instructor creates global variables since they are being used in two difference methods; 
        static string username; 
        static string password;
        static void Main(string[] args)
        {
            //Requesting input from user and appending it to the userName string variable; 
            //I am using the Trim() method to remove all whitespace characters in the string. 
            //My solution; 
            Console.WriteLine("Please enter username");
            string registeredName = Console.ReadLine(); 
            Console.WriteLine("Please enter password with at least two special characters");
            string registeredPassword = Console.ReadLine(); 
            Console.WriteLine("Thank you for registering");
            
            Console.WriteLine("To login please enter username: ");
            string loginUser = Console.ReadLine(); 
            Console.WriteLine("Please enter password: ");
            string loginKey = Console.ReadLine(); 
            VerifyCredentials(registeredName, registeredPassword, loginUser, loginKey); 


            //Instructor solution 
            Register(); 
            Login(); 

            
            Console.Read();
        }
        //method will first check if the username is correct and then execute the nested if statement to verify password; 
        //if username is incorrect the user will have to try again. 
        public static void VerifyCredentials(string registerUser, string registerPass,string verifyUsername, string verifyPassword)
        {
            if(registerUser.Equals(verifyUsername))
            {
                Console.WriteLine("successful username {0}", verifyUsername);

                if(registerPass.Equals(verifyPassword))
                {
                    Console.WriteLine("successful loggin. Welcome!"); 
                }
                else
                {
                    Console.WriteLine("incorrect password. please try again"); 
                }
            }
            else
            {
                Console.WriteLine("username is incorrect or not registered. Please enter correct username."); 
            }    

            // cleaner code by just putting in two methods instead of my initial approach. 
        }

        //Instructor solution method. He uses a register method and login method separately. 
        //it does make more sense since these would be built in methods inside of the programs and he did mention the 
        //more variables that you have running in the program itself the more memory will be used up. Just something I would 
        //need to take into consideration moving forward. 
        public static void Register()
        {
            Console.WriteLine("Please enter your username"); 
            username = Console.ReadLine(); 
            Console.WriteLine("Please enter your username"); 
            password = Console.ReadLine(); 
            Console.WriteLine("Registration completed"); 

            Console.WriteLine("---------------");
            
        }
        public static void Login()
        {
            Console.WriteLine("Please enter username"); 

            if(username == Console.ReadLine())
            {
                Console.WriteLine("please enter your password"); 
                if(password == Console.ReadLine())
                {
                   Console.WriteLine("Login successful");      
                }
                else 
                {
                    Console.WriteLine("login failed, wrong password. restart program"); 
                }
            }
            else
            {
                Console.WriteLine("login failed, wrong password. Restart program"); 
            }

        }
    }
}
