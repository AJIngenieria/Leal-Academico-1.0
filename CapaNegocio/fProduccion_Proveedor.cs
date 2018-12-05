using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fProduccion_Proveedor
    {
        public static string Guardar_DatosBasicos
            (//Datos Basicos
            int idempleado, string codigoid, string proveedor, string tipo, string area, string documento, string identificacion, int idestado,
            string titular, int idpais, int idciudad, string telefono, string movil, string direccion1, string direccion2, string email, DateTime inicio, byte[] foto,
            int auto)
        {
            Conexion_Produccion_Proveedor Obj = new Conexion_Produccion_Proveedor();

            //Datos Basicos
            Obj.Idempleado = idempleado;
            Obj.Auto = auto;

            Obj.Tipo = tipo;
            Obj.Area = area;
            Obj.Idestado = idestado;
            Obj.Proveedor = proveedor;
            Obj.CodigoID = codigoid;
            Obj.Documento = documento;
            Obj.Identificacion = identificacion;
            Obj.Titular = titular;
            Obj.Idpais = idpais;
            Obj.Idciudad = idciudad;
            Obj.Telefono = telefono;
            Obj.Movil = movil;
            Obj.Direccion1 = direccion1;
            Obj.Direccion2 = direccion2;
            Obj.Email = email;
            Obj.Inicio = inicio;
            Obj.Foto = foto;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static DataTable Mostrar()
        {
            return new Conexion_Produccion_Proveedor().Mostrar();
        }

        public static DataTable Examinar_PorCodigo(string filtro)
        {
            Conexion_Produccion_Proveedor Obj = new Conexion_Produccion_Proveedor();
            Obj.Filtro = filtro;
            return Obj.Examinar_PorCodigo(Obj);
        }

        public static DataTable Examinar_PorIdentificacion(string filtro)
        {
            Conexion_Produccion_Proveedor Obj = new Conexion_Produccion_Proveedor();
            Obj.Filtro = filtro;
            return Obj.Examinar_PorIdentificacion(Obj);
        }

        public static DataTable Examinar_PorNombre(string filtro)
        {
            Conexion_Produccion_Proveedor Obj = new Conexion_Produccion_Proveedor();
            Obj.Filtro = filtro;
            return Obj.Examinar_PorNombre(Obj);
        }
    }
}
