using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fProduccion_Productos
    {
        
        public static string Guardar_DatosBasicos
            (
                //Datos Basicos
                int auto, int idempleado, int idmarca,  int estado,
                string codigoid, string producto, string descripcion, string referencia, string importado, string empacado, string vence, string grupo,
                string ofertable, string ubicacion,

                //Costos de Productos
                int idimpuesto, string compra, string va_venta, string va_maximo, string va_minimo, string ca_maxima,
                string ca_minima, string oferta, DateTime inicio, DateTime fin, string v_impuesto, string balanza, string unidad, string medida

                //Codigos de Barra



                //Proveedor de Distribucion de Productos
            )
        {
            Conexion_Produccion_Producto Obj = new Conexion_Produccion_Producto();

            Obj.Idempleado = idempleado;
            Obj.Idmarca = idmarca;

            Obj.Auto = auto;
            Obj.Estado = estado;

            //Datos Basicos
            //Obj.CodigoID = codigoid;
            Obj.Producto = producto;
            Obj.Descripcion = descripcion;

            Obj.Referencia = referencia;
            Obj.Importado = importado;
            Obj.Empacada = empacado;
            Obj.Vence = vence;
            Obj.Grupo = grupo;
            Obj.Ofertable = ofertable;
            //Obj.Ubicacion = ubicacion;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static DataTable Buscar_Producto(string filtro)
        {
            Conexion_Produccion_Producto Obj = new Conexion_Produccion_Producto();
            Obj.Filtro = filtro;
            return Obj.Buscar_Producto(Obj);
        }

        public static DataTable CodigoID_Solicitud(string filtro)
        {
            Conexion_Produccion_Producto Obj = new Conexion_Produccion_Producto();
            Obj.Filtro = filtro;
            return Obj.CodigoID_Solicitud(Obj);
        }

    }
}
