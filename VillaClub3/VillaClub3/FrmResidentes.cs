
using System;
using System.Windows.Forms;

namespace VillaClub3
{
    public partial class FrmResidentes : Form
    {
        public FrmResidentes()
        {
            InitializeComponent();
            dgvResidentes.CellClick += dgvResidentes_CellClick;
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


            if (dni.Length != 8)
            {
                MessageBox.Show(
                    "El DNI debe tener exactamente 8 dígitos.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtDnix.Focus();
                return;
            }

            for (int i = 0; i < dni.Length; i++)
            {
                if (!char.IsDigit(dni[i]))
                {
                    MessageBox.Show(
                        "El DNI solo debe contener números.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtDnix.Focus();
                    return;
                }
            }

            if (telefono.Length != 9)
            {
                MessageBox.Show(
                    "El teléfono debe tener exactamente 9 dígitos.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return;
            }

            for (int i = 0; i < telefono.Length; i++)
            {
                if (!char.IsDigit(telefono[i]))
                {
                    MessageBox.Show(
                        "El teléfono solo debe contener números.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtTelefono.Focus();
                    return;
                }
            }



            // Evitar códigos y DNI duplicados

            for (int i = 0; i < dgvResidentes.Rows.Count; i++)
            {
                if (dgvResidentes.Rows[i].IsNewRow)
                {
                    continue;
                }

                string codigoExistente =
                    Convert.ToString(dgvResidentes.Rows[i].Cells[0].Value);

                string dniExistente =
                    Convert.ToString(dgvResidentes.Rows[i].Cells[1].Value);

                if (string.Equals(
                    codigoExistente,
                    codigo,
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "El código ya está registrado.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (dniExistente == dni)
                {
                    MessageBox.Show(
                        "El DNI ya está registrado.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
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

            string codigo = txtCodigo.Text.Trim();
            string dni = txtDnix.Text.Trim();

            // Buscar al residente por código o DNI
            for (int i = 0; i < dgvResidentes.Rows.Count; i++)
            {
                if (dgvResidentes.Rows[i].IsNewRow)
                {
                    continue;
                }

                string codigoFila =
                    Convert.ToString(dgvResidentes.Rows[i].Cells[0].Value);

                string dniFila =
                    Convert.ToString(dgvResidentes.Rows[i].Cells[1].Value);

                if ((codigo != "" &&
                     string.Equals(codigoFila, codigo,
                         StringComparison.OrdinalIgnoreCase))
                    ||
                    (dni != "" && dniFila == dni))
                {
                    filaSeleccionada = dgvResidentes.Rows[i];
                    break;
                }
            }

            if (filaSeleccionada == null)
            {
                MessageBox.Show(
                    "Ingresa el código o DNI de un residente registrado.",
                    "Modificación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string codigoNuevo = txtCodigo.Text.Trim();
            string dniNuevo = txtDnix.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string manzana = txtManzana.Text.Trim();
            string lote = txtLote.Text.Trim();
            string telefono = txtTelefono.Text.Trim();

            // Validar campos obligatorios
            if (codigoNuevo == "" || dniNuevo == "" ||
                nombres == "" || apellidos == "" ||
                manzana == "" || lote == "" || telefono == "")
            {
                MessageBox.Show(
                    "Completa todos los campos antes de modificar.",
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

            // Validar que el DNI tenga 8 dígitos numéricos
            if (dniNuevo.Length != 8)
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos.");
                txtDnix.Focus();
                return;
            }

            for (int i = 0; i < dniNuevo.Length; i++)
            {
                if (!char.IsDigit(dniNuevo[i]))
                {
                    MessageBox.Show("El DNI solo debe contener números.");
                    txtDnix.Focus();
                    return;
                }
            }

            // Validar que el teléfono tenga 9 dígitos numéricos
            if (telefono.Length != 9)
            {
                MessageBox.Show("El teléfono debe tener exactamente 9 dígitos.");
                txtTelefono.Focus();
                return;
            }

            for (int i = 0; i < telefono.Length; i++)
            {
                if (!char.IsDigit(telefono[i]))
                {
                    MessageBox.Show("El teléfono solo debe contener números.");
                    txtTelefono.Focus();
                    return;
                }
            }

            // Comprobar duplicados en otras filas
            for (int i = 0; i < dgvResidentes.Rows.Count; i++)
            {
                if (dgvResidentes.Rows[i].IsNewRow ||
                    dgvResidentes.Rows[i] == filaSeleccionada)
                {
                    continue;
                }

                string codigoFila =
                    Convert.ToString(dgvResidentes.Rows[i].Cells[0].Value);

                string dniFila =
                    Convert.ToString(dgvResidentes.Rows[i].Cells[1].Value);

                if (string.Equals(codigoFila, codigoNuevo,
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Ese código ya pertenece a otro residente.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (dniFila == dniNuevo)
                {
                    MessageBox.Show(
                        "Ese DNI ya pertenece a otro residente.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }

            // Actualizar los datos del residente
            filaSeleccionada.Cells[0].Value = codigoNuevo;
            filaSeleccionada.Cells[1].Value = dniNuevo;
            filaSeleccionada.Cells[2].Value = nombres;
            filaSeleccionada.Cells[3].Value = apellidos;
            filaSeleccionada.Cells[4].Value = manzana;
            filaSeleccionada.Cells[5].Value = lote;
            filaSeleccionada.Cells[6].Value = telefono;
            filaSeleccionada.Cells[7].Value = cboTipoResidente.Text;
            filaSeleccionada.Cells[8].Value = cboEstadoPago.Text;

            MessageBox.Show(
                "Residente modificado correctamente.",
                "Modificación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LimpiarCampos();
        }


        private void dgvResidentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se haya seleccionado una fila válida
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila = dgvResidentes.Rows[e.RowIndex];

            if (fila.IsNewRow)
            {
                return;
            }

            // Cargar los datos en los campos
            txtCodigo.Text = Convert.ToString(fila.Cells[0].Value);
            txtDnix.Text = Convert.ToString(fila.Cells[1].Value);
            txtNombres.Text = Convert.ToString(fila.Cells[2].Value);
            txtApellidos.Text = Convert.ToString(fila.Cells[3].Value);
            txtManzana.Text = Convert.ToString(fila.Cells[4].Value);
            txtLote.Text = Convert.ToString(fila.Cells[5].Value);
            txtTelefono.Text = Convert.ToString(fila.Cells[6].Value);

            cboTipoResidente.Text =
                Convert.ToString(fila.Cells[7].Value);

            cboEstadoPago.Text =
                Convert.ToString(fila.Cells[8].Value);
        }


        public string[,] ObtenerDatosResidentes()
        {
            int cantidad = 0;

            for (int i = 0; i < dgvResidentes.Rows.Count; i++)
            {
                if (!dgvResidentes.Rows[i].IsNewRow)
                {
                    cantidad++;
                }
            }

            string[,] datos = new string[cantidad, 9];
            int posicion = 0;

            for (int i = 0; i < dgvResidentes.Rows.Count; i++)
            {
                if (dgvResidentes.Rows[i].IsNewRow)
                {
                    continue;
                }

                for (int j = 0; j < 9; j++)
                {
                    datos[posicion, j] =
                        Convert.ToString(dgvResidentes.Rows[i].Cells[j].Value) ?? "";
                }

                posicion++;
            }

            return datos;
        }


        public string[] BuscarResidentePorCodigo(string codigo)
        {
            for (int i = 0; i < dgvResidentes.Rows.Count; i++)
            {
                if (dgvResidentes.Rows[i].IsNewRow)
                {
                    continue;
                }

                string codigoActual = Convert.ToString(
                    dgvResidentes.Rows[i].Cells[0].Value);

                if (string.Equals(
                    codigoActual,
                    codigo,
                    StringComparison.OrdinalIgnoreCase))
                {
                    string[] datos = new string[4];

                    datos[0] = codigoActual;
                    datos[1] = Convert.ToString(
                        dgvResidentes.Rows[i].Cells[1].Value);
                    datos[2] = Convert.ToString(
                        dgvResidentes.Rows[i].Cells[2].Value);
                    datos[3] = Convert.ToString(
                        dgvResidentes.Rows[i].Cells[3].Value);

                    return datos;
                }
            }

            return null;
        }


        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int cantidad = dgvResidentes.Rows.Count;

            if (dgvResidentes.AllowUserToAddRows)
            {
                cantidad--;
            }

            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = 0; j < cantidad - 1 - i; j++)
                {
                    string nombreActual = Convert.ToString(
                        dgvResidentes.Rows[j].Cells[2].Value);

                    string nombreSiguiente = Convert.ToString(
                        dgvResidentes.Rows[j + 1].Cells[2].Value);

                    if (string.Compare(nombreActual, nombreSiguiente,
                        StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        for (int k = 0; k < dgvResidentes.Columns.Count; k++)
                        {
                            object datoTemporal =
                                dgvResidentes.Rows[j].Cells[k].Value;

                            dgvResidentes.Rows[j].Cells[k].Value =
                                dgvResidentes.Rows[j + 1].Cells[k].Value;

                            dgvResidentes.Rows[j + 1].Cells[k].Value =
                                datoTemporal;
                        }
                    }
                }
            }

            MessageBox.Show(
                "Residentes ordenados alfabéticamente de A a Z.",
                "Ordenamiento",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}

