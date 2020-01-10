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

            if (!(string.IsNullOrEmpty(txtNit.Text)))
            {
                nombre = txtNombreEmp.Text;
                nit = int.Parse(txtNit.Text);
                admin.registrarEmpresa(nit, nombre);
            }
            else
            {
                MessageBox.Show("Datos ingresados incorrectos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}
