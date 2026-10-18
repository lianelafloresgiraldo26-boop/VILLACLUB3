namespace VillaClub3
{
    partial class FrmBusqueda
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
            btnLimpiar = new Button();
            btnBuscar = new Button();
            button1 = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dgvResidentes).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(59, 47);
            label2.Name = "label2";
            label2.Size = new Size(298, 30);
            label2.TabIndex = 3;
            label2.Text = "BÚSQUEDA DE RESIDENTES";
            // 
            // txtDnix
            // 
            txtDnix.Font = new Font("Segoe UI", 12F);
            txtDnix.Location = new Point(345, 123);
            txtDnix.Name = "txtDnix";
            txtDnix.Size = new Size(259, 29);
            txtDnix.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(345, 99);
            label3.Name = "label3";
            label3.Size = new Size(37, 21);
            label3.TabIndex = 9;
            label3.Text = "DNI";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 12F);
            txtCodigo.Location = new Point(59, 123);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(259, 29);
            txtCodigo.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(59, 99);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 7;
            label1.Text = "Código";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F);
            btnLimpiar.Location = new Point(302, 181);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(173, 47);
            btnLimpiar.TabIndex = 26;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F);
            btnBuscar.Location = new Point(59, 181);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(173, 47);
            btnBuscar.TabIndex = 25;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(560, 181);
            button1.Name = "button1";
            button1.Size = new Size(173, 47);
            button1.TabIndex = 27;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvResidentes
            // 
            dgvResidentes.AllowUserToAddRows = false;
            dgvResidentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResidentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResidentes.Columns.AddRange(new DataGridViewColumn[] { codigo, dni, nombres, apellidos, manzana, lote, telefono, tipoDeResidente, estadoDePago });
            dgvResidentes.Location = new Point(59, 252);
            dgvResidentes.MultiSelect = false;
            dgvResidentes.Name = "dgvResidentes";
            dgvResidentes.ReadOnly = true;
            dgvResidentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResidentes.Size = new Size(674, 222);
            dgvResidentes.TabIndex = 28;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            // 
            // dni
            // 
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            dni.ReadOnly = true;
            // 
            // nombres
            // 
            nombres.HeaderText = "Nombres";
            nombres.Name = "nombres";
            nombres.ReadOnly = true;
            // 
            // apellidos
            // 
            apellidos.HeaderText = "Apellidos";
            apellidos.Name = "apellidos";
            apellidos.ReadOnly = true;
            // 
            // manzana
            // 
            manzana.HeaderText = "Manzana";
            manzana.Name = "manzana";
            manzana.ReadOnly = true;
            // 
            // lote
            // 
            lote.HeaderText = "Lote";
            lote.Name = "lote";
            lote.ReadOnly = true;
            // 
            // telefono
            // 
            telefono.HeaderText = "Teléfono";
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            // 
            // tipoDeResidente
            // 
            tipoDeResidente.HeaderText = "Tipo de residente";
            tipoDeResidente.Name = "tipoDeResidente";
            tipoDeResidente.ReadOnly = true;
            // 
            // estadoDePago
            // 
            estadoDePago.HeaderText = "Estado de pago";
            estadoDePago.Name = "estadoDePago";
            estadoDePago.ReadOnly = true;
            // 
            // FrmBusqueda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(dgvResidentes);
            Controls.Add(button1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(txtDnix);
            Controls.Add(label3);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "FrmBusqueda";
            Text = "FrmBusqueda";
            ((System.ComponentModel.ISupportInitialize)dgvResidentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtDnix;
        private Label label3;
        private TextBox txtCodigo;
        private Label label1;
        private Button btnLimpiar;
        private Button btnBuscar;
        private Button button1;
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
    }
}