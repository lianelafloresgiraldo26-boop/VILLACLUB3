namespace VillaClub3
{
    partial class FrmResidentes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            txtCodigo = new TextBox();
            txtDnix = new TextBox();
            label3 = new Label();
            txtApellidos = new TextBox();
            label4 = new Label();
            txtNombres = new TextBox();
            label5 = new Label();
            txtLote = new TextBox();
            label6 = new Label();
            txtManzana = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtTelefono = new TextBox();
            label9 = new Label();
            label10 = new Label();
            cboTipoResidente = new ComboBox();
            cboEstadoPago = new ComboBox();
            btnRegistrar = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            dgvResidentes = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            nombres = new DataGridViewTextBoxColumn();
            apellidos = new DataGridViewTextBoxColumn();
            manzana = new DataGridViewTextBoxColumn();
            lote = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            tipoDeResidente = new DataGridViewTextBoxColumn();
            estadoDePago = new DataGridViewTextBoxColumn();
            btnVolver = new Button();
            label11 = new Label();
            btnOrdenar = new Button();
            btnSubir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResidentes).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(73, 55);
            label2.Name = "label2";
            label2.Size = new Size(350, 37);
            label2.TabIndex = 2;
            label2.Text = "REGISTRO DE RESIDENTES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(72, 144);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 3;
            label1.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 12F);
            txtCodigo.Location = new Point(72, 176);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(295, 34);
            txtCodigo.TabIndex = 4;
            // 
            // txtDnix
            // 
            txtDnix.Font = new Font("Segoe UI", 12F);
            txtDnix.Location = new Point(399, 176);
            txtDnix.Margin = new Padding(3, 4, 3, 4);
            txtDnix.Name = "txtDnix";
            txtDnix.Size = new Size(295, 34);
            txtDnix.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(399, 144);
            label3.Name = "label3";
            label3.Size = new Size(46, 28);
            label3.TabIndex = 5;
            label3.Text = "DNI";
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Segoe UI", 12F);
            txtApellidos.Location = new Point(399, 273);
            txtApellidos.Margin = new Padding(3, 4, 3, 4);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(295, 34);
            txtApellidos.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(399, 241);
            label4.Name = "label4";
            label4.Size = new Size(94, 28);
            label4.TabIndex = 9;
            label4.Text = "Apellidos";
            // 
            // txtNombres
            // 
            txtNombres.Font = new Font("Segoe UI", 12F);
            txtNombres.Location = new Point(72, 273);
            txtNombres.Margin = new Padding(3, 4, 3, 4);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(295, 34);
            txtNombres.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(72, 241);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 7;
            label5.Text = "Nombres";
            // 
            // txtLote
            // 
            txtLote.Font = new Font("Segoe UI", 12F);
            txtLote.Location = new Point(727, 273);
            txtLote.Margin = new Padding(3, 4, 3, 4);
            txtLote.Name = "txtLote";
            txtLote.Size = new Size(295, 34);
            txtLote.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(727, 241);
            label6.Name = "label6";
            label6.Size = new Size(50, 28);
            label6.TabIndex = 13;
            label6.Text = "Lote";
            // 
            // txtManzana
            // 
            txtManzana.Font = new Font("Segoe UI", 12F);
            txtManzana.Location = new Point(727, 176);
            txtManzana.Margin = new Padding(3, 4, 3, 4);
            txtManzana.Name = "txtManzana";
            txtManzana.Size = new Size(295, 34);
            txtManzana.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(727, 144);
            label7.Name = "label7";
            label7.Size = new Size(91, 28);
            label7.TabIndex = 11;
            label7.Text = "Manzana";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(400, 345);
            label8.Name = "label8";
            label8.Size = new Size(163, 28);
            label8.TabIndex = 17;
            label8.Text = "Tipo de residente";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(73, 381);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(295, 34);
            txtTelefono.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(73, 349);
            label9.Name = "label9";
            label9.Size = new Size(86, 28);
            label9.TabIndex = 15;
            label9.Text = "Teléfono";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(727, 345);
            label10.Name = "label10";
            label10.Size = new Size(149, 28);
            label10.TabIndex = 18;
            label10.Text = "Estado de pago";
            // 
            // cboTipoResidente
            // 
            cboTipoResidente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoResidente.Font = new Font("Segoe UI", 12F);
            cboTipoResidente.FormattingEnabled = true;
            cboTipoResidente.Items.AddRange(new object[] { "Propietario", "Inquilino" });
            cboTipoResidente.Location = new Point(400, 381);
            cboTipoResidente.Margin = new Padding(3, 4, 3, 4);
            cboTipoResidente.Name = "cboTipoResidente";
            cboTipoResidente.Size = new Size(294, 36);
            cboTipoResidente.TabIndex = 19;
            // 
            // cboEstadoPago
            // 
            cboEstadoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstadoPago.Font = new Font("Segoe UI", 12F);
            cboEstadoPago.FormattingEnabled = true;
            cboEstadoPago.Items.AddRange(new object[] { "Al día", "Con deuda" });
            cboEstadoPago.Location = new Point(727, 381);
            cboEstadoPago.Margin = new Padding(3, 4, 3, 4);
            cboEstadoPago.Name = "cboEstadoPago";
            cboEstadoPago.Size = new Size(295, 36);
            cboEstadoPago.TabIndex = 20;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 12F);
            btnRegistrar.Location = new Point(72, 471);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(209, 63);
            btnRegistrar.TabIndex = 21;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F);
            btnBuscar.Location = new Point(288, 471);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(209, 63);
            btnBuscar.TabIndex = 22;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F);
            btnModificar.Location = new Point(504, 471);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(209, 63);
            btnModificar.TabIndex = 23;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F);
            btnLimpiar.Location = new Point(720, 471);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(209, 63);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // dgvResidentes
            // 
            dgvResidentes.AllowUserToAddRows = false;
            dgvResidentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResidentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResidentes.Columns.AddRange(new DataGridViewColumn[] { codigo, dni, nombres, apellidos, manzana, lote, telefono, tipoDeResidente, estadoDePago });
            dgvResidentes.Location = new Point(72, 621);
            dgvResidentes.Margin = new Padding(3, 4, 3, 4);
            dgvResidentes.MultiSelect = false;
            dgvResidentes.Name = "dgvResidentes";
            dgvResidentes.ReadOnly = true;
            dgvResidentes.RowHeadersWidth = 51;
            dgvResidentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResidentes.Size = new Size(951, 568);
            dgvResidentes.TabIndex = 25;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.MinimumWidth = 6;
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            // 
            // dni
            // 
            dni.HeaderText = "DNI";
            dni.MinimumWidth = 6;
            dni.Name = "dni";
            dni.ReadOnly = true;
            // 
            // nombres
            // 
            nombres.HeaderText = "Nombres";
            nombres.MinimumWidth = 6;
            nombres.Name = "nombres";
            nombres.ReadOnly = true;
            // 
            // apellidos
            // 
            apellidos.HeaderText = "Apellidos";
            apellidos.MinimumWidth = 6;
            apellidos.Name = "apellidos";
            apellidos.ReadOnly = true;
            // 
            // manzana
            // 
            manzana.HeaderText = "Manzana";
            manzana.MinimumWidth = 6;
            manzana.Name = "manzana";
            manzana.ReadOnly = true;
            // 
            // lote
            // 
            lote.HeaderText = "Lote";
            lote.MinimumWidth = 6;
            lote.Name = "lote";
            lote.ReadOnly = true;
            // 
            // telefono
            // 
            telefono.HeaderText = "Teléfono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            // 
            // tipoDeResidente
            // 
            tipoDeResidente.HeaderText = "Tipo de residente";
            tipoDeResidente.MinimumWidth = 6;
            tipoDeResidente.Name = "tipoDeResidente";
            tipoDeResidente.ReadOnly = true;
            // 
            // estadoDePago
            // 
            estadoDePago.HeaderText = "Estado de pago";
            estadoDePago.MinimumWidth = 6;
            estadoDePago.Name = "estadoDePago";
            estadoDePago.ReadOnly = true;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F);
            btnVolver.Location = new Point(891, 1221);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(131, 63);
            btnVolver.TabIndex = 26;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(73, 563);
            label11.Name = "label11";
            label11.Size = new Size(175, 28);
            label11.TabIndex = 27;
            label11.Text = "Lista de Residentes";
            // 
            // btnOrdenar
            // 
            btnOrdenar.Font = new Font("Segoe UI", 12F);
            btnOrdenar.Location = new Point(891, 563);
            btnOrdenar.Margin = new Padding(3, 4, 3, 4);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(131, 45);
            btnOrdenar.TabIndex = 28;
            btnOrdenar.Text = "Ordenar A-Z";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnSubir
            // 
            btnSubir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubir.Location = new Point(951, 471);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(157, 57);
            btnSubir.TabIndex = 29;
            btnSubir.Text = "Subir datos";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // FrmResidentes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 1055);
            Controls.Add(btnSubir);
            Controls.Add(btnOrdenar);
            Controls.Add(label11);
            Controls.Add(btnVolver);
            Controls.Add(dgvResidentes);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(btnRegistrar);
            Controls.Add(cboEstadoPago);
            Controls.Add(cboTipoResidente);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(txtTelefono);
            Controls.Add(label9);
            Controls.Add(txtLote);
            Controls.Add(label6);
            Controls.Add(txtManzana);
            Controls.Add(label7);
            Controls.Add(txtApellidos);
            Controls.Add(label4);
            Controls.Add(txtNombres);
            Controls.Add(label5);
            Controls.Add(txtDnix);
            Controls.Add(label3);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmResidentes";
            Text = "FrmResidentes";
            ((System.ComponentModel.ISupportInitialize)dgvResidentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtCodigo;
        private TextBox txtDnix;
        private Label label3;
        private TextBox txtApellidos;
        private Label label4;
        private TextBox txtNombres;
        private Label label5;
        private TextBox txtLote;
        private Label label6;
        private TextBox txtManzana;
        private Label label7;
        private Label label8;
        private TextBox txtTelefono;
        private Label label9;
        private Label label10;
        private ComboBox cboTipoResidente;
        private ComboBox cboEstadoPago;
        private Button btnRegistrar;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnLimpiar;
        private DataGridView dgvResidentes;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn nombres;
        private DataGridViewTextBoxColumn apellidos;
        private DataGridViewTextBoxColumn manzana;
        private DataGridViewTextBoxColumn lote;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn tipoDeResidente;
        private DataGridViewTextBoxColumn estadoDePago;
        private Button btnVolver;
        private Label label11;
        private Button btnOrdenar;
        private Button btnSubir;
    }
}