using System;
using System.Windows.Forms;

namespace VillaClub3
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(Form formulario)
        {
            formulario.ShowDialog();
        }

        private void btnGestionResidentes_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmResidentes());
        }

        private void btnBusqueda_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmBusqueda());
        }

        private void btnPagosMantenimiento_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPagos());
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
