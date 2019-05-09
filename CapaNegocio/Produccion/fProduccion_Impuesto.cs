using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class fProduccion_Impuesto
    {
        //Método Insertar que llama al método Insertar de la clase DIngreso
        //de la CapaDatos
        public static string Guardar_DatosBasicos
            (
                string auto, string impuesto, string tipo, int valor, string aplicable
            )
        {
            Conexion_Produccion_Impuesto Obj = new Conexion_Produccion_Impuesto();
            Obj.Auto = auto;
            Obj.Impuesto = impuesto;
            Obj.Tipo = tipo;
            Obj.Valor = valor;
            Obj.Aplicable = aplicable;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static DataTable Buscar_Impuesto(string filtro)
        {
            Conexion_Produccion_Impuesto Obj = new Conexion_Produccion_Impuesto();
            Obj.Filtro = filtro;
            return Obj.Buscar_Impuesto(Obj);
        }

        public static DataTable Mostrar_Impuesto()
        {
            return new Conexion_Produccion_Impuesto().Mostrar_Impuesto();
        }

        public static string Guardar_AutoGenerador(
            string impuesto, string tipo, int valor,
            int idproveedor,string marca,string descripcion
            )
        {
            Conexion_Produccion_Impuesto Obj = new Conexion_Produccion_Impuesto();
            Obj.Impuesto = impuesto;
            Obj.Tipo = tipo;
            Obj.Valor = valor;

            //Obj.Idproveedor = idproveedor;
            //Obj.Marca = marca;
            //Obj.Descripcion =descripcion;

            return Obj.Guardar_AutoGenerador(Obj);
        }

    }
}
