using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlumnos formAlumnos = new FormAlumnos();
            formAlumnos.Show();
        }

        private void asignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAsignaturas formAsignaturas = new FormAsignaturas();
            formAsignaturas.Show();
        }
    }
}
