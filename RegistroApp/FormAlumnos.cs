using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RegistroBL;
using RegistroBOL;

namespace RegistroApp
{
    public partial class FormAlumnos : Form
    {
        public FormAlumnos()
        {
            InitializeComponent();
        }

        private void FormAlumnos_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones de campos
                if (string.IsNullOrWhiteSpace(tx_nombre.Text) ||
                    string.IsNullOrWhiteSpace(tx_apellidopat.Text) ||
                    string.IsNullOrWhiteSpace(tx_apellidomat.Text) ||
                    string.IsNullOrWhiteSpace(tx_email.Text) ||
                    string.IsNullOrWhiteSpace(tx_matricula.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación del formato del nombre
                if (!Regex.IsMatch(tx_nombre.Text, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$"))
                {
                    MessageBox.Show("El nombre solo debe contener letras y espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación de correo electrónico
                try
                {
                    var addr = new System.Net.Mail.MailAddress(tx_email.Text);
                }
                catch
                {
                    MessageBox.Show("El correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                AlumnoBOL alumnoBOL = new AlumnoBOL
                {
                    // No asignamos IDAlumno si es un nuevo registro
                    Nombre = tx_nombre.Text.Trim(),
                    ApellidoPat = tx_apellidopat.Text.Trim(),
                    ApellidoMat = tx_apellidomat.Text.Trim(),
                    Email = tx_email.Text.Trim(),
                    NumMatricula = tx_matricula.Text.Trim()
                };


                AlumnoBL alumnoBL = new AlumnoBL();
                bool resultado;


                if (string.IsNullOrWhiteSpace(tx_id.Text))
                {
                    // Crear nuevo alumno
                    resultado = alumnoBL.Guardar(alumnoBOL);
                }
                else
                {
                    // Actualizar alumno existente
                    if (int.TryParse(tx_id.Text, out int id))
                    {
                        alumnoBOL.IDAlumno = id;
                        resultado = alumnoBL.Actualizar(alumnoBOL);
                    }
                    else
                    {
                        MessageBox.Show("El ID debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                if (resultado)
                {
                    MessageBox.Show("Alumno guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarAlumnos();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarAlumnos()
        {
            AlumnoBL alumnoBL = new AlumnoBL();
            List<AlumnoBOL> listaAlumnos = alumnoBL.ObtenerAlumnos();

            if (listaAlumnos.Count > 0)
            {
                dgv_alumnos.DataSource = null; // Limpiar DataSource
                dgv_alumnos.AutoGenerateColumns = true; // Generar columnas automáticamente
                dgv_alumnos.DataSource = listaAlumnos; // Asignar lista al DataGridView
                dgv_alumnos.Columns["IDAlumno"].Visible = false; // Opcional: Ocultar columna de ID
            }
            else
            {
                MessageBox.Show("No hay alumnos para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void LimpiarCampos()
        {
            tx_id.Clear();
            tx_nombre.Clear();
            tx_apellidopat.Clear();
            tx_apellidomat.Clear();
            tx_email.Clear();
            tx_matricula.Clear();
        }

        private void dgv_alumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que el índice de fila sea válido
            if (e.RowIndex >= 0)
            {
                // Obtenemos la fila seleccionada
                DataGridViewRow row = dgv_alumnos.Rows[e.RowIndex];

                // Asignamos los valores de las celdas a los campos del formulario
                tx_id.Text = row.Cells["IDAlumno"].Value?.ToString();
                tx_nombre.Text = row.Cells["Nombre"].Value?.ToString();
                tx_apellidopat.Text = row.Cells["ApellidoPat"].Value?.ToString();
                tx_apellidomat.Text = row.Cells["ApellidoMat"].Value?.ToString();
                tx_email.Text = row.Cells["Email"].Value?.ToString();
                tx_matricula.Text = row.Cells["NumMatricula"].Value?.ToString();

                // Opcional: Cambiar el texto del botón "Guardar" a "Actualizar"
                bt_guardar.Text = "Actualizar";
            }
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(tx_id.Text, out int id))
                {
                    var confirmResult = MessageBox.Show("¿Estás seguro de eliminar este alumno?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        AlumnoBL alumnoBL = new AlumnoBL();
                        bool resultado = alumnoBL.Eliminar(id);
                        if (resultado)
                        {
                            MessageBox.Show("Alumno eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                            CargarAlumnos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un alumno válido para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
