using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Sistema_Usuarios
    {
        private int _Idusuario;
        private string _Usuario;
        private string _Contraseña;

        private string _Filtro;

        public int Idusuario
        {
            get
            {
                return _Idusuario;
            }

            set
            {
                _Idusuario = value;
            }
        }

        public string Usuario
        {
            get
            {
                return _Usuario;
            }

            set
            {
                _Usuario = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return _Contraseña;
            }

            set
            {
                _Contraseña = value;
            }
        }

        public string Filtro
        {
            get
            {
                return _Filtro;
            }

            set
            {
                _Filtro = value;
            }
        }

    
    //Constructor Vacio
    public Conexion_Sistema_Usuarios()
    {

    }
    //Constructor con todos los parametros
    public Conexion_Sistema_Usuarios (int idusuario, string usuario, string contraseña,string filtro)
    {

            //Informacion Academica
            this.Idusuario = idusuario;
            this.Usuario = usuario;
            this.Contraseña = contraseña;

            //Filtros de Busquda
            this.Filtro = filtro;
        }

    public DataTable Login(Conexion_Sistema_Usuarios Usuarios)
    {
        DataTable DtResultado = new DataTable("Sistema.Usuarios");
        SqlConnection SqlCon = new SqlConnection();
        try
        {
            SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "Sistema.Login";
            SqlCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter ParUsuario = new SqlParameter();
            ParUsuario.ParameterName = "@Usuario";
            ParUsuario.SqlDbType = SqlDbType.VarChar;
            ParUsuario.Size = 20;
            ParUsuario.Value = Usuarios.Usuario;
            SqlCmd.Parameters.Add(ParUsuario);

            SqlParameter ParContraseña = new SqlParameter();
            ParContraseña.ParameterName = "@Password";
            ParContraseña.SqlDbType = SqlDbType.VarChar;
            ParContraseña.Size = 20;
            ParContraseña.Value = Usuarios.Contraseña;
            SqlCmd.Parameters.Add(ParContraseña);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

        }
        catch (Exception ex)
        {
            DtResultado = null;
        }
        return DtResultado;
        }

    }

}
