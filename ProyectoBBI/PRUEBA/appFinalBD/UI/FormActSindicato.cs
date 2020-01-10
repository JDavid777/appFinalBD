using appFinalBD.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFinalBD.UI
{
    public partial class FormActSindicato : Form
    {
        Logica admin = new Logica();
        public FormActSindicato()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(txtNombre.Text) && int.Parse(txtNoRegistro.Text) > 0 && !string.IsNullOrEmpty(txtNoRegistro.Text) )
                {

                    if (int.Parse(txtNuevoIdEmpresa.Text) > 0 && !string.IsNullOrEmpty(txtNuevoIdEmpresa.Text))
                    {
                        if (int.Parse(txtNuevoNoRegistro.Text) > 0 && !string.IsNullOrEmpty(txtNuevoNoRegistro.Text))
                        {

                            int noRegistro, nuevoIdEmpresa;
                            string nombre;
                            DateTime fecha = dtDate.Value;
                            int nuevoId = int.Parse(txtNuevoNoRegistro.Text);
                            nombre = txtNombre.Text;
                            nuevoIdEmpresa = int.Parse(txtNuevoIdEmpresa.Text);
                            noRegistro = int.Parse(txtNoRegistro.Text);
                            if (admin.actualizarSindicato(noRegistro, nuevoIdEmpresa, nombre, fecha.ToString("MM-dd-yyyy"), nuevoId) > 0)
                            {
                                MessageBox.Show("Sindicato Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtNombre.Clear();
                                txtNoRegistro.Clear();
                                txtNuevoIdEmpresa.Clear();
                                txtNuevoNoRegistro.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Sindicato no actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else { MessageBox.Show("Datos Incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else { MessageBox.Show("Datos Incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("Datos Incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            catch (Exception)
            {
                MessageBox.Show("Datos Incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
