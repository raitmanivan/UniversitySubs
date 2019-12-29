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
using Services.Session;

namespace Materias_UAI
{
    public partial class Subjects : Form
    {
        Session session = Session.getInstance();
        BLLStudent BusinessStudent = new BLLStudent();
        BLLSubject BusinessSubject = new BLLSubject();

        public Subjects()
        {
            InitializeComponent();
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            bunifuCustomDataGridSubjects.DataSource = null;
            try
            {
                bunifuCustomDataGridSubjects.DataSource = BusinessSubject.ListStudentSubjects(BusinessStudent.SearchStudentByUser(session.user), "All student subjects");
                bunifuCustomDataGridSubjects.Columns["Student"].Visible = false;
                bunifuCustomDataGridSubjects.Columns["Subject"].Width = 300;
            }
            catch (Exception)
            {
                bunifuCustomDataGridSubjects.DataSource = BusinessSubject.ListSubjects();
            }
        }

        private void GoBackButtonColors()
        {
            this.bunifuFlatButtonAllSubjects.Normalcolor = Color.Tomato;
            this.bunifuFlatButtonAllSubjects.OnHovercolor = Color.Tomato;

            this.bunifuFlatButtonApprovedSubjects.Normalcolor = Color.Tomato;
            this.bunifuFlatButtonApprovedSubjects.OnHovercolor = Color.Tomato;

            this.bunifuFlatButtonSubjectsInProgress.Normalcolor = Color.Tomato;
            this.bunifuFlatButtonSubjectsInProgress.OnHovercolor = Color.Tomato;

            this.bunifuFlatButtonSubjectsPendingExam.Normalcolor = Color.Tomato;
            this.bunifuFlatButtonSubjectsPendingExam.OnHovercolor = Color.Tomato;

            this.bunifuDropdownSubjectYearPendings.NomalColor = Color.Tomato;
            this.bunifuDropdownSubjectYearPendings.onHoverColor = Color.Tomato;
        }

        private void bunifuFlatButtonAllSubjects_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGridSubjects.DataSource = BusinessSubject.ListStudentSubjects(BusinessStudent.SearchStudentByUser(session.user),"All student subjects");

            #region Design...
            bunifuCustomDataGridSubjects.Columns["Student"].Visible = false;
            bunifuCustomDataGridSubjects.Columns["Status"].Visible = true;
            bunifuCustomDataGridSubjects.Columns["Qualification"].Visible = true;
            bunifuCustomDataGridSubjects.Columns["Subject"].Width = 300;
            GoBackButtonColors();
            this.bunifuFlatButtonAllSubjects.Normalcolor = Color.Coral;
            this.bunifuFlatButtonAllSubjects.OnHovercolor = Color.Coral;
            #endregion
        }

        private void bunifuFlatButtonApprovedSubjects_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGridSubjects.DataSource = null;
            bunifuCustomDataGridSubjects.DataSource = BusinessSubject.ListStudentSubjects(BusinessStudent.SearchStudentByUser(session.user),"Only approved student subjects");

