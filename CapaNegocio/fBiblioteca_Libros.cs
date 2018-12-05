using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio
{
    public class fBiblioteca_Libros
    {
        public static string Guardar_DatosBasicos
            (//Datos Basicos
            string auto, string Titulo, string SubTitulo, string Categoria, string Editorial, string Autor, DateTime Fecha, string Cantidad, string Serie)
        {
            Conexion_Biblioteca_Libros Obj = new Conexion_Biblioteca_Libros();
            //Datos Basicos
            Obj.Titulo = Titulo;
            Obj.SubTitulo = SubTitulo;
            Obj.Categoria = Categoria;
            Obj.Editorial = Editorial;
            Obj.Autor = Autor;
            Obj.Fecha = Fecha;
            Obj.Cantidad = Cantidad;
            Obj.Serie = Serie;

            Obj.Auto = auto;

            return Obj.Guardar_DatosBasicos(Obj);
        }
    }
}
