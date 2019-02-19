using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Sistema_Estados
    {
        private int _Idestado;
        private string _Estado;
        private string _Descripcion;

        //Filtro
        private int _Auto;
        private string _Filtro;

        public int Idestado { get => _Idestado; set => _Idestado = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }

        public Conexion_Sistema_Estados()
        {

        }

        public Conexion_Sistema_Estados(int idestado, int auto, string estado, string descripcion, string filtro)
        {
            this.Idestado = idestado;
            this.Auto = auto;
            this.Estado = estado;
            this.Descripcion = descripcion;
            this.Filtro = filtro;
        }

        public string Guardar_DatosBasicos(Conexion_Sistema_Estados Estados)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Jalo la conexion de la base de datos 
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCon.Open();

                //Establecer la conexion para mandar a la base de datos
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Sistema.AJ_Estado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdestado = new SqlParameter();
                ParIdestado.ParameterName = "@Idestado";
                ParIdestado.SqlDbType = SqlDbType.Int;
                ParIdestado.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdestado);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 20;
                ParEstado.Value = Estados.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Estados.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 50;
                ParDescripcion.Value = Estados.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                
                //ejecutamos el envio de datos

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Error al Registrar";
            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Sistema.Estados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Sistema.Mostrar_Estados";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
            {

                DtResultado = null;
            }
            return DtResultado;
        }

    }
}
