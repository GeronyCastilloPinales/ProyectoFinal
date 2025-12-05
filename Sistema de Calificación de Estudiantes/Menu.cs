using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Calificación_de_Estudiantes
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEstudiante f2 = new FrmEstudiante();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMateria f3 = new FrmMateria();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCalificación f4 = new FrmCalificación();
            f4.Show();
        }
    }
}
