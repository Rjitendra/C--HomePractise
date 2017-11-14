using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public  class Class1
    {


        public void test() { Console.WriteLine("jitendra"); }
    }
    public class y : Class1
    {

        public new void test() { Console.WriteLine("jitendra behera"); }
        //public override void test() {

        //    Console.WriteLine("my name is jitendra");
        //}

    }

    class yy
    {
        static void Main(string[] args)
        {
            y m = new y();
            Class1 ms = new Class1();
            ms.test();
            m.test();
            Console.ReadKey();
        }
    }
}