            #region Design...
            bunifuCustomDataGridSubjects.Columns["Student"].Visible = false;
            bunifuCustomDataGridSubjects.Columns["Status"].Visible = false;
            bunifuCustomDataGridSubjects.Columns["Qualification"].Visible = true;
            bunifuCustomDataGridSubjects.Columns["Subject"].Width = 300;
            GoBackButtonColors();
            this.bunifuFlatButtonApprovedSubjects.Normalcolor = Color.Coral;
            this.bunifuFlatButtonApprovedSubjects.OnHovercolor = Color.Coral;
            #endregion
        }

        private void bunifuFlatButtonSubjectsPendingExam_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGridSubjects.DataSource = null;
            bunifuCustomDataGridSubjects.DataSource = BusinessSubject.ListStudentSubjects(BusinessStudent.SearchStudentByUser(session.user),"Only pending exam student subjects");
            
            #region Design...
            bunifuCustomDataGridSubjects.Columns["Student"].Visible = false;
            bunifuCustomDataGridSubjects.Columns["Status"].Visible = false;
            bunifuCustomDataGridSubjects.Columns["Qualification"].Visible = false;
            bunifuCustomDataGridSubjects.Columns["Subject"].Width = 616;
            GoBackButtonColors();
            this.bunifuFlatButtonSubjectsPendingExam.Normalcolor = Color.Coral;
            this.bunifuFlatButtonSubjectsPendingExam.OnHovercolor = Color.Coral;
            #endregion
        }

        private void bunifuFlatButtonSubjectsInProgress_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGridSubjects.DataSource = null;
            bunifuCustomDataGridSubjects.DataSource = BusinessSubject.ListStudentSubjects(BusinessStudent.SearchStudentByUser(session.user), "Only pending student subjects");

            #region Design...
            bunifuCustomDataGridSubjects.Columns["Student"].Visible = false;
            bunifuCustomDataGridSubjects.Columns["Status"].Visible = false;
            bunifuCustomDataGridSubjects.Columns["Qualification"].Visible = false;
            bunifuCustomDataGridSubjects.Columns["Subject"].Width = 616;
            GoBackButtonColors();
            this.bunifuFlatButtonSubjectsInProgress.Normalcolor = Color.Coral;
            this.bunifuFlatButtonSubjectsInProgress.OnHovercolor = Color.Coral;
            #endregion
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            if(this.bunifuDropdownSubjectYearPendings.selectedValue == "Pendientes 1 año")
            {
                bunifuCustomDataGridSubjects.DataSource = null;
                bunifuCustomDataGridSubjects.DataSource = BusinessSubject.ListPendingStudentSubjectsByYear(BusinessStudent.SearchStudentByUser(session.user),"1");
            }

            else if (this.bunifuDropdownSubjectYearPendings.selectedValue == "Pendientes 2 año")
            {
                bunifuCustomDataGridSubjects.DataSource = null;
                bunifuCustomDataGridSubjects.DataSource = BusinessSubject.ListPendingStudentSubjectsByYear(BusinessStudent.SearchStudentByUser(session.user), "2");
            }

            else if (this.bunifuDropdownSubjectYearPendings.selectedValue == "Pendientes 3 año")
            {
                bunifuCustomDataGridSubjects.DataSource = null;
                bunifuCustomDataGridSubjects.DataSource = BusinessSubject.ListPendingStudentSubjectsByYear(BusinessStudent.SearchStudentByUser(session.user), "3");
            }

            else if (this.bunifuDropdownSubjectYearPendings.selectedValue == "Pendientes 4 año")
            {
                bunifuCustomDataGridSubjects.DataSource = null;
                bunifuCustomDataGridSubjects.DataSource = BusinessSubject.ListPendingStudentSubjectsByYear(BusinessStudent.SearchStudentByUser(session.user), "4");
            }

            else if (this.bunifuDropdownSubjectYearPendings.selectedValue == "Pendientes 5 año")
            {
                bunifuCustomDataGridSubjects.DataSource = null;
                bunifuCustomDataGridSubjects.DataSource = BusinessSubject.ListPendingStudentSubjectsByYear(BusinessStudent.SearchStudentByUser(session.user), "5");
            }

            else if (this.bunifuDropdownSubjectYearPendings.selectedValue == "Pendientes Analista")
            {
                bunifuCustomDataGridSubjects.DataSource = null;
                List<int> subjectsId = new List<int>();
                for (int i = 1; i < 31; i++)
                    subjectsId.Add(i);
                bunifuCustomDataGridSubjects.DataSource = listPendingSubjectsForGraduation(subjectsId);
            }

            else if (this.bunifuDropdownSubjectYearPendings.selectedValue == "Pendientes Ingeniero")
            {
                bunifuCustomDataGridSubjects.DataSource = null;
                List<int> subjectsId = new List<int>();
                for (int i = 1; i < 51; i++)
                    subjectsId.Add(i);
                bunifuCustomDataGridSubjects.DataSource = listPendingSubjectsForGraduation(subjectsId);
            }
            
            #region Design...
            GoBackButtonColors();
            this.bunifuDropdownSubjectYearPendings.NomalColor = Color.Coral;
            this.bunifuDropdownSubjectYearPendings.onHoverColor = Color.Coral;
            bunifuCustomDataGridSubjects.Columns["Student"].Visible = false;
            bunifuCustomDataGridSubjects.Columns["Status"].Visible = false;
            bunifuCustomDataGridSubjects.Columns["Qualification"].Visible = false;
            bunifuCustomDataGridSubjects.Columns["Subject"].Width = 616;
            #endregion

        }

        private List<StudentSubject> listPendingSubjectsForGraduation(List<int> subjectsId)
        {
            List<StudentSubject> auxSubjects = BusinessSubject.ListStudentSubjects(BusinessStudent.SearchStudentByUser(session.user), "Only pending and pending exam student subjects");
            List<StudentSubject> finalSubjects = new List<StudentSubject>();

            foreach (StudentSubject subject in auxSubjects)
            {
                foreach (int item in subjectsId)
                {
                    if (subject.Subject.SubjectID == item)
                    {
                        finalSubjects.Add(subject);
                        break;
                    }
                }
            }
            return finalSubjects;
        }
    }
}
