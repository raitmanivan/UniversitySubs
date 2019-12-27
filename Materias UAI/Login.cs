using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EE;
using BLL;
using Services;
using Services.Session;

namespace Materias_UAI
{
    public partial class Login : Form
    {
        User user = new User();
        BLLUser BusinessUser = new BLLUser();
        int attempts = 0;

        public Login()
        {
            InitializeComponent();
        }

        private void bunifuMetroTextboxUSER_Enter(object sender, EventArgs e)
        {
            this.bunifuMetroTextboxUSER.Text = "";
        }

        private void bunifuMetroTextboxPASSWORD_Enter(object sender, EventArgs e)
        {
            this.bunifuMetroTextboxPASSWORD.isPassword = true;
            this.bunifuMetroTextboxPASSWORD.Text = "";
        }

        private void bunifuFlatButtonLOGIN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.bunifuMetroTextboxUSER.Text) || string.IsNullOrEmpty(this.bunifuMetroTextboxPASSWORD.Text))
                MessageBox.Show("You have not completed the corresponding data", "Error");
            else if(this.bunifuMetroTextboxUSER.Text == "Usuario" || this.bunifuMetroTextboxPASSWORD.Text == "Contraseña")
                MessageBox.Show("You have not completed the corresponding data", "Error");
            else
            {
                string proposedUser = this.bunifuMetroTextboxUSER.Text;
                string proposedPassword = this.bunifuMetroTextboxPASSWORD.Text;
                user.Username = proposedUser;

                if (BusinessUser.LoginQuery(user, Security.Encrypt(proposedPassword)))
                {
                    attempts = 0;
                    Console.WriteLine("Creating session for the user...");
                    Session sm = Session.getInstance();
                    try
                    {
                        user = BusinessUser.SearchUserByUsername(user);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    sm.user = user;
                    MessageBox.Show("Ingresaste al sistema correctamente", "Información");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect data", "Error");
                    this.bunifuMetroTextboxPASSWORD.Text = "";
                    attempts += 1;
                }

                if (attempts == 3)
                {
                    MessageBox.Show("You have reached the maximun level of attempts, you have been blocked.", "Attention is needed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }

        }
    }
}
