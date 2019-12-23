using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Parameter
    {
        public Parameter(string name, Object value)
        {
            this.Name = name;
            this.Value = value;
        }

        public string Name { get; set; }
        public Object Value { get; set; }
    }
}
