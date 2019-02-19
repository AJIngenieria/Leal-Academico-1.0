using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fSistema_Estados
    {
        public static string Guardar_DatosBasicos
            (//Datos Basicos
            int auto, string estado, string descripcion)
        {
            Conexion_Sistema_Estados Obj = new Conexion_Sistema_Estados();
            //Datos Basicos
            
            Obj.Estado = estado;
            Obj.Descripcion = descripcion;
            Obj.Auto = auto;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static DataTable Mostrar()
        {
            return new Conexion_Sistema_Estados().Mostrar();
        }
    }
}
