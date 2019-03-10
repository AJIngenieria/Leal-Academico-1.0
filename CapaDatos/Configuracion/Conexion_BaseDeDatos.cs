using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion_BaseDeDatos
    {

        //Conexion Principal de la Base de Datos
        public static string Cn = Properties.Settings.Default.Cn;

        //Conexion Para la Base de Datos de Seguridad
        public static string Seguridad = Properties.Settings.Default.Seguridad;

    }
}
