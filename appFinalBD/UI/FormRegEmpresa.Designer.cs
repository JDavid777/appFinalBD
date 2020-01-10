namespace appFinalBD.UI
{
    partial class FormRegEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegEmpresa));
            this.pnlEmpresa = new System.Windows.Forms.Panel();
            this.btnAgregarEMP = new System.Windows.Forms.Button();
            this.btnAtrasEMP = new System.Windows.Forms.Button();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.txtNombreEmp = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbNit = new System.Windows.Forms.Label();
            this.pnlEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEmpresa
            // 
            this.pnlEmpresa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEmpresa.BackgroundImage")));
            this.pnlEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEmpresa.Controls.Add(this.btnAgregarEMP);
            this.pnlEmpresa.Controls.Add(this.btnAtrasEMP);
            this.pnlEmpresa.Controls.Add(this.txtNit);
            this.pnlEmpresa.Controls.Add(this.txtNombreEmp);
            this.pnlEmpresa.Controls.Add(this.lbNombre);
            this.pnlEmpresa.Controls.Add(this.lbNit);
            this.pnlEmpresa.Location = new System.Drawing.Point(0, 0);
            this.pnlEmpresa.Name = "pnlEmpresa";
            this.pnlEmpresa.Size = new System.Drawing.Size(410, 376);
            this.pnlEmpresa.TabIndex = 0;
            // 
            // btnAgregarEMP
            // 
            this.btnAgregarEMP.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEMP.Location = new System.Drawing.Point(273, 298);
            this.btnAgregarEMP.Name = "btnAgregarEMP";
            this.btnAgregarEMP.Size = new System.Drawing.Size(75, 28);
            this.btnAgregarEMP.TabIndex = 5;
            this.btnAgregarEMP.Text = "Agregar";
            this.btnAgregarEMP.UseVisualStyleBackColor = true;
            this.btnAgregarEMP.Click += new System.EventHandler(this.btnAgregarEMP_Click);
            // 
            // btnAtrasEMP
            // 
            this.btnAtrasEMP.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrasEMP.Location = new System.Drawing.Point(0, 0);
            this.btnAtrasEMP.Name = "btnAtrasEMP";
            this.btnAtrasEMP.Size = new System.Drawing.Size(75, 23);
            this.btnAtrasEMP.TabIndex = 4;
            this.btnAtrasEMP.Text = "Atras";
            this.btnAtrasEMP.UseVisualStyleBackColor = true;
            this.btnAtrasEMP.Click += new System.EventHandler(this.btnAtrasEMP_Click);
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(77, 110);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(156, 20);
            this.txtNit.TabIndex = 3;
            // 
            // txtNombreEmp
            // 
            this.txtNombreEmp.Location = new System.Drawing.Point(77, 208);
            this.txtNombreEmp.Name = "txtNombreEmp";
            this.txtNombreEmp.Size = new System.Drawing.Size(156, 20);
            this.txtNombreEmp.TabIndex = 2;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lbNombre.Location = new System.Drawing.Point(74, 175);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(58, 18);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // lbNit
            // 
            this.lbNit.AutoSize = true;
            this.lbNit.BackColor = System.Drawing.Color.Transparent;
            this.lbNit.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNit.ForeColor = System.Drawing.SystemColors.Control;
            this.lbNit.Location = new System.Drawing.Point(74, 72);
            this.lbNit.Name = "lbNit";
            this.lbNit.Size = new System.Drawing.Size(26, 18);
            this.lbNit.TabIndex = 0;
            this.lbNit.Text = "Nit";
            // 
            // FormRegEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 376);
            this.Controls.Add(this.pnlEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegEmpresa";
            this.pnlEmpresa.ResumeLayout(false);
            this.pnlEmpresa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmpresa;
        private System.Windows.Forms.Button btnAgregarEMP;
        private System.Windows.Forms.Button btnAtrasEMP;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.TextBox txtNombreEmp;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbNit;
    }
}