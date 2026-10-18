
using System;
using System.Windows.Forms;

namespace VillaClub3
{
    public partial class FrmResidentes : Form
    {
        public FrmResidentes()
        {
            InitializeComponent();
        }

        

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtDnix.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtManzana.Clear();
            txtLote.Clear();
            txtTelefono.Clear();

            cboTipoResidente.SelectedIndex = -1;
            cboEstadoPago.SelectedIndex = -1;

            dgvResidentes.ClearSelection();
        }


        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            string dni = txtDnix.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string manzana = txtManzana.Text.Trim();
            string lote = txtLote.Text.Trim();
            string telefono = txtTelefono.Text.Trim();

            if (codigo == "" || dni == "" || nombres == "" ||
                apellidos == "" || manzana == "" || lote == "" ||
                telefono == "")
            {
                MessageBox.Show(
                    "Completa todos los campos del residente.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cboTipoResidente.SelectedIndex == -1 ||
                cboEstadoPago.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Selecciona el tipo de residente y el estado de pago.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Evitar códigos y DNI duplicados
            foreach (DataGridViewRow fila in dgvResidentes.Rows)
            {
                if (fila.IsNewRow)
                    continue;

                string codigoExistente =
                    Convert.ToString(fila.Cells[0].Value);

                string dniExistente =
                    Convert.ToString(fila.Cells[1].Value);

                if (string.Equals(codigoExistente, codigo,
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("El código ya está registrado.");
                    return;
                }

                if (dniExistente == dni)
                {
                    MessageBox.Show("El DNI ya está registrado.");
                    return;
                }
            }

            dgvResidentes.Rows.Add(
                codigo,
                dni,
                nombres,
                apellidos,
                manzana,
                lote,
                telefono,
                cboTipoResidente.Text,
                cboEstadoPago.Text
            );

            MessageBox.Show(
                "Residente registrado correctamente.",
                "Registro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LimpiarCampos();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            string dni = txtDnix.Text.Trim();

            if (codigo == "" && dni == "")
            {
                MessageBox.Show(
                    "Ingresa el código o el DNI que deseas buscar.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow filaEncontrada = null;

            foreach (DataGridViewRow fila in dgvResidentes.Rows)
            {
                if (fila.IsNewRow)
                    continue;

                string codigoFila =
                    Convert.ToString(fila.Cells[0].Value);

                string dniFila =
                    Convert.ToString(fila.Cells[1].Value);

                bool coincideCodigo =
                    codigo != "" &&
                    string.Equals(codigoFila, codigo,
                        StringComparison.OrdinalIgnoreCase);

                bool coincideDni =
                    dni != "" && dniFila == dni;

                if (coincideCodigo || coincideDni)
                {
                    filaEncontrada = fila;
                    break;
                }
            }

            if (filaEncontrada == null)
            {
                MessageBox.Show(
                    "No se encontró ningún residente con esos datos.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            // Mostrar los datos encontrados
            txtCodigo.Text =
                Convert.ToString(filaEncontrada.Cells[0].Value);

            txtDnix.Text =
                Convert.ToString(filaEncontrada.Cells[1].Value);

            txtNombres.Text =
                Convert.ToString(filaEncontrada.Cells[2].Value);

            txtApellidos.Text =
                Convert.ToString(filaEncontrada.Cells[3].Value);

            txtManzana.Text =
                Convert.ToString(filaEncontrada.Cells[4].Value);

            txtLote.Text =
                Convert.ToString(filaEncontrada.Cells[5].Value);

            txtTelefono.Text =
                Convert.ToString(filaEncontrada.Cells[6].Value);

            cboTipoResidente.SelectedItem =
                Convert.ToString(filaEncontrada.Cells[7].Value);

            cboEstadoPago.SelectedItem =
                Convert.ToString(filaEncontrada.Cells[8].Value);

            dgvResidentes.ClearSelection();
            filaEncontrada.Selected = true;
            dgvResidentes.CurrentCell = filaEncontrada.Cells[0];
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = null;

            // Priorizar la fila seleccionada o encontrada
            if (dgvResidentes.SelectedRows.Count > 0)
            {
                filaSeleccionada = dgvResidentes.SelectedRows[0];
            }
            else
            {
                string codigo = txtCodigo.Text.Trim();
                string dni = txtDnix.Text.Trim();

                foreach (DataGridViewRow fila in dgvResidentes.Rows)
                {
                    if (fila.IsNewRow)
                        continue;

                    string codigoFila =
                        Convert.ToString(fila.Cells[0].Value);

                    string dniFila =
                        Convert.ToString(fila.Cells[1].Value);

                    if ((codigo != "" &&
                         string.Equals(codigoFila, codigo,
                             StringComparison.OrdinalIgnoreCase))
                        ||
                        (dni != "" && dniFila == dni))
                    {
                        filaSeleccionada = fila;
                        break;
                    }
                }
            }

            if (filaSeleccionada == null)
            {
                MessageBox.Show(
                    "Busca un residente antes de modificarlo.",
                    "Modificación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string codigoNuevo = txtCodigo.Text.Trim();
            string dniNuevo = txtDnix.Text.Trim();

            if (codigoNuevo == "" || dniNuevo == "" ||
                txtNombres.Text.Trim() == "" ||
                txtApellidos.Text.Trim() == "" ||
                txtManzana.Text.Trim() == "" ||
                txtLote.Text.Trim() == "" ||
                txtTelefono.Text.Trim() == "" ||
                cboTipoResidente.SelectedIndex == -1 ||
                cboEstadoPago.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Completa todos los campos antes de modificar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Comprobar duplicados en otras filas
            foreach (DataGridViewRow fila in dgvResidentes.Rows)
            {
                if (fila.IsNewRow || fila == filaSeleccionada)
                    continue;

                string codigoFila =
                    Convert.ToString(fila.Cells[0].Value);

                string dniFila =
                    Convert.ToString(fila.Cells[1].Value);

                if (string.Equals(codigoFila, codigoNuevo,
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Ese código ya pertenece a otro residente.");
                    return;
                }

                if (dniFila == dniNuevo)
                {
                    MessageBox.Show("Ese DNI ya pertenece a otro residente.");
                    return;
                }
            }

            // Actualizar la fila
            filaSeleccionada.Cells[0].Value = codigoNuevo;
            filaSeleccionada.Cells[1].Value = dniNuevo;
            filaSeleccionada.Cells[2].Value = txtNombres.Text.Trim();
            filaSeleccionada.Cells[3].Value = txtApellidos.Text.Trim();
            filaSeleccionada.Cells[4].Value = txtManzana.Text.Trim();
            filaSeleccionada.Cells[5].Value = txtLote.Text.Trim();
            filaSeleccionada.Cells[6].Value = txtTelefono.Text.Trim();
            filaSeleccionada.Cells[7].Value = cboTipoResidente.Text;
            filaSeleccionada.Cells[8].Value = cboEstadoPago.Text;

            MessageBox.Show(
                "Residente modificado correctamente.",
                "Modificación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LimpiarCampos();
        }



        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

