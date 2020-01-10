using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppZoo.logica;
using System.Windows.Forms;

namespace AppZoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Creo un objeto animal
        Animal objAnimal = new Animal();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*paso 1: capturar en variables la info ingresada desde la interfaz*/
            int codigo;
            string nombre, genero="", pais;
            codigo = int.Parse(txtCodigo.Text);
            nombre = txtNombre.Text;
            if (rbHembra.Checked)
            {
                genero = rbHembra.Text;
            }
            else if (rbMacho.Checked)
            {
                genero = rbMacho.Text;
            }
            pais = cbxPais.SelectedItem.ToString();

            //paso 2: enviar las variables a la capa de la logica

            bool resultado = objAnimal.insertarAnimal(codigo, nombre, genero, pais);
            if (resultado)
            {
                MessageBox.Show("Animal registrado", "Mensaje", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Animal no registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
