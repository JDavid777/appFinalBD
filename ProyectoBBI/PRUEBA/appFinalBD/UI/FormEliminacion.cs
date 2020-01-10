using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using appFinalBD.logica;
using appFinalBD.UI;
using System.Windows.Forms;

namespace appFinalBD
{
    public partial class FormEliminacion : Form
    {
        private string valor;
        Logica admin = new Logica();
        public FormEliminacion()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void infoTextBox(string valor)
        {
            this.valor = valor;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(txtID.Text) && int.Parse(txtID.Text) > 0)
                {

                    int identificacion;
                    identificacion = int.Parse(txtID.Text);
                    if (valor == "Sindicalista")
                    {
                        if (admin.eliminarSindicalista(identificacion) > 0)
                        {
                            MessageBox.Show("Eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Eliminar: Id no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (valor == "Sindicato")
                    {
                        if (admin.eliminarSindicato(identificacion) > 0)
                        {
                            MessageBox.Show("Eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtID.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Eliminar: Id no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (valor == "Empresa")
                    {
                       //
                        //if (admin.eliminarEmpresa(identificacion) > 0)
                        //{
                        //    MessageBox.Show("Eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                        //else
                        //{
                        //    MessageBox.Show("No se pudo Eliminar: Nit no encontrado o la empresa esta tiene sindicatos asociados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}

                    }
                }
                else { MessageBox.Show("No se pudo Eliminar: Id no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo Eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
