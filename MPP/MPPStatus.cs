using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EE.States;

namespace MPP
{
    public class MPPStatus
    {
        public Status ReturnStatus(string status)
        {
            if (status == "Aprobada" || status == "Approved")
                return new ApprovedStatus();
            else if (status == "No cursada" || status == "Pending")
                return new PendingStatus();
            else if (status == "Final pendiente" || status == "Pending exam")
                return new PendingExamStatus();
            else if (status == "Activa" || status == "Active")
                return new ActiveStatus();
            else if (status == "Inactiva" || status == "Inactive")
                return new InactiveStatus();
            else if (status == "En curso" || status == "In course")
                return new InCourseStatus();
            else
                return null;
        }
    }
}
