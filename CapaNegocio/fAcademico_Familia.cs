using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fAcademico_Familia
    {
        public static string Guardar_DatosBasicos
            (//Datos Basicos
            string familia, string descripcion, string auto)
        {
            Conexion_Academico_Familia Obj = new Conexion_Academico_Familia();
            //Datos Basicos
            Obj.Auto = auto;
            Obj.Familia = familia;
            Obj.Descripcion = descripcion;

            return Obj.Guardar_DatosBasicos(Obj);
        }


        public static DataTable Buscar(String filtro)
        {
            Conexion_Academico_Familia Obj = new Conexion_Academico_Familia();
            Obj.Filtro = filtro;
            return Obj.Buscar(Obj);
        }

    }
}
