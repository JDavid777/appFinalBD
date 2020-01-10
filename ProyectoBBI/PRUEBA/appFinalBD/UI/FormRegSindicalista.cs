using System;
using appFinalBD.logica;
using System.Windows.Forms;

namespace appFinalBD
{
    public partial class RegSindicalista : Form
    {
        Logica admin = new Logica();
        public RegSindicalista()
        {
            InitializeComponent();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAceptar2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIdentificacion.Text) && int.Parse(txtIdentificacion.Text) > 0)
                {
                    if (!string.IsNullOrEmpty(txtNombre.Text))
                    {
                        if (!string.IsNullOrEmpty(txtApellido.Text))
                        {
                            int identificacion;
                            string nombre, apellido, genero = "", estado;
                            if (rbFemenino.Checked||rbMasculino.Checked)
                            {
                                identificacion = int.Parse(txtIdentificacion.Text);
                                nombre = txtNombre.Text;
                                apellido = txtApellido.Text;
                                estado = cbxEstado.SelectedItem.ToString();
                                if (rbFemenino.Checked)
                                {
                                    genero = "f";
                                }
                                else if (rbMasculino.Checked)
                                {
                                    genero = "m";
                                }
                                if (admin.registrarSindicalista(nombre, apellido, identificacion, genero, estado) > 0)
                                {
                                    MessageBox.Show("Sindicalista registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtApellido.Clear();
                                    txtIdentificacion.Clear();
                                    txtNombre.Clear();

                                }
                                else
                                {
                                    MessageBox.Show("Sindicalista no registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch(Exception)
            {
                MessageBox.Show("Entrada Incorrecta.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
