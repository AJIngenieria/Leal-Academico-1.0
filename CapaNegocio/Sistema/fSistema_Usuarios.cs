using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fSistema_Usuarios
    {
        public static DataTable Login(string usuario, string contraseña)
        {
            Conexion_Sistema_Usuarios Obj = new Conexion_Sistema_Usuarios();
            Obj.Usuario = usuario;
            Obj.Contraseña = contraseña;
            return Obj.Login(Obj);
        }
    }
}
