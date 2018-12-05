using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fAcademico_Bitacora
    {
        public static string Guardar_DatosBasicos
            (//Datos Basicos
            int idalumno, string codigoid, string carnet, string alumno,
            string documento, string identificacion, string curso, string jornada, string director, string bitacora, string tipo,
            DateTime fechaderegistro, DateTime fechadecitacion, string descripcion)
        {
            Conexion_Academico_Bitacora Obj = new Conexion_Academico_Bitacora();
            //Datos Basicos
            Obj.Idalumno = idalumno;
            Obj.CodigoID = codigoid;
            Obj.Carnet = carnet;
            Obj.Alumno = alumno;
            Obj.Documento = documento;
            Obj.Identificacion = identificacion;
            Obj.Curso = curso;
            Obj.Jornada = jornada;
            Obj.Director = director;
            Obj.Bitacora = bitacora;
            Obj.Tipo = tipo;
            Obj.FechaDeRegistro = fechaderegistro;
            Obj.FechaDeCitacion = fechadecitacion;
            Obj.Descripcion = descripcion;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static DataTable AutoCompletar_CodigoID()
        {
            return new Conexion_Academico_Bitacora().AutoCompletar_CodigoID();
        }

    }
}
