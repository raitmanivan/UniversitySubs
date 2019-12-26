using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EE.States;

namespace EE
{
    public class StudentSubject
    {
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public Status Status { get; set; }
        public int ? Qualification { get; set; }

        public StudentSubject(Student student, Subject subject, Status status, int ? qualification)
        {
            this.Student = student;
            this.Subject = subject;
            this.Status = status;
            this.Qualification = qualification;
        }

        public StudentSubject(Subject subject, Status status, int? qualification)
        {
            this.Subject = subject;
            this.Status = status;
            this.Qualification = qualification;
        }
    }
}
