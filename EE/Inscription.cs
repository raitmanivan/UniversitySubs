using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Inscription(Student student, Subject subject, DateTime date, int year, int correspondingPeriod)
        {
            this.Student = student;
            this.Subject = subject;
            this.Date = date;
            this.Year = year;
            this.CorrespondingPeriod = correspondingPeriod;
        }

        public Inscription()
        {
            Student = new Student();
            Subject = new Subject();
        }

       
    }
}
