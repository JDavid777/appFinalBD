namespace AppZoo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbxPais = new System.Windows.Forms.ComboBox();
            this.rbMacho = new System.Windows.Forms.RadioButton();
            this.rbHembra = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbPais = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.tbGestion = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnConsultarAnimales = new System.Windows.Forms.Button();
            this.pnlRegistro.SuspendLayout();
            this.tbGestion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlRegistro.Controls.Add(this.btnGuardar);
            this.pnlRegistro.Controls.Add(this.cbxPais);
            this.pnlRegistro.Controls.Add(this.rbMacho);
            this.pnlRegistro.Controls.Add(this.rbHembra);
            this.pnlRegistro.Controls.Add(this.txtNombre);
            this.pnlRegistro.Controls.Add(this.txtCodigo);
            this.pnlRegistro.Controls.Add(this.lbPais);
            this.pnlRegistro.Controls.Add(this.lbGenero);
            this.pnlRegistro.Controls.Add(this.lbNombre);
            this.pnlRegistro.Controls.Add(this.lbCodigo);
            this.pnlRegistro.Controls.Add(this.lbMensaje);
            this.pnlRegistro.Location = new System.Drawing.Point(12, 12);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(412, 386);
            this.pnlRegistro.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(280, 312);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 36);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbxPais
            // 
            this.cbxPais.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPais.FormattingEnabled = true;
            this.cbxPais.Items.AddRange(new object[] {
            "Colombia",
            "E.E.U.U",
            "Peru",
            "Argentina",
            "Ecuador",
            "España"});
            this.cbxPais.Location = new System.Drawing.Point(117, 203);
            this.cbxPais.Name = "cbxPais";
            this.cbxPais.Size = new System.Drawing.Size(220, 26);
            this.cbxPais.TabIndex = 9;
            this.cbxPais.Text = "Colombia";
            // 
            // rbMacho
            // 
            this.rbMacho.AutoSize = true;
            this.rbMacho.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMacho.Location = new System.Drawing.Point(237, 155);
            this.rbMacho.Name = "rbMacho";
            this.rbMacho.Size = new System.Drawing.Size(69, 22);
            this.rbMacho.TabIndex = 8;
            this.rbMacho.TabStop = true;
            this.rbMacho.Text = "Macho";
            this.rbMacho.UseVisualStyleBackColor = true;
            // 
            // rbHembra
            // 
            this.rbHembra.AutoSize = true;
            this.rbHembra.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHembra.Location = new System.Drawing.Point(118, 153);
            this.rbHembra.Name = "rbHembra";
            this.rbHembra.Size = new System.Drawing.Size(78, 22);
            this.rbHembra.TabIndex = 7;
            this.rbHembra.TabStop = true;
            this.rbHembra.Text = "Hembra";
            this.rbHembra.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(118, 49);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(219, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPais.Location = new System.Drawing.Point(21, 205);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(40, 18);
            this.lbPais.TabIndex = 4;
            this.lbPais.Text = "Pais:";
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenero.Location = new System.Drawing.Point(20, 151);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(57, 18);
            this.lbGenero.TabIndex = 3;
            this.lbGenero.Text = "Genero:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(20, 97);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(62, 18);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(20, 50);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(55, 18);
            this.lbCodigo.TabIndex = 1;
            this.lbCodigo.Text = "Código:";
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.Location = new System.Drawing.Point(15, 9);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(287, 21);
            this.lbMensaje.TabIndex = 0;
            this.lbMensaje.Text = "Ingrese información del Animal";
            // 
            // tbGestion
            // 
            this.tbGestion.Controls.Add(this.tabPage1);
            this.tbGestion.Controls.Add(this.tabPage2);
            this.tbGestion.Location = new System.Drawing.Point(460, 12);
            this.tbGestion.Name = "tbGestion";
            this.tbGestion.SelectedIndex = 0;
            this.tbGestion.Size = new System.Drawing.Size(346, 386);
            this.tbGestion.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnConsultarAnimales);
            this.tabPage1.Controls.Add(this.dgvDatos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(338, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cargar Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(338, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar Animal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(25, 75);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(291, 251);
            this.dgvDatos.TabIndex = 0;
            // 
            // btnConsultarAnimales
            // 
            this.btnConsultarAnimales.Location = new System.Drawing.Point(25, 28);
            this.btnConsultarAnimales.Name = "btnConsultarAnimales";
            this.btnConsultarAnimales.Size = new System.Drawing.Size(113, 23);
            this.btnConsultarAnimales.TabIndex = 1;
            this.btnConsultarAnimales.Text = "ConsultarAimales";
            this.btnConsultarAnimales.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 410);
            this.Controls.Add(this.tbGestion);
            this.Controls.Add(this.pnlRegistro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Registro Animal v1.0";
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.tbGestion.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbxPais;
        private System.Windows.Forms.RadioButton rbMacho;
        private System.Windows.Forms.RadioButton rbHembra;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.TabControl tbGestion;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnConsultarAnimales;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

