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

        BLLSubject BusinessSubject = new BLLSubject();
        string SelectedSubjectname = "Not Selected";

        public Administration()
        {
            InitializeComponent();
        }

        #region User Administration...
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
                Student newStudent = new Student(this.bunifuCustomTextboxStudentID.Text, this.bunifuCustomTextboxUniversityID.Text, this.bunifuCustomTextboxNameAndSurname.Text, this.bunifuCustomTextboxEmail.Text, new ActiveStatus());
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
        #endregion

        private void bunifuCustomDataGridSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SelectedSubjectname = this.bunifuCustomDataGridSubjects.Rows[e.RowIndex].Cells[1].Value.ToString();
                bunifuCustomLabelSubjectSelected.Text = SelectedSubjectname;
            }
            catch (Exception)
            {
                bunifuCustomLabelSubjectSelected.Text = "";
            }

        }

        private void ListSubjects(bool status)
        {
            this.bunifuCustomLabelSubjectSelectedTitle.Visible = true;
            this.bunifuCustomLabelSubjectSelected.Visible = true;

            bunifuCustomDataGridSubjects.DataSource = null;
            if (status)
                bunifuCustomDataGridSubjects.DataSource = BusinessSubject.ListSubjects();
            else
                bunifuCustomDataGridSubjects.DataSource = BusinessSubject.ListActiveSubjects();

            #region Column design...
            bunifuCustomDataGridSubjects.Columns["SubjectID"].Width = 30;
            bunifuCustomDataGridSubjects.Columns["SubjectID"].HeaderText = "ID";

            bunifuCustomDataGridSubjects.Columns["Name"].Width = 300;

            bunifuCustomDataGridSubjects.Columns["Year"].Width = 40;

            bunifuCustomDataGridSubjects.Columns["Status"].Width = 70;

            bunifuCustomDataGridSubjects.Columns["PeriodType"].HeaderText = "Period";
            bunifuCustomDataGridSubjects.Columns["PeriodType"].Width = 100;

            bunifuCustomDataGridSubjects.Columns["CorrespondingPeriod"].HeaderText = "Time";
            bunifuCustomDataGridSubjects.Columns["CorrespondingPeriod"].Width = 40;
            #endregion
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["Asignaturas"])
            {
                ListSubjects(false);
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["Estudiantes"])
            {
                this.bunifuCustomLabelSubjectSelectedTitle.Visible = false;
                this.bunifuCustomLabelSubjectSelected.Visible = false;
            }
        }

        private void Administration_Load(object sender, EventArgs e)
        {
            #region Design...
            bunifuCustomLabelSubjectSelected.Text = "";
            this.bunifuCustomLabelSubjectSelectedTitle.Visible = false;
            this.bunifuCustomLabelSubjectSelected.Visible = false;
            #endregion
        }

        private void bunifuFlatButtonNewSubject_Click(object sender, EventArgs e)
        {
            this.bunifuCustomDataGridSubjects.DataSource = null;
            List<Subject> emptyList = new List<Subject>();
            Subject emptySubject = new Subject();
            emptySubject.SubjectID = BusinessSubject.ListSubjects().Count + 1;
            emptySubject.Status = new ActiveStatus();
            emptySubject.Year = 1;
            emptySubject.CorrespondingPeriod = 1;
            emptySubject.PeriodType = "Four-month";
            emptyList.Add(emptySubject);
            this.bunifuCustomDataGridSubjects.DataSource = emptyList;

            #region Column design...
            bunifuCustomDataGridSubjects.Columns["SubjectID"].Width = 30;
            bunifuCustomDataGridSubjects.Columns["SubjectID"].HeaderText = "ID";

            bunifuCustomDataGridSubjects.Columns["Name"].Width = 300;

            bunifuCustomDataGridSubjects.Columns["Year"].Width = 40;

            bunifuCustomDataGridSubjects.Columns["Status"].Width = 70;

            bunifuCustomDataGridSubjects.Columns["PeriodType"].HeaderText = "Period";
            bunifuCustomDataGridSubjects.Columns["PeriodType"].Width = 100;

            bunifuCustomDataGridSubjects.Columns["CorrespondingPeriod"].HeaderText = "Time";
            bunifuCustomDataGridSubjects.Columns["CorrespondingPeriod"].Width = 40;
            #endregion

        }

        private void bunifuFlatButtonConfirmNewSubject_Click(object sender, EventArgs e)
        {
            ActiveStatus status = new ActiveStatus();
            try
            {
                DataGridViewSelectedRowCollection selected = this.bunifuCustomDataGridSubjects.SelectedRows;
                if (selected.Count == 0)
                {
                    MessageBox.Show("Seleccione la nueva asignatura", "Información");
                    return;
                }
                foreach (DataGridViewRow row in selected)
                {
                    Subject newSubject = new Subject();
                    newSubject.SubjectID = Convert.ToInt32(row.Cells[0].Value);
                    newSubject.Name = row.Cells[1].Value.ToString();
                    newSubject.Year = Convert.ToInt32(row.Cells[2].Value);
                    newSubject.Status = status;
                    newSubject.PeriodType = row.Cells[4].Value.ToString();
                    newSubject.CorrespondingPeriod = Convert.ToInt32(row.Cells[5].Value);

                    BusinessSubject.CreateSubject(newSubject);

                }

                MessageBox.Show("Alta realizada correctamente", "Información");
                ListSubjects(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en el alta de la asignatura", "Contactese con un administrador");
                Console.WriteLine(ex.Message);
            }

            //this.bunifuFlatButtonConfirmNewSubject.Visible = false;
        }

        private void bunifuCustomDataGridSubjects_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.bunifuCustomDataGridSubjects.CurrentRow.Selected = true;
            }
            catch (Exception)
            {
            }

        }

        private void bunifuFlatButtonSubjectsInProgress_Click(object sender, EventArgs e)
        {
            Subject SelectedSubject = new Subject();
            SelectedSubject = BusinessSubject.ListSubjectByName(SelectedSubjectname);
            try
            {
                if (SelectedSubject.Status.status == "Active")
                {
                    BusinessSubject.ChangeSubjectStatus(SelectedSubject, new InactiveStatus());
                }
                else if (SelectedSubject.Status.status == "Inactive")
                {
                    BusinessSubject.ChangeSubjectStatus(SelectedSubject, new ActiveStatus());
                }

                MessageBox.Show("Cambio realizado correctamente", "Información");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en el cambio de estado de la asignatura", "Contactese con un administrador");
                Console.WriteLine(ex.Message);
            }

            ListSubjects(false);

        }

        private void bunifuiOSSwitchMoreDetails_OnValueChange(object sender, EventArgs e)
        {
            if (this.bunifuiOSSwitchMoreDetails.Value)
            {
                ListSubjects(true);
            }
            else
            {
                ListSubjects(false);
            }
        }
    }
}
