using System;
using appFinalBD.logica;
using System.Windows.Forms;

namespace appFinalBD
{
    public partial class ActSindicalista : Form
    {
        Logica admin = new Logica();
        public ActSindicalista()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNuevoDocumento.Text) && int.Parse(txtNuevoDocumento.Text) > 0)
                {
                    if (!string.IsNullOrEmpty(txtNombres.Text))
                    {
                        if (!string.IsNullOrEmpty(txtApellidos.Text))
                        {
                            int identificacion,idnuevo;
                            string nombre, apellido, genero = "", estado;
                            if (rbFemenino.Checked || rbMasculino.Checked)
                            { 
                                nombre = txtNombres.Text;
                                apellido = txtApellidos.Text;
                                estado = cbxEstado.SelectedItem.ToString();
                                identificacion = int.Parse(txtIdActual.Text);
                                idnuevo = int.Parse(txtNuevoDocumento.Text);

                                if (rbFemenino.Checked)
                                {
                                    genero = "f";
                                }
                                else
                                {
                                    genero = "m";
                                }
                                if (admin.actualizarSindicalista(nombre, apellido, identificacion, genero, estado, idnuevo) > 0)
                                {
                                    MessageBox.Show("Sindicalista Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Sindicalista no actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Seleccione un genero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Es necesario que llene todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Es necesario que llene todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Es necesario que llene todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Entrada Incorrecta.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }
    }
}
