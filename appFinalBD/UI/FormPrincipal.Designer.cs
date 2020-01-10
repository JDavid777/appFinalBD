namespace appFinalBD.UI
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnConsultarSuspendidos = new System.Windows.Forms.Button();
            this.dtpFechaBuscada = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarFecha = new System.Windows.Forms.Button();
            this.rbAgremiacion = new System.Windows.Forms.RadioButton();
            this.dtgImpreciones = new System.Windows.Forms.DataGridView();
            this.cbxTransaccion = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rbSindicato = new System.Windows.Forms.RadioButton();
            this.rbSindicalista = new System.Windows.Forms.RadioButton();
            this.rbEmpresa = new System.Windows.Forms.RadioButton();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgImpreciones)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPrincipal.BackgroundImage")));
            this.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPrincipal.Controls.Add(this.btnLimpiar);
            this.pnlPrincipal.Controls.Add(this.label3);
            this.pnlPrincipal.Controls.Add(this.label2);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Controls.Add(this.lblBuscar);
            this.pnlPrincipal.Controls.Add(this.btnConsultarSuspendidos);
            this.pnlPrincipal.Controls.Add(this.dtpFechaBuscada);
            this.pnlPrincipal.Controls.Add(this.btnBuscarFecha);
            this.pnlPrincipal.Controls.Add(this.rbAgremiacion);
            this.pnlPrincipal.Controls.Add(this.dtgImpreciones);
            this.pnlPrincipal.Controls.Add(this.cbxTransaccion);
            this.pnlPrincipal.Controls.Add(this.btnSalir);
            this.pnlPrincipal.Controls.Add(this.btnAceptar);
            this.pnlPrincipal.Controls.Add(this.rbSindicato);
            this.pnlPrincipal.Controls.Add(this.rbSindicalista);
            this.pnlPrincipal.Controls.Add(this.rbEmpresa);
            this.pnlPrincipal.Location = new System.Drawing.Point(2, 3);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(872, 483);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LightGray;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(694, 91);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 27);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Menu Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(34, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Selecione una opcion para realizar la transaccion que necesite.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(396, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sindicalistas suspendidos con agremiacion vigente";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBuscar.Location = new System.Drawing.Point(34, 43);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(245, 17);
            this.lblBuscar.TabIndex = 11;
            this.lblBuscar.Text = "Buscar  por fecha de inicio de agremiacion";
            // 
            // btnConsultarSuspendidos
            // 
            this.btnConsultarSuspendidos.BackColor = System.Drawing.Color.LightGray;
            this.btnConsultarSuspendidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarSuspendidos.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarSuspendidos.Location = new System.Drawing.Point(399, 59);
            this.btnConsultarSuspendidos.Name = "btnConsultarSuspendidos";
            this.btnConsultarSuspendidos.Size = new System.Drawing.Size(86, 25);
            this.btnConsultarSuspendidos.TabIndex = 10;
            this.btnConsultarSuspendidos.Text = "Consultar";
            this.btnConsultarSuspendidos.UseVisualStyleBackColor = false;
            this.btnConsultarSuspendidos.Click += new System.EventHandler(this.btnConsultarSuspendidos_Click);
            // 
            // dtpFechaBuscada
            // 
            this.dtpFechaBuscada.CalendarFont = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaBuscada.Location = new System.Drawing.Point(37, 64);
            this.dtpFechaBuscada.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpFechaBuscada.Name = "dtpFechaBuscada";
            this.dtpFechaBuscada.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaBuscada.TabIndex = 9;
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.BackColor = System.Drawing.Color.LightGray;
            this.btnBuscarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarFecha.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFecha.Location = new System.Drawing.Point(276, 59);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(75, 25);
            this.btnBuscarFecha.TabIndex = 8;
            this.btnBuscarFecha.Text = "Buscar";
            this.btnBuscarFecha.UseVisualStyleBackColor = false;
            this.btnBuscarFecha.Click += new System.EventHandler(this.btnBuscarFecha_Click);
            // 
            // rbAgremiacion
            // 
            this.rbAgremiacion.AutoSize = true;
            this.rbAgremiacion.BackColor = System.Drawing.Color.Transparent;
            this.rbAgremiacion.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAgremiacion.ForeColor = System.Drawing.SystemColors.Control;
            this.rbAgremiacion.Location = new System.Drawing.Point(399, 130);
            this.rbAgremiacion.Name = "rbAgremiacion";
            this.rbAgremiacion.Size = new System.Drawing.Size(100, 22);
            this.rbAgremiacion.TabIndex = 7;
            this.rbAgremiacion.TabStop = true;
            this.rbAgremiacion.Text = "Agremiacion";
            this.rbAgremiacion.UseVisualStyleBackColor = false;
            // 
            // dtgImpreciones
            // 
            this.dtgImpreciones.AllowUserToOrderColumns = true;
            this.dtgImpreciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgImpreciones.Location = new System.Drawing.Point(37, 175);
            this.dtgImpreciones.Name = "dtgImpreciones";
            this.dtgImpreciones.Size = new System.Drawing.Size(792, 292);
            this.dtgImpreciones.TabIndex = 6;
            // 
            // cbxTransaccion
            // 
            this.cbxTransaccion.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTransaccion.FormattingEnabled = true;
            this.cbxTransaccion.Items.AddRange(new object[] {
            "Registrar",
            "Actualizar",
            "Consultar",
            "Eliminar"});
            this.cbxTransaccion.Location = new System.Drawing.Point(536, 127);
            this.cbxTransaccion.Name = "cbxTransaccion";
            this.cbxTransaccion.Size = new System.Drawing.Size(121, 25);
            this.cbxTransaccion.TabIndex = 5;
            this.cbxTransaccion.Text = "Registrar";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(827, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(38, 26);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.LightGray;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAceptar.Location = new System.Drawing.Point(694, 129);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 25);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // rbSindicato
            // 
            this.rbSindicato.AutoSize = true;
            this.rbSindicato.BackColor = System.Drawing.Color.Transparent;
            this.rbSindicato.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSindicato.ForeColor = System.Drawing.SystemColors.Control;
            this.rbSindicato.Location = new System.Drawing.Point(37, 130);
            this.rbSindicato.Name = "rbSindicato";
            this.rbSindicato.Size = new System.Drawing.Size(81, 22);
            this.rbSindicato.TabIndex = 2;
            this.rbSindicato.TabStop = true;
            this.rbSindicato.Text = "Sindicato";
            this.rbSindicato.UseVisualStyleBackColor = false;
            // 
            // rbSindicalista
            // 
            this.rbSindicalista.AutoSize = true;
            this.rbSindicalista.BackColor = System.Drawing.Color.Transparent;
            this.rbSindicalista.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSindicalista.ForeColor = System.Drawing.SystemColors.Control;
            this.rbSindicalista.Location = new System.Drawing.Point(158, 130);
            this.rbSindicalista.Name = "rbSindicalista";
            this.rbSindicalista.Size = new System.Drawing.Size(92, 22);
            this.rbSindicalista.TabIndex = 1;
            this.rbSindicalista.TabStop = true;
            this.rbSindicalista.Text = "Sindicalista";
            this.rbSindicalista.UseVisualStyleBackColor = false;
            // 
            // rbEmpresa
            // 
            this.rbEmpresa.AutoSize = true;
            this.rbEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.rbEmpresa.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmpresa.ForeColor = System.Drawing.SystemColors.Control;
            this.rbEmpresa.Location = new System.Drawing.Point(294, 130);
            this.rbEmpresa.Name = "rbEmpresa";
            this.rbEmpresa.Size = new System.Drawing.Size(78, 22);
            this.rbEmpresa.TabIndex = 0;
            this.rbEmpresa.TabStop = true;
            this.rbEmpresa.Text = "Empresa";
            this.rbEmpresa.UseVisualStyleBackColor = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 483);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgImpreciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.DataGridView dtgImpreciones;
        private System.Windows.Forms.ComboBox cbxTransaccion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RadioButton rbSindicato;
        private System.Windows.Forms.RadioButton rbSindicalista;
        private System.Windows.Forms.RadioButton rbEmpresa;
        private System.Windows.Forms.RadioButton rbAgremiacion;
        private System.Windows.Forms.Button btnConsultarSuspendidos;
        private System.Windows.Forms.DateTimePicker dtpFechaBuscada;
        private System.Windows.Forms.Button btnBuscarFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiar;
    }
}