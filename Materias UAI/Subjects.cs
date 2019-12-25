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

namespace Materias_UAI
{
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            BLLSubject BusinessSubject = new BLLSubject();
            bunifuCustomDataGridSubjects.DataSource = null;
            Student ivan = new Student();
            ivan.StudentID = "B00015192-T1";
            ivan.NameAndSurname = "Ivan Raitman";
            bunifuCustomDataGridSubjects.DataSource = BusinessSubject.ListStudentSubjects(ivan);
        }
    }
}
