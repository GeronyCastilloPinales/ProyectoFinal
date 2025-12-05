using Sistema_de_Calificación_de_Estudiantes.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Calificación_de_Estudiantes
{
    public partial class FrmMateria : Form
    {
        private SistemaCalificacionEntities _context;

        private void Materia_Load(object sender, EventArgs e)
        {
            _context = new SistemaCalificacionEntities();
            this.cargarDatos();
        }

        private void cargarDatos()
        {
            var listaMateria = _context.Materia
                   .Select(p => new {
                       MateriaID = p.MateriaID,
                       NombreMateria = p.NombreMateria,
                   }).ToList();

            dgMateria.DataSource = listaMateria;
        }
        public FrmMateria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            if (string.IsNullOrEmpty(txtMateriaID.Text))
            {
                MessageBox.Show("El ID está incorrecto o vacio.");
                return;
            }
            if (string.IsNullOrEmpty(txtNombreMateria.Text))
            {
                MessageBox.Show("El Nombre está incorrecto o vacio.");
                return;
            }

            int id = Convert.ToInt32(txtMateriaID.Text);

            bool existe = _context.Materia.Any(c => c.MateriaID == id);

            if (existe)
            {
                MessageBox.Show("El ID de materia ya existe. Ingrese uno diferente.");
                return;
            }

            Materia materia = new Materia()
            {
                MateriaID = Convert.ToInt32(txtMateriaID.Text),
                NombreMateria = txtNombreMateria.Text,
            };

            _context.Materia.Add(materia);

            int rowsAffected = _context.SaveChanges();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Se ha insertado la materia en la base de datos.");
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

            int MateriaID = Convert.ToInt32(txtID.Text);

            Materia
                materia = _context.Materia.FirstOrDefault(q => q.MateriaID.Equals(MateriaID));
            if (materia == null)
            {
                MessageBox.Show("Materia no existe.");
                return;
            }
            try
            {
                _context.Materia.Remove(materia);
                int rowsAffected = _context.SaveChanges();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Se ha eliminado la materia en la base de datos.");
                }
            }

            catch (DbUpdateException ex)
            {
                MessageBox.Show("No se puede eliminar: esta materia está siendo usada en otra tabla.",
                                "Error de restricción",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }

            this.cargarDatos();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ActualizarMateriaID.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            if (string.IsNullOrEmpty(ActualizarNombreMateria.Text))
            {
                MessageBox.Show("El nombre de la materia está incorrecto o vacio.");
                return;
            }

            int MateriaID = Convert.ToInt32(ActualizarMateriaID.Text);

            Materia materia = _context.Materia.FirstOrDefault(q => q.MateriaID.Equals(MateriaID));
            if (materia == null)
            {
                MessageBox.Show("Materia no existe.");
                return;
            }

            materia.MateriaID = Convert.ToInt32(ActualizarMateriaID.Text);
            materia.NombreMateria = ActualizarNombreMateria.Text;
            

            int rowsAffected = _context.SaveChanges();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Se ha actualizado una materia en la base de datos.");
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
                        
                        for (int i = 0; i < dgMateria.Columns.Count; i++)
                        {
                            sw.Write(dgMateria.Columns[i].HeaderText);

                            if (i < dgMateria.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();

                        foreach (DataGridViewRow row in dgMateria.Rows)
                        {
                            if (!row.IsNewRow) 
                            {
                                for (int i = 0; i < dgMateria.Columns.Count; i++)
                                {
                                    sw.Write(row.Cells[i].Value?.ToString());

                                    if (i < dgMateria.Columns.Count - 1)
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
