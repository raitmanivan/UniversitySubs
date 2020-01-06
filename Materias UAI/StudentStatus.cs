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

namespace Materias_UAI
{
    public partial class StudentStatus : Form
    {
        BLLStudent BusinessStudent = new BLLStudent();
        BLLSubject BusinessSubject = new BLLSubject();
        Session session = Session.getInstance();


        public StudentStatus()
        {
            InitializeComponent();
        }

        private void bunifuFlatButtonInscriptionHistory_Click(object sender, EventArgs e)
        {
            this.bunifuCustomDataGridSubjects.DataSource = null;
            this.bunifuCustomDataGridSubjects.DataSource = BusinessSubject.ListStudentInscriptionHistory(BusinessStudent.SearchStudentByUser(session.user));
            bunifuCustomDataGridSubjects.Columns["InscriptionID"].Visible = false;
            bunifuCustomDataGridSubjects.Columns["Student"].Visible = false;

        }
    }
}
