using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Biblioteca_DetalleDePrestamos
    {
        //Llaves primarias
        private int _Iddetalleprestamo;
        private int _Idarticulo;
        private int _Idprestamo;

        //Datos
        private string _Articulo;
        private string _Cantidad;
        private string _Serie;

        public int Iddetalleprestamo
        {
            get
            {
                return _Iddetalleprestamo;
            }

            set
            {
                _Iddetalleprestamo = value;
            }
        }

        public int Idarticulo
        {
            get
            {
                return _Idarticulo;
            }

            set
            {
                _Idarticulo = value;
            }
        }

        public int Idprestamo
        {
            get
            {
                return _Idprestamo;
            }

            set
            {
                _Idprestamo = value;
            }
        }

        public string Articulo
        {
            get
            {
                return _Articulo;
            }

            set
            {
                _Articulo = value;
            }
        }

        public string Cantidad
        {
            get
            {
                return _Cantidad;
            }

            set
            {
                _Cantidad = value;
            }
        }

        public string Serie
        {
            get
            {
                return _Serie;
            }

            set
            {
                _Serie = value;
            }
        }

        public Conexion_Biblioteca_DetalleDePrestamos()
        {

        }

        public Conexion_Biblioteca_DetalleDePrestamos(int iddetalledeprestamo, int idarticulo, int idprestamo, string articulo, string cantidad, string serie)
        {
            this.Iddetalleprestamo = iddetalledeprestamo;
            this.Idarticulo = idarticulo;
            this.Idprestamo = idprestamo;
            this.Articulo = articulo;
            this.Cantidad = cantidad;
            this.Serie = serie;
        }

        //Método Insertar
        public string Guardar_DetallePrestamosAlumnos(Conexion_Biblioteca_DetalleDePrestamos Detalle_de_Prestamo, ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "Biblioteca.AJ_DetallePrestamos_Alumno";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalleprestamo = new SqlParameter();
                ParIddetalleprestamo.ParameterName = "@Iddetalleprestamo";
                ParIddetalleprestamo.SqlDbType = SqlDbType.Int;
                ParIddetalleprestamo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddetalleprestamo);

                SqlParameter ParIdarticulo = new SqlParameter();
                ParIdarticulo.ParameterName = "@Idarticulo";
                ParIdarticulo.SqlDbType = SqlDbType.Int;
                ParIdarticulo.Value = Detalle_de_Prestamo.Idarticulo;
                SqlCmd.Parameters.Add(ParIdarticulo);

                SqlParameter ParIdprestamo = new SqlParameter();
                ParIdprestamo.ParameterName = "@Idprestamo";
                ParIdprestamo.SqlDbType = SqlDbType.Int;
                ParIdprestamo.Value = Detalle_de_Prestamo.Idprestamo;
                SqlCmd.Parameters.Add(ParIdprestamo);

                SqlParameter ParArticulo = new SqlParameter();
                ParArticulo.ParameterName = "@Articulo";
                ParArticulo.SqlDbType = SqlDbType.VarChar;
                ParArticulo.Size = 50;
                ParArticulo.Value = Detalle_de_Prestamo.Articulo;
                SqlCmd.Parameters.Add(ParArticulo);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@Cantidad";
                ParCantidad.SqlDbType = SqlDbType.VarChar;
                ParCantidad.Size = 50;
                ParCantidad.Value = Detalle_de_Prestamo.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

                SqlParameter ParSerie = new SqlParameter();
                ParSerie.ParameterName = "@Serie";
                ParSerie.SqlDbType = SqlDbType.VarChar;
                ParSerie.Size = 20;
                ParSerie.Value = Detalle_de_Prestamo.Serie;
                SqlCmd.Parameters.Add(ParSerie);

                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;

        }

        public string Guardar_DetallePrestamosDocente(Conexion_Biblioteca_DetalleDePrestamos Detalle_de_Prestamo, ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "Biblioteca.AJ_DetallePrestamos_Docente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalleprestamo = new SqlParameter();
                ParIddetalleprestamo.ParameterName = "@Iddetalleprestamo";
                ParIddetalleprestamo.SqlDbType = SqlDbType.Int;
                ParIddetalleprestamo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddetalleprestamo);

                SqlParameter ParIdarticulo = new SqlParameter();
                ParIdarticulo.ParameterName = "@Idarticulo";
                ParIdarticulo.SqlDbType = SqlDbType.Int;
                ParIdarticulo.Value = Detalle_de_Prestamo.Idarticulo;
                SqlCmd.Parameters.Add(ParIdarticulo);

                SqlParameter ParIdprestamo = new SqlParameter();
                ParIdprestamo.ParameterName = "@Idprestamo";
                ParIdprestamo.SqlDbType = SqlDbType.Int;
                ParIdprestamo.Value = Detalle_de_Prestamo.Idprestamo;
                SqlCmd.Parameters.Add(ParIdprestamo);

                SqlParameter ParArticulo = new SqlParameter();
                ParArticulo.ParameterName = "@Articulo";
                ParArticulo.SqlDbType = SqlDbType.VarChar;
                ParArticulo.Size = 50;
                ParArticulo.Value = Detalle_de_Prestamo.Articulo;
                SqlCmd.Parameters.Add(ParArticulo);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@Cantidad";
                ParCantidad.SqlDbType = SqlDbType.VarChar;
                ParCantidad.Size = 50;
                ParCantidad.Value = Detalle_de_Prestamo.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

                SqlParameter ParSerie = new SqlParameter();
                ParSerie.ParameterName = "@Serie";
                ParSerie.SqlDbType = SqlDbType.VarChar;
                ParSerie.Size = 20;
                ParSerie.Value = Detalle_de_Prestamo.Serie;
                SqlCmd.Parameters.Add(ParSerie);


                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;

        }

    }
}
