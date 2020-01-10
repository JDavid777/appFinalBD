using System;
using System.Windows.Forms;
using appFinalBD.logica;
namespace appFinalBD.UI
{
    public partial class FormRegSindicato : Form
    {
        Logica admin = new Logica();
        public FormRegSindicato()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int numRegistro, nit;
            string Nombre;
            DateTime fecha;
            try
            {
                if (!string.IsNullOrEmpty(txtNit.Text) && int.Parse(txtNit.Text) > 0)
                {
                    if (!string.IsNullOrEmpty(txtNombre.Text))
                    {
                        if (!string.IsNullOrEmpty(txtNoRegistro.Text) && int.Parse(txtNoRegistro.Text) > 0)
                        {
                            nit = int.Parse(txtNit.Text);
                            numRegistro = int.Parse(txtNoRegistro.Text);
                            Nombre = txtNombre.Text;
                            fecha = dtpFecha.Value;
                           if( admin.registrarSindicato(numRegistro, nit, Nombre, fecha.ToString("MM-dd-yyyy"))>0)
                            MessageBox.Show("Sindicalista registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            MessageBox.Show("Sindicalista no registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Entrada Incorrecta.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
                          
        catch(Exception)
            {
                MessageBox.Show("Entrada Incorrecta.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
           
        }

       
    }

