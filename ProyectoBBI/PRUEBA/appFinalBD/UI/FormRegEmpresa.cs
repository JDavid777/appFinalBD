using System;
using System.Windows.Forms;
using appFinalBD.logica;

namespace appFinalBD.UI
{
    public partial class FormRegEmpresa : Form
    {
        Logica admin = new Logica();
        public FormRegEmpresa()
        {
            InitializeComponent();
        }

        private void btnAtrasEMP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarEMP_Click(object sender, EventArgs e)
        {
            int nit;
            string nombre;
            try
            {
                if (!(string.IsNullOrEmpty(txtNit.Text)) && int.Parse(txtNit.Text) > 0)
                {
                    if (!string.IsNullOrEmpty(txtNombreEmp.Text))
                    {
                        nombre = txtNombreEmp.Text;
                        nit = int.Parse(txtNit.Text);
                       
                        if (admin.registrarEmpresa(nit, nombre)>0)
                        {
                            MessageBox.Show("Empresa registrada corretamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNombreEmp.Clear();
                            txtNit.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido registrar la empresa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                      

                    }
                    else
                    {
                        MessageBox.Show("Datos ingresados incorrectos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
                else
                {
                    MessageBox.Show("Datos ingresados incorrectos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Datos ingresados incorrectos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
          
        }
    }
}
