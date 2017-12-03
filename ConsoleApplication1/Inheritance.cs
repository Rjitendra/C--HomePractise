using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("Well Come to Inheritance");
        }

    }
    public class SecondClass : BaseClass, IMethod
    {
       public string name { get; set; }
       public List<string> names() {
            
            List<string> names = new List<string>() { "Jitendra", "jitu.kdp27@gmail.com", "7702889920" };
            return names;
        }
        public void Show()
        {
            base.Display();
            Console.WriteLine("this is SecondClass");
        }//
        public virtual void GetEmployee()
        {
            List<string> names =this.names();
            Console.WriteLine("My Name is-{0}", names[0]);

        }
    }
    public class ThirdClass : SecondClass
    {
        public override void GetEmployee()
        {
            //base.Display();
            base.Show();
            var userDetail = base.names();
            base.name = userDetail[0];
            Console.WriteLine("My Name :{0}, My Email:{1}, and mobile no :{2} ", this.name, userDetail[1],userDetail[2] );
            base.GetEmployee();
        }


    }

    public interface IMethod {
        string name { get; set; }
         List<string> names();
   }

    public class MainMethod
    {


        static void Main(string[] args)
        {
            ThirdClass obj = new ThirdClass();
            obj.GetEmployee();
            Console.ReadLine();

        }
 }
}
