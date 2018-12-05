using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio
{
    public class fAcademico_Aulas
    {
        public static string Guardar_DatosBasicos
            (//Datos Basicos
            string auto, string Aula, string capacidad, int idcurso, string año, int idestado)
        {
            Conexion_Academico_Aula Obj = new Conexion_Academico_Aula();
            //Datos Basicos
            Obj.Aula = Aula;
            Obj.Capacidad = capacidad;
            Obj.Idcurso = idcurso;
            Obj.Año = año;
            Obj.Idestado = idestado;
            Obj.Auto = auto;

            return Obj.Guardar_DatosBasicos(Obj);
        }
    }
}
