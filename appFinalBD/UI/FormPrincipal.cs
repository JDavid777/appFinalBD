using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appFinalBD.logica;

namespace appFinalBD.UI
{
    public partial class FormPrincipal : Form
    {
        Logica admin = new Logica();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rbSindicalista.Checked)
            {
                if ((string)cbxTransaccion.SelectedItem == "Registrar")
                {
                    RegSindicalista registrarSindicalista = new RegSindicalista();
                    this.Hide();
                    registrarSindicalista.ShowDialog();
                    this.Show();

                }
                if ((string)cbxTransaccion.SelectedItem == "Actualizar")
                {
                    ActSindicalista actSindicalista = new ActSindicalista();
                    this.Hide();
                    actSindicalista.ShowDialog();
                    this.Show();

                }
                if ((string)cbxTransaccion.SelectedItem == "Eliminar")
                {
                    
                    FormEliminacion delete = new FormEliminacion();
                    delete.infoTextBox("Sindicalista");
                    this.Hide();
                    delete.ShowDialog();
                    this.Show();
                }
                if ((string)cbxTransaccion.SelectedItem == "Consultar")
                {
                    dtgImpreciones.DataSource= admin.consultarSindicalistas();
                    dtgImpreciones.DataMember = "Resultado Datos";
                }
            }
            if (rbSindicato.Checked)
            {
                if ((string)cbxTransaccion.SelectedItem == "Registrar")
                {
                    FormRegSindicato regSindicato = new FormRegSindicato();
                    this.Hide();
                    regSindicato.ShowDialog();
                    this.Show();

                }
                if ((string)cbxTransaccion.SelectedItem == "Actualizar")
                {
                    FormActSindicato actSindicato = new FormActSindicato();
                    this.Hide();
                    actSindicato.ShowDialog();
                    this.Show();

                }
                if ((string)cbxTransaccion.SelectedItem == "Eliminar")
                {
                    FormEliminacion delete = new FormEliminacion();
                    delete.infoTextBox("Sindicato");

                    this.Hide();
                    delete.ShowDialog();
                    this.Show();
                }
                if ((string)cbxTransaccion.SelectedItem == "Consultar")
                {
                    dtgImpreciones.DataSource = admin.consultarSindicato();
                    dtgImpreciones.DataMember = "Resultado Datos";
                }

            }
            if (rbEmpresa.Checked)
            {
                if ((string)cbxTransaccion.SelectedItem == "Registrar")
                {
                    FormRegEmpresa regEmpresa = new FormRegEmpresa();
                    this.Hide();
                    regEmpresa.ShowDialog();
                    this.Show();

                }
                if ((string)cbxTransaccion.SelectedItem == "Consultar")
                {
                    dtgImpreciones.DataSource = admin.consultarEmpresas();
                    dtgImpreciones.DataMember = "Resultado Datos";
                }
                else
                {
                    MessageBox.Show("Lo sentimos usted no tiene permisos para realizar esa accion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            if (rbAgremiacion.Checked)
            {
                if ((string)cbxTransaccion.SelectedItem == "Registrar")
                {
                    FormRegistarAGR agr = new FormRegistarAGR();
                    this.Hide();
                    agr.ShowDialog();
                    this.Show();
                }
                else if ((string)cbxTransaccion.SelectedItem=="Consultar")
                {
                    dtgImpreciones.DataSource = admin.consultarAgremiaciones();
                    dtgImpreciones.DataMember = "Resultado Datos";
                }
                else
                {
                    MessageBox.Show("Lo sentimos usted no tiene permisos para realizar esa accion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
            }
        }

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFechaBuscada.Value;
           dtgImpreciones.DataSource= admin.consultarAgremiacion(fecha.ToString("MM-dd-yyyy"));
            dtgImpreciones.DataMember = "Resultado Datos";

        }

        private void btnConsultarSuspendidos_Click(object sender, EventArgs e)
        {
            try
            {
                dtgImpreciones.DataSource = admin.consultarSindicalistasSuspendidos();
                dtgImpreciones.DataMember = "Resultado Datos";
            }
            catch (Exception)
            {
            }
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtgImpreciones.DataSource = null;
        }
    }
}
