using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1Actual
{
    class Student
    {
        //properties
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public List<Subject> Subjects { get; set; }

        //constructor
        public Student(string name, string dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }
        
        public override string ToString()   //override of ToString method to display all properties of student object
        {
            return string.Format("Name: {0}\nDate of Birth: {1}", Name, DateOfBirth,Subjects[0],Subjects[1]);
        }
    }
}
