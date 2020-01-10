using appFinalBD.datos;
using System.Data;

namespace appFinalBD.logica
{
    class Logica
    {
        Datos datos = new Datos();

        #region Registro
        public int registrarSindicalista(string parNombre, string parApellidos, int parIdentificacion, string parGenero, string parEstado)
        {
            string consulta = "insert into Sindicalista values (" + parIdentificacion + ",'" + parNombre + "','" + parApellidos + "','" + parEstado + "','" + parGenero + "')";
            int resultado = datos.ejecutarDML(consulta);
            return resultado;
        }

        public int registrarSindicato(int parId, int parIdEmpresa, string parNombre, string parFecha)
        {
            string consulta = "insert into Sindicato values (" + parId + "," + parIdEmpresa + ",'" + parNombre + "','" + parFecha + "')";
            int resultado = datos.ejecutarDML(consulta);
            return resultado;

        }
        public int registrarEmpresa(int parNit, string parNombre)
        {
            string consulta = "insert into Empresa values (" + parNit + ",'" + parNombre + "')";
            int resultado = datos.ejecutarDML(consulta);
            return resultado;

        }
        public int registarAgremiacion(int parIdSindicato, int parIdSindicalista, string parFechaInicio,string parFechaFin)
        {
            string consulta = "insert into agremia values (" + parIdSindicato + "," + parIdSindicalista + ",'" + parFechaInicio + "','"+parFechaFin+"')";
            int resultado = datos.ejecutarDML(consulta);
            return resultado;

        }
        #endregion
        #region Actualizacion
        public int actualizarSindicalista(string parNombre, string parApellidos, int parIdentificacion, string parGenero, string parEstado, int parNuevaIdentificacion)
        {
            string consulta = "UPDATE Sindicalista SET sinNombre = '" + parNombre + "' WHERE sinid = " + parIdentificacion + ";" +
                              "UPDATE Sindicalista SET sinApellido = '" + parApellidos + "' WHERE sinid = " + parIdentificacion + ";" +
                              "UPDATE Sindicalista SET sinGenero = '" + parGenero + "' WHERE sinid = " + parIdentificacion + ";" +
                                "UPDATE Sindicalista SET sinEstado = '" + parEstado + "' WHERE sinid = " + parIdentificacion + ";" +
                              "UPDATE Sindicalista SET sinid = " + parNuevaIdentificacion + " WHERE sinid = " + parIdentificacion + ";";

            int resultado = datos.ejecutarDML(consulta);
            return resultado;
        }

        public int actualizarSindicato(int parId, int parIdEmpresa, string parNombre, string parFecha, int parNuevoId)
        {

            string consulta = "UPDATE Sindicato SET Nombre = '" + parNombre + "' WHERE noRegistrosind = " + parId + ";" +
                              "UPDATE Sindicato set empNit='" + parIdEmpresa + "'WHERE noRegistrosind =" + parId + ";" +
                              "UPDATE Sindicato set fechaFundacion='" + parFecha + "'WHERE noRegistrosind =" + parId + ";" +
                              "UPDATE Sindicato SET noRegistrosind = " + parNuevoId + " WHERE noRegistrosind = " + parId + ";";

            int resultado = datos.ejecutarDML(consulta);
            return resultado;

        }

        private int actualizarAgremiacion(int id, string fechainicio, string fechafin,bool sindicalista)
        {
            string consulta;
            if (sindicalista)
            {
                consulta ="update agremia set fechainicio= "+fechainicio+";"+
                        "update agremia set fechafin= " + fechafin + ";"+
                            "update agremia set sinid = '" +id+"' where sinid="+id+";";
            }
            else
            {
                consulta = "update agremia set fechainicio= " + fechainicio + ";" +
                       "update agremia set fechafin= " + fechafin + ";" +
                           "update agremia set noregistrosind = '" + id + "' where noregistrosind=" + id + ";";
            }
            int resultado = datos.ejecutarDML(consulta);
            return resultado;
        }
        #endregion
        #region Eliminacion
        public int eliminarSindicalista(int parId)
        {
            eliminarAgremiacion(parId,false);
            string consulta = "delete from sindicalista where sinId =" + parId;
            int resultado = datos.ejecutarDML(consulta);
            return resultado;
        }

