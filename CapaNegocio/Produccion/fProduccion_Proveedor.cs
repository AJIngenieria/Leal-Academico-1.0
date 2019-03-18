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

            int idempleado, string proveedor, string tipo, string area, string documento, string estado,
            string titular, string pais, string ciudad, string telefono, string movil, string direccion1, string direccion2, 
            string email, DateTime inicio, byte[] foto,

            int auto)
        {
            Conexion_Produccion_Proveedor Obj = new Conexion_Produccion_Proveedor();

            //Datos Basicos
            Obj.Idempleado = idempleado;
            Obj.Auto = auto;

            Obj.Tipo = tipo;
            Obj.Area = area;
            Obj.Estado = estado;
            Obj.Proveedor = proveedor;
            Obj.Documento = documento;
            Obj.Titular = titular;
            Obj.Pais = pais;
            Obj.Ciudad = ciudad;
            Obj.Telefono = telefono;
            Obj.Movil = movil;
            Obj.Direccion1 = direccion1;
            Obj.Direccion2 = direccion2;
            Obj.Email = email;
            Obj.Inicio = inicio;
            Obj.Foto = foto;

            return Obj.Guardar_DatosBasicos(Obj);
        }


        public static DataTable Buscar_Proveedor(string filtro)
        {
            Conexion_Produccion_Proveedor Obj = new Conexion_Produccion_Proveedor();
            Obj.Filtro = filtro;
            return Obj.Buscar_Proveedor(Obj);
        }

        public static DataTable Mostrar()
        {
            return new Conexion_Produccion_Proveedor().Mostrar();
        }

        //Método que se encarga de llamar al método Eliminar
        public static string Eliminar(int Idproveedor)
        {
            Conexion_Produccion_Proveedor Obj = new Conexion_Produccion_Proveedor();
            Obj.Idproveedor = Idproveedor;
            return Obj.Eliminar(Obj);
        }

        public static DataTable CodigoID_Solicitud(string filtro)
        {
            Conexion_Produccion_Proveedor Obj = new Conexion_Produccion_Proveedor();
            Obj.Filtro = filtro;
            return Obj.CodigoID_Solicitud(Obj);
        }

    }
}
