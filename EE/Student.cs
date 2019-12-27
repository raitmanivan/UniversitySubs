using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EE.States;

namespace EE
{
    public class Student
    {
        public string StudentID { get; set; }
        public string UniversityID { get; set; }
        public string NameAndSurname { get; set; }
        public string Email { get; set; }
        public Status Status { get; set; }

        public Student() { }

        public Student(string studentID, string universityID, string nameAndSurname, string email, Status status)
        {
            this.StudentID = studentID;
            this.UniversityID = universityID;
            this.NameAndSurname = nameAndSurname;
            this.Email = email;
            this.Status = status;
        }

        public override string ToString()
        {
            return string.Format("{0}", NameAndSurname);
        }
    }
}
