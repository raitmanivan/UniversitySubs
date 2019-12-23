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
            this.Nombre = name;
            this.Valor = value;
        }

        public string Nombre { get; set; }
        public Object Valor { get; set; }
    }
}
