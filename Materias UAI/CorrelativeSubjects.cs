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
using Services.Session;

namespace Materias_UAI
{
    public partial class CorrelativeSubjects : Form
    {
        BLLSubject BusinessSubject = new BLLSubject();
        Session session = Session.getInstance();
        BLLStudent BusinessStudent = new BLLStudent();
        string SelectedSubjectname = "Not Selected";

        public CorrelativeSubjects()
        {
            InitializeComponent();
        }

        private void GoBackButtonColors()
        {
            this.bunifuFlatButtonAllSubjects.Normalcolor = Color.Tomato;
            this.bunifuFlatButtonAllSubjects.OnHovercolor = Color.Tomato;

            this.bunifuFlatButtonCorrelativeSubjects.Normalcolor = Color.Tomato;
            this.bunifuFlatButtonCorrelativeSubjects.OnHovercolor = Color.Tomato;

            this.bunifuFlatButtonViewRemainingSubjects.Normalcolor = Color.Tomato;
            this.bunifuFlatButtonViewRemainingSubjects.OnHovercolor = Color.Tomato;

            this.bunifuFlatButtonSubjectsToUnlock.Normalcolor = Color.Tomato;
            this.bunifuFlatButtonSubjectsToUnlock.OnHovercolor = Color.Tomato;

            this.bunifuFlatButtonSubjectInscripcion.Normalcolor = Color.Tomato;
            this.bunifuFlatButtonSubjectInscripcion.OnHovercolor = Color.Tomato;

            this.bunifuFlatButtonConfirmInscripcion.Visible = false;
        }

        private void CleanSelectedSubjectName()
        {
            SelectedSubjectname = "Not Selected";
        }

