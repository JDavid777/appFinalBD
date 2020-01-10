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
            int idSindicalista, idSindicato;
            idSindicalista = int.Parse(txtIDSindicalista.Text);
            idSindicato = int.Parse(txtNORegistro.Text);
            DateTime fechainicio, fechafin;
            fechainicio = dtpFechaInicio.Value;
            fechafin = dtPFechaFin.Value;

            admin.registarAgremiacion(idSindicato, idSindicalista, fechainicio.ToString("MM-dd-yyyy"), fechafin.ToString("MM-dd-yyyy"));
        }
    }
}
