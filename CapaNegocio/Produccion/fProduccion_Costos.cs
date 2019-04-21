using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fProduccion_Costos
    {
        public static string Guardar_DatosBasicos
            (
                //Datos Basicos

                int idproducto, int idimpuesto, int idempleado, string compra, string va_venta, string va_maximo, string va_minimo, string ca_maxima,
                string ca_minima, string oferta, DateTime inicio, DateTime fin, string v_impuesto, string balanza, string unidad, string medida,

                int auto, int estado
            )
        {
            Conexion_Produccion_Costos Obj = new Conexion_Produccion_Costos();
            //Datos Basicos

            //Llaves principales
            Obj.Idproducto = idproducto;
            Obj.Idimpuesto = idimpuesto;
            Obj.Idempleado = idempleado;

            //Datos Basicos
            Obj.Compra = compra;
            Obj.Va_Venta = va_venta;
            Obj.Va_Maximo = va_maximo;
            Obj.Va_Minimo = va_minimo;
            Obj.Ca_Maxima = ca_maxima;
            Obj.Ca_Minima = ca_minima;
            Obj.Oferta = oferta;
            Obj.Inicio = inicio;
            Obj.Fin = fin;
            Obj.V_Impuesto = v_impuesto;
            Obj.Balanza = balanza;
            Obj.Unidad = unidad;
            Obj.Medida = medida;

            Obj.Estado = estado;

            Obj.Auto = auto;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static DataTable Buscar_Costos(string filtro)
        {
            Conexion_Produccion_Costos Obj = new Conexion_Produccion_Costos();
            Obj.Filtro = filtro;
            return Obj.Buscar_Costos(Obj);
        }
    }
}
