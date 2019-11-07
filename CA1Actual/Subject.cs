using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1Actual
{
    class Subject
    {
        //properties
        public string Name { get; set; }
        public string Lecturer { get; set; }
        public int Year { get; set; }

        //constructors 
        public Subject()   //basic blank constructor
        {
        }
        public Subject(string name) : this(name, "",0)   //chained constructor
        {
        }
        public Subject(string name, string lecturer) : this(name, lecturer, 0) //chained constructor
        {
        }

        public Subject(string name, string lecturer, int year)  //fully paramaterised constructor
        {
            Name = name;
            Lecturer = lecturer;
            Year = year;
        }

        public override string ToString()   //overrride of ToString method to display all properties of object
        {
            return string.Format("Name: {0} Lecturer: {1} Year {2}", Name, Lecturer, Year);
        }



    }
}
