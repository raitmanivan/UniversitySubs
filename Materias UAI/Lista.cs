using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materias_UAI
{
    public class Lista
    {
        public Materias lista;
        GestorDeMaterias gestor = new GestorDeMaterias();

        public void AgregarMateria(Materias nueva)
        {

            if (lista == null)
            {
                lista = nueva;
                //gestor.GuardarMaterias(nueva);               
            }              
            else
            {
                Materias ultimo = BuscarUltimo(lista);
                ultimo.Sig = nueva;
                //gestor.GuardarMaterias(nueva);              
            }
        }

        private Materias BuscarUltimo(Materias lista)
        {
            if (lista.Sig == null)
                return lista;
            else
                return BuscarUltimo(lista.Sig);
        }

        public void BorrarSeleccionado(Materias materia)
        {
            Materias Aeliminar = Buscar(lista, materia);
            if (Aeliminar == lista)
                lista = lista.Sig;
            else
            {
                Materias anterior = BuscarAnterior(lista, Aeliminar);
                Materias siguiente = Aeliminar.Sig;
                anterior.Sig = siguiente;
            }
        }

        public Materias Buscar(Materias list, Materias materia)
        {
            if (list == null)
                return list;
            if (list.Nombre == materia.Nombre)
                return list;
            else
                return Buscar(list.Sig, materia);
        }

        public Materias BuscarPorNombre(Materias list,string nombre)
        {
            if (list == null)
                return list;
            if (list.Nombre.ToLower() == nombre.ToLower())
                return list;
            else
                return BuscarPorNombre(list.Sig, nombre);
        }

        public Materias BuscarPorCodigo(Materias list, int codigo)
        {
            if (list == null)
                return list;
            if (list.Codigo == codigo)
                return list;
            else
                return BuscarPorCodigo(list.Sig, codigo);
        }

        private Materias BuscarAnterior(Materias lista, Materias materia)
        {
            if (lista == materia)
                return lista;
            if (lista.Sig == materia)
                return lista;
            else
                return BuscarAnterior(lista.Sig, materia);
        }

        public void Modificar(Materias nuevo, Materias seleccionado)
        {
            Materias Amodificar = Buscar(lista, seleccionado);
            Amodificar.Estado = nuevo.Estado;
            Amodificar.Nota = nuevo.Nota;
            /*
            if (nuevo.Correlativa != null)
                Amodificar.Correlativa = nuevo.Correlativa;
            else
                Amodificar.Correlativa = null;
            if (nuevo.Correlativa2 != null)
                Amodificar.Correlativa2 = nuevo.Correlativa2;
            else
                Amodificar.Correlativa2 = null;
            if (nuevo.Correlativa3 != null)
                Amodificar.Correlativa3 = nuevo.Correlativa3;
            else
                Amodificar.Correlativa3 = null;
            Amodificar.Cuatrimestre = nuevo.Cuatrimestre;
            */
            Materias Correlativa = BuscarCorrelativaPorCodigo(lista, Amodificar.Codigo);
            if(Correlativa != null)
            Correlativa.Correlativa.Estado = Amodificar.Estado;
        }

        public Materias [] ListaAVector()
        {
            Materias inicio = lista;
            Materias[] vector = new Materias[100];
            int i = 0;
            while(lista != null)
            {
                vector[i] = lista;
                i++;
                lista = lista.Sig;
            }
            lista = inicio;
            return vector;
        }

        public void HardCode()
        {
            Materias[] array = new Materias[60];
            array = gestor.Listar().ToArray();             
     /*    
            Materias nuevo = new Materias();
            nuevo.Codigo = 1;
            nuevo.Nombre = "Programación Estructurada";
            nuevo.Estado = "Aprobada";
            nuevo.Año = 1;
            nuevo.Cuatrimestre = 1;
            array[0] = nuevo;

            Materias nuevo2 = new Materias();
            nuevo2.Codigo = 2;
            nuevo2.Nombre = "Sistemas de Computación I";
            nuevo2.Estado = "Aprobada";
            nuevo2.Año = 1;
            nuevo2.Cuatrimestre = 1;
            array[1] = nuevo2;

            Materias nuevo3 = new Materias();
            nuevo3.Codigo = 3;
            nuevo3.Nombre = "Laboratorio de Cálculo";
            nuevo3.Estado = "Aprobada";
            nuevo3.Año = 1;
            nuevo3.Cuatrimestre = 1;
            array[2] = nuevo3;

            Materias nuevo4 = new Materias();
            nuevo4.Codigo = 4;
            nuevo4.Nombre = "Problemática del Mundo Actual";
            nuevo4.Estado = "Aprobada";
            nuevo4.Año = 1;
            nuevo4.Cuatrimestre = 1;
            array[3] = nuevo4;

            Materias nuevo5 = new Materias();
            nuevo5.Codigo = 5;
            nuevo5.Nombre = "Inglés I";
            nuevo5.Estado = "Aprobada";
            nuevo5.Año = 1;
            nuevo5.Cuatrimestre = 1;
            array[4] = nuevo5;

            Materias nuevo6 = new Materias();
            nuevo6.Codigo = 6;
            nuevo6.Nombre = "Sistemas de Computación II";
            nuevo6.Estado = "Aprobada";
            nuevo6.Año = 1;
            nuevo6.Correlativa = nuevo2;
            nuevo6.Cuatrimestre = 2;
            array[5] = nuevo6;

            Materias nuevo7 = new Materias();
            nuevo7.Codigo = 7;
            nuevo7.Nombre = "Cálculo Infinitesimal I";
            nuevo7.Estado = "Aprobada";
            nuevo7.Año = 1;
            nuevo7.Correlativa = nuevo3;
            nuevo7.Cuatrimestre = 2;
            array[6] = nuevo7;

            Materias nuevo8 = new Materias();
            nuevo8.Codigo = 8;
            nuevo8.Nombre = "Historia de la Ciencia y de la Técnica";
            nuevo8.Estado = "Cursando";
            nuevo8.Año = 1;
            nuevo8.Correlativa = nuevo4;
            nuevo8.Cuatrimestre = 2;
            array[7] = nuevo8;

            Materias nuevo9 = new Materias();
            nuevo9.Codigo = 9;
            nuevo9.Nombre = "Inglés II";
            nuevo9.Estado = "Aprobada";
            nuevo9.Año = 1;
            nuevo9.Correlativa = nuevo5;
            nuevo9.Cuatrimestre = 2;
            array[8] = nuevo9;

            Materias nuevo10 = new Materias();
            nuevo10.Codigo = 10;
            nuevo10.Nombre = "Programación I";
            nuevo10.Estado = "Cursando";
            nuevo10.Año = 1;
            nuevo10.Correlativa = nuevo;
            nuevo10.Cuatrimestre = 2;
            array[9] = nuevo10;

            Materias nuevo11 = new Materias();
            nuevo11.Codigo = 11;
            nuevo11.Nombre = "Programación Orientada a Objetos";
            nuevo11.Estado = "No cursada";
            nuevo11.Año = 2;
            nuevo11.Correlativa = nuevo10;
            nuevo11.Cuatrimestre = 1;
            array[10] = nuevo11;

            Materias nuevo12 = new Materias();
            nuevo12.Codigo = 12;
            nuevo12.Nombre = "Metodologías de Desarrollo de Sistemas I";
            nuevo12.Estado = "No cursada";
            nuevo12.Año = 2;
            nuevo12.Cuatrimestre = 1;
            array[11] = nuevo12;

            Materias nuevo13 = new Materias();
            nuevo13.Codigo = 13;
            nuevo13.Nombre = "Cálculo Infinitesimal II";
            nuevo13.Estado = "Aprobada";
            nuevo13.Año = 2;
            nuevo13.Correlativa = nuevo7;
            nuevo13.Cuatrimestre = 1;
            array[12] = nuevo13;

            Materias nuevo14 = new Materias();
            nuevo14.Codigo = 14;
            nuevo14.Nombre = "Inglés III";
            nuevo14.Estado = "Aprobada";
            nuevo14.Año = 2;
            nuevo14.Correlativa = nuevo9;
            nuevo14.Cuatrimestre = 1;
            array[13] = nuevo14;

            Materias nuevo15 = new Materias();
            nuevo15.Codigo = 15;
            nuevo15.Nombre = "Arquitectura de Sistemas Operativos";
            nuevo15.Estado = "No cursada";
            nuevo15.Año = 2;
            nuevo15.Correlativa = nuevo6;
            nuevo15.Cuatrimestre = 1;
            array[14] = nuevo15;

            Materias nuevo16 = new Materias();
            nuevo16.Codigo = 16;
            nuevo16.Nombre = "Análisis de Procesos Administrativos";
            nuevo16.Estado = "No cursada";
            nuevo16.Año = 2;
            nuevo16.Cuatrimestre = 1;
            array[15] = nuevo16;

            Materias nuevo17 = new Materias();
            nuevo17.Codigo = 17;
            nuevo17.Nombre = "Metodologías de Desarrollo de Sistemas II";
            nuevo17.Estado = "No cursada";
            nuevo17.Año = 2;
            nuevo17.Correlativa = nuevo12;
            nuevo17.Cuatrimestre = 2;
            array[16] = nuevo17;

            Materias nuevo18 = new Materias();
            nuevo18.Codigo = 18;
            nuevo18.Nombre = "Física I";
            nuevo18.Estado = "Aprobada";
            nuevo18.Año = 2;
            nuevo18.Correlativa = nuevo7;
            nuevo18.Cuatrimestre = 2;
            array[17] = nuevo18;

            Materias nuevo19 = new Materias();
            nuevo19.Codigo = 19;
            nuevo19.Nombre = "Probabilidad y Estadística";
            nuevo19.Estado = "Cursando";
            nuevo19.Año = 2;
            nuevo19.Correlativa = nuevo13;
            nuevo19.Cuatrimestre = 2;
            array[18] = nuevo19;

            Materias nuevo20 = new Materias();
            nuevo20.Codigo = 20;
            nuevo20.Nombre = "Inglés IV";
            nuevo20.Estado = "Aprobada";
            nuevo20.Año = 2;
            nuevo20.Correlativa = nuevo14;
            nuevo20.Cuatrimestre = 2;
            array[19] = nuevo20;

            Materias nuevo21 = new Materias();
            nuevo21.Codigo = 21;
            nuevo21.Nombre = "Química";
            nuevo21.Estado = "Aprobada";
            nuevo21.Año = 2;
            nuevo21.Cuatrimestre = 2;
            array[20] = nuevo21;

            Materias nuevo22 = new Materias();
            nuevo22.Codigo = 22;
            nuevo22.Nombre = "Lenguajes de Última Generación";
            nuevo22.Estado = "No cursada";
            nuevo22.Año = 2;
            nuevo22.Correlativa = nuevo11;
            nuevo22.Cuatrimestre = 2;
            array[21] = nuevo22;

            Materias nuevo23 = new Materias();
            nuevo23.Codigo = 23;
            nuevo23.Nombre = "Sistemas de Representación";
            nuevo23.Estado = "Aprobada";
            nuevo23.Año = 3;
            nuevo23.Cuatrimestre = 1;
            array[22] = nuevo23;

            Materias nuevo24 = new Materias();
            nuevo24.Codigo = 24;
            nuevo24.Nombre = "Base de Datos";
            nuevo24.Estado = "No cursada";
            nuevo24.Año = 3;
            nuevo24.Correlativa = nuevo12;
            nuevo24.Cuatrimestre = 1;
            array[23] = nuevo24;

            Materias nuevo25 = new Materias();
            nuevo25.Codigo = 25;
            nuevo25.Nombre = "Tecnología de las Comunicaciones";
            nuevo25.Estado = "No cursada";
            nuevo25.Año = 3;
            nuevo25.Correlativa = nuevo15;
            nuevo24.Cuatrimestre = 1;
            array[24] = nuevo25;

            Materias nuevo26 = new Materias();
            nuevo26.Codigo = 26;
            nuevo26.Nombre = "Trabajo de Campo";
            nuevo26.Estado = "No cursada";
            nuevo26.Año = 3;
            nuevo26.Correlativa = nuevo17;
            nuevo26.Correlativa2 = nuevo22;
            nuevo26.Cuatrimestre = 1;
            array[25] = nuevo26;

            Materias nuevo27 = new Materias();
            nuevo27.Codigo = 27;
            nuevo27.Nombre = "Física II";
            nuevo27.Estado = "No cursada";
            nuevo27.Año = 3;
            nuevo27.Correlativa = nuevo18;
            nuevo27.Cuatrimestre = 1;
            array[26] = nuevo27;

            Materias nuevo28 = new Materias();
            nuevo28.Codigo = 28;
            nuevo28.Nombre = "Optativa";
            nuevo28.Estado = "No cursada";
            nuevo28.Año = 3;
            nuevo28.Cuatrimestre = 2;
            array[27] = nuevo28;

            Materias nuevo29 = new Materias();
            nuevo29.Codigo = 29;
            nuevo29.Nombre = "Teleinformática y Comunicaciones";
            nuevo29.Estado = "No cursada";
            nuevo29.Año = 3;
            nuevo29.Correlativa = nuevo24;
            nuevo29.Cuatrimestre = 2;
            array[28] = nuevo29;

            Materias nuevo30 = new Materias();
            nuevo30.Codigo = 30;
            nuevo30.Nombre = "Trabajo de Diploma";
            nuevo30.Estado = "No cursada";
            nuevo30.Año = 3;
            nuevo30.Correlativa = nuevo26;
            nuevo30.Cuatrimestre = 2;
            array[29] = nuevo30;

            Materias nuevo31 = new Materias();
            nuevo31.Codigo = 31;
            nuevo31.Nombre = "Matemática Discreta y autómatas";
            nuevo31.Estado = "Aprobada";
            nuevo31.Año = 3;
            nuevo31.Correlativa = nuevo13;
            nuevo31.Cuatrimestre = 2;
            array[30] = nuevo31;

            Materias nuevo32 = new Materias();
            nuevo32.Codigo = 32;
            nuevo32.Nombre = "Optativa";
            nuevo32.Estado = "No cursada";
            nuevo32.Año = 3;
            nuevo32.Cuatrimestre = 2;
            array[31] = nuevo32;

            Materias nuevo33 = new Materias();
            nuevo33.Codigo = 33;
            nuevo33.Nombre = "Optativa";
            nuevo33.Estado = "No cursada";
            nuevo33.Año = 3;
            nuevo33.Cuatrimestre = 2;
            array[32] = nuevo33;

            Materias nuevo34 = new Materias();
            nuevo34.Codigo = 34;
            nuevo34.Nombre = "Sistemas de Información";
            nuevo34.Estado = "No cursada";
            nuevo34.Año = 4;
            nuevo34.Correlativa = nuevo17;
            nuevo34.Cuatrimestre = 1;
            array[33] = nuevo34;

            Materias nuevo35 = new Materias();
            nuevo35.Codigo = 35;
            nuevo35.Nombre = "Organización y Gestion Empresaria";
            nuevo35.Estado = "No cursada";
            nuevo35.Año = 4;
            nuevo35.Cuatrimestre = 1;
            array[34] = nuevo35;

            Materias nuevo36 = new Materias();
            nuevo36.Codigo = 36;
            nuevo36.Nombre = "Base de Datos Para la Administración";
            nuevo36.Estado = "No cursada";
            nuevo36.Año = 4;
            nuevo36.Correlativa = nuevo24;
            nuevo36.Cuatrimestre = 1;
            array[35] = nuevo36;

            Materias nuevo37 = new Materias();
            nuevo37.Codigo = 37;
            nuevo37.Nombre = "Lenguajes de Programación Para la Administración";
            nuevo37.Estado = "No cursada";
            nuevo37.Año = 4;
            nuevo37.Correlativa = nuevo22;
            nuevo37.Cuatrimestre = 1;
            array[36] = nuevo37;

            Materias nuevo38 = new Materias();
            nuevo38.Codigo = 38;
            nuevo38.Nombre = "Administración de Proyectos";
            nuevo38.Estado = "Cursando";
            nuevo38.Año = 4;
            nuevo38.Cuatrimestre = 2;
            array[37] = nuevo38;

            Materias nuevo39 = new Materias();
            nuevo39.Codigo = 39;
            nuevo39.Nombre = "Planificación Estratégica";
            nuevo39.Estado = "No cursada";
            nuevo39.Año = 4;
            nuevo39.Correlativa = nuevo35;
            nuevo39.Cuatrimestre = 2;
            array[38] = nuevo39;

            Materias nuevo40 = new Materias();
            nuevo40.Codigo = 40;
            nuevo40.Nombre = "Optativa";
            nuevo40.Estado = "No cursada";
            nuevo40.Año = 4;
            nuevo40.Cuatrimestre = 2;
            array[39] = nuevo40;

            Materias nuevo41 = new Materias();
            nuevo41.Codigo = 41;
            nuevo41.Nombre = "Modelos Computacionales de Gestión Administrativa";
            nuevo41.Estado = "No cursada";
            nuevo41.Año = 4;
            nuevo41.Correlativa = nuevo37;
            nuevo41.Cuatrimestre = 2;
            array[40] = nuevo41;

            Materias nuevo42 = new Materias();
            nuevo42.Codigo = 42;
            nuevo42.Nombre = "Electromagnetismo. Estado sólido I";
            nuevo42.Estado = "No cursada";
            nuevo42.Año = 4;
            nuevo42.Correlativa = nuevo27;
            nuevo42.Cuatrimestre = 2;
            array[41] = nuevo42;

            Materias nuevo43 = new Materias();
            nuevo43.Codigo = 43;
            nuevo43.Nombre = "Sistema de Hardware para la Administración";
            nuevo43.Estado = "No cursada";
            nuevo43.Año = 5;
            nuevo43.Correlativa = nuevo18;
            nuevo43.Cuatrimestre = 1;
            array[42] = nuevo43;

            Materias nuevo44 = new Materias();
            nuevo44.Codigo = 44;
            nuevo44.Nombre = "Seminario de Aplicación Profesional";
            nuevo44.Estado = "No cursada";
            nuevo44.Año = 5;
            nuevo44.Correlativa = nuevo30;
            nuevo44.Correlativa2 = nuevo37;
            nuevo44.Correlativa3 = nuevo41;
            nuevo44.Cuatrimestre = 1;
            array[43] = nuevo44;

            Materias nuevo45 = new Materias();
            nuevo45.Codigo = 45;
            nuevo45.Nombre = "Modelización Numérica";
            nuevo45.Estado = "No cursada";
            nuevo45.Año = 5;
            nuevo45.Correlativa = nuevo19;
            nuevo45.Cuatrimestre = 1;
            array[44] = nuevo45;

            Materias nuevo46 = new Materias();
            nuevo46.Codigo = 46;
            nuevo46.Nombre = "Electromagnetismo. Estado sólido II";
            nuevo46.Estado = "No cursada";
            nuevo46.Año = 5;
            nuevo46.Correlativa = nuevo42;
            nuevo46.Cuatrimestre = 1;
            array[45] = nuevo46;

            Materias nuevo47 = new Materias();
            nuevo47.Codigo = 47;
            nuevo47.Nombre = "Práctica Profesional Supervisada";
            nuevo47.Estado = "No cursada";
            nuevo47.Año = 5;
            nuevo47.Correlativa = nuevo29;
            nuevo47.Cuatrimestre = 1;
            array[46] = nuevo47;

            Materias nuevo48 = new Materias();
            nuevo48.Codigo = 48;
            nuevo48.Nombre = "Auditoría Operativa";
            nuevo48.Estado = "No cursada";
            nuevo48.Año = 5;
            nuevo48.Cuatrimestre = 2;
            array[47] = nuevo48;

            Materias nuevo49 = new Materias();
            nuevo49.Codigo = 49;
            nuevo49.Nombre = "Redes Administrativas";
            nuevo49.Estado = "No cursada";
            nuevo49.Año = 5;
            nuevo49.Correlativa = nuevo29;
            nuevo49.Cuatrimestre = 2;
            array[48] = nuevo49;

            Materias nuevo50 = new Materias();
            nuevo50.Codigo = 50;
            nuevo50.Nombre = "Teleprocesamiento Avanzado";
            nuevo50.Estado = "No cursada";
            nuevo50.Año = 5;
            nuevo50.Correlativa = nuevo29;
            nuevo50.Cuatrimestre = 2;
            array[49] = nuevo50;

            Materias nuevo51 = new Materias();
            nuevo51.Codigo = 51;
            nuevo51.Nombre = "Seguridad Informática";
            nuevo51.Estado = "No cursada";
            nuevo51.Año = 5;
            nuevo51.Correlativa = nuevo43;
            nuevo51.Cuatrimestre = 2;
            array[50] = nuevo51;

            Materias nuevo52 = new Materias();
            nuevo52.Codigo = 52;
            nuevo52.Nombre = "Trabajo Final de Ingeniería";
            nuevo52.Estado = "No cursada";
            nuevo52.Año = 5;
            nuevo52.Correlativa = nuevo44;
            nuevo52.Cuatrimestre = 2;
            array[51] = nuevo52;
*/    
            int i;
            for (i = 0; i < 52; i++)
            {
                AgregarMateria(array[i]);
                if (array[i] == null)
                    i = 52;
            }
        }

        public int ContarMateriasTotales()
        {
            Materias inicio = lista;
            int cont = 0;
            while (lista != null)
            {
                cont++;
                lista = lista.Sig;
            }
            lista = inicio;
            return cont;
        }

        public int ContarMateriasAprobadas()
        {
            Materias inicio = lista;
            int cont = 0;
            while (lista != null)
            {
                if (lista.Estado == "Aprobada")
                    cont++;
                lista = lista.Sig;
            }
            lista = inicio;
            return cont;
        }

        public double CalcularPromedioNotas()
        {
            Materias inicio = lista;
            int cont = 0;
            double suma = 0;
            while(lista!= null)
            {
                if (lista.Nota != 0)
                {
                    suma += lista.Nota;
                    cont++;
                }
                lista = lista.Sig;
            }
            lista = inicio;
            return suma / cont;
        }

        public Materias BuscarCorrelativaPorCodigo(Materias lista, int codigo)
        {
            if (lista == null)
                return null;
            if (lista.Correlativa == null)
                return BuscarCorrelativaPorCodigo(lista.Sig, codigo);
            else
                if(lista.Correlativa!= null)
            {
                if (lista.Correlativa.Codigo == codigo)
                    return lista;
                else
                    return BuscarCorrelativaPorCodigo(lista.Sig, codigo);
            }
           
            return null;
        }
    }
}