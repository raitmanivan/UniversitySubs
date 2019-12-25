using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class StudentSubject
    {
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public string Status { get; set; }
        public int ? Qualification { get; set; }

        public StudentSubject(Student student, Subject subject, string status, int ? qualification)
        {
            this.Student = student;
            this.Subject = subject;
            this.Status = status;
            this.Qualification = qualification;
        }
    }
}
