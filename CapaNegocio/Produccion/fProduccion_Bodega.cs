using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fProduccion_Bodega
    {
        public static string Guardar_DatosBasicos
            (
            int idempleado, int idsucurzal, string codigoid, string descripcion, string responsable, 
            string ciudad, string zona, string direccion, string telefono, 
            
            int estado, string auto
            )
        {
            Conexion_Produccion_Bodega Obj = new Conexion_Produccion_Bodega();
            Obj.Idempleados = idempleado;

            Obj.Auto = auto;
            Obj.Estado = estado;
            Obj.CodigoID = codigoid;
            Obj.Descripcion = descripcion;
            Obj.Responsable = responsable;
            Obj.Ciudad = ciudad;
            Obj.Zona = zona;
            Obj.Idsucurzal = idsucurzal;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            
            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static DataTable Buscar_Bodega(string filtro)
        {
            Conexion_Produccion_Bodega Obj = new Conexion_Produccion_Bodega();
            Obj.Filtro = filtro;
            return Obj.Buscar_Bodega(Obj);
        }

        public static DataTable CodigoID_Solicitud(string filtro)
        {
            Conexion_Produccion_Bodega Obj = new Conexion_Produccion_Bodega();
            Obj.Filtro = filtro;
            return Obj.CodigoID_Solicitud(Obj);
        }

    }
}
