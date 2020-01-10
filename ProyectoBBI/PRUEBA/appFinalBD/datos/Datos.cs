using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace appFinalBD.datos
{
    class Datos
    {
        //paso1: se crea la cadena de conexion 
        string cadenaConexion = @"Data Source=DAVID;Initial Catalog=proyectoFinal;Integrated Security=True";
        public int ejecutarDML(string consulta)
        {
            int filasAfectadas=0;
            try
            {
               
                //paso1: creo una conexion 
                SqlConnection conexion = new SqlConnection(this.cadenaConexion);
                //paso2: creo un comando
                SqlCommand comando = new SqlCommand(consulta, conexion);
                //paso3: abrir conexion
                conexion.Open();
                //paso4: ejecuto el comando y devuelve el numero de filas afectadas
                // ejecuta algo que no es un select
                filasAfectadas = comando.ExecuteNonQuery();
                //paso5: cerrar la conexion 
                conexion.Close();
                //paso6: retornar las filas afectadas
                return filasAfectadas;
            }
            catch (Exception e)
            {
                //MessageBox.Show("La operacion no termino correctamente: "+e, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return filasAfectadas;
            }
           
        }
       // permite representar en memoria cache grandes cadenas de datos
        public DataSet ejecutaSELECT(string consulta)
        {
            //paso1:creo el data set vacio

            DataSet miDS = new DataSet();
            try
            {
                //paso2: creo un adaptador
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cadenaConexion);
                adaptador.Fill(miDS, "Resultado Datos");
                return miDS;
            }
            catch (Exception)
            {
                 MessageBox.Show("La operacion no termino correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return miDS;
            }
          
            
          

        }
    }
}

