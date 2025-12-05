using Sistema_de_Calificación_de_Estudiantes.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Calificación_de_Estudiantes
{
    public partial class FrmCalificación : Form
    {
        private SistemaCalificacionEntities _context;

        private void Calificacion_Load(object sender, EventArgs e)
        {
            _context = new SistemaCalificacionEntities();
            this.cargarDatos();
        }


        public FrmCalificación()
        {
            InitializeComponent();
        }

        private void cargarDatos()
        {
            var listaCalificacion = _context.Calificacion
                   .Select(p => new
                   {
                       CalificacionID = p.CalificacionID,
                       EstudianteID = p.EstudianteID,
                       MateriaID = p.MateriaID,
                       Periodo1 = p.Periodo1,
                       Periodo2 = p.Periodo2,
                       Periodo3 = p.Periodo3,
                       Periodo4 = p.Periodo4,
                       Examen = p.Examen,
                       TotalCalificacion = p.TotalCalificacion,
                       Clasificacion = p.Clasificacion,
                       Estado = p.Estado,
                       FechaRegistro = p.FechaRegistro,
                   }).ToList();

            dgCalificacion.DataSource = listaCalificacion;
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
        private void Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCalificacionID.Text))
            {
                MessageBox.Show("El ID está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(txtEstudianteID.Text))
            {
                MessageBox.Show("El ID está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(txtMateriaID.Text))
            {
                MessageBox.Show("El ID está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(txtPeriodo1.Text))
            {
                MessageBox.Show("El Periodo está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(txtPeriodo2.Text))
            {
                MessageBox.Show("El Periodo está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(txtPeriodo3.Text))
            {
                MessageBox.Show("El Periodo está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(txtPeriodo4.Text))
            {
                MessageBox.Show("El Periodo está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(txtExamen.Text))
            {
                MessageBox.Show("El Examen está incorrecto o vacio.");
                return;
            }
            //
            int id = Convert.ToInt32(txtCalificacionID.Text);

            bool existe = _context.Calificacion.Any(c => c.CalificacionID == id);

            if (existe)
            {
                MessageBox.Show("El ID de calificación ya existe. Ingrese uno diferente.");
                return;
            }
            //
            if (!int.TryParse(txtPeriodo1.Text.Trim(), out int p1) ||
            !int.TryParse(txtPeriodo2.Text.Trim(), out int p2) ||
            !int.TryParse(txtPeriodo3.Text.Trim(), out int p3) ||
            !int.TryParse(txtPeriodo4.Text.Trim(), out int p4) ||
            !int.TryParse(txtExamen.Text.Trim(), out int examen))
            {
                MessageBox.Show("Periodos y Examen deben ser números enteros válidos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (p1 < 0 || p1 > 100 || p2 < 0 || p2 > 100 || p3 < 0 || p3 > 100 || p4 < 0 || p4 > 100 || examen < 0 || examen > 100)
            {
                MessageBox.Show("Las notas deben estar entre 0 y 100.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // 
            int estudianteId = Convert.ToInt32(txtEstudianteID.Text.Trim());
            int materiaId = Convert.ToInt32(txtMateriaID.Text.Trim());

            if (!_context.Estudiante.Any(a => a.EstudianteID == estudianteId))
            {
                MessageBox.Show($"No existe un Estudiante con ID = {estudianteId}.", "FK inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_context.Materia.Any(m => m.MateriaID == materiaId))
            {
                MessageBox.Show($"No existe una Materia con ID = {materiaId}.", "FK inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Calificacion calificacion = new Calificacion()
            {
                CalificacionID = Convert.ToInt32(txtCalificacionID.Text),
                EstudianteID = Convert.ToInt32(txtEstudianteID.Text),
                MateriaID = Convert.ToInt32(txtMateriaID.Text),
                Periodo1 = Convert.ToInt32(txtPeriodo1.Text),
                Periodo2 = Convert.ToInt32(txtPeriodo2.Text),
                Periodo3 = Convert.ToInt32(txtPeriodo3.Text),
                Periodo4 = Convert.ToInt32(txtPeriodo4.Text),
                Examen = Convert.ToInt32(txtExamen.Text),
                FechaRegistro = DateTime.Now
            };

            _context.Calificacion.Add(calificacion);

            int rowsAffected = _context.SaveChanges();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Se ha insertado una calificacion en la base de datos.");
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

            int CalificacionID = Convert.ToInt32(txtID.Text);

            Calificacion
                calificacion = _context.Calificacion.FirstOrDefault(q => q.CalificacionID.Equals(CalificacionID));
            if (calificacion == null)
            {
                MessageBox.Show("Calificacion no existe.");
                return;
            }

            _context.Calificacion.Remove(calificacion);
            int rowsAffected = _context.SaveChanges();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Se ha eliminado la calificacion en la base de datos.");
            }

            this.cargarDatos();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ActualizarCalificacionID.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            if (string.IsNullOrEmpty(ActualizarEstudianteID.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            if (string.IsNullOrEmpty(ActualizarMateriaID.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            if (string.IsNullOrEmpty(ActualizarPeriodo1.Text))
            {
                MessageBox.Show("El Periodo está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(ActualizarPeriodo2.Text))
            {
                MessageBox.Show("El Periodo está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(ActualizarPeriodo3.Text))
            {
                MessageBox.Show("El Periodo está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(ActualizarPeriodo4.Text))
            {
                MessageBox.Show("El Periodo está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(ActualizarExamen.Text))
            {
                MessageBox.Show("El examen está incorrecto o vacio.");
                return;
            }

            int CalificacionID = Convert.ToInt32(ActualizarCalificacionID.Text);

            Calificacion calificacion = _context.Calificacion.FirstOrDefault(q => q.CalificacionID.Equals(CalificacionID));
            if (calificacion == null)
            {
                MessageBox.Show("calificacion no existe.");
                return;
            }

            calificacion.CalificacionID = Convert.ToInt32(ActualizarCalificacionID.Text);
            calificacion.EstudianteID = Convert.ToInt32(ActualizarEstudianteID.Text);
            calificacion.MateriaID = Convert.ToInt32(ActualizarMateriaID.Text);
            calificacion.Periodo1 = Convert.ToInt32(ActualizarPeriodo1.Text);
            calificacion.Periodo2 = Convert.ToInt32(ActualizarPeriodo2.Text);
            calificacion.Periodo3 = Convert.ToInt32(ActualizarPeriodo3.Text);
            calificacion.Periodo4 = Convert.ToInt32(ActualizarPeriodo4.Text);
            calificacion.Examen = Convert.ToInt32(ActualizarExamen.Text);

            int rowsAffected = _context.SaveChanges();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Se ha actualizado una Calificacion en la base de datos.");
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

                        for (int i = 0; i < dgCalificacion.Columns.Count; i++)
                        {
                            sw.Write(dgCalificacion.Columns[i].HeaderText);

                            if (i < dgCalificacion.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();

                        foreach (DataGridViewRow row in dgCalificacion.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                for (int i = 0; i < dgCalificacion.Columns.Count; i++)
                                {
                                    sw.Write(row.Cells[i].Value?.ToString());

                                    if (i < dgCalificacion.Columns.Count - 1)
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