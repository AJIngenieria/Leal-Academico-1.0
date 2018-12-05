using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Biblioteca_Libros
    {
        private int _Idaño;
        private string _Titulo;
        private string _SubTitulo;
        private string _Categoria;
        private string _Editorial;
        private string _Autor;
        private DateTime _Fecha;
        private string _Cantidad;
        private string _Serie;

        private string _Auto;
        private string _Filtro;

        public int Idaño { get => _Idaño; set => _Idaño = value; }
        public string Titulo { get => _Titulo; set => _Titulo = value; }
        public string SubTitulo { get => _SubTitulo; set => _SubTitulo = value; }
        public string Categoria { get => _Categoria; set => _Categoria = value; }
        public string Editorial { get => _Editorial; set => _Editorial = value; }
        public string Autor { get => _Autor; set => _Autor = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public string Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public string Serie { get => _Serie; set => _Serie = value; }
        public string Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }

        public Conexion_Biblioteca_Libros()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Biblioteca_Libros(string titulo, string subtitulo, string categoria, string editorial, string autor, DateTime fecha, string cantidad, string serie, string auto, string filtro)
        {
            //Datos Basicos
            this.Titulo = titulo;
            this.SubTitulo = subtitulo;
            this.Categoria = categoria;
            this.Editorial = editorial;
            this.Autor = autor;
            this.Fecha = fecha;
            this.Cantidad = cantidad;
            this.Serie = serie;

            this.Auto = auto;
            this.Filtro = filtro;
        }

        //Metodo Insertar

        public string Guardar_DatosBasicos(Conexion_Biblioteca_Libros Libros)
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
                SqlCmd.CommandText = "Biblioteca.AJ_Libros";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdlibros = new SqlParameter();
                ParIdlibros.ParameterName = "@Idlibros";
                ParIdlibros.SqlDbType = SqlDbType.Int;
                ParIdlibros.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdlibros);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Libros.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParTitulo = new SqlParameter();
                ParTitulo.ParameterName = "@Titulo";
                ParTitulo.SqlDbType = SqlDbType.VarChar;
                ParTitulo.Size = 50;
                ParTitulo.Value = Libros.Titulo;
                SqlCmd.Parameters.Add(ParTitulo);

                SqlParameter ParSubTitulo = new SqlParameter();
                ParSubTitulo.ParameterName = "@SubTitulo";
                ParSubTitulo.SqlDbType = SqlDbType.VarChar;
                ParSubTitulo.Size = 20;
                ParSubTitulo.Value = Libros.SubTitulo;
                SqlCmd.Parameters.Add(ParSubTitulo);

                SqlParameter ParCategoria = new SqlParameter();
                ParCategoria.ParameterName = "@Categoria";
                ParCategoria.SqlDbType = SqlDbType.VarChar;
                ParCategoria.Size = 20;
                ParCategoria.Value = Libros.Categoria;
                SqlCmd.Parameters.Add(ParCategoria);

                SqlParameter ParEditorial = new SqlParameter();
                ParEditorial.ParameterName = "@Editorial";
                ParEditorial.SqlDbType = SqlDbType.VarChar;
                ParEditorial.Size = 20;
                ParEditorial.Value = Libros.Editorial;
                SqlCmd.Parameters.Add(ParEditorial);

                SqlParameter ParAutor = new SqlParameter();
                ParAutor.ParameterName = "@Autor";
                ParAutor.SqlDbType = SqlDbType.VarChar;
                ParAutor.Size = 50;
                ParAutor.Value = Libros.Autor;
                SqlCmd.Parameters.Add(ParAutor);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@Fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Libros.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@Cantidad";
                ParCantidad.SqlDbType = SqlDbType.VarChar;
                ParCantidad.Size = 20;
                ParCantidad.Value = Libros.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

                SqlParameter ParSerie = new SqlParameter();
                ParSerie.ParameterName = "@serie";
                ParSerie.SqlDbType = SqlDbType.VarChar;
                ParSerie.Size = 20;
                ParSerie.Value = Libros.Serie;
                SqlCmd.Parameters.Add(ParSerie);

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
    }
}
