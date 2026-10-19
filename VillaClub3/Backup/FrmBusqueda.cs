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
        public FrmBusqueda()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            string dni = txtDnix.Text.Trim();

            if (codigo == "" && dni == "")
            {
                MessageBox.Show(
                    "Ingrese un código o un DNI para buscar.",
                    "Búsqueda de residentes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            MessageBox.Show(
                "Los criterios de búsqueda son correctos. " +
                "Falta conectar los registros de residentes.",
                "Búsqueda",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
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
