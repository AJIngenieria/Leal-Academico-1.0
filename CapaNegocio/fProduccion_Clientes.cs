using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fProduccion_Clientes
    {
        public static string Guardar_DatosBasicos(int auto, int idestado, int idciudad, int idpais, string codigoid, string cliente, string documento,
            string identificacion, string telefono, string movil, string email, string direccion)
        {
            Conexion_Produccion_Clientes Obj = new Conexion_Produccion_Clientes();
            Obj.Idciudad = idciudad;
            Obj.Idestado = idestado;
            Obj.Idpais = idpais;
            Obj.CodigoID = codigoid;
            Obj.Cliente = cliente;
            Obj.Documento = documento;
            Obj.Identificacion = identificacion;
            Obj.Telefono = telefono;
            Obj.Movil = movil;
            Obj.Email = email;
            Obj.Direccion = direccion;

            Obj.Auto = auto;

            return Obj.Guardar_DatosBasicos(Obj);
        }
    }
}
