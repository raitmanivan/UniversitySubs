using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EE.States;

namespace EE
{
    public class Subject
    {
        public int SubjectID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public Status Status { get; set; }
        public string PeriodType { get; set; }
        public int CorrespondingPeriod { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }
}
