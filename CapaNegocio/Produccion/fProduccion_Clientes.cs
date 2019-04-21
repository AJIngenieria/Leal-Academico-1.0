using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fProduccion_Clientes
    {
        public static string Guardar_DatosBasicos
            (
                int idempleado, string cliente, string documento,
                string pais, string ciudad, string telefono, string movil, string email, string direccion,
                int auto, int estado
            )
        {
            Conexion_Produccion_Clientes Obj = new Conexion_Produccion_Clientes();
            Obj.Idempleado = idempleado;
            Obj.Cliente = cliente;
            Obj.Documento = documento;
            Obj.Pais = pais;
            Obj.Ciudad = ciudad;
            Obj.Movil = movil;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Direccion = direccion;

            Obj.Estado = estado;
            Obj.Auto = auto;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static DataTable Buscar_Cliente(string filtro)
        {
            Conexion_Produccion_Clientes Obj = new Conexion_Produccion_Clientes();
            Obj.Filtro = filtro;
            return Obj.Buscar_Cliente(Obj);
        }

        public static DataTable CodigoID_Solicitud(string filtro)
        {
            Conexion_Produccion_Clientes Obj = new Conexion_Produccion_Clientes();
            Obj.Filtro = filtro;
            return Obj.CodigoID_Solicitud(Obj);
        }

    }
}
