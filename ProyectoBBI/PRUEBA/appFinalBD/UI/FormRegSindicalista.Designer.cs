﻿namespace appFinalBD
{
    partial class RegSindicalista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegSindicalista));
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnAceptar2 = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.pnlPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPrincipal.BackgroundImage")));
            this.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPrincipal.Controls.Add(this.btnAceptar2);
            this.pnlPrincipal.Controls.Add(this.btnAtras);
            this.pnlPrincipal.Controls.Add(this.lblIdentificacion);
            this.pnlPrincipal.Controls.Add(this.lblApellidos);
            this.pnlPrincipal.Controls.Add(this.lblNombres);
            this.pnlPrincipal.Controls.Add(this.txtIdentificacion);
            this.pnlPrincipal.Controls.Add(this.txtApellido);
            this.pnlPrincipal.Controls.Add(this.txtNombre);
            this.pnlPrincipal.Controls.Add(this.lblGenero);
            this.pnlPrincipal.Controls.Add(this.rbMasculino);
            this.pnlPrincipal.Controls.Add(this.rbFemenino);
            this.pnlPrincipal.Controls.Add(this.lblEstado);
            this.pnlPrincipal.Controls.Add(this.cbxEstado);
            this.pnlPrincipal.Location = new System.Drawing.Point(-2, -3);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(551, 468);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // btnAceptar2
            // 
            this.btnAceptar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar2.Location = new System.Drawing.Point(312, 389);
            this.btnAceptar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar2.Name = "btnAceptar2";
            this.btnAceptar2.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar2.TabIndex = 16;
            this.btnAceptar2.Text = "Aceptar";
            this.btnAceptar2.UseVisualStyleBackColor = true;
            this.btnAceptar2.Click += new System.EventHandler(this.btnAceptar2_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(0, 0);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(100, 28);
            this.btnAtras.TabIndex = 15;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIdentificacion.Location = new System.Drawing.Point(93, 186);
            this.lblIdentificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(124, 24);
            this.lblIdentificacion.TabIndex = 14;
            this.lblIdentificacion.Text = "Identificación:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblApellidos.Location = new System.Drawing.Point(93, 133);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(93, 24);
            this.lblApellidos.TabIndex = 13;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombres.Location = new System.Drawing.Point(93, 79);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(93, 24);
            this.lblNombres.TabIndex = 12;
            this.lblNombres.Text = "Nombres:";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(241, 186);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(185, 22);
            this.txtIdentificacion.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(241, 135);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(185, 22);
            this.txtApellido.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(241, 79);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 22);
            this.txtNombre.TabIndex = 9;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.Transparent;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGenero.Location = new System.Drawing.Point(93, 297);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(74, 24);
            this.lblGenero.TabIndex = 5;
            this.lblGenero.Text = "Genero";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.BackColor = System.Drawing.Color.Transparent;
            this.rbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.ForeColor = System.Drawing.SystemColors.Control;
            this.rbMasculino.Location = new System.Drawing.Point(367, 297);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(117, 28);
            this.rbMasculino.TabIndex = 4;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = false;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.BackColor = System.Drawing.Color.Transparent;
            this.rbFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemenino.ForeColor = System.Drawing.SystemColors.Control;
            this.rbFemenino.Location = new System.Drawing.Point(212, 297);
            this.rbFemenino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(118, 28);
            this.rbFemenino.TabIndex = 3;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEstado.Location = new System.Drawing.Point(93, 240);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(68, 24);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado";
            // 
            // cbxEstado
            // 
            this.cbxEstado.BackColor = System.Drawing.Color.Silver;
            this.cbxEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Suspendido"});
            this.cbxEstado.Location = new System.Drawing.Point(241, 240);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(129, 28);
            this.cbxEstado.TabIndex = 1;
            this.cbxEstado.Text = "Activo";
            // 
            // RegSindicalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 463);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegSindicalista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAceptar2;
    }
}

