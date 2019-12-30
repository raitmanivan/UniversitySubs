using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Services.Session;
using BLL;
using EE;

namespace Materias_UAI
{
    public partial class Init : Form
    {
        Session session = Session.getInstance();
        BLLStudent BusinessStudent = new BLLStudent();
        Student empty = new Student();
        public Init()
        {
            InitializeComponent();
            openChildForm(new Login());
            FillStudentInformation(empty);
            this.bunifuFlatButtonLOGOUT.Visible = false;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if(Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
                Student empty = new Student();
                FillStudentInformation(empty);
                this.bunifuTileButtonUSER.Visible = false;
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                SidebarWrapper.Width = 300;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
                FillStudentInformation(empty);
                this.bunifuTileButtonUSER.Visible = true;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new Subjects());
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelChart.Controls.Add(childForm);
            PanelChart.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            openChildForm(new Login());
        }

        private void FillStudentInformation(Student student)
        {
            if (student.NameAndSurname != null)
                this.bunifuCustomLabelNAME.Text = student.NameAndSurname;
            else
                this.bunifuCustomLabelNAME.Text = "";
            if(student.StudentID != null)
                this.bunifuCustomLabelStudentID.Text = student.StudentID;
            else
                this.bunifuCustomLabelStudentID.Text = "";
            if (student.UniversityID != null)
                this.bunifuCustomLabelUniversityID.Text = student.UniversityID;
            else
                this.bunifuCustomLabelUniversityID.Text = "";
            if (student.Email != null)
                this.bunifuCustomLabelEmail.Text = student.Email;
            else
                this.bunifuCustomLabelEmail.Text = "";
            if (student.Status != null)
                this.bunifuCustomLabelStatus.Text = student.Status.status;
            else
                this.bunifuCustomLabelStatus.Text = "";
        }

        private void bunifuTileButtonUSER_Click(object sender, EventArgs e)
        {
            try
            {
                this.bunifuCustomLabelNAME.Text = session.user.Username;
                Student student = new Student();
                FillStudentInformation(BusinessStudent.SearchStudentByUser(session.user));
                this.bunifuFlatButtonLOGOUT.Visible = true;

            }
            catch (Exception)
            {
                this.bunifuCustomLabelNAME.Text = "";
            }
        }

        private void MenuTop_Paint(object sender, PaintEventArgs e)
        {
       
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            openChildForm(new Administration());
        }

        private void bunifuFlatButtonLOGOUT_Click(object sender, EventArgs e)
        {
            try
            {
                if(session.Logout())
                {
                    MessageBox.Show("Saliste del sistema correctamente", "Información");
                    FillStudentInformation(empty);
                    this.bunifuFlatButtonLOGOUT.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void bunifuFlatButtonCORRELATIVITIES_Click(object sender, EventArgs e)
        {
            openChildForm(new CorrelativeSubjects());
        }
    }
}
