using System.Xml.Linq;

namespace q4
{

    class student { 
    
      public string Name{ get; set; }
        public int Age{ get; set; }
        public int Grade{ get; set; }



    }




    internal class Program
    {
        static void Main(string[] args)
        {

            var students = new List<student>
            {
                new student { Name = "Alice", Age = 20, Grade = 90 },
                new student { Name = "Bob", Age = 22, Grade = 85 },
                new student { Name = "Charlie", Age = 21, Grade = 95 }

            };
            var studentName = students.Where(student => student.Grade >= 80 && student.Age > 20).Select(student => student.Name);
            Console.WriteLine("student names older than 20 AND or equal to 80. ");

            foreach (var name in studentName)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("+++++++++++++++++++++++++++++++++");
            var students1 = new List<student>
            {
                new student { Name = "Alice", Age = 20, Grade = 90 },
                new student { Name = "Bob", Age = 22, Grade = 85 },
                new student { Name = "Charlie", Age = 21, Grade = 95 }

            };


            var stu = students1.GroupBy(student => student.Age).Select(g => new
            {

                age = g.Key,
                count = g.Count(),
                AvgGrade = g.Average(student => student.Grade)

            });
            foreach (var item in stu)
            {
                Console.WriteLine($"Age Group: {item.age}");
                Console.WriteLine($"Count: {item.count}");
                Console.WriteLine($"Average Grade: {item.AvgGrade}");
            }


        }
    }
}
