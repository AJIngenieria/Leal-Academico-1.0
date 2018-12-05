using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fTesoreria_ValoresAcademicos
    {
        public static string Guardar_DatosBasicos
            (//Datos Basicos
            string concepto, string valor, string periodo, string año ,string auto)
        {
            Conexion_Tesoreria_ValoresAcademicos Obj = new Conexion_Tesoreria_ValoresAcademicos();
            //Datos Basicos
            Obj.Concepto = concepto;
            Obj.Valor = valor;
            Obj.Periodo = periodo;
            Obj.Año = año;
            Obj.Auto = auto;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static DataTable Buscar_ValoresAcademico(string filtro)
        {
            Conexion_Tesoreria_ValoresAcademicos Obj = new Conexion_Tesoreria_ValoresAcademicos();
            Obj.Filtro = filtro;
            return Obj.Buscar_ValoresAcademico(Obj);
        }

    }
}
