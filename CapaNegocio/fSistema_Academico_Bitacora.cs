using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fSistema_Academico_Bitacora
    {
        public static string Guardar_DatosBasicos
            (//Datos Basicos
            string auto, string bitacora)
        {
            Conexion_Sistema_Bitacora Obj = new Conexion_Sistema_Bitacora();
            //Datos Basicos
            Obj.Auto = auto;
            Obj.Bitacora = bitacora;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static DataTable Mostrar()
        {
            return new Conexion_Sistema_Bitacora().Mostrar();
        }

    }
}
