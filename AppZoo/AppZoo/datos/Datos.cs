using System;
using System.Data.SqlClient;
using System.Data;
namespace AppZoo.datos
{
    class Datos
    {
        //paso1: se crea la cadena de conexion 
        string cadenaConexion = @"Data Source=ST-MJ03LSRE\SQLEXPRESS;Initial Catalog=DBZoo;Integrated Security=True";
        public int ejecutarDML(string consulta)
        {
            int filasAfectadas;
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
        //permite representar en memoria cache grandes cadenas de datos
        public DataSet  ejecutaSELECT( string consulta)
        {
            //paso1:creo el data set vacio

            DataSet miDS = new DataSet();
            //paso2: creo un adaptador
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cadenaConexion);
            
        }
    }
}
