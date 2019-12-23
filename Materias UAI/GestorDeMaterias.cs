using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materias_UAI
{
    public class GestorDeMaterias
    {

        public void GuardarMaterias(Materias unaMateria)
        {
            FileStream archivo = new FileStream("Materias.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(archivo);
            if(unaMateria != null)
            sw.WriteLine(unaMateria.ObtenerRegistro());

            sw.Close(); archivo.Close();
        }

        public List<Materias> Listar()
        {
            List<Materias> lista = new List<Materias>();

            FileStream archivo = new FileStream("Materias.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(archivo);

            string linea = sr.ReadLine();

            while(linea != null)
            {
                Materias nuevaMateria = new Materias(linea);
                lista.Add(nuevaMateria);
                linea = sr.ReadLine();
            }

            archivo.Close(); sr.Close();

            return lista;
        }

        public void GuardarModificaciones(Materias [] materias, int cont)
        {
            FileStream archivo = new FileStream("Materias.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(archivo);

            for (int i = 0; i < cont; i++)
                sw.WriteLine(materias[i].ObtenerRegistro());

            sw.Close(); archivo.Close();

        }
#region Funciones que se llamaran al final del programa, para guardar o no los cambios realizados:
        public void RestaurarArchivo(int cont)
        {
            List<Materias> lista = new List<Materias>();

            FileStream archivo = new FileStream("MateriasBACKUP.txt", FileMode.Open);
            StreamReader sr = new StreamReader(archivo);

            string linea = sr.ReadLine();

            while (linea != null)
            {
                Materias nuevaMateria = new Materias(linea);
                lista.Add(nuevaMateria);
                linea = sr.ReadLine();
            }

            archivo.Close(); sr.Close();

            Materias [] materias = lista.ToArray();

            FileStream archivoArecuperar = new FileStream("Materias.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(archivoArecuperar);

            for (int i = 0; i < cont; i++)
                sw.WriteLine(materias[i].ObtenerRegistro());

            sw.Close(); archivoArecuperar.Close();
        }

        public void GuardarCambios(int cont) 
        {
            List<Materias> lista = new List<Materias>();

            FileStream archivo = new FileStream("Materias.txt", FileMode.Open);
            StreamReader sr = new StreamReader(archivo);

            string linea = sr.ReadLine(); 

            while (linea != null)
            {
                Materias nuevaMateria = new Materias(linea);
                lista.Add(nuevaMateria);
                linea = sr.ReadLine();
            }

            archivo.Close(); sr.Close();

            Materias[] materias = lista.ToArray();

            FileStream archivoAgrabar = new FileStream("MateriasBACKUP.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(archivoAgrabar);

            for (int i = 0; i < cont; i++)
                sw.WriteLine(materias[i].ObtenerRegistro());

            sw.Close(); archivoAgrabar.Close();
        }
        #endregion
    }
}
