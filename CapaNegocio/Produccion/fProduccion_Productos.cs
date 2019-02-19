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
        //Método Insertar que llama al método Insertar de la clase DIngreso
        //de la CapaDatos
        public static string Guardar_DatosBasicos(int idempleado, int idmarca, int auto, int idestado,
            string codigoid, string producto, string descripcion, string referencia, string importado, string empacado, string vence, string grupo,
            string ofertable, string ubicacion)
        {
            Conexion_Produccion_Producto Obj = new Conexion_Produccion_Producto();

            Obj.Idempleado = idempleado;
            Obj.Idmarca = idmarca;

            Obj.Auto = auto;
            Obj.Idestado = idestado;

            //Datos Basicos
            Obj.CodigoID = codigoid;
            Obj.Producto = producto;
            Obj.Descripcion = descripcion;

            Obj.Referencia = referencia;
            Obj.Importado = importado;
            Obj.Empacada = empacado;
            Obj.Vence = vence;
            Obj.Grupo = grupo;
            Obj.Ofertable = ofertable;
            Obj.Ubicacion = ubicacion;

            return Obj.Guardar_DatosBasicos(Obj);
        }
    }
}
