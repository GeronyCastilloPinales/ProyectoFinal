using Sistema_de_Calificación_de_Estudiantes.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Calificación_de_Estudiantes
{
    public partial class FrmEstudiante : Form
    {


        private SistemaCalificacionEntities _context;

        private void Estudiante_Load(object sender, EventArgs e)
        {
            _context = new SistemaCalificacionEntities();
            this.cargarDatos();
        }
        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void cargarDatos()
        {
            var listaEstudiante = _context.Estudiante
                   .Select(p => new
                   {
                       EstudianteID = p.EstudianteID,
                       Nombre = p.Nombre,
                       Apellido = p.Apellido,
                       Curso = p.Curso
                   }).ToList();

            dgEstudiante.DataSource = listaEstudiante;
        }
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                return;

            if (e.KeyChar == ' ')
                return;

            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true; 
                MessageBox.Show("Solo se permiten letras.");
            }
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEstudianteID.Text))
            {
                MessageBox.Show("El ID está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El Nombre está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("El Apellido está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(txtCurso.Text))
            {
                MessageBox.Show("El Curso está incorrecto o vacio.");
                return;
            }

            int id = Convert.ToInt32(txtEstudianteID.Text);

            bool existe = _context.Estudiante.Any(c => c.EstudianteID == id);

            if (existe)
            {
                MessageBox.Show("El ID de estudiante ya existe. Ingrese uno diferente.");
                return;
            }

            Estudiante estudiante = new Estudiante()
            {
                EstudianteID = Convert.ToInt32(txtEstudianteID.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Curso = txtCurso.Text,
            };

            _context.Estudiante.Add(estudiante);

            int rowsAffected = _context.SaveChanges();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Se ha insertado un Estudiante en la base de datos.");
            }

            this.cargarDatos();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            int EstudianteID = Convert.ToInt32(txtID.Text);

            Estudiante
                estudiante = _context.Estudiante.FirstOrDefault(q => q.EstudianteID.Equals(EstudianteID));
            if (estudiante == null)
            {
                MessageBox.Show("Estudiante no existe.");
                return;
            }

            _context.Estudiante.Remove(estudiante);
            int rowsAffected = _context.SaveChanges();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Se ha eliminado el estudiante en la base de datos.");
            }

            this.cargarDatos();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ActualizarEstudianteID.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            if (string.IsNullOrEmpty(ActualizarNombre.Text))
            {
                MessageBox.Show("El nombre de estudiante está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(ActualizarApellido.Text))
            {
                MessageBox.Show("El Apellido de estudiante está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(ActualizarCurso.Text))
            {
                MessageBox.Show("El curso de estudiante está incorrecto o vacio.");
                return;
            }

            int EstudianteID = Convert.ToInt32(ActualizarEstudianteID.Text);

            Estudiante estudiante = _context.Estudiante.FirstOrDefault(q => q.EstudianteID.Equals(EstudianteID));
            if (estudiante == null)
            {
                MessageBox.Show("estudiante no existe.");
                return;
            }

            estudiante.EstudianteID = Convert.ToInt32(ActualizarEstudianteID.Text);
            estudiante.Nombre = ActualizarNombre.Text;
            estudiante.Apellido = ActualizarApellido.Text;
            estudiante.Curso = ActualizarCurso.Text;

            int rowsAffected = _context.SaveChanges();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Se ha actualizado un Estudiante en la base de datos.");
            }

            this.cargarDatos();
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            this.cargarDatos();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "CSV (*.csv)|*.csv";
            save.FileName = "Exportacion.csv";

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(save.FileName, false, Encoding.UTF8))
                    {

                        for (int i = 0; i < dgEstudiante.Columns.Count; i++)
                        {
                            sw.Write(dgEstudiante.Columns[i].HeaderText);

                            if (i < dgEstudiante.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();

                        foreach (DataGridViewRow row in dgEstudiante.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                for (int i = 0; i < dgEstudiante.Columns.Count; i++)
                                {
                                    sw.Write(row.Cells[i].Value?.ToString());

                                    if (i < dgEstudiante.Columns.Count - 1)
                                        sw.Write(",");
                                }
                                sw.WriteLine();
                            }
                        }
                    }

                    MessageBox.Show("Exportado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar: " + ex.Message);
                }
            }
        }
    }

}
