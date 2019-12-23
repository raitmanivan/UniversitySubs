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
    public partial class ABM_Materias : Form
    {
        Lista miLista = new Lista();
        //Lista listabackup = new Lista();
        Materias seleccionado = new Materias();
        //int indice;
        int modo = 0;

        public ABM_Materias(Lista lista)
        {
            InitializeComponent();
            miLista = lista;
            ///
            ///VER COMO RESTAURAR CAMBIOS
            ///
            MostrarLista();
        }

        public void MostrarLista()
        {
            listView1.Items.Clear();
                       if (miLista.lista != null)
                            AgregarAlistaForm(miLista.lista);
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

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            BotonEliminar.Enabled = false;
            BotonModificar.Enabled = false;
            modo = 1;
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            BotonAgregar.Enabled = false;
            BotonEliminar.Enabled = false;
            modo = 2;
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            BotonAgregar.Enabled = false;
            BotonModificar.Enabled = false;
            modo = 3;
        }

        private void BotonProcesar_Click(object sender, EventArgs e)
        {
            BotonAgregar.Enabled = true;
            BotonEliminar.Enabled = true;
            BotonModificar.Enabled = true;
            
            switch(modo)
            {
                case 1: ///AGREGAR:
                    {
                        if (textBoxNombre.Text == "")
                        {
                            MessageBox.Show("Complete todos los campos");
                            return;
                        }

                        Materias nueva = new Materias();
                        nueva.Nombre = textBoxNombre.Text;

                        if (miLista.Buscar(miLista.lista, nueva) != null)
                        {
                            MessageBox.Show("La materia que está queriendo ingresar ya se encuentra registrada");
                            return;
                        }

                        if (comboBoxAño.Text == "")
                        {
                            MessageBox.Show("Complete el Año de la materia");
                            return;
                        }

                        if (comboBoxAño.Text == "Primer Año")
                            nueva.Año = 1;
                        else if (comboBoxAño.Text == "Segundo Año")
                            nueva.Año = 2;
                        else if (comboBoxAño.Text == "Tercer Año")
                            nueva.Año = 3;
                        else if (comboBoxAño.Text == "Cuarto Año")
                            nueva.Año = 4;
                        else if (comboBoxAño.Text == "Quinto Año")
                            nueva.Año = 5;

                        if (comboxEstado.Text == "Aprobada")
                            nueva.Estado = "Aprobada";
                        else if (comboxEstado.Text == "Cursando")
                            nueva.Estado = "Cursando";
                        else if (comboxEstado.Text == "No Cursada")
                            nueva.Estado = "No Cursada";

                        Materias materia = new Materias();
                        materia.Nombre = textBoxCorrelativa.Text;
                        int correlativa = 0;
                        if (!string.IsNullOrEmpty(textBoxCorrelativa.Text))
                        {
                             correlativa = Convert.ToInt32(textBoxCorrelativa.Text);
                            materia = miLista.BuscarCorrelativaPorCodigo(miLista.lista, correlativa);
                            if (materia != null)
                                nueva.Correlativa = materia;
                            else
                            {
                                MessageBox.Show("El código de materia correlativa ingresado no existe");
                                return;
                            }
                                
                        }

                        int cantidad = miLista.ContarMateriasTotales();
                        nueva.Codigo = cantidad + 1;

                        nueva.Estado = "No cursada";
                        if (SelectorDeCuatri.Value == 0)
                            MessageBox.Show("Ingrese en que cuatrimestre se dicta la materia");
                        nueva.Cuatrimestre = (int)SelectorDeCuatri.Value;

                        miLista.AgregarMateria(nueva);
                        MostrarLista();

                        break;
                    }
                case 2: ///MODIFICAR:
                    {
                        if (textBoxNombre.Text == "")
                            return;

                        Materias nuevo = new Materias();
                        nuevo.Nombre = textBoxNombre.Text;

                        nuevo.Codigo = seleccionado.Codigo;

                        if (comboBoxAño.Text == "Primer Año")
                            nuevo.Año = 1;
                        else if (comboBoxAño.Text == "Segundo Año")
                            nuevo.Año = 2;
                        else if (comboBoxAño.Text == "Tercer Año")
                            nuevo.Año = 3;
                        else if (comboBoxAño.Text == "Cuarto Año")
                            nuevo.Año = 4;
                        else if (comboBoxAño.Text == "Quinto Año")
                            nuevo.Año = 5;

                        if (comboxEstado.Text == "Aprobada")
                            nuevo.Estado = "Aprobada";
                        else if (comboxEstado.Text == "Cursando")
                            nuevo.Estado = "Cursando";
                        else if (comboxEstado.Text == "No cursada")
                            nuevo.Estado = "No Cursada";


                        int correlativa = 0;
                        if (!string.IsNullOrEmpty(textBoxCorrelativa.Text))
                        {
                            Materias materia = new Materias();
                            materia.Nombre = textBoxCorrelativa.Text;
                            correlativa = Convert.ToInt32(textBoxCorrelativa.Text);
                            materia = miLista.BuscarPorCodigo(miLista.lista, correlativa);
                            if (materia != null)
                                nuevo.Correlativa = materia;
                            else
                            {
                                MessageBox.Show("El código de materia correlativa ingresado no existe");
                                return;
                            }

                        }
                        else
                            nuevo.Correlativa = null;

                        if (!string.IsNullOrEmpty(textBoxCorrelativa2.Text))
                        {
                            Materias materia = new Materias();
                            materia.Nombre = textBoxCorrelativa2.Text;
                            correlativa = Convert.ToInt32(textBoxCorrelativa2.Text);
                            materia = miLista.BuscarPorCodigo(miLista.lista, correlativa);
                            if (materia != null)
                                nuevo.Correlativa2 = materia;
                            else
                            {
                                MessageBox.Show("El código de materia correlativa ingresado no existe");
                                return;
                            }

                        }
                        else
                            nuevo.Correlativa2 = null;

                        if (!string.IsNullOrEmpty(textBoxCorrelativa3.Text))
                        {
                            Materias materia = new Materias();
                            materia.Nombre = textBoxCorrelativa3.Text;
                            correlativa = Convert.ToInt32(textBoxCorrelativa3.Text);
                            materia = miLista.BuscarPorCodigo(miLista.lista, correlativa);
                            if (materia != null)
                                nuevo.Correlativa3 = materia;
                            else
                            {
                                MessageBox.Show("El código de materia correlativa ingresado no existe");
                                return;
                            }

                        }
                        else
                            nuevo.Correlativa3 = null;

                        miLista.Modificar(nuevo, seleccionado);

                        MostrarLista();
                        break;
                    }
                case 3: //ELIMINAR...
                    {
                        if (textBoxNombre.Text == "")
                            return;

                        Materias Aeliminar = new Materias();
                        Aeliminar.Nombre = textBoxNombre.Text;

                        if (comboxEstado.Text == "Aprobada")
                            Aeliminar.Estado = "Aprobada";
                        else if (comboxEstado.Text == "Cursando")
                            Aeliminar.Estado = "Cursando";
                        else if (comboxEstado.Text == "No Cursada")
                            Aeliminar.Estado = "No Cursada";

                        if (comboBoxAño.Text == "Primer Año")
                            Aeliminar.Año = 1;
                        else if (comboBoxAño.Text == "Segundo Año")
                            Aeliminar.Año = 2;
                        else if (comboBoxAño.Text == "Tercer Año")
                            Aeliminar.Año = 3;
                        else if (comboBoxAño.Text == "Cuarto Año")
                            Aeliminar.Año = 4;
                        else if (comboBoxAño.Text == "Quinto Año")
                            Aeliminar.Año = 5;

                        miLista.BorrarSeleccionado(Aeliminar);

                        MostrarLista();
                        break;
                    }
            }  
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCorrelativa.Text = "";

            if (listView1.SelectedItems.Count == 0) return;
            int indice = listView1.FocusedItem.Index;
            string nombre = listView1.Items[indice].SubItems[1].Text;

            Materias materia = new Materias();
            materia = miLista.BuscarPorNombre(miLista.lista, nombre);
            if(materia != null)
            {
                seleccionado = materia;
                textBoxNombre.Text = materia.Nombre;

                switch(materia.Año)
                {
                    case 1:
                        {
                            comboBoxAño.Text = "Primer Año";
                            break;
                        }
                    case 2:
                        {
                            comboBoxAño.Text = "Segundo Año";
                            break;
                        }
                    case 3:
                        {
                            comboBoxAño.Text = "Tercer Año";
                            break;
                        }
                    case 4:
                        {
                            comboBoxAño.Text = "Cuarto Año";
                            break;
                        }
                    case 5:
                        {
                            comboBoxAño.Text = "Quinto Año";
                            break;
                        }
                }

                if (seleccionado.Estado == "Aprobada")
                    comboxEstado.Text = "Aprobada";
                else if (seleccionado.Estado == "Cursando")
                    comboxEstado.Text = "Cursando";
                else if (seleccionado.Estado == "No cursada")
                    comboxEstado.Text = "No cursada";

                if (materia.Correlativa!=null)
                textBoxCorrelativa.Text = materia.Correlativa.Codigo.ToString();
                if (materia.Correlativa2 != null)
                    textBoxCorrelativa2.Text = materia.Correlativa2.Codigo.ToString();
                if (materia.Correlativa3 != null)
                    textBoxCorrelativa3.Text = materia.Correlativa3.Codigo.ToString();

                if (materia.Cuatrimestre == 1)
                    SelectorDeCuatri.Value = 1;
                else
                    SelectorDeCuatri.Value = 2;
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void textBoxCorrelativa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (seleccionado.Correlativa != null)
            MessageBox.Show(seleccionado.Correlativa.Nombre,"Materia:");
        }

        private void BotonCancelarSeleccion_Click(object sender, EventArgs e)
        {
            BotonAgregar.Enabled = true;
            BotonEliminar.Enabled = true;
            BotonModificar.Enabled = true;
        }

        private void BotonRestaurar_Click(object sender, EventArgs e)
        {
           // miLista.lista = listabackup.lista; ///VER COMO RESTAURAR CAMBIOS
            MostrarLista();
        }
    }
}
