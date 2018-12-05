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
        public static string Guardar_DatosBasicos(int idempleado, string codigoid, string descripcion, string responsable, string ciudad, string zona,
            string sucurzal, string direccion1, string direccion2, string telefono, string movil, string propiedad, string mensualidad, string valor,

            string estado, string auto)
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
            Obj.Sucurzal = sucurzal;
            Obj.Direccion = direccion1;
            Obj.Direccion2 = direccion2;
            Obj.Movil = movil;
            Obj.Telefono = telefono;
            Obj.Propiedad = propiedad;
            Obj.Mensualidad = mensualidad;
            Obj.Valor = valor;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static DataTable Examinar_PorCodigo(string filtro)
        {
            Conexion_Produccion_Bodega Obj = new Conexion_Produccion_Bodega();
            Obj.Filtro = filtro;
            return Obj.Examinar_PorCodigo(Obj);
        }

        public static DataTable Examinar_PorNombre(string filtro)
        {
            Conexion_Produccion_Bodega Obj = new Conexion_Produccion_Bodega();
            Obj.Filtro = filtro;
            return Obj.Examinar_PorNombre(Obj);
        }

        public static DataTable Examinar_PorSucurzal(string filtro)
        {
            Conexion_Produccion_Bodega Obj = new Conexion_Produccion_Bodega();
            Obj.Filtro = filtro;
            return Obj.Examinar_PorSucurzal(Obj);
        }

    }
}