        public int eliminarSindicato(int parId)
        {
            eliminarAgremiacion(parId,true);
            string consulta = "delete from Sindicato where noregistrosind =" + parId;
            int resultado = datos.ejecutarDML(consulta);
            return resultado;

        }
        public int eliminarEmpresa(int parId)
        {
            string consulta = "delete from Empresa where empNit =" + parId;
            int resultado = datos.ejecutarDML(consulta);
            return resultado;

        }
        public int eliminarAgremiacion(int parId, bool sindicato)
        {
            string consulta;
            if (sindicato)
            {
                consulta = "delete from agremia where noregistrosind =" + parId;
            }
            else
            {
                consulta = "delete from agremia where sinid =" + parId;
            }
          
            int resultado = datos.ejecutarDML(consulta);
            return resultado;

        }
        #endregion
        #region Consultas
        public DataSet consultarAgremiaciones()
        {
            string consulta = "select sindicalista.sinid as Identificacion,sindicalista.sinNombre as Nombres,sindicalista.sinApellido as Apellidos,sindicalista.singenero as Genero,sindicato.noregistrosind as No_Registro,sindicato.nombre as Sindicato," +
                              "sindicato.fechafundacion,sindicato.empnit as Nit_Empresa,fechainicio,fechafin from " +
                              "sindicalista inner join AGREMIA on SINDICALISTA.SINID=agremia.sinid inner join sindicato on sindicato.NOREGISTROSIND=agremia.NOREGISTROSIND";
            return datos.ejecutaSELECT(consulta);
        }
        public DataSet consultarAgremiacion(string parFechaInicioAgremiacion)
        {
            string consulta = "select empresa.EMPNOMBRE as Nombre_Empresa,SINDICATO.NOREGISTROSIND as Numero_Registro_Sindical,SINDICATO.NOMBRE as Nombre_Sindicato,SINDICALISTA.SINID as ID_Sindicalista,SINDICALISTA.SINNOMBRE as Nombre_Sindicalista,SINDICALISTA.SINAPELLIDO as Apellido_Sindicalista  from agremia " +
                              "inner join sindicalista on sindicalista.sinid = agremia.sinid " +
                              "inner join sindicato on sindicato.noregistrosind = agremia.noregistrosind inner join EMPRESA on SINDICATO.EMPNIT=EMPRESA.EMPNIT " +
                              "where fechaInicio=" + "'" + parFechaInicioAgremiacion + "'";
            return datos.ejecutaSELECT(consulta);
        }
        public DataSet consultarSindicalistasSuspendidos()
        {
            string consulta = "select count (*) as numeroSindicalistasSuspendidos from (select sindicalista.sinid from sindicalista inner join agremia " +
                              "on sindicalista.sinid=agremia.sinid " +
                              "where agremia.fechafin<=getdate() " +
                              "and sindicalista.sinEstado ='Suspendido') as r";
            return datos.ejecutaSELECT(consulta);
        }
        public DataSet consultarSindicalistas()
        {
            string consulta = "select sinid as Identificacion, sinnombre as Nombres, sinApellido as Apellidos, sinestado Estado, singenero as Genero from sindicalista";
            return datos.ejecutaSELECT(consulta);
        }
        public DataSet consultarSindicato()
        {
            string consulta = "select noregistrosind as Numero_Registro,empnit as Nit_Empresa,"+
                "nombre as Nombre, fechafundacion as Fundacion  from sindicato";
            return datos.ejecutaSELECT(consulta);
        } 
        public DataSet consultarEmpresas()
        {
            string consulta = "select empnit as Nit, empnombre as Nombre from empresa";
            return datos.ejecutaSELECT(consulta);
        }
        #endregion
    }
}
