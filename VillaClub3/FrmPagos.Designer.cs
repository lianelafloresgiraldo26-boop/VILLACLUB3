namespace VillaClub3
{
    partial class FrmPagos
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
            txtDnix = new TextBox();
            label3 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtMonto = new TextBox();
            label5 = new Label();
            cboMes = new ComboBox();
            cboEstadoPago = new ComboBox();
            label6 = new Label();
            btnRegistrarPago = new Button();
            btnBuscarPago = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            dgvPagos = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colDni = new DataGridViewTextBoxColumn();
            colNombres = new DataGridViewTextBoxColumn();
            colApellidos = new DataGridViewTextBoxColumn();
            colMes = new DataGridViewTextBoxColumn();
            colAnio = new DataGridViewTextBoxColumn();
            colMonto = new DataGridViewTextBoxColumn();
            colEstadoPago = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(46, 44);
            label2.Name = "label2";
            label2.Size = new Size(220, 30);
            label2.TabIndex = 3;
            label2.Text = "GESTIÓN DE PAGOS";
            // 
            // txtDnix
            // 
            txtDnix.Font = new Font("Segoe UI", 12F);
            txtDnix.Location = new Point(332, 122);
            txtDnix.Name = "txtDnix";
            txtDnix.Size = new Size(259, 29);
            txtDnix.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(332, 98);
            label3.Name = "label3";
            label3.Size = new Size(37, 21);
            label3.TabIndex = 9;
            label3.Text = "DNI";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 12F);
            txtCodigo.Location = new Point(46, 122);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(259, 29);
            txtCodigo.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(46, 98);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 7;
            label1.Text = "Código";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(332, 172);
            label4.Name = "label4";
            label4.Size = new Size(99, 21);
            label4.TabIndex = 13;
            label4.Text = "Mes de pago";
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Segoe UI", 12F);
            txtMonto.Location = new Point(46, 196);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(259, 29);
            txtMonto.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(46, 172);
            label5.Name = "label5";
            label5.Size = new Size(79, 21);
            label5.TabIndex = 11;
            label5.Text = "Monto(s/)";
            // 
            // cboMes
            // 
            cboMes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMes.Font = new Font("Segoe UI", 12F);
            cboMes.FormattingEnabled = true;
            cboMes.Items.AddRange(new object[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            cboMes.Location = new Point(332, 196);
            cboMes.Name = "cboMes";
            cboMes.Size = new Size(259, 29);
            cboMes.TabIndex = 15;
            // 
            // cboEstadoPago
            // 
            cboEstadoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstadoPago.Font = new Font("Segoe UI", 12F);
            cboEstadoPago.FormattingEnabled = true;
            cboEstadoPago.Items.AddRange(new object[] { "Pendiente", "", "Pagado", "", "Vencido" });
            cboEstadoPago.Location = new Point(46, 274);
            cboEstadoPago.Name = "cboEstadoPago";
            cboEstadoPago.Size = new Size(259, 29);
            cboEstadoPago.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(46, 250);
            label6.Name = "label6";
            label6.Size = new Size(120, 21);
            label6.TabIndex = 16;
            label6.Text = "Estado del pago";
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.Font = new Font("Segoe UI", 12F);
            btnRegistrarPago.Location = new Point(46, 331);
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.Size = new Size(183, 47);
            btnRegistrarPago.TabIndex = 22;
            btnRegistrarPago.Text = "Registrar pago";
            btnRegistrarPago.UseVisualStyleBackColor = true;
            btnRegistrarPago.Click += btnRegistrarPago_Click;
            // 
            // btnBuscarPago
            // 
            btnBuscarPago.Font = new Font("Segoe UI", 12F);
            btnBuscarPago.Location = new Point(235, 331);
            btnBuscarPago.Name = "btnBuscarPago";
            btnBuscarPago.Size = new Size(183, 47);
            btnBuscarPago.TabIndex = 23;
            btnBuscarPago.Text = "Buscar pago";
            btnBuscarPago.UseVisualStyleBackColor = true;
            btnBuscarPago.Click += btnBuscarPago_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F);
            btnLimpiar.Location = new Point(424, 331);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(183, 47);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F);
            btnVolver.Location = new Point(492, 678);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(115, 47);
            btnVolver.TabIndex = 28;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgvPagos
            // 
            dgvPagos.AllowUserToAddRows = false;
            dgvPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagos.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colDni, colNombres, colApellidos, colMes, colAnio, colMonto, colEstadoPago });
            dgvPagos.Location = new Point(46, 396);
            dgvPagos.MultiSelect = false;
            dgvPagos.Name = "dgvPagos";
            dgvPagos.ReadOnly = true;
            dgvPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPagos.Size = new Size(561, 266);
            dgvPagos.TabIndex = 27;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colDni
            // 
            colDni.HeaderText = "DNI";
            colDni.Name = "colDni";
            colDni.ReadOnly = true;
            // 
            // colNombres
            // 
            colNombres.HeaderText = "Nombres";
            colNombres.Name = "colNombres";
            colNombres.ReadOnly = true;
            // 
            // colApellidos
            // 
            colApellidos.HeaderText = "Apellidos";
            colApellidos.Name = "colApellidos";
            colApellidos.ReadOnly = true;
            // 
            // colMes
            // 
            colMes.HeaderText = "Mes de pago";
            colMes.Name = "colMes";
            colMes.ReadOnly = true;
            // 
            // colAnio
            // 
            colAnio.HeaderText = "Año";
            colAnio.Name = "colAnio";
            colAnio.ReadOnly = true;
            // 
            // colMonto
            // 
            colMonto.HeaderText = "Monto (S/)";
            colMonto.Name = "colMonto";
            colMonto.ReadOnly = true;
            // 
            // colEstadoPago
            // 
            colEstadoPago.HeaderText = "Estado de pago";
            colEstadoPago.Name = "colEstadoPago";
            colEstadoPago.ReadOnly = true;
            // 
            // FrmPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 751);
            Controls.Add(btnVolver);
            Controls.Add(dgvPagos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscarPago);
            Controls.Add(btnRegistrarPago);
            Controls.Add(cboEstadoPago);
            Controls.Add(label6);
            Controls.Add(cboMes);
            Controls.Add(label4);
            Controls.Add(txtMonto);
            Controls.Add(label5);
            Controls.Add(txtDnix);
            Controls.Add(label3);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "FrmPagos";
            Text = "FrmPagos";
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtDnix;
        private Label label3;
        private TextBox txtCodigo;
        private Label label1;
        private Label label4;
        private TextBox txtMonto;
        private Label label5;
        private ComboBox cboMes;
        private ComboBox cboEstadoPago;
        private Label label6;
        private Button btnRegistrarPago;
        private Button btnBuscarPago;
        private Button btnLimpiar;
        private Button btnVolver;
        private DataGridView dgvPagos;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colDni;
        private DataGridViewTextBoxColumn colNombres;
        private DataGridViewTextBoxColumn colApellidos;
        private DataGridViewTextBoxColumn colMes;
        private DataGridViewTextBoxColumn colAnio;
        private DataGridViewTextBoxColumn colMonto;
        private DataGridViewTextBoxColumn colEstadoPago;
    }
}