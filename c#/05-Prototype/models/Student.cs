using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Prototype.models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public List<string> Lessons { get; set; }

        public Student ShallowCopy()
        {
            return (Student)this.MemberwiseClone();
        }

        public Student DeepCopy()
        {
            var cloneStudent = (Student)this.ShallowCopy();
            cloneStudent.Lessons = new List<string>(); // reference type
            cloneStudent.Lessons.AddRange(Lessons);

            return cloneStudent;
        }
    }
}