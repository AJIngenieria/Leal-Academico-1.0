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
            int idvalor, int idestado, int idcurso, int idjornada, string alumno, string identificacion, string documento, string valor, string año, string orden, string auto)
        {
            Conexion_Academico_OrdenDeMatricula Obj = new Conexion_Academico_OrdenDeMatricula();
            //Datos Basicos

            Obj.Idvalor = idvalor;
            Obj.Idestado = idestado;
            Obj.Idcurso = idcurso;
            Obj.Idjornada = idjornada;
            Obj.Alumno = alumno;
            Obj.Identificacion = identificacion;
            Obj.Documento = documento;
            Obj.Año = año;
            Obj.Valor = valor;
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
