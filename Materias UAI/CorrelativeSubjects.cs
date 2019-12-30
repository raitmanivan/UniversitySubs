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

        }

        private void bunifuFlatButtonAllSubjects_Click(object sender, EventArgs e)
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
            #region Design...
            bunifuCustomLabelSubjectSelected.Text = "";
            GoBackButtonColors();
            this.bunifuFlatButtonAllSubjects.Normalcolor = Color.Coral;
            this.bunifuFlatButtonAllSubjects.OnHovercolor = Color.Coral;
            #endregion
        }

        private void CorrelativeSubjects_Load(object sender, EventArgs e)
        {
            bunifuCustomLabelSubjectSelected.Text = "";
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
        }

        private void bunifuCustomDataGridSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedSubjectname = this.bunifuCustomDataGridSubjects.Rows[e.RowIndex].Cells[1].Value.ToString();
            bunifuCustomLabelSubjectSelected.Text = SelectedSubjectname;
        }

        private void bunifuFlatButtonCorrelativeSubjects_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGridSubjects.DataSource = null;
            bunifuCustomDataGridSubjects.DataSource = BusinessSubject.ListCorrelativeSubjects(BusinessSubject.ListSubjectByName(SelectedSubjectname));
            bunifuCustomDataGridSubjects.Columns["SubjectID"].Visible = false;
            bunifuCustomDataGridSubjects.Columns["Year"].Visible = false;
            bunifuCustomDataGridSubjects.Columns["Status"].Visible = false;
            bunifuCustomDataGridSubjects.Columns["PeriodType"].Visible = false;
            bunifuCustomDataGridSubjects.Columns["CorrespondingPeriod"].Visible = false;
            bunifuCustomDataGridSubjects.Columns["Name"].Width = 600;
        }
    }
}
