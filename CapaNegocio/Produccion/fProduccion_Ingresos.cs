using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fProduccion_Ingresos
    {
        //Método Insertar que llama al método Insertar de la clase DIngreso
        //de la CapaDatos
        public static string Guardar_DatosBasicos(int idtrabajador, int idproveedor, string comprobante, string nº_comprobante, DateTime fecha_de_ingreso, string estado, DataTable dtDetalles)
        {
            Conexion_Produccion_Ingresos Obj = new Conexion_Produccion_Ingresos();
            Obj.Idtrabajador = idtrabajador;
            Obj.Idproveedor = idproveedor;
            Obj.Comprobante = comprobante;
            Obj.Nº_Comprobante = nº_comprobante;
            Obj.Fecha_de_Ingreso = fecha_de_ingreso;
            Obj.Estado = estado;
            List<Conexion_Produccion_DetalleDeIngreso> detalles = new List<Conexion_Produccion_DetalleDeIngreso>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                Conexion_Produccion_DetalleDeIngreso detalle = new Conexion_Produccion_DetalleDeIngreso();
                detalle.Idproducto = Convert.ToInt32(row["Idproducto"].ToString());
                detalle.Stock_Inicial = Convert.ToInt32(row["Stock_Inicial"].ToString());
                detalle.Stock_Actual = Convert.ToInt32(row["Stock_Inicial"].ToString());
                detalle.Precio_de_Compra = Convert.ToInt32(row["Precio_de_Compra"].ToString());
                detalle.Precio_de_Venta = Convert.ToInt32(row["Precio_de_Venta"].ToString());
                detalles.Add(detalle);
            }
            return Obj.Guardar_DatosBasicos(Obj, detalles);
        }

        //Método Anular que llama al método Anular de la clase DIngreso
        //de la CapaDatos
        public static string Anular(int idingresos)
        {
            Conexion_Produccion_Ingresos Obj = new Conexion_Produccion_Ingresos();
            Obj.Idingresos = idingresos;
            return Obj.Anular(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DIngreso
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new Conexion_Produccion_Ingresos().Mostrar();
        }

        //Método BuscarApellidos que llama al método BuscarApellidos
        //de la clase DCliente de la CapaDatos
        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            Conexion_Produccion_Ingresos Obj = new Conexion_Produccion_Ingresos();
            return Obj.BuscarFechas(textobuscar, textobuscar2);
        }
        public static DataTable MostrarDetalle(string textobuscar)
        {
            Conexion_Produccion_Ingresos Obj = new Conexion_Produccion_Ingresos();
            return Obj.MostrarDetalle(textobuscar);
        }

        public static DataTable CodigoID_Solicitud(string filtro)
        {
            Conexion_Produccion_Ingresos Obj = new Conexion_Produccion_Ingresos();
            Obj.Filtro = filtro;
            return Obj.CodigoID_Solicitud(Obj);
        }
    }
}
