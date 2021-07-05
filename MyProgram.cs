using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class MyProgram 
    {
        static void Main(string[] args)
        {
          
            List<Students> students = new List<Students>
            {
                new Students {FirstName = "Farrukh", LastName = "Kholmatov", ID = 1, Age = 19},
                new Students {FirstName = "Ilhom", LastName = "O'rmonov", ID = 2, Age = 20},
                new Students {FirstName = "Diyor", LastName = "Ravshanov", ID = 3, Age = 18},
                new Students {FirstName = "Shohrux", LastName = "Kholmatov", ID = 4, Age = 21},
                new Students {FirstName = "Suhrob", LastName = "Kholmatov", ID = 5, Age = 20},
                new Students {FirstName = "John", LastName = "Liskov", ID = 6, Age = 19},  
                new Students {FirstName = "Tom" , LastName = "Stark", ID = 7, Age = 22 }
            };

            List<Details> details = new List<Details>
            {
                new Details {SubjectID = 1, SubjectName = "Maths", Mark = 4},
                new Details {SubjectID = 2, SubjectName = "Physics", Mark = 3},
                new Details {SubjectID = 3, SubjectName = "English", Mark = 5},
                new Details {SubjectID = 4, SubjectName = "History", Mark = 3}
            };

            var selected = students.Where(p => p.Age > 19).Select(p => p.FirstName + " " + p.LastName + " " + p.Age);

            foreach(var item in selected)
            {
                Console.WriteLine(item);
            }

            var newJoinedTable = students.Join(details, p => p.ID, u => u.SubjectID, 
                (student, detail) => new
                { FirstName = student.FirstName,
                  LastName = student.LastName,
                  Mark = detail.Mark, 
                  SubjectName = detail.SubjectName });

            foreach (var item in newJoinedTable)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.SubjectName + " " + item.Mark);
            }
        }
    }
}
