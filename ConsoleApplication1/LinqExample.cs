using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class LinqExample
    {
    }
    public class StudentClass
    {
        #region data
        protected enum GradeLevel { FirstYear = 1, SecondYear, ThirdYear, FourthYear };
        protected class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int ID { get; set; }
            public GradeLevel Year;
            public List<int> ExamScores;
        }
        class Person
        {
            internal int PersonID;
            internal string car;
            internal string name;
        }
        public class Students
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int StandardID { get; set; }
        }

        public class Standard
        {
            public int StandardID { get; set; }
            public string StandardName { get; set; }
        }
        protected static List<Student> students = new List<Student>
    {
        new Student {FirstName = "Terry", LastName = "Adams", ID = 120,
            Year = GradeLevel.SecondYear,
            ExamScores = new List<int>{ 99, 82, 81, 79}},
        new Student {FirstName = "Fadi", LastName = "Fakhouri", ID = 116,
            Year = GradeLevel.ThirdYear,
            ExamScores = new List<int>{ 99, 86, 90, 94}},
        new Student {FirstName = "Hanying", LastName = "Feng", ID = 117,
            Year = GradeLevel.FirstYear,
            ExamScores = new List<int>{ 93, 92, 80, 87}},
        new Student {FirstName = "Cesar", LastName = "Garcia", ID = 114,
            Year = GradeLevel.FourthYear,
            ExamScores = new List<int>{ 97, 89, 85, 82}},
        new Student {FirstName = "Debra", LastName = "Garcia", ID = 115,
            Year = GradeLevel.ThirdYear,
            ExamScores = new List<int>{ 35, 72, 91, 70}},
        new Student {FirstName = "Hugo", LastName = "Garcia", ID = 118,
            Year = GradeLevel.SecondYear,
            ExamScores = new List<int>{ 92, 90, 83, 78}},
        new Student {FirstName = "Sven", LastName = "Mortensen", ID = 113,
            Year = GradeLevel.FirstYear,
            ExamScores = new List<int>{ 88, 94, 65, 91}},
        new Student {FirstName = "Claire", LastName = "O'Donnell", ID = 112,
            Year = GradeLevel.FourthYear,
            ExamScores = new List<int>{ 75, 84, 91, 39}},
        new Student {FirstName = "Svetlana", LastName = "Omelchenko", ID = 111,
            Year = GradeLevel.SecondYear,
            ExamScores = new List<int>{ 97, 92, 81, 60}},
        new Student {FirstName = "Lance", LastName = "Tucker", ID = 119,
            Year = GradeLevel.ThirdYear,
            ExamScores = new List<int>{ 68, 79, 88, 92}},
        new Student {FirstName = "Michael", LastName = "Tucker", ID = 122,
            Year = GradeLevel.FirstYear,
            ExamScores = new List<int>{ 94, 92, 91, 91}},
        new Student {FirstName = "Eugene", LastName = "Zabokritski", ID = 121,
            Year = GradeLevel.FourthYear,
            ExamScores = new List<int>{ 96, 85, 91, 60}}
    };
        #endregion

        //Helper method, used in GroupByRange.
        protected static int GetPercentile(Student s)
        {
            double avg = s.ExamScores.Average();
            return avg > 0 ? (int)avg / 10 : 0;
        }



        public void QueryHighScores(int exam, int score)
        {
            var highScores = from student in students
                             where student.ExamScores[exam] > score
                             select new { Name = student.FirstName, Score = student.ExamScores[exam] };

            foreach (var item in highScores)
            {
                Console.WriteLine($"{item.Name:-15}{item.Score}");
            }
        }
        public void GroupBySingleProperty()
        {
            //    Console.WriteLine("Group by a single property in an object:");

            //    Variable queryLastNames is an IEnumerable<IGrouping<string,
            //    DataClass.Student>>.
            //   var queryLastNames =
            //       from student in students
            //       group student by student.LastName into newGroup
            //       orderby newGroup.Key
            //       select newGroup;

            //    foreach (var nameGroup in queryLastNames)
            //    {
            //        Console.WriteLine("Key: {0}", nameGroup.Key);
            //        foreach (var student in nameGroup)
            //        {
            //            Console.WriteLine(student.LastName, student.FirstName);
            //        }
            //    }
            //}

            var result = students.OrderBy(x => x.FirstName).Select(x => x.FirstName);
            var result1 = from s in students where s.FirstName == "Svetlana" orderby s.FirstName  select s.FirstName ;
            var res = students.ToList();
            var resh = students.GroupBy(x => x.LastName);


        }


        public void me() {


            List<Person> st = new List<Person> {
            new Person { PersonID = 1, car = "Ferrari",name="jitu" },
            new Person { PersonID = 1, car = "BMW",name="chitu" },
            new Person { PersonID = 2, car = "Audi",name="situ" }
        };

            IList<string> strList1 = new List<string>() {
    "One",
    "Two",
    "Three",
    "Four"
};

            IList<string> strList2 = new List<string>() {
    "One",
    "Two",
      "Three",
    "Five",
    "Six"
};
            IList<Students> studentList = new List<Students>() {
    new Students() { StudentID = 1, StudentName = "John", StandardID =1 },
    new Students() { StudentID = 2, StudentName = "Moin", StandardID =1 },
    new Students() { StudentID = 3, StudentName = "Bill", StandardID =2 },
    new Students() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
    new Students() { StudentID = 5, StudentName = "Ron"  }
};

            IList<Standard> standardList = new List<Standard>() {
    new Standard(){ StandardID = 1, StandardName="Standard 1"},
    new Standard(){ StandardID = 2, StandardName="Standard 2"},
    new Standard(){ StandardID = 3, StandardName="Standard 3"}
};


            var results = from p in st
                          group  p.car by  p.PersonID into g
                          select new { PersonID = g.Key, Cars = g.ToList() };
            var results1 = st.GroupBy(x => x.PersonID);
            //var s = from a in strList1 join b in strList2 on a equals b select new {a };
            var innerJoin = strList1.Join(strList2,
                      str1 => str1,
                      str2 => str2,
                      (str1, str2) => str1);

            var joinres = (from stu in studentList join std in standardList on stu.StandardID equals std.StandardID select new { stu.StudentName,std.StandardName}).ToList();
            //var leftjoin = (from a in studentList
            //               join b in standardList on a.StudentID equals b.StandardID into p
            //               from c in p.DefaultIfEmpty()
            //               select new
            //               {

            //                   name = a.StudentName,
            //                   standardname = c?.StandardName??string.Empty



            //               }).ToList();
            var joi = studentList.Join(standardList, stu => stu.StudentID, std => std.StandardID, (stu, std) => new { stu, std }).Select(x=> new {

                StandardName = x.std,
                name=x.stu

            }) .ToList();
            var a = studentList.Where(x => x.StudentName.Contains("John")).ToList();
                var groupJoin = standardList.GroupJoin(studentList,  //inner sequence
                                std => std.StandardID, //outerKeySelector 
                                sd => sd.StandardID,     //innerKeySelector
                                (std, sd) => new // resultSelector 
                                {
                                    std,
                                    sd
                                });
            var f = (from b in studentList where b.StudentID>1  && b.StandardID <5 select b).ToList();


        }
       

    }

    public class Program
    {
        public static void Main()
        {
            StudentClass sc = new StudentClass();
            sc.QueryHighScores(1, 90);
            sc.GroupBySingleProperty();
            sc.me();

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
