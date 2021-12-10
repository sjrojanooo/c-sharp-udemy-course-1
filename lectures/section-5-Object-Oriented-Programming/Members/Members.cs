using System; 
using static System.Console; 
using System.Threading.Tasks; 
using System.Text; 
using System.Linq; 
using System.Diagnostics; // enables debug property; 

namespace Members
{
    class Members
    {
        // creating private member variables 
        private string memberName; 
        private string jobTitle; 

        public int age; 

        // minimum private salary is 
        private int salary = 20000; 

        // short hand to creating a getter and setter for the member property; 
        public string JobTite {get;set;}

        // this is the member property - all properties start with a capital letter; 
        public string MemberName
        {
            get
            {
                return memberName;  
            }
            set
            {
                this.memberName = value; 
            }
        }

        // public member Method - can be called from other classes; 
        public void Introducing(bool isFreind)
        {
            if (isFreind)
            {
                SharingPrivateInfo(); 
            }
            else
            {
                WriteLine("Hi name is {0}, and my job title is {1}. I'm {2} years old.", memberName, jobTitle, salary); 
            }
        }

        public void SharingPrivateInfo()
        {
            WriteLine("My salary is {0}", salary); 
        }

        public Members()
        {
            age = 30; 
            memberName = "Steven"; 
            salary = 80000; 
            jobTitle = "Data Engineer"; 
            WriteLine("Object created"); 
        }

        // member - finalizer - destructor; 
        // a class can only have one finalizers/destructor per class; 
        // it can't be inherited or overloaded; 
        // whenever the object runs out of scope or is deleted, that is when this finalizer comes in; 
        
        ~Members()
        {
            // cleanup statement 
            WriteLine("Deconstruction of Members object"); 
            // DebuggableAttribute.WriteLine("Destruction of members objects");
            Debug.WriteLine("Destruction of members object"); 
        }
    }
}
