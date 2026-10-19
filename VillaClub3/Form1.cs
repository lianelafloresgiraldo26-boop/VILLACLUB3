
using System;
using System.Windows.Forms;

namespace VillaClub3
{
    public partial class FrmMenuPrincipal : Form
    {
        // Mantener una sola instancia de cada formulario

        private FrmResidentes formularioResidentes;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            formularioResidentes = new FrmResidentes();
        }



        private void AbrirFormulario(Form formulario)
        {
            formulario.ShowDialog();
        }

        private void btnGestionResidentes_Click_1(object sender, EventArgs e)
        {
            formularioResidentes.ShowDialog();
        }


        private void btnBusqueda_Click_1(object sender, EventArgs e)
        {
            string[,] datos = formularioResidentes.ObtenerDatosResidentes();

            AbrirFormulario(new FrmBusqueda(datos));
        }


        private void btnPagosMantenimiento_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPagos(formularioResidentes));
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

