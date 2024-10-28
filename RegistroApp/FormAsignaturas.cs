using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RegistroBL;
using RegistroBOL;

namespace RegistroApp
{
    public partial class FormAsignaturas : Form
    {
        public FormAsignaturas()
        {
            InitializeComponent();

        }

        private void FormAsignaturas_Load_1(object sender, EventArgs e)
        {
            CargarAsignaturas();
        }

        private void bt_guardarA_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones de campos
                if (string.IsNullOrWhiteSpace(tb_nombreasig.Text) ||
                    string.IsNullOrWhiteSpace(tb_creditos.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación del formato del nombre
                if (!Regex.IsMatch(tb_nombreasig.Text, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$"))
                {
                    MessageBox.Show("El nombre solo debe contener letras y espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación de créditos como número entero
                if (!int.TryParse(tb_creditos.Text.Trim(), out int creditos))
                {
                    MessageBox.Show("El campo Créditos debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                AsignaturaBOL asignaturaBOL = new AsignaturaBOL
                {
                    NomAsignatura = tb_nombreasig.Text.Trim(),
                    Creditos = creditos
                };

                AsignaturaBL asignaturaBL = new AsignaturaBL();
                bool resultado;

                if (string.IsNullOrWhiteSpace(tb_idasignatura.Text))
                {
                    // Crear nueva asignatura
                    resultado = asignaturaBL.Guardar(asignaturaBOL);
                }
                else
                {
                    // Actualizar asignatura existente
                    if (int.TryParse(tb_idasignatura.Text, out int id))
                    {
                        asignaturaBOL.CodAsignatura = id;
                        resultado = asignaturaBL.Actualizar(asignaturaBOL);
                    }
                    else
                    {
                        MessageBox.Show("El ID debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (resultado)
                {
                    MessageBox.Show("Asignatura guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarAsignaturas();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la asignatura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(tb_idasignatura.Text, out int id))
                {
                    var confirmResult = MessageBox.Show("¿Estás seguro de eliminar esta asignatura?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        AsignaturaBL asignaturaBL = new AsignaturaBL();
                        bool resultado = asignaturaBL.Eliminar(id);
                        if (resultado)
                        {
                            MessageBox.Show("Asignatura eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                            CargarAsignaturas();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la asignatura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una asignatura válida para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarAsignaturas()
        {
            try
            {
                AsignaturaBL asignaturaBL = new AsignaturaBL();
                List<AsignaturaBOL> listaAsignaturas = asignaturaBL.ObtenerAsignaturas();

                if (listaAsignaturas.Count > 0)
                {
                    dgv_asignaturas.DataSource = null; // Limpiar DataSource
                    dgv_asignaturas.AutoGenerateColumns = true;
                    dgv_asignaturas.DataSource = listaAsignaturas;
                    dgv_asignaturas.Columns["CodAsignatura"].Visible = false; // Opcional: Ocultar columna de ID
                }
                else
                {
                    MessageBox.Show("No hay asignaturas para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar las asignaturas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            tb_idasignatura.Clear();
            tb_nombreasig.Clear();
            tb_creditos.Clear();

            // Restablecer el texto del botón "Guardar"
            bt_guardarA.Text = "Guardar";
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_asignaturas_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el índice de fila sea válido
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dgv_asignaturas.Rows[e.RowIndex];

                // Asignar los valores de las celdas a los campos del formulario
                tb_idasignatura.Text = row.Cells["CodAsignatura"].Value?.ToString();
                tb_nombreasig.Text = row.Cells["NomAsignatura"].Value?.ToString();
                tb_creditos.Text = row.Cells["Creditos"].Value?.ToString();

                // Opcional: Cambiar el texto del botón "Guardar" a "Actualizar"
                bt_guardarA.Text = "Actualizar";
            }
        }
    }
}
