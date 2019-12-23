using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Materias_UAI
{
    public partial class Correlatividades : Form
    {
        Lista miLista = new Lista();
        int cont = 0;
        Materias buscada = new Materias();
        Materias seleccionado = new Materias();
        DateTime FechaDeHoy = DateTime.Today;
        bool cambio;
        int contador = 0;
        int año = 0;

        GestorDeMaterias gestorMaterias;

        public Correlatividades(Lista lista)
        {
            InitializeComponent();
            gestorMaterias = new GestorDeMaterias();
            miLista.HardCode();
            this.listView2.CheckBoxes = true;
            cambio = false;
            LlenarListaParaInscripcion(cambio);

             if (listView2.Items.Count <= 0)
                this.buttonInscripcion.Visible = false;
        }

        private void CompletarLABELcuatrimestre(int respuesta)
        {
            if (respuesta == 1)
                this.labelCuatriACTUAL.Text = "Primer cuatrimestre";
            else if (respuesta == 2)
                this.labelCuatriACTUAL.Text = "Segundo cuatrimestre";
            else
                this.labelCuatriACTUAL.Visible = false;
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        public void MostrarLista(int opcion)
        {
            listView1.Items.Clear();

            switch(opcion)
            {
                case 0:
                    {
                        if (miLista.lista != null)
                            AgregarAlistaForm(miLista.lista);
                        break;
                    }
                case 1:
                    {
                        if (miLista.lista != null)
                            AgregarMateriasQuePuedoCursarAform(miLista.lista);
                        break;
                    }
                case 3:
                    {
                        if (miLista.lista != null)
                        {
                            AgregarBuscadaAform(miLista.lista, buscada);

                            if (cont == miLista.ContarMateriasTotales())
                            {
                                MessageBox.Show("No se ha encontrado la materia");
                                cont = 0;
                                AgregarAlistaForm(miLista.lista);
                            }
                        }
                        break;
                    }
                case 4: 
                    {
                        if (miLista.lista != null)
                            AgregarBuscadaPorAñoAform(miLista.lista, año);
                        break;
                    }
            }
        }

        public void AgregarBuscadaPorAñoAform(Materias lista, int año)
        {
            if (lista.Año == año)
            {
                ListViewItem list = new ListViewItem(lista.Codigo.ToString());
                list.SubItems.Add(lista.Nombre);
                list.SubItems.Add(lista.Año.ToString());
                list.SubItems.Add(lista.Estado);
                if (lista.Correlativa != null && lista.Correlativa2 != null && lista.Correlativa3 != null)
                    list.SubItems.Add(lista.Correlativa.Codigo.ToString() + " - " + lista.Correlativa2.Codigo.ToString() + " - " + lista.Correlativa3.Codigo.ToString());
                else if (lista.Correlativa != null && lista.Correlativa2 != null)
                    list.SubItems.Add(lista.Correlativa.Codigo.ToString() + " - " + lista.Correlativa2.Codigo.ToString());
                else if (lista.Correlativa != null)
                    list.SubItems.Add(lista.Correlativa.Codigo.ToString());

                listView1.Items.Add(list);
            }
            if (lista.Sig != null)
                AgregarBuscadaPorAñoAform(lista.Sig, año);
        }

        public void AgregarAlistaForm(Materias lista)
        {
            ListViewItem list = new ListViewItem(lista.Codigo.ToString());
            list.SubItems.Add(lista.Nombre);
            list.SubItems.Add(lista.Año.ToString());
            list.SubItems.Add(lista.Estado);
            if (lista.Correlativa != null && lista.Correlativa2 != null && lista.Correlativa3 != null)
                list.SubItems.Add(lista.Correlativa.Codigo.ToString() + " - " + lista.Correlativa2.Codigo.ToString() + " - " + lista.Correlativa3.Codigo.ToString());
            else if (lista.Correlativa != null && lista.Correlativa2 != null)
                list.SubItems.Add(lista.Correlativa.Codigo.ToString() + " - " + lista.Correlativa2.Codigo.ToString());
            else if (lista.Correlativa != null)
                list.SubItems.Add(lista.Correlativa.Codigo.ToString());

                listView1.Items.Add(list);

            if (lista.Sig != null)
                AgregarAlistaForm(lista.Sig);
        }

        public void AgregarMateriasQuePuedoCursarAform(Materias lista)
        {
            if(lista.Correlativa == null)
            {
                if (lista.Estado != "Aprobada" && lista.Estado != "Cursando")
                {
                    ListViewItem list = new ListViewItem(lista.Codigo.ToString());
                    list.SubItems.Add(lista.Nombre);
                    list.SubItems.Add(lista.Año.ToString());
                    list.SubItems.Add(lista.Estado);
                    list.SubItems.Add(lista.Cuatrimestre.ToString());

                    listView1.Items.Add(list);
                    cont++;
                }
            }

            else if (lista.Estado != "Aprobada" && lista.Estado != "Cursando" && lista.Correlativa.Estado  == "Aprobada")
            {
                ListViewItem list = new ListViewItem(lista.Codigo.ToString());
                list.SubItems.Add(lista.Nombre);
                list.SubItems.Add(lista.Año.ToString());
                list.SubItems.Add(lista.Estado);
                list.SubItems.Add(lista.Cuatrimestre.ToString());

                listView1.Items.Add(list);
                cont++;
            }

            if (lista.Sig != null)
                AgregarMateriasQuePuedoCursarAform(lista.Sig);
        }

        private void BotonBuscarMateriasDisponibles_Click(object sender, EventArgs e)
        {
            string mensaje = "Mostrar materias según cuatrimestre en curso?";
            string titulo = "Seleccione la opción deseada:";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult ventana;
            cont = 0;

            ventana = MessageBox.Show(mensaje, titulo, botones);
            int mes = FechaDeHoy.Month;

            if (ventana == System.Windows.Forms.DialogResult.Yes)
            {
                listView1.Columns[4].Text = " ";
                listView1.Items.Clear();
                int respuesta = QueCuatrimestreEs(mes);
                if(respuesta == 0)
                {
                    MessageBox.Show("El mes actual no corresponde a ningún cuatrimestre, se procederá a mostrar las materias que puede cursar el cuatrimestre que viene:","Información:");
                    respuesta = 1;
                }
                MostrarMateriasSegunCuatriemstre(miLista.lista,respuesta);
                MessageBox.Show("Cantidad de materias disponibles " + cont, "Materias disponibles");
            }

            else if (ventana == System.Windows.Forms.DialogResult.No)
            {
                listView1.Columns[4].Text = "Cuatrimestre:";
                MostrarLista(1);
                MessageBox.Show("Cantidad de materias disponibles " + cont, "Materias disponibles");
            }
        }

        public void AgregarMateriasQuePuedoCursarSegunCuatrimestre(Materias lista)
        {
            if (lista.Correlativa == null)
            {
                if (lista.Estado != "Aprobada" && lista.Estado != "Cursando")
                {
                    ListViewItem list = new ListViewItem(lista.Codigo.ToString());
                    list.SubItems.Add(lista.Nombre);
                    list.SubItems.Add(lista.Año.ToString());
                    list.SubItems.Add(lista.Estado);

                    listView1.Items.Add(list);
                    cont++;
                }
            }

            else if (lista.Estado != "Aprobada" && lista.Estado != "Cursando" && lista.Correlativa.Estado == "Aprobada")
            {
                ListViewItem list = new ListViewItem(lista.Codigo.ToString());
                list.SubItems.Add(lista.Nombre);
                list.SubItems.Add(lista.Año.ToString());
                list.SubItems.Add(lista.Estado);

                listView1.Items.Add(list);
                cont++;
            }
        }

        public void MostrarMateriasSegunCuatriemstre(Materias lista, int respuesta)
        {
            if(lista.Cuatrimestre == respuesta )
                AgregarMateriasQuePuedoCursarSegunCuatrimestre(lista);
            if (lista.Sig != null)
                MostrarMateriasSegunCuatriemstre(lista.Sig,respuesta);
        }

        private int QueCuatrimestreEs (int mes)
        {
            if (mes >= 4 && mes <= 7)
                return 1;
            else
                if(mes>= 8 && mes <=12)
                return 2;
            return 0; 
        }

        private void BotonBuscadorAño_Click(object sender, EventArgs e)
        {
            listView1.Columns[4].Text = "Correlatividad:";
            año = (int)SelectorDeAño1.Value;
            if (año == 0)
                MostrarLista(0);
            else
                MostrarLista(4);
        }

        public void AgregarBuscadaAform(Materias lista, Materias buscada)
        {
            if (lista.Nombre.ToLower() == buscada.Nombre.ToLower())
            {
                ListViewItem list = new ListViewItem(lista.Codigo.ToString());
                list.SubItems.Add(lista.Nombre);
                list.SubItems.Add(lista.Año.ToString());
                list.SubItems.Add(lista.Estado);
                if (lista.Correlativa != null && lista.Correlativa2 != null && lista.Correlativa3 != null)
                    list.SubItems.Add(lista.Correlativa.Codigo.ToString() + " - " + lista.Correlativa2.Codigo.ToString() + " - " + lista.Correlativa3.Codigo.ToString());
                else if (lista.Correlativa != null && lista.Correlativa2 != null)
                    list.SubItems.Add(lista.Correlativa.Codigo.ToString() + " - " + lista.Correlativa2.Codigo.ToString());
                else if (lista.Correlativa != null)
                    list.SubItems.Add(lista.Correlativa.Codigo.ToString());

                listView1.Items.Add(list);
            }
            else
                cont++;
            if (lista.Sig != null)
                AgregarBuscadaAform(lista.Sig, buscada);
        }

        private void BotonBuscador_Click(object sender, EventArgs e)
        {
            listView1.Columns[4].Text = "Correlatividad:";
            buscada.Nombre = textBoxBuscador.Text;
            if (textBoxBuscador.Text == "")
                MessageBox.Show("El campo está vacio","Error");
            else
                MostrarLista(3);

            cont = 0;
        }

        private void BotonVerTodasLasMaterias_Click(object sender, EventArgs e)
        {
            listView1.Columns[4].Text = "Correlatividad:";
            MostrarLista(0);
            ReiniciarCampos();
        }

        public void LlenarListaParaInscripcion(bool cambio)
        {
            int mes = FechaDeHoy.Month;

            listView1.Items.Clear();

            int respuesta = QueCuatrimestreEs(mes);
            if (respuesta == 0)
                respuesta = 1;
            if (cambio == true)
            {
                if (respuesta == 1 || respuesta == 0)
                    respuesta = 2;
                else if (respuesta == 2)
                    respuesta = 1;
            }
            MostrarMateriasSegunCuatriemstre2(miLista.lista, respuesta);
            CompletarLABELcuatrimestre(respuesta);
        }

        public void MostrarMateriasSegunCuatriemstre2(Materias lista, int respuesta)
        {
            if (lista.Cuatrimestre == respuesta)
                AgregarMateriasQuePuedoCursarSegunCuatrimestre2(lista);
            if (lista.Sig != null)
                MostrarMateriasSegunCuatriemstre2(lista.Sig, respuesta);
        }

        public void AgregarMateriasQuePuedoCursarSegunCuatrimestre2(Materias lista)
        {
            if (lista.Correlativa == null)
            {
                if (lista.Estado != "Aprobada" && lista.Estado != "Cursando")
                {
                    ListViewItem list = new ListViewItem(lista.Codigo.ToString());
                    list.SubItems.Add(lista.Nombre);
                    list.SubItems.Add(lista.Año.ToString());
                    list.SubItems.Add(lista.Estado);

                    listView2.Items.Add(list);
                    cont++;
                }
            }

            else if (lista.Estado != "Aprobada" && lista.Estado != "Cursando" && lista.Correlativa.Estado == "Aprobada")
            {
                ListViewItem list = new ListViewItem(lista.Codigo.ToString());
                list.SubItems.Add(lista.Nombre);
                list.SubItems.Add(lista.Año.ToString());
                list.SubItems.Add(lista.Estado);

                listView2.Items.Add(list);
                cont++;
            }
        }

        private void BotonVolver2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        public void LlenarListaParaInscripcion3(Materias materia, bool cambio)
        {
            int mes = FechaDeHoy.Month;
            listView1.Items.Clear();
            int respuesta = QueCuatrimestreEs(mes);

            if (cambio == true)
            {
                if (materia.Cuatrimestre == respuesta)
                    AgregarMateriasQuePuedoCursarSegunCuatrimestre3(materia);
            }
            else
            {
                if (respuesta == 0)
                    respuesta = 1;

                if (respuesta == 1)
                    respuesta = 2;
                else if (respuesta == 2)
                    respuesta = 1;

                if (materia.Cuatrimestre == respuesta)
                    AgregarMateriasQuePuedoCursarSegunCuatrimestre3(materia);
            }
        }

        public void AgregarMateriasQuePuedoCursarSegunCuatrimestre3(Materias materia)
        {
            if (materia.Estado != "Aprobada" && materia.Estado != "Cursando")
            {
                ListViewItem list = new ListViewItem(materia.Nombre);
                listView3.Items.Add(list);
            }
            else
                return;
        }

        private void BotonSimularDistintoCuatrimestre_Click(object sender, EventArgs e)
        {
            listView3.Items.Clear();

            if(EsPar(contador)== true)
            {
                cambio = true;
                listView2.Items.Clear();
                LlenarListaParaInscripcion(cambio);
                contador++;
            }
            else
            {
                cambio = false;
                listView2.Items.Clear();
                LlenarListaParaInscripcion(cambio);
                contador++;
            }
        }

        public bool EsPar(int num)
        {
            return Convert.ToBoolean((num % 2 == 0 ? true : false));
        }

        public void ReiniciarCampos()
        {
            textBoxBuscador.Clear();
            SelectorDeAño1.Value = 0;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            Materias correlativaQueDesbloquea = miLista.BuscarCorrelativaPorCodigo(miLista.lista, seleccionado.Codigo);
            if(correlativaQueDesbloquea != null)
            MessageBox.Show(correlativaQueDesbloquea.Nombre,"Materia que desbloquea:");
            else
                MessageBox.Show("No desbloquea ninguna materia", "Materia que desbloquea:");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
    
            int indice = listView1.FocusedItem.Index;
            string nombre = listView1.Items[indice].SubItems[1].Text;

            seleccionado = miLista.BuscarPorNombre(miLista.lista, nombre);
        }

        private void listView2_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int[] codigo = new int[10];
            int i = 0;
            listView3.Items.Clear();
            Materias materia = new Materias();
            foreach (ListViewItem s in listView2.CheckedItems)
            {
                ListViewItem list = new ListViewItem(s.Text);
                codigo[i] = Convert.ToInt32(list.Text);
                i++;
            }

            for (i = 0; i < listView2.CheckedIndices.Count; i++)
            {
                materia = miLista.BuscarCorrelativaPorCodigo(miLista.lista, codigo[i]);
                if (materia != null)
                    LlenarListaParaInscripcion3(materia, cambio);
            }
        }

        private void buttonInscripcion_Click(object sender, EventArgs e)
        {
            int[] codigo = new int[10];
            int i = 0;
            Materias materia = new Materias();

            if (listView2.CheckedIndices.Count <= 0)
            {
                MessageBox.Show("No ha seleccionado ninguna materia","Error");
                return;
            }
                
            foreach (ListViewItem s in listView2.CheckedItems)
            {
                ListViewItem list = new ListViewItem(s.Text);
                codigo[i] = Convert.ToInt32(list.Text);
                i++;
            }

            for (i = 0; i < listView2.CheckedIndices.Count; i++)
            {
                materia = miLista.BuscarPorCodigo(miLista.lista, codigo[i]);
                if (materia != null)
                {
                    materia.Estado = "Cursando";
                    Materias Correlativa = miLista.BuscarCorrelativaPorCodigo(miLista.lista, materia.Codigo);
                    if (Correlativa != null)
                        Correlativa.Correlativa.Estado = materia.Estado;
                }
                else
                    return;   
            }

///VALIDACIÓN:
            string mensaje = "¿Desea inscribirse a las materias seleccionadas?";
            string titulo = "Seleccione la opción deseada:";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult ventana;

            ventana = MessageBox.Show(mensaje, titulo, botones);    
            if (ventana == System.Windows.Forms.DialogResult.Yes)
            {
                gestorMaterias.GuardarModificaciones(miLista.ListaAVector(), miLista.ContarMateriasTotales());

                listView3.Items.Clear();
                listView2.Items.Clear();
                LlenarListaParaInscripcion(cambio);
            }

            else if (ventana == System.Windows.Forms.DialogResult.No)
                MessageBox.Show("Inscripción cancelada","Información");
///
        }
    }
}
