using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materias_UAI
{
    public class Materias
    {    
        public Materias(string registro)
        {
            string[] datos = registro.Split('-');
            Codigo = Convert.ToInt32(datos[0]);
            Nombre = datos[1];
            Año = Convert.ToInt32(datos[2]);
            Estado = datos[3];
            Nota = Convert.ToInt32(datos[4]);
            Cuatrimestre = Convert.ToInt32(datos[5]);

            if(datos.Length >= 8)
            {
                Correlativa = new Materias();
                Correlativa.Codigo = Convert.ToInt32(datos[6]);
                Correlativa.Nombre = datos[7];
                Correlativa.Estado = datos[8];
            }
            
            if (datos.Length >= 11)
            {
                Correlativa2 = new Materias();
                Correlativa2.Codigo = Convert.ToInt32(datos[9]);
                Correlativa2.Nombre = datos[10];
                Correlativa2.Estado = datos[11];
            }
                
            if (datos.Length >= 14)
            {
                Correlativa3 = new Materias();
                Correlativa3.Codigo = Convert.ToInt32(datos[12]);
                Correlativa3.Nombre = datos[13];
                Correlativa3.Estado = datos[14];
            }         
        }

        public Materias()
        {}

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Año { get; set; }
        public string Estado { get; set; }
        public int Cuatrimestre { get; set; }
        public int Nota { get; set; }

        public Materias Correlativa { get; set; }
        public Materias Correlativa2 { get; set; }
        public Materias Correlativa3 { get; set; }

        public Materias Sig { get; set; }

        public string ObtenerRegistro()
        {
            if (Correlativa != null && Correlativa2 == null && Correlativa3 == null)
                return string.Format("{0}-{1}-{2}-{3}-{4}-{5}-{6}-{7}-{8}", Codigo, Nombre, Año, Estado, Nota ,Cuatrimestre, Correlativa.Codigo, Correlativa.Nombre, Correlativa.Estado);
            else
                if (Correlativa != null && Correlativa2 != null && Correlativa3 == null)
                return string.Format("{0}-{1}-{2}-{3}-{4}-{5}-{6}-{7}-{8}-{9}-{10}-{11}", Codigo, Nombre, Año, Estado, Nota, Cuatrimestre, Correlativa.Codigo, Correlativa.Nombre, Correlativa.Estado, Correlativa2.Codigo, Correlativa2.Nombre, Correlativa2.Estado);
            else
                if (Correlativa != null && Correlativa2 != null && Correlativa3 != null)
                return string.Format("{0}-{1}-{2}-{3}-{4}-{5}-{6}-{7}-{8}-{9}-{10}-{11}-{12}-{13}-{14}", Codigo, Nombre, Año, Estado, Nota, Cuatrimestre, Correlativa.Codigo, Correlativa.Nombre, Correlativa.Estado, Correlativa2.Codigo, Correlativa2.Nombre, Correlativa2.Estado, Correlativa3.Codigo, Correlativa3.Nombre, Correlativa3.Estado);
            else
                 return string.Format("{0}-{1}-{2}-{3}-{4}-{5}", Codigo, Nombre, Año, Estado, Nota, Cuatrimestre); ;
        }
    }
}
