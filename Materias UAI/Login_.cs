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
    public partial class Login_ : Form
    {
        Lista miLista = new Lista();
        int cont = 0;

        public Login_(Lista lista)
        {
            InitializeComponent();
            miLista = lista;
            this.textBox1.Text = "Administrador";
            textBox2.UseSystemPasswordChar = true;
        }

        private void BotonIniciarSesión_Click(object sender, EventArgs e)
        {
            string admin = textBox1.Text.ToLower();

#region "Credenciales"            
            if (admin == "administrador" && textBox2.Text == "Ivan2407")
            {
                MessageBox.Show("Credenciales correctas","Ingreso exitoso");
                this.Hide();
                ABM_Materias form = new ABM_Materias(this.miLista);
                form.Show();
            }
#endregion    

            else
            {
                if(cont!=2)
                {
                    MessageBox.Show("Credenciales incorrectas","Ingreso incorrecto");
                    this.textBox2.Clear();
                    cont++;
                }
                else
                {
                    MessageBox.Show("Cantidad permitida de intentos superada","Error");
                    Form1 form = new Form1();
                    form.Show();
                    this.Close();
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string admin = textBox1.Text.ToLower();

                #region "Credenciales"            
                if (admin == "administrador" && textBox2.Text == "Ivan2407")
                {
                    MessageBox.Show("Credenciales correctas", "Ingreso exitoso");
                    this.Hide();
                    ABM_Materias form = new ABM_Materias(this.miLista);
                    form.Show();
                }
                #endregion

                else
                {
                    if (cont != 2)
                    {
                        MessageBox.Show("Credenciales incorrectas", "Ingreso incorrecto");
                        this.textBox2.Clear();
                        cont++;
                    }
                    else
                    {
                        MessageBox.Show("Cantidad permitida de intentos superada", "Error");
                        Form1 form = new Form1();
                        form.Show();
                        this.Close();
                    }
                }
            }
        }
    }
}
