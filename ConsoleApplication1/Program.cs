using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {//ref out extend
        int m = 1;
        //int n = 2;
        static void Main(string[] args)
        {
            int y = 2; ;
            int z=1;
            Program test = new Program();
            test.add(ref test);
            test.sub(out z);
            string n = "jitendra";
           

            Console.WriteLine("value of a:{0}", y);
            Console.WriteLine("name:{0}",n.test());
            Console.ReadKey();
            

       
        }

        public void add(ref Program a)
        {
            //a = 5;

            Console.WriteLine("value of a:{0}", a.m);
        }
        public void sub(out int a)
        {
            a = 5;

            Console.WriteLine("value of a:{0}", a);
        }
    }

    public static class extend {


        public static string test(this string name) {
            char[] names = name.ToCharArray();
            names[0] = char.IsUpper(names[0]) ? name[0] : char.ToUpper(names[0]);
            return new string(names);


        }

    }


}
