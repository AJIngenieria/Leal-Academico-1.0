using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fSistema_Academico_CodigoID
    {
        public static string Guardar
             (//Datos Basicos
             string numero, string letra, string simbolo, string auto)
        {
            Conexion_Sistema_CodigoID Obj = new Conexion_Sistema_CodigoID();
            //Datos Basicos
            Obj.Numero = numero;
            Obj.Letras = letra;
            Obj.Simbolo = simbolo;
            Obj.Auto = auto;

            return Obj.Guardar(Obj);
        }
        
    }
}