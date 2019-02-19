using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fGestion_DatosMedicos
    {
        //Método Insertar que llama al método Insertar de la clase DIngreso
        //de la CapaDatos
        public static string Guardar_DatosBasicos(/*int idempleado,*/ string codigoid,string rh, string eps, string alimentos, string animales, string insectos,
            string medicamentos, string plantas, string indicaciones)
        {
            Conexion_Gestion_DatosMedicos Obj = new Conexion_Gestion_DatosMedicos();
            //Obj.Idempleado = idempleado;
            Obj.CodigoID = codigoid;
            Obj.RH = rh;
            Obj.Eps = eps;
            Obj.Alimentos = alimentos;
            Obj.Animales = animales;
            Obj.Insectos = insectos;
            Obj.Medicamentos = medicamentos;
            Obj.Plantas = plantas;
            Obj.Indicaciones = indicaciones;

            return Obj.Guardar_Salud(Obj);
        }
    }
}
