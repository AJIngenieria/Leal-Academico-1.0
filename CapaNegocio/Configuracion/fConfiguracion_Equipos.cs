using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio
{
    public class fConfiguracion_Equipos
    {
        public static string Guardar_DatosBasicos
            
            (
                //Campos Generales
                string equipo, string hdd, string seguridad,

                //Campo de Validacion
                string auto
            )
        {
            Conexion_Configuracion_Equipos Obj = new Conexion_Configuracion_Equipos();

            //Campos Generales
            Obj.Equipo = equipo;
            Obj.HDD = hdd;
            Obj.Seguridad = seguridad;

            //Campo de Validacion
            Obj.Auto = auto;

            return Obj.Guardar_Equipo(Obj);
        }
    }
}
