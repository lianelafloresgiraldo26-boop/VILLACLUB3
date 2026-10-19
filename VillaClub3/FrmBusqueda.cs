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
    public partial class FrmBusqueda : Form
    {

        private string[,] datosResidentes;
        
        
        public FrmBusqueda(string[,] datos)
        {
            InitializeComponent();
            datosResidentes = datos;
        }

        public string[,] ObtenerDatosResidentes()
        {
            int cantidad = 0;

            // Contar las filas que contienen residentes
            for (int i = 0; i < dgvResidentes.Rows.Count; i++)
            {
                if (!dgvResidentes.Rows[i].IsNewRow)
                {
                    cantidad++;
                }
            }

            // Crear una matriz con 9 columnas
            string[,] datos = new string[cantidad, 9];

            int posicion = 0;

            // Copiar los datos de cada residente
            for (int i = 0; i < dgvResidentes.Rows.Count; i++)
            {
                if (!dgvResidentes.Rows[i].IsNewRow)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        datos[posicion, j] =
                            Convert.ToString(dgvResidentes.Rows[i].Cells[j].Value) ?? "";

                    }

                    posicion++;
                }
            }

            return datos;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            string dni = txtDnix.Text.Trim();

            if (codigo == "" && dni == "")
            {
                MessageBox.Show(
                    "Ingresa el código o el DNI que deseas buscar.",
                    "Búsqueda de residentes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            dgvResidentes.Rows.Clear();

            bool encontrado = false;

            for (int i = 0; i < datosResidentes.GetLength(0); i++)
            {
                bool coincideCodigo =
                    codigo != "" &&
                    string.Equals(
                        datosResidentes[i, 0],
                        codigo,
                        StringComparison.OrdinalIgnoreCase
                    );

                bool coincideDni =
                    dni != "" &&
                    datosResidentes[i, 1] == dni;

                if (coincideCodigo || coincideDni)
                {
                    dgvResidentes.Rows.Add(
                        datosResidentes[i, 0],
                        datosResidentes[i, 1],
                        datosResidentes[i, 2],
                        datosResidentes[i, 3],
                        datosResidentes[i, 4],
                        datosResidentes[i, 5],
                        datosResidentes[i, 6],
                        datosResidentes[i, 7],
                        datosResidentes[i, 8]
                    );

                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show(
                    "No se encontró ningún residente con esos datos.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtDnix.Clear();
            dgvResidentes.Rows.Clear();

            txtCodigo.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
