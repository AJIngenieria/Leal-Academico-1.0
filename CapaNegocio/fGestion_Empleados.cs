using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fGestion_Empleados
    {
        //Método Insertar que llama al método Insertar de la clase DIngreso
        //de la CapaDatos
        public static string Guardar_DatosBasicos(int idrol, string codigoid,string estado, string empleado, string profesion, string identificacion, string documento, string expedicion, DateTime fechaexpedicion, string email, string telefono,
            string direccion, DateTime Fechadeingreso, DateTime fechadesalida)
        {
            Conexion_Gestion_Empleados Obj = new Conexion_Gestion_Empleados();
            Obj.Idrol = idrol;
            Obj.CodigoID = codigoid;
            Obj.Empleado = empleado;
            Obj.Profesion = profesion;
            Obj.Identificacion = identificacion;
            Obj.Documento = documento;
            Obj.Expedicion = expedicion;
            Obj.FechaExpedicion = fechaexpedicion;
            Obj.Email = email;
            Obj.Telefono = telefono;
            Obj.Estado = estado;
            Obj.Direccion = direccion;
            Obj.FechaDeIngreso = Fechadeingreso;
            Obj.Fechadesalida = fechadesalida;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static DataTable Mostrar_CodigoID()
        {
            return new Conexion_Gestion_Empleados().Mostrar_CodigoID();
        }

    }
}
