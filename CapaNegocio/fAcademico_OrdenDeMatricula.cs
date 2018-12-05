using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fAcademico_OrdenDeMatricula
    {
        public static string Guardar_DatosBasicos
            (//Datos Basicos
            int idvalor, string alumno, string identificacion, string noidentificacion,string valor, string año, string orden, string auto)
        {
            Conexion_Academico_OrdenDeMatricula Obj = new Conexion_Academico_OrdenDeMatricula();
            //Datos Basicos
            Obj.Idvalores = idvalor;
            Obj.Auto = auto;
            Obj.Alumno = alumno;
            Obj.Identificacion = identificacion;
            Obj.NoIdentificacion = noidentificacion;
            Obj.Valor = valor;
            Obj.Año = año;
            Obj.Orden = orden;
            
            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static DataTable Buscar_PorAlumno(string filtro)
        {
            Conexion_Academico_OrdenDeMatricula Obj = new Conexion_Academico_OrdenDeMatricula();
            Obj.Filtro = filtro;
            return Obj.Buscar_OrdenPorAlumno(Obj);
        }

        public static DataTable Buscar_PorAño(string filtro)
        {
            Conexion_Academico_OrdenDeMatricula Obj = new Conexion_Academico_OrdenDeMatricula();
            Obj.Filtro = filtro;
            return Obj.Buscar_OdenPorAño(Obj);
        }

        public static DataTable Buscar_PorOrden(string filtro)
        {
            Conexion_Academico_OrdenDeMatricula Obj = new Conexion_Academico_OrdenDeMatricula();
            Obj.Filtro = filtro;
            return Obj.Buscar_OrdenPorOrden(Obj);
        }

    }
}
