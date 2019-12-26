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
    public partial class Form1 : Form
    {
        int botonSeleccionado = 0;
        int cont = 0; 
        Materias buscada = new Materias();
        Materias seleccionado = new Materias();
        int año = 0;

        public Lista miLista = new Lista();
        GestorDeMaterias gestorMaterias;

        public Form1()
        {
            InitializeComponent();      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gestorMaterias = new GestorDeMaterias();
            miLista.HardCode();
            ActualizarContador();
            MostrarLista(0);
        }

        public void ActualizarContador()
        {
            label3.Text = miLista.ContarMateriasTotales().ToString();
            label4.Text = miLista.ContarMateriasAprobadas().ToString();
            int restantes = (miLista.ContarMateriasTotales() - miLista.ContarMateriasAprobadas());
            label6.Text = restantes.ToString();
            label13.Text = string.Format("{0:0.##}", miLista.CalcularPromedioNotas());
            this.label1HOMOLOGADAoSinNota.Visible = false;
            this.numericUpDownNOTAS.Enabled = true;
        }

        public void MostrarLista(int opcion)
        {
            listView1.Items.Clear();

            switch(opcion)
            {
                case 0: ///Muestra la lista completa de materias
                    {
                        if (miLista.lista != null)
                            AgregarAlistaForm(miLista.lista);
                        break;
                    }
                case 1: ///Muestra la lista de materias Aprobadas
                    {
                        if (miLista.lista != null)
                            AgregarAprobadasAform(miLista.lista);
                        break;
                    }
                case 2: ///Muestra la lista de materias en curso
                    {
                        if (miLista.lista != null)
                            AgregarEnCursoAform(miLista.lista);
                        break;
                    }
                case 3: ///Muestra sólo la materia buscada
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
                case 4: ///Muestra sólo las materias filtradas por año
                    {
                        if (miLista.lista != null)
                            AgregarBuscadaPorAñoAform(miLista.lista, año);
                        break;
                    }
            } 
        }

        public void AgregarAlistaForm(Materias lista)
        {
            ListViewItem list = new ListViewItem(lista.Nombre);
            list.SubItems.Add(lista.Año.ToString());
            list.SubItems.Add(lista.Estado);
            if(lista.Nota != 0)
                list.SubItems.Add(lista.Nota.ToString());

            listView1.Items.Add(list);

            if (lista.Sig != null)
                AgregarAlistaForm(lista.Sig);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            int indice = listView1.FocusedItem.Index;
            string nombre = listView1.Items[indice].SubItems[0].Text;

            seleccionado = miLista.BuscarPorNombre(miLista.lista, nombre);

            textBoxCambiarEstado.Text = seleccionado.Nombre;
            if (seleccionado.Estado == "Aprobada")
                comboxEstado.Text = "Aprobada";
            else if (seleccionado.Estado == "Cursando")
                comboxEstado.Text = "Cursando";
            else if (seleccionado.Estado == "No cursada")
                comboxEstado.Text = "No cursada";
            this.numericUpDownNOTAS.Value = seleccionado.Nota;

            if(seleccionado.Nombre == "Inglés I" || seleccionado.Nombre == "Inglés II" || seleccionado.Nombre == "Inglés III" || seleccionado.Nombre == "Inglés IV")
            {
                this.label1HOMOLOGADAoSinNota.Visible = true;
                this.label1HOMOLOGADAoSinNota.Text = "Homologada";
                this.numericUpDownNOTAS.Enabled = false;
            }

            else if(seleccionado.Estado == "Aprobada" && seleccionado.Nota == 0)
            {
                this.label1HOMOLOGADAoSinNota.Visible = true;
                this.label1HOMOLOGADAoSinNota.Text = "Sin nota";
                this.numericUpDownNOTAS.Enabled = true;
            }

            else
            {
                this.label1HOMOLOGADAoSinNota.Visible = false;
                this.numericUpDownNOTAS.Enabled = true;
            }

        }

        private void BotonVerAprobadas_Click(object sender, EventArgs e)
        {
            MostrarLista(1);
            botonSeleccionado = 2;
            ReiniciarCampos();
        }

        public void AgregarAprobadasAform(Materias lista)
        {
            if(lista.Estado == "Aprobada")
            {
                ListViewItem list = new ListViewItem(lista.Nombre);
                list.SubItems.Add(lista.Año.ToString());
                list.SubItems.Add(lista.Estado);
                if (lista.Nota != 0)
                    list.SubItems.Add(lista.Nota.ToString());
                listView1.Items.Add(list);
            }
            if (lista.Sig != null)
                AgregarAprobadasAform(lista.Sig);
        }

        public int AgregarFaltantesAño(Materias lista,int año)
        {
            if (lista.Estado != "Aprobada" && lista.Año == año)
            {
                ListViewItem list = new ListViewItem(lista.Nombre);
                list.SubItems.Add(lista.Año.ToString());
                list.SubItems.Add(lista.Estado);
                if (lista.Nota != 0)
                    list.SubItems.Add(lista.Nota.ToString());
                listView1.Items.Add(list);
                cont++;
            }
            if (lista.Sig != null)
                AgregarFaltantesAño(lista.Sig,año);
            return cont;
        }

        public void AgregarBuscadaPorAñoAform(Materias lista, int año)
        {
            if (lista.Año == año)
            {
                ListViewItem list = new ListViewItem(lista.Nombre);
                list.SubItems.Add(lista.Año.ToString());
                list.SubItems.Add(lista.Estado);
                if (lista.Nota != 0)
                    list.SubItems.Add(lista.Nota.ToString());
                listView1.Items.Add(list);
            }
            if (lista.Sig != null)
                AgregarBuscadaPorAñoAform(lista.Sig, año);
        }

        private void BotonVerMateriasEnCurso_Click(object sender, EventArgs e)
        {
            MostrarLista(2);
            botonSeleccionado = 3;
            ReiniciarCampos();
        }

        public void AgregarEnCursoAform(Materias lista)
        {
            if (lista.Estado == "Cursando")
            {
                ListViewItem list = new ListViewItem(lista.Nombre);
                list.SubItems.Add(lista.Año.ToString());
                list.SubItems.Add(lista.Estado);
                if (lista.Nota != 0)
                    list.SubItems.Add(lista.Nota.ToString());
                listView1.Items.Add(list);
            }
            if (lista.Sig != null)
                AgregarEnCursoAform(lista.Sig);
        }
        
        public void AgregarParaTituloIntermedioAform(Materias lista)
        {
            if (lista.Año!=4 && lista.Año!=5 && lista.Estado!="Aprobada")
            {
                ListViewItem list = new ListViewItem(lista.Nombre);
                list.SubItems.Add(lista.Año.ToString());
                list.SubItems.Add(lista.Estado);
                if (lista.Nota != 0)
                    list.SubItems.Add(lista.Nota.ToString());
                listView1.Items.Add(list);
                cont++;
            }
            if (lista.Sig != null)
                AgregarParaTituloIntermedioAform(lista.Sig);
        }

        private void BotonVerTodas_Click(object sender, EventArgs e)
        {
            MostrarLista(0);
            botonSeleccionado = 1;
            ReiniciarCampos();
        }

        private void BotonIrAform_Click(object sender, EventArgs e)
        {
            this.Hide();
            Correlatividades form = new Correlatividades(this.miLista);
            form.Show();
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            if (textBoxCambiarEstado.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la materia", "Error");
                return;
            }
                
            Materias nuevo = new Materias();
            nuevo.Nombre = textBoxCambiarEstado.Text;

            if (comboxEstado.Text == "Aprobada")
                nuevo.Estado = "Aprobada";
            else if (comboxEstado.Text == "Cursando")
                nuevo.Estado = "Cursando";
            else if (comboxEstado.Text == "No cursada")
                nuevo.Estado = "No cursada";

            nuevo.Año = seleccionado.Año;
            nuevo.Codigo = seleccionado.Codigo;

            if(seleccionado.Correlativa != null)
                nuevo.Correlativa = seleccionado.Correlativa;

            if (seleccionado.Correlativa2 != null)
                nuevo.Correlativa2 = seleccionado.Correlativa2;

            if (seleccionado.Correlativa3 != null)
                nuevo.Correlativa3 = seleccionado.Correlativa3;

            nuevo.Cuatrimestre = seleccionado.Cuatrimestre;

            nuevo.Nota = Convert.ToInt32(this.numericUpDownNOTAS.Value);

            miLista.Modificar(nuevo,seleccionado);

            if (botonSeleccionado == 1)
                MostrarLista(0);
            else if (botonSeleccionado == 2)
                MostrarLista(1);
            else if (botonSeleccionado == 3)
                MostrarLista(2);
            else
                MostrarLista(0);

            ActualizarContador();
            ReiniciarCampos();
            gestorMaterias.GuardarModificaciones(miLista.ListaAVector(),miLista.ContarMateriasTotales());
        }

        public void ReiniciarCampos()
        {
            textBoxCambiarEstado.Clear();
            comboxEstado.Text = "";
            textBoxBuscador.Clear();
            SelectorDeAño1.Value = 0;
            comboBoxBusqueda.Text = "";
        }

        public void AgregarBuscadaAform(Materias lista, Materias buscada)
        {
            if (lista.Nombre.ToLower() == buscada.Nombre.ToLower())
            {
                ListViewItem list = new ListViewItem(lista.Nombre);
                list.SubItems.Add(lista.Año.ToString());
                list.SubItems.Add(lista.Estado);
                if (lista.Nota != 0)
                    list.SubItems.Add(lista.Nota.ToString());
                listView1.Items.Add(list);
            }
            else
                cont++;
            if (lista.Sig != null)
                AgregarBuscadaAform(lista.Sig, buscada);
        }


        private void BotonBuscador_Click(object sender, EventArgs e)
        {
            buscada.Nombre = textBoxBuscador.Text;
            if (textBoxBuscador.Text == "")
                MessageBox.Show("El campo está vacio");
            else
            {
                MostrarLista(3);
                ReiniciarCampos();
            }

            cont = 0;
        }

        private void BotonBuscadorAño_Click(object sender, EventArgs e)
        {
            año = (int)SelectorDeAño1.Value;
            if (año == 0)
                MostrarLista(0);
            else
                MostrarLista(4);
            ReiniciarCampos();
        }

        private void BotonEjecutar_Click(object sender, EventArgs e)
        {
            if(comboBoxBusqueda.Text == "")
            {
                MessageBox.Show("Elija una opción","Error");
                return;
            }

            listView1.Items.Clear();
            int año = 0;
            cont = 0;
            string respuesta;

            respuesta = comboBoxBusqueda.Text;
            switch(respuesta)
            {
                case "¿Cuántas materias me faltan de Primer año?":
                    {
                        año = 1;
                        AgregarFaltantesAño(miLista.lista,año);
                        MessageBox.Show("Cantidad de materias faltantes: " + cont,"Primer año");
                        break;
                    }
                case "¿Cuántas materias me faltan de Segundo año?":
                    {
                        año = 2;
                        AgregarFaltantesAño(miLista.lista, año);
                        MessageBox.Show("Cantidad de materias faltantes: " + cont, "Segundo año");
                        break;
                    }
                case "¿Cuántas materias me faltan de Tercer año?":
                    {
                        año = 3;
                        AgregarFaltantesAño(miLista.lista, año);
                        MessageBox.Show("Cantidad de materias faltantes: " + cont, "Tercer año");
                        break;
                    }
                case "¿Cuántas materias me faltan de Cuarto año?":
                    {
                        año = 4;
                        AgregarFaltantesAño(miLista.lista, año);
                        MessageBox.Show("Cantidad de materias faltantes: " + cont, "Cuarto año");
                        break;
                    }
                case "¿Cuántas materias me faltan de Quinto año?":
                    {
                        año = 5;
                        AgregarFaltantesAño(miLista.lista, año);
                        MessageBox.Show("Cantidad de materias faltantes: " + cont, "Quinto año");
                        break;
                    }
                case "¿Cuántas materias me faltan para el Título Intermedio?":
                    {
                        AgregarParaTituloIntermedioAform(miLista.lista);
                        MessageBox.Show("Cantidad de materias faltantes: " + cont, "Título intermedio");
                        break;
                    }
            }
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea guardar cambios?", "Salir", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                gestorMaterias.GuardarCambios(miLista.ContarMateriasTotales());
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                try
                {
                    gestorMaterias.RestaurarArchivo(miLista.ContarMateriasTotales());
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (result == DialogResult.Cancel)
            {
            }
            
        }

        private void BotonAdministrador_Click(object sender, EventArgs e)
        {            
            this.Hide();
            Login_ form = new Login_(this.miLista);
            form.Show();

            /** PARA PRUEBAS:
             
            this.Hide();
            ABM_Materias form = new ABM_Materias(this.miLista);
            form.Show();
            */
        }

        private void comboBoxBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
