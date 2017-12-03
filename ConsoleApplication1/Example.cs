using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Example
    {
        public Example() {

           
        }
        public int add() {
            var employees = new List<Employee>
                {
                    new Employee {Name = "Tom", Age = 32,Department = "Design",Salary=120000},
                    new Employee {Name = "John", Age = 22,Department = "UI",Salary=86000},
                    new Employee {Name = "Sandra", Age = 36,Department = "UI",Salary=83000},
                    new Employee {Name = "Julie", Age = 54,Department = "Javascript",Salary=80000},
                    new Employee {Name = "Samantha", Age = 21,Department = "Design",Salary=125000}
                };
            //var result = employees.Select(x => new { x.Age, x.Name }).GroupBy(x => x.Age).ToList();
            var Avg = employees.Select(x => x.Age).Average();
            var sum = employees.Select(x => x.Age).Sum();
            var result = employees.Select(x => new { x.Age, x.Name }).OrderBy(x=>x.Age).Where(x=>x.Age> (employees.Select(y => y.Age).Average())).ToList();
            var massagedEmployees = employees.GroupBy(e => e.Department)
                                 .Select(g => new { Department = g.Key, Avg = g.Average(e => e.Salary) });
            var emplgroup = employees.GroupBy(x => x.Department);
            foreach (var res in result)
            {
                Console.WriteLine("Name:{0},age:{1}", res.Name,res.Age);
               

            }


            foreach (var res in emplgroup)
            {
                Console.WriteLine("{0}-{1}",res.Key,res.Count());
                foreach (var re in res)
                {
                    Console.WriteLine("{0}-{1}",re.Name,re.Age);

                }

                }



            return 5; }

       
       




    }
    class Example1: Example
    {
        public int add(int a) { return 50; }
    }

  public  class Employee 
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }


    public class main {

        static void Main(string[] args)
        {
            Example1 ob = new Example1();
            var result = ob.add(5);
            var result1 = ob.add();
            Console.WriteLine("result is :{0}", result);
            Console.WriteLine("result is :{0}", result);
            Console.ReadKey();

        }

        }
}
