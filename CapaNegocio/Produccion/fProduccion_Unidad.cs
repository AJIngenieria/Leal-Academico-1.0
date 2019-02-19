using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fProduccion_Unidad
    {
        //Método Insertar que llama al método Insertar de la clase DIngreso
        //de la CapaDatos
        public static string Guardar_DatosBasicos(string auto,string unidad, string descripcion)
        {
            Conexion_Produccion_Unidad Obj = new Conexion_Produccion_Unidad();
            Obj.Auto = auto;
            Obj.Unidad = unidad;
            Obj.Descripcion = descripcion;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        //public static DataTable Mostrar_CodigoID()
        //{
        //    //return new Conexion_Gestion_Empleados().Mostrar_CodigoID();
        //}
    }
}
