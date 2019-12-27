using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using EE;
using EE.States;
using Services;

namespace Materias_UAI
{
    public partial class Administration : Form
    {
        BLLStudent BusinessStudent = new BLLStudent();
        BLLUser BusinessUser = new BLLUser();

        public Administration()
        {
            InitializeComponent();
        }

        private void bunifuFlatButtonSAVE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.bunifuCustomTextboxStudentID.Text))
            {
                MessageBox.Show("No ha completado el campo [Legajo]", "Error");
                return;
            }

            if (string.IsNullOrEmpty(this.bunifuCustomTextboxNameAndSurname.Text))
            {
                MessageBox.Show("No ha completado el campo [Nombre y apellido]", "Error");
                return;
            }

            if (string.IsNullOrEmpty(this.bunifuCustomTextboxUniversityID.Text))
            {
                MessageBox.Show("No ha completado el campo [Universidad]", "Error");
                return;
            }

            if (string.IsNullOrEmpty(this.bunifuCustomTextboxEmail.Text))
            {
                MessageBox.Show("No ha completado el campo [Email]", "Error");
                return;
            }

            if (string.IsNullOrEmpty(this.bunifuCustomTextboxUsername.Text))
            {
                MessageBox.Show("No ha completado el campo [Usuario]", "Error");
                return;
            }

            if (string.IsNullOrEmpty(this.bunifuCustomTextboxPassword.Text))
            {
                MessageBox.Show("No ha completado el campo [Contraseña]", "Error");
                return;
            }

            try
            {
                Student newStudent = new Student(this.bunifuCustomTextboxStudentID.Text,this.bunifuCustomTextboxUniversityID.Text,this.bunifuCustomTextboxNameAndSurname.Text,this.bunifuCustomTextboxEmail.Text,new ActiveStatus());
                BusinessStudent.CreateStudent(newStudent);

                User newUser = new User(this.bunifuCustomTextboxUsername.Text, Security.Encrypt(this.bunifuCustomTextboxPassword.Text));
                BusinessUser.CreateUser(newUser);

                BusinessStudent.LinkStudentWithUser(newStudent, newUser);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error al crear al estudiante", "Comunicarse con un administrador");
            }
        }
    }
}
