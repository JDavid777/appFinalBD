using System;
using System.Windows.Forms;
using appFinalBD.logica;
namespace appFinalBD.UI
{
    public partial class FormRegistarAGR : Form
    {
        Logica admin = new Logica();
        
        public FormRegistarAGR()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIDSindicalista.Text) && int.Parse(txtIDSindicalista.Text) > 0)
                {
                    if (!string.IsNullOrEmpty(txtNORegistro.Text) && int.Parse(txtNORegistro.Text) > 0)
                    {
                            int idSindicalista, idSindicato;
                            idSindicalista = int.Parse(txtIDSindicalista.Text);
                            idSindicato = int.Parse(txtNORegistro.Text);
                            DateTime fechainicio, fechafin;
                            fechainicio = dtpFechaInicio.Value;
                            fechafin = dtPFechaFin.Value;
                        if (admin.registarAgremiacion(idSindicato, idSindicalista, fechainicio.ToString("MM-dd-yyyy"), fechafin.ToString("MM-dd-yyyy"))>0)
                        {
                            MessageBox.Show("Agremiacion registara correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtIDSindicalista.Clear();
                            txtNORegistro.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible registrar agremiacion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                MessageBox.Show("Datos incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
