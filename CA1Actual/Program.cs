using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1Actual
{
    class Program
    {
        static void Main(string[] args)
        {
            //create subjects
            Subject s1 = new Subject("Programming", "Vivion Kinsella", 1);
            Subject s2 = new Subject("UX Design", "Adrian Durcan", 2);
            Subject s3 = new Subject("SE1", "Therese Hume", 2);
            Subject s4 = new Subject("DB Tech", "Colm Davey", 2);

            List<Subject> Subjects = new List<Subject>();  //create list of subjects

            Subjects.Add(s1);
            Subjects.Add(s2);
            Subjects.Add(s3);
            Subjects.Add(s4);

            //create 2 student objects
            Student student1 = new Student("David Whalley", "27/03/1999");
            Student student2 = new Student("Silly Billy", "01/01/1996");

            //make list for student 1 subjects
            List<Subject> Student1Subjects = new List<Subject>();
            Student1Subjects.Add(s1);
            Student1Subjects.Add(s2);
            student1.Subjects(Student1Subjects); //should add list of subjects to student 1 object.. but is failing to pass it to setter

            //make list for student 2 subjects
            List<Subject> Student2Subjects = new List<Subject>();
            Student2Subjects.Add(s1);
            Student2Subjects.Add(s4);
            student2.Subjects(Student2Subjects);  //should add list of subjects to student 1 object.. but is failing to pass it to setter


            //display student details
            Console.WriteLine(student1);
            Console.WriteLine();
            Console.WriteLine(student2);
            Console.WriteLine();

        }

        public void DisplayAgeInDays(Student student)  //method to calculate age in days
        {

            //will need to convert from existing date format to date time format
            DateTime start = new DateTime(student.DateOfBirth);   
            DateTime end = new DateTime(2019, 11, 07);

            TimeSpan difference = end - start; //create TimeSpan object

            Console.WriteLine("Agein days: " + difference.Days); //Extract days, write to Console.
        }
    }
}
