using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fProduccion_CodigoDeBarra
    {
        public static string Guardar_DatosBasicos
            (
                int auto, int idproducto,
                string codigo, string marca, string referencia
            )
        {
            Conexion_Produccion_Cod_Barra Obj = new Conexion_Produccion_Cod_Barra();
            //Datos Basicos

            Obj.Idproducto = idproducto;
            Obj.Codigo = codigo;
            Obj.Marca = marca;
            Obj.Referencia = referencia;

            Obj.Auto = auto;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static DataTable Buscar_CodigoDeBarra(string filtro)
        {
            Conexion_Produccion_Cod_Barra Obj = new Conexion_Produccion_Cod_Barra();
            Obj.Filtro = filtro;
            return Obj.Buscar_CodigoDeBarra(Obj);
        }
    }
}
