using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Produccion_Ingresos
    {
        //Llaves Primarias
        private int _Idingresos;
        private int _Idtrabajador;
        private int _Idproveedor;

        //Datos Basicos
        private string _Comprobante;
        private string _Nº_Comprobante;
        private DateTime _Fecha_de_Ingreso;
        private string _Estado;

        //Variables segun el procedimiento a realizar
        //Guardar, Editar, Buscar

        private int _Auto;
        private string _Filtro;

        public int Idingresos { get => _Idingresos; set => _Idingresos = value; }
        public int Idtrabajador { get => _Idtrabajador; set => _Idtrabajador = value; }
        public int Idproveedor { get => _Idproveedor; set => _Idproveedor = value; }
        public string Comprobante { get => _Comprobante; set => _Comprobante = value; }
        public string Nº_Comprobante { get => _Nº_Comprobante; set => _Nº_Comprobante = value; }
        public DateTime Fecha_de_Ingreso { get => _Fecha_de_Ingreso; set => _Fecha_de_Ingreso = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }

        //Constructores
        public Conexion_Produccion_Ingresos()
        {

        }
        public Conexion_Produccion_Ingresos
            (
                int idingresos, int idtrabajador, int idproveedor, string comprobante, string nº_comprobante, DateTime fecha_de_ingreso, string estado,
                
                int auto, string filtro
            )
        {
            this.Idingresos = idingresos;
            this.Idtrabajador = idtrabajador;
            this.Idproveedor = idproveedor;
            this.Comprobante = comprobante;
            this.Nº_Comprobante = nº_comprobante;
            this.Fecha_de_Ingreso = fecha_de_ingreso;
            this.Estado = estado;

            this.Filtro = filtro;
            this.Auto = auto;
        }
        //Métodos

        public string Guardar_DatosBasicos(Conexion_Produccion_Ingresos Ingresos, List<Conexion_Produccion_DetalleDeIngreso> Detalle)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCon.Open();
                //Establecer la transacción
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "Almacen.spInsertar_IngresosAlmacen";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Parámetros
                SqlParameter ParIdingreso = new SqlParameter();
                ParIdingreso.ParameterName = "@idingresos";
                ParIdingreso.SqlDbType = SqlDbType.Int;
                ParIdingreso.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdingreso);

                SqlParameter ParIdTrabajador = new SqlParameter();
                ParIdTrabajador.ParameterName = "@idtrabajador";
                ParIdTrabajador.SqlDbType = SqlDbType.Int;
                ParIdTrabajador.Value = Ingresos.Idtrabajador;
                SqlCmd.Parameters.Add(ParIdTrabajador);

                SqlParameter ParIdproveedor = new SqlParameter();
                ParIdproveedor.ParameterName = "@idproveedor";
                ParIdproveedor.SqlDbType = SqlDbType.Int;
                ParIdproveedor.Value = Ingresos.Idproveedor;
                SqlCmd.Parameters.Add(ParIdproveedor);


                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@Fecha_de_Ingreso";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Ingresos.Fecha_de_Ingreso;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParTipo_Comprobante = new SqlParameter();
                ParTipo_Comprobante.ParameterName = "@Comprobante";
                ParTipo_Comprobante.SqlDbType = SqlDbType.VarChar;
                ParTipo_Comprobante.Size = 900;
                ParTipo_Comprobante.Value = Ingresos.Comprobante;
                SqlCmd.Parameters.Add(ParTipo_Comprobante);

                SqlParameter ParNº_Comprobante = new SqlParameter();
                ParNº_Comprobante.ParameterName = "@Nº_Comprobante";
                ParNº_Comprobante.SqlDbType = SqlDbType.VarChar;
                ParNº_Comprobante.Size = 900;
                ParNº_Comprobante.Value = Ingresos.Nº_Comprobante;
                SqlCmd.Parameters.Add(ParNº_Comprobante);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 900;
                ParEstado.Value = Ingresos.Estado;
                SqlCmd.Parameters.Add(ParEstado);


                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

                if (rpta.Equals("OK"))
                {
                    //Obtenemos el codigo del ingreso que se genero por la base de datos

                    this.Idingresos = Convert.ToInt32(SqlCmd.Parameters["@idingresos"].Value);
                    foreach (Conexion_Produccion_DetalleDeIngreso det in Detalle)
                    {
                        //Establecemos el codigo del ingreso que se autogenero
                        det.Idingresos = this.Idingresos;
                        //Llamamos al metodo insertar de la clase DetalleIngreso
                        //y le pasamos la conexion y la transaccion que debe de usar
                        rpta = det.Insertar(det, ref SqlCon, ref SqlTra);
                        if (!rpta.Equals("OK"))
                        {
                            //Si ocurre un error al insertar un detalle de ingreso salimos del for
                            break;
                        }
                    }
                }
                if (rpta.Equals("OK"))
                {
                    //Se inserto todo los detalles y confirmamos la transaccion
                    SqlTra.Commit();
                }
                else
                {
                    //Algun detalle no se inserto y negamos la transaccion
                    SqlTra.Rollback();
                }

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

        public string Anular(Conexion_Produccion_Ingresos AnularIngreso)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Almacen.spAnular_IngresosAlmacen";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdingreso = new SqlParameter();
                ParIdingreso.ParameterName = "@idingresos";
                ParIdingreso.SqlDbType = SqlDbType.Int;
                ParIdingreso.Value = AnularIngreso.Idingresos;
                SqlCmd.Parameters.Add(ParIdingreso);
                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Anulo el Ingreso";

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


        //Método Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Almacen.Almacen_Ingresos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Almacen.spMostrar_IngresosAlmacen";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


        //Método BuscarFechas
        public DataTable BuscarFechas(String TextoBuscar, String TextoBuscar2)
        {
            DataTable DtResultado = new DataTable("Almacen.Almacen_Ingresos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Almacen.spBuscar_ingreso_IngresosAlmacen_Fecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 50;
                ParTextoBuscar2.Value = TextoBuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        //Método Mostrar Detalle de Ingresos Almacen
        public DataTable MostrarDetalle(String TextoBuscar)
        {
            DataTable DtResultado = new DataTable("Almacen.Almacen_DetalleDeIngreso");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Almacen.spMostrar_DetalleDeIngresoAlmacen";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


        public DataTable CodigoID_Solicitud(Conexion_Produccion_Ingresos CodigoID)
        {
            DataTable DtResultado = new DataTable("Produccion.Ingreso");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Sistema.ID_IngresoAlmacen";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParFiltro = new SqlParameter();
                ParFiltro.ParameterName = "@Filtro";
                ParFiltro.SqlDbType = SqlDbType.VarChar;
                ParFiltro.Size = 1;
                ParFiltro.Value = CodigoID.Filtro;
                SqlCmd.Parameters.Add(ParFiltro);

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
