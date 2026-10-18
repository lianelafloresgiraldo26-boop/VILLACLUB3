namespace VillaClub3
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnGestionResidentes = new Button();
            btnBusqueda = new Button();
            btnPagosMantenimiento = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(292, 45);
            label1.Name = "label1";
            label1.Size = new Size(189, 37);
            label1.TabIndex = 0;
            label1.Text = "VILLA CLUB 3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(217, 91);
            label2.Name = "label2";
            label2.Size = new Size(338, 30);
            label2.TabIndex = 1;
            label2.Text = "Sistema de Gestión de Residentes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(252, 133);
            label3.Name = "label3";
            label3.Size = new Size(268, 21);
            label3.TabIndex = 2;
            label3.Text = "Seleccione un módulo para continuar";
            // 
            // btnGestionResidentes
            // 
            btnGestionResidentes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGestionResidentes.Location = new Point(146, 190);
            btnGestionResidentes.Name = "btnGestionResidentes";
            btnGestionResidentes.Size = new Size(233, 69);
            btnGestionResidentes.TabIndex = 3;
            btnGestionResidentes.Text = "Gestión de residentes";
            btnGestionResidentes.UseVisualStyleBackColor = true;
            btnGestionResidentes.Click += btnGestionResidentes_Click_1;
            // 
            // btnBusqueda
            // 
            btnBusqueda.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBusqueda.Location = new Point(385, 190);
            btnBusqueda.Name = "btnBusqueda";
            btnBusqueda.Size = new Size(233, 69);
            btnBusqueda.TabIndex = 4;
            btnBusqueda.Text = "Búsqueda";
            btnBusqueda.UseVisualStyleBackColor = true;
            btnBusqueda.Click += btnBusqueda_Click_1;
            // 
            // btnPagosMantenimiento
            // 
            btnPagosMantenimiento.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPagosMantenimiento.Location = new Point(146, 265);
            btnPagosMantenimiento.Name = "btnPagosMantenimiento";
            btnPagosMantenimiento.Size = new Size(233, 69);
            btnPagosMantenimiento.TabIndex = 5;
            btnPagosMantenimiento.Text = "Pagos de mantenimiento";
            btnPagosMantenimiento.UseVisualStyleBackColor = true;
            btnPagosMantenimiento.Click += btnPagosMantenimiento_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalir.Location = new Point(385, 265);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(233, 69);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 398);
            Controls.Add(btnSalir);
            Controls.Add(btnPagosMantenimiento);
            Controls.Add(btnBusqueda);
            Controls.Add(btnGestionResidentes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMenuPrincipal";
            Text = "Villa Club 3 - Menú Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGestionResidentes;
        private Button btnBusqueda;
        private Button btnPagosMantenimiento;
        private Button btnSalir;
    }
}
