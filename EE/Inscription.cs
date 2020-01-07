using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EE.States;

namespace EE
{
    public class Inscription
    {
        public int InscriptionID { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public DateTime Date { get; set; }
        public int Year { get; set; }
        public int CorrespondingPeriod { get; set; }
        public Status Status { get; set; }

        public Inscription(Student student, Subject subject, DateTime date, int year, int correspondingPeriod, Status status)
        {
            this.Student = student;
            this.Subject = subject;
            this.Date = date;
            this.Year = year;
            this.CorrespondingPeriod = correspondingPeriod;
            this.Status = status;
        }

        public Inscription(int inscriptionID,Student student, Subject subject, Status status)
        {
            this.InscriptionID = inscriptionID;
            this.Student = student;
            this.Subject = subject;
            this.Status = status;
        }

        public Inscription()
        {
            Student = new Student();
            Subject = new Subject();
        }

       
    }
}
