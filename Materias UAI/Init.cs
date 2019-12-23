using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Materias_UAI
{
    public partial class Init : Form
    {
        public Init()
        {
            InitializeComponent();
        }

        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSession session_form = new FormSession();
            session_form.MdiParent = this;
            session_form.Show();
        }
    }
}
