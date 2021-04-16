using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question01
{
    class Student : IComparable<Student>
    {

        public int StudentID { get; set; }

        public Student(int studentID)
        {
            this.StudentID = studentID;
        }
        public int CompareTo(Student other)
        {
            throw new NotImplementedException();
        }
    }
}
