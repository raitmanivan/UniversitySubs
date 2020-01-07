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
using Services.Session;
using EE;
using EE.States;

namespace Materias_UAI
{
    public partial class StudentStatus : Form
    {
        BLLStudent BusinessStudent = new BLLStudent();
        BLLSubject BusinessSubject = new BLLSubject();
        Session session = Session.getInstance();
        string SelectedSubjectname = "Not Selected";

        public StudentStatus()
        {
            InitializeComponent();
        }

        private void bunifuFlatButtonInscriptionHistory_Click(object sender, EventArgs e)
        {
            this.bunifuCustomDataGridSubjects.DataSource = null;
            ConfirmedStatus status = new ConfirmedStatus();
            this.bunifuCustomDataGridSubjects.DataSource = BusinessSubject.ListStudentInscriptionHistory(BusinessStudent.SearchStudentByUser(session.user), status);
            bunifuCustomDataGridSubjects.Columns["Student"].Visible = false;
            bunifuCustomLabelSubjectSelected.Text = "";

            GoBackButtonColors();
            this.bunifuFlatButtonInscriptionHistory.Normalcolor = Color.Coral;
            this.bunifuFlatButtonInscriptionHistory.OnHovercolor = Color.Coral;
            this.bunifuiOSSwitchMoreDetails.Visible = true;
            this.bunifuCustomLabelMoreDetails.Visible = true;
            this.bunifuiOSSwitchMoreDetails.Value = false;

        }

        private void GoBackButtonColors()
        {

            this.bunifuFlatButtonSubjectInscripcion.Normalcolor = Color.Tomato;
            this.bunifuFlatButtonSubjectInscripcion.OnHovercolor = Color.Tomato;

            this.bunifuFlatButtonCancelSubjectInscription.Normalcolor = Color.Tomato;
            this.bunifuFlatButtonCancelSubjectInscription.OnHovercolor = Color.Tomato;

            this.bunifuFlatButtonInscriptionHistory.Normalcolor = Color.Tomato;
            this.bunifuFlatButtonInscriptionHistory.OnHovercolor = Color.Tomato;

            this.bunifuFlatButtonConfirmInscripcion.Visible = false;
            this.bunifuiOSSwitchMoreDetails.Visible = false;
            this.bunifuCustomLabelMoreDetails.Visible = false;
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
            if (design)
            {
                #region Design...
                bunifuCustomLabelSubjectSelected.Text = "";
                GoBackButtonColors();
                #endregion
            }

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

        private void bunifuCustomDataGridSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.bunifuFlatButtonSubjectInscripcion.OnHovercolor == Color.Coral)
            {
                SelectedSubjectname = this.bunifuCustomDataGridSubjects.Rows[e.RowIndex].Cells[1].Value.ToString();
                bunifuCustomLabelSubjectSelected.Text = SelectedSubjectname;
                this.bunifuFlatButtonConfirmInscripcion.Visible = true;
            }
            else if (this.bunifuFlatButtonInscriptionHistory.OnHovercolor == Color.Coral)
            {
                SelectedSubjectname = this.bunifuCustomDataGridSubjects.Rows[e.RowIndex].Cells[2].Value.ToString();
            }

        }

        private void bunifuFlatButtonCancelSubjectInscription_Click(object sender, EventArgs e)
        {
            CancelledStatus InscriptionStatus = new CancelledStatus();
            PendingStatus SubjectStatus = new PendingStatus();

            try
            {
                DataGridViewSelectedRowCollection selected = this.bunifuCustomDataGridSubjects.SelectedRows;
                if (selected.Count == 0)
                {
                    MessageBox.Show("Seleccione las materias deseadas", "Información");
                    return;
                }
                foreach (DataGridViewRow row in selected)
                {
                    Inscription inscription = new Inscription(Convert.ToInt32(row.Cells[0].Value), BusinessStudent.SearchStudentByUser(session.user), BusinessSubject.ListSubjectByName(row.Cells[2].Value.ToString()), InscriptionStatus);
                    BusinessSubject.CancelStudentInscription(inscription);
                    BusinessSubject.ChangeStudentSubjectStatus(BusinessStudent.SearchStudentByUser(session.user), BusinessSubject.ListSubjectByName(row.Cells[2].Value.ToString()), SubjectStatus, null);
                }

                MessageBox.Show("Inscripción cancelada correctamente", "Información");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al cancelar la inscripción", "Contactese con un administrador");
                Console.WriteLine(ex.Message);
            }


            ConfirmedStatus status = new ConfirmedStatus();
            this.bunifuCustomDataGridSubjects.DataSource = null;
            this.bunifuCustomDataGridSubjects.DataSource = BusinessSubject.ListStudentInscriptionHistory(BusinessStudent.SearchStudentByUser(session.user), status);
            bunifuCustomDataGridSubjects.Columns["Student"].Visible = false;

            GoBackButtonColors();
            this.bunifuFlatButtonCancelSubjectInscription.Normalcolor = Color.Coral;
            this.bunifuFlatButtonCancelSubjectInscription.OnHovercolor = Color.Coral;

            bunifuCustomLabelSubjectSelected.Text = "";
        }

        private void StudentStatus_Load(object sender, EventArgs e)
        {
            bunifuCustomLabelSubjectSelected.Text = "";
            this.bunifuiOSSwitchMoreDetails.Visible = false;
            this.bunifuCustomLabelMoreDetails.Visible = false;
            AllSubjects_Click(false);
        }

        private int CalculateCorrespondingPeriod(int month)
        {
            if (month >= 3 && month <= 7)
                return 1;
            else
                return 2;
        }

        private void bunifuFlatButtonConfirmInscripcion_Click(object sender, EventArgs e)
        {
            InCourseStatus status = new InCourseStatus();
            try
            {
                DateTime date = DateTime.Today;
                ConfirmedStatus InscriptionStatus = new ConfirmedStatus();
                foreach (DataGridViewTextBoxCell row in this.bunifuCustomDataGridSubjects.SelectedCells)
                {
                    Inscription StudentInscription = new Inscription(BusinessStudent.SearchStudentByUser(session.user), BusinessSubject.ListSubjectByName(row.Value.ToString()), date, date.Year, CalculateCorrespondingPeriod(date.Month), InscriptionStatus);
                    BusinessSubject.NewStudentInscription(StudentInscription);
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

        private void bunifuiOSSwitchMoreDetails_OnValueChange(object sender, EventArgs e)
        {
            if (this.bunifuiOSSwitchMoreDetails.Value)
            {
                CancelledStatus status = new CancelledStatus();
                this.bunifuCustomDataGridSubjects.DataSource = null;
                this.bunifuCustomDataGridSubjects.DataSource = BusinessSubject.ListStudentInscriptionHistory(BusinessStudent.SearchStudentByUser(session.user), status);
                bunifuCustomDataGridSubjects.Columns["Student"].Visible = false;
            }
            else
            {
                ConfirmedStatus status = new ConfirmedStatus();
                this.bunifuCustomDataGridSubjects.DataSource = null;
                this.bunifuCustomDataGridSubjects.DataSource = BusinessSubject.ListStudentInscriptionHistory(BusinessStudent.SearchStudentByUser(session.user), status);
                bunifuCustomDataGridSubjects.Columns["Student"].Visible = false;
            }
        }
    }
}
