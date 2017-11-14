using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class x {


        public abstract void test();
    }
    public class y : x
    {

        public  void test1()
        {

            Console.WriteLine("my name is jitendra");
        }
        //public override void test() {

        //    Console.WriteLine("my name is jitendra");
        //}

    }

    class yy
    {
        static void Main(string[] args)
        {
            y m = new y();
            //m.test();
            m.test1();
            Console.ReadLine();
        }
    }
}
