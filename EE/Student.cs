using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class Student
    {
        public string StudentID { get; set; }
        public string UniversityID { get; set; }
        public string NameAndSurname { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", NameAndSurname);
        }
    }
}
