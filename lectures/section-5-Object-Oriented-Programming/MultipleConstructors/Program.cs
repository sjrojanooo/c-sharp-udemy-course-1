using static System.Console;
using System.Linq; 
using System.Threading.Tasks; 
using System.Text;


namespace MultipleConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Human brother = new Human("Michael", "Rojano", "brown", 34); 
            Human steven = new Human("Steven", "Rojano", "hazel",30);
            Human thiago = new Human("Thiago","Rojano","blue"); 
            Human mini = new Human("Mini"); 
            Human elisa = new Human("Elisa","Quintana"); 
            Human jesus = new Human("Jesus","Quintana", 65); 



            brother.IntroduceMyself(); 
            steven.IntroduceMyself(); 
            thiago.IntroduceMyself(); 
            mini.IntroduceMyself(); 
            elisa.IntroduceMyself(); 
            jesus.IntroduceMyself(); 

            ReadKey(); 

        }
    }
}