        private void AllSubjects_Click(bool design)
        {
            bunifuCustomDataGridSubjects.DataSource = null;
            try
            {
                bunifuCustomDataGridSubjects.DataSource = BusinessSubject.ListStudentSubjects(BusinessStudent.SearchStudentByUser(session.user), "All student subjects");
                bunifuCustomDataGridSubjects.Columns["Student"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["Status"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["Qualification"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["Subject"].Width = 600;

            }
            catch (Exception)
            {
                bunifuCustomDataGridSubjects.DataSource = BusinessSubject.ListSubjects();
                bunifuCustomDataGridSubjects.Columns["SubjectID"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["Year"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["Status"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["PeriodType"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["CorrespondingPeriod"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["Name"].Width = 600;
            }
            if(design)
            {
                #region Design...
                bunifuCustomLabelSubjectSelected.Text = "";
                GoBackButtonColors();
                this.bunifuFlatButtonAllSubjects.Normalcolor = Color.Coral;
                this.bunifuFlatButtonAllSubjects.OnHovercolor = Color.Coral;
                #endregion
            }

        }

        private void bunifuFlatButtonAllSubjects_Click(object sender, EventArgs e)
        {
            AllSubjects_Click(true);
        }

        private void CorrelativeSubjects_Load(object sender, EventArgs e)
        {
            bunifuCustomLabelSubjectSelected.Text = "";
            AllSubjects_Click(false);
        }

        private void bunifuCustomDataGridSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedSubjectname = this.bunifuCustomDataGridSubjects.Rows[e.RowIndex].Cells[1].Value.ToString();
            bunifuCustomLabelSubjectSelected.Text = SelectedSubjectname;

            if(this.bunifuFlatButtonSubjectInscripcion.OnHovercolor == Color.Coral)
                this.bunifuFlatButtonConfirmInscripcion.Visible = true;
        }

        private void bunifuFlatButtonCorrelativeSubjects_Click(object sender, EventArgs e)
        {
            if(SelectedSubjectname == "Not Selected")
            {
                MessageBox.Show("Por favor seleccione una materia", "Información");
                return;
            }

            bunifuCustomDataGridSubjects.DataSource = null;
            List<Subject> AuxSubjects = BusinessSubject.ListCorrelativeSubjects(BusinessSubject.ListSubjectByName(SelectedSubjectname));
            if(AuxSubjects != null)
            {
                bunifuCustomDataGridSubjects.DataSource = AuxSubjects;
                #region Design...
                bunifuCustomDataGridSubjects.Columns["SubjectID"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["Year"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["Status"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["PeriodType"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["CorrespondingPeriod"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["Name"].Width = 600;
                bunifuCustomLabelSubjectSelected.Text = "";
                GoBackButtonColors();
                this.bunifuFlatButtonCorrelativeSubjects.Normalcolor = Color.Coral;
                this.bunifuFlatButtonCorrelativeSubjects.OnHovercolor = Color.Coral;
                #endregion
            }
            else
            {
                AllSubjects_Click(true);
                MessageBox.Show("La materia seleccionada no tiene correlativas", "Información");
            }

            CleanSelectedSubjectName();

        }

        private void bunifuFlatButtonViewRemainingSubjects_Click(object sender, EventArgs e)
        {
            if (ViewRemainingSubjects())
            {
                #region Design...
                bunifuCustomDataGridSubjects.Columns["SubjectID"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["Year"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["Status"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["PeriodType"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["CorrespondingPeriod"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["Name"].Width = 600;
                bunifuCustomLabelSubjectSelected.Text = "";
                GoBackButtonColors();
                this.bunifuFlatButtonViewRemainingSubjects.Normalcolor = Color.Coral;
                this.bunifuFlatButtonViewRemainingSubjects.OnHovercolor = Color.Coral;
                #endregion
            }
            
        }

        private void bunifuFlatButtonSubjectsToUnlock_Click(object sender, EventArgs e)
        {
            if (SelectedSubjectname == "Not Selected")
            {
                MessageBox.Show("Por favor seleccione una materia", "Información");
                return;
            }

            bunifuCustomDataGridSubjects.DataSource = null;
            List<Subject> AuxSubjects = BusinessSubject.ListUnlockSubjectsBySubject(BusinessSubject.ListSubjectByName(SelectedSubjectname));
            if (AuxSubjects == null || AuxSubjects.Count == 0)
            {
                AllSubjects_Click(true);
                MessageBox.Show("La materia seleccionada no desbloquea ninguna materia", "Información");
            }
            else
            {
                bunifuCustomDataGridSubjects.DataSource = AuxSubjects;
                #region Design...
                bunifuCustomDataGridSubjects.Columns["SubjectID"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["Year"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["Status"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["PeriodType"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["CorrespondingPeriod"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["Name"].Width = 600;
                bunifuCustomLabelSubjectSelected.Text = "";
                GoBackButtonColors();
                this.bunifuFlatButtonSubjectsToUnlock.Normalcolor = Color.Coral;
                this.bunifuFlatButtonSubjectsToUnlock.OnHovercolor = Color.Coral;
                #endregion
            }

            CleanSelectedSubjectName();
        }

        private bool ViewRemainingSubjects()
        {
            bool readyToStudy = false;
            int readyToStudyCount = 0;
            bunifuCustomDataGridSubjects.DataSource = null;
            List<Subject> SubjectReadyToStudy = new List<Subject>();

            List<StudentSubject> PendingSubjects = BusinessSubject.ListStudentSubjects(BusinessStudent.SearchStudentByUser(session.user), "Only pending student subjects");
            if (PendingSubjects.Count != 0)
            {
                foreach (StudentSubject studentSubject in PendingSubjects)
                {

                    List<Subject> correlatives = BusinessSubject.ListCorrelativeSubjects(BusinessSubject.ListSubjectBySubjectID(studentSubject.Subject.SubjectID));
                    if (correlatives != null)
                    {
                        foreach (Subject correlative in correlatives)
                        {
                            if (BusinessSubject.ListCorrelativeSubjects(BusinessSubject.ListApprovedSubjectBySubjectID(BusinessStudent.SearchStudentByUser(session.user), correlative.SubjectID)).Count == 0)
                                readyToStudy = false;
                            else
                                readyToStudy = true;
                            readyToStudyCount += 1;
                        }

                        if (correlatives.Count == readyToStudyCount && readyToStudy == true)
                        {
                            SubjectReadyToStudy.Add(studentSubject.Subject);
                        }
                        readyToStudyCount = 0;
                        readyToStudy = false;
                    }
                    else
                        SubjectReadyToStudy.Add(studentSubject.Subject);
                }

                bunifuCustomDataGridSubjects.DataSource = SubjectReadyToStudy;
                return true;
            }
            else
            {
                AllSubjects_Click(true);
                MessageBox.Show("Ya no existen materias pendientes para el estudiante", "Información");
                return false;
            }
        }



        private void bunifuFlatButtonSubjectInscripcion_Click(object sender, EventArgs e)
        {
            if(ViewRemainingSubjects())
            {
                #region Design...
                bunifuCustomDataGridSubjects.Columns["SubjectID"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["Year"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["Status"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["PeriodType"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["CorrespondingPeriod"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["Name"].Width = 500;
                bunifuCustomLabelSubjectSelected.Text = "";
                GoBackButtonColors();
                this.bunifuFlatButtonSubjectInscripcion.Normalcolor = Color.Coral;
                this.bunifuFlatButtonSubjectInscripcion.OnHovercolor = Color.Coral;
                #endregion
            }

        }

        private void bunifuFlatButtonConfirmInscripcion_Click(object sender, EventArgs e)
        {
            InCourseStatus status = new InCourseStatus();
            try
            {
                foreach (DataGridViewTextBoxCell row in this.bunifuCustomDataGridSubjects.SelectedCells)
                {
                    BusinessSubject.ChangeStudentSubjectStatus(BusinessStudent.SearchStudentByUser(session.user), BusinessSubject.ListSubjectByName(row.Value.ToString()), status, null);
                }

                MessageBox.Show("Inscripción realizada correctamente", "Información");
                if (ViewRemainingSubjects())
                {
                    #region Design...
                    bunifuCustomDataGridSubjects.Columns["SubjectID"].Visible = false;
                    bunifuCustomDataGridSubjects.Columns["Year"].Visible = false;
                    bunifuCustomDataGridSubjects.Columns["Status"].Visible = false;
                    bunifuCustomDataGridSubjects.Columns["PeriodType"].Visible = false;
                    bunifuCustomDataGridSubjects.Columns["CorrespondingPeriod"].Visible = false;
                    bunifuCustomDataGridSubjects.Columns["Name"].Width = 500;
                    bunifuCustomLabelSubjectSelected.Text = "";
                    GoBackButtonColors();
                    this.bunifuFlatButtonSubjectInscripcion.Normalcolor = Color.Coral;
                    this.bunifuFlatButtonSubjectInscripcion.OnHovercolor = Color.Coral;
                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en la inscripción", "Contactese con un administrador");
                Console.WriteLine(ex.Message);
            }

            this.bunifuFlatButtonConfirmInscripcion.Visible = false;
        }
    }
}
