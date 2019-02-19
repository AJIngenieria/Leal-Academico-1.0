using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class fAcademico_Asistencia
    {
        public static DataTable Mostrar_TomaDeAsistencia(string curso, string jornada)
        {
            Conexion_Academico_Asistencia Obj = new Conexion_Academico_Asistencia();
            Obj.Curso = curso;
            Obj.Jornada = jornada;
            return Obj.Mostrar_TomaDeAsistencia(Obj);
        }
    }
}
