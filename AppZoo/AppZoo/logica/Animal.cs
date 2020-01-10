using System;
using AppZoo.datos;

namespace AppZoo.logica
{
    class Animal
    {
        //Crear un objeto de la capa de datos
       Datos objDatos = new Datos();
    
        public bool insertarAnimal(int codigo, string nombre, string genero, string pais)
        {
            // se construye la consulta para insertar
            string consulta = "insert into Animal(aniCodigo,aniNombre,aniGenero,aniPais) values (" + codigo + ",'" + nombre + "','" + genero + "','" + pais + "')";
            //se envia la consulta a la capa de datos
          
            int resultado = objDatos.ejecutarDML(consulta);
            return resultado >0 ? true : false;
        }
    }
}
