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
                //llaves Primarias

                int idempleado, int idotros, int idmarca, int idcostos,

                //Datos Basicos

                int codigoid, string producto, string referencia, string descripcion,
                string ofertable, string importado, string empacado, string tipo, string grupo, string vence,

                //Costos de Productos
                string va_compra, string va_venta01, string va_venta02, string va_venta03,
                string va_oferta, string va_ventapublico, string ca_maxima, string ca_minimo,

                //Impuestos - Otros Datos
                int idimpuesto, int idbodega, int idproveedor,
                string ubicacion, string unidaddeventa, string observacion,

                //Filtros y Metodo
                int estado, int auto
            )
        {
            Conexion_Produccion_Producto Obj = new Conexion_Produccion_Producto();

            //Obj.Idempleado = idempleado;
            //Llave Primaria
            Obj.Idempleado = idempleado;

            //Datos Basicos
            Obj.Idmarca = idmarca;
            Obj.CodigoID = codigoid;
            Obj.Producto = producto;
            Obj.Descripcion = descripcion;
            Obj.Referencia = referencia;
            Obj.Ofertable = ofertable;
            Obj.Importado = importado;
            Obj.Empacada = empacado;
            Obj.Tipo = tipo;
            Obj.Vence = vence;
            Obj.Grupo = grupo;

            //Costos de Productos

            Obj.ValorCompra = va_compra;
            Obj.ValorVenta1 = va_venta01;
            Obj.ValorVenta2 = va_venta02;
            Obj.ValorVenta3 = va_venta03;
            Obj.ValorOferta = va_oferta;
            Obj.ValorVentaPublico = va_ventapublico;
            Obj.Ca_Minima = ca_minimo;
            Obj.Ca_Maxima = ca_maxima;

            //Impuestos - Otros Datos
            Obj.Idbodega = idbodega;
            Obj.Idproveedor = idproveedor;
            Obj.Idimpuesto = idimpuesto;
            Obj.Ubicacion = ubicacion;
            Obj.UnidadDeVenta = unidaddeventa;
            Obj.Observacion = observacion;

            //Metodos y Filtros

            Obj.Auto = auto;
            Obj.Estado = estado;

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
