using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EE.States;
using MPP;

namespace BLL
{
    public class BLLStatus
    {
        public Status ReturnStatus(string status)
        {
            MPPStatus mapper = new MPPStatus();
            return mapper.ReturnStatus(status);
        }
    }
}
