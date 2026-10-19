using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillaClub3
{
    public partial class FrmPagos : Form
    {

        private FrmResidentes formularioResidentes;
        public FrmPagos(FrmResidentes formulario)
        {
            InitializeComponent();
            formularioResidentes = formulario;
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {

            string codigo = txtCodigo.Text.Trim();
            string dni = txtDnix.Text.Trim();
            string montoTexto = txtMonto.Text.Trim();

            if (codigo == "" || dni == "" || montoTexto == "")
            {
                MessageBox.Show("Complete el código, DNI y monto.");
                return;
            }

            if (cboMes.SelectedIndex == -1 ||
                cboEstadoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el mes y el estado del pago.");
                return;
            }

            if (dni.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 dígitos.");
                return;
            }

            bool dniValido = true;

            for (int i = 0; i < dni.Length; i++)
            {
                if (!char.IsDigit(dni[i]))
                {
                    dniValido = false;
                }
            }

            if (!dniValido)
            {
                MessageBox.Show("El DNI solo debe contener números.");
                return;
            }

            double monto;

            if (!double.TryParse(montoTexto, out monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto válido mayor que cero.");
                return;
            }

            int anio = DateTime.Now.Year;

            for (int i = 0; i < dgvPagos.Rows.Count; i++)
            {
                string codigoActual = Convert.ToString(
                    dgvPagos.Rows[i].Cells[0].Value);

                string mesActual = Convert.ToString(
                    dgvPagos.Rows[i].Cells[4].Value);

                string anioActual = Convert.ToString(
                    dgvPagos.Rows[i].Cells[5].Value);

                if (codigoActual == codigo &&
                    mesActual == cboMes.Text &&
                    anioActual == anio.ToString())
                {
                    MessageBox.Show(
                        "Ya existe un registro de pago para este residente y mes.");
                    return;
                }
            }

            string[] datosResidente =
    formularioResidentes.BuscarResidentePorCodigo(codigo);

            if (datosResidente == null)
            {
                MessageBox.Show("El residente no está registrado.");
                return;
            }

            dgvPagos.Rows.Add(
                datosResidente[0],
                datosResidente[1],
                datosResidente[2],
                datosResidente[3],
                cboMes.Text,
                anio,
                monto,
                cboEstadoPago.Text);

            MessageBox.Show("Pago registrado correctamente.");

            txtCodigo.Clear();
            txtDnix.Clear();
            txtMonto.Clear();
            cboMes.SelectedIndex = -1;
            cboEstadoPago.SelectedIndex = -1;

        }

        private void btnBuscarPago_Click(object sender, EventArgs e)
        {

            string codigo = txtCodigo.Text.Trim();

            if (codigo == "")
            {
                MessageBox.Show("Ingrese el código del residente.");
                return;
            }

            string[] datos = formularioResidentes.BuscarResidentePorCodigo(codigo);

            if (datos == null)
            {
                MessageBox.Show("No se encontró un residente con ese código.");
                txtDnix.Clear();
                return;
            }

            txtDnix.Text = datos[1];

            MessageBox.Show(
                "Residente encontrado: " + datos[2] + " " + datos[3]);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtDnix.Clear();
            txtMonto.Clear();

            cboMes.SelectedIndex = -1;
            cboEstadoPago.SelectedIndex = -1;

            dgvPagos.ClearSelection();

            txtCodigo.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
