using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fConfiguracion_CodigoID
    {
        public static DataTable Auto_CodigoID_Alumno()
        {
            return new Conexion_Configuracion_CodigoID().AutoCompletar_Alumno();
        }

        public static DataTable Auto_CodigoID_Empleado()
        {
            return new Conexion_Configuracion_CodigoID().AutoCompletar_Empleado();
        }

    }
}
