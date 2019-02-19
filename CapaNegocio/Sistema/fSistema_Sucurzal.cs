using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fSistema_Sucurzal
    {
        public static string Guardar_DatosBasicos
            (//Datos Basicos
            string sucurzal, string ciudad,
            string descripcion, string auto
            )
        {
            Conexion_Sistema_Sucurzal Obj = new Conexion_Sistema_Sucurzal();
            //Datos Basicos
            Obj.Auto = auto;

            Obj.Sucurzal = sucurzal;
            Obj.Ciudad = ciudad;
            Obj.Descripcion = descripcion;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static DataTable Mostrar_Surcurzal()
        {
            return new Conexion_Sistema_Sucurzal().Mostrar_Surcurzal();
        }
    }
}
