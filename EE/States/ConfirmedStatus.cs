﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE.States
{
    public class ConfirmedStatus : Status
    {
        public ConfirmedStatus()
        {
            status = "Confirmed";
        }

        public override string ToString()
        {
            return string.Format("{0}", status);
        }
    }
}
