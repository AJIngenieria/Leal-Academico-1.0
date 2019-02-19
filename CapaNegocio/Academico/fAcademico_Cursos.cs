using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fAcademico_Cursos
    {
        public static string Guardar_DatosBasicos
            (//Datos Basicos
            string auto, string curso, string año, string estado, string descripcion)
        {
            Conexion_Academico_Cursos Obj = new Conexion_Academico_Cursos();
            //Datos Basicos
            Obj.Auto = auto;
            Obj.Curso = curso;
            Obj.Año = año;
            Obj.Estado = estado;
            Obj.Descripcion = descripcion;

            return Obj.Guardar_DatosBasicos(Obj);
        }
        
        public static DataTable Mostrar()
        {
            return new Conexion_Academico_Cursos().Mostrar();
        }

    }
}
