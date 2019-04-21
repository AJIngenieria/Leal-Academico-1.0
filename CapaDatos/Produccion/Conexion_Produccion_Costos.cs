using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Produccion_Costos
    {
        //Llaves Primarias
        private int _Idcostos;
        private int _Idproducto;
        private int _Idimpuesto;
        private int _Idempleado;

        //Variable de Condicion Guardar o Editar
        private int _Auto;

        //Variables Generales

        private string _Compra;
        private string _Va_Venta;
        private string _Va_Maximo;
        private string _Va_Minimo;
        private string _Ca_Maxima;
        private string _Ca_Minima;
        private string _Oferta;
        private DateTime _Inicio;
        private DateTime _Fin;
        private string _V_Impuesto;
        private string _Balanza;
        private string _Unidad;
        private string _Medida;
        private int _Estado;

        //Variable de Consulta General o Filtros
        private string _Filtro;

        public int Idcostos { get => _Idcostos; set => _Idcostos = value; }
        public int Idproducto { get => _Idproducto; set => _Idproducto = value; }
        public int Idimpuesto { get => _Idimpuesto; set => _Idimpuesto = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public string Compra { get => _Compra; set => _Compra = value; }
        public string Va_Venta { get => _Va_Venta; set => _Va_Venta = value; }
        public string Va_Maximo { get => _Va_Maximo; set => _Va_Maximo = value; }
        public string Va_Minimo { get => _Va_Minimo; set => _Va_Minimo = value; }
        public string Ca_Maxima { get => _Ca_Maxima; set => _Ca_Maxima = value; }
        public string Ca_Minima { get => _Ca_Minima; set => _Ca_Minima = value; }
        public string Oferta { get => _Oferta; set => _Oferta = value; }
        public DateTime Inicio { get => _Inicio; set => _Inicio = value; }
        public DateTime Fin { get => _Fin; set => _Fin = value; }
        public string V_Impuesto { get => _V_Impuesto; set => _V_Impuesto = value; }
        public string Balanza { get => _Balanza; set => _Balanza = value; }
        public string Unidad { get => _Unidad; set => _Unidad = value; }
        public string Medida { get => _Medida; set => _Medida = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public int Idempleado { get => _Idempleado; set => _Idempleado = value; }

        //Constructores
        public Conexion_Produccion_Costos()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Produccion_Costos
            (
                int idcostos, int idproducto, int idimpuesto, int idempleado, string compra, string va_venta, string va_maximo, string va_minimo, string ca_maxima,
                string ca_minima, string oferta, DateTime inicio, DateTime fin, string v_impuesto, string balanza, string unidad, string medida, 

                int auto, int estado, string filtro
            )

        {
            //Llaves principales
            this.Idcostos = idcostos;
            this.Idproducto = idproducto;
            this.Idimpuesto = idimpuesto;
            this.Idempleado = idempleado;

            //Datos Basicos
            this.Compra = compra;
            this.Va_Venta = va_venta;
            this.Va_Maximo = va_maximo;
            this.Va_Minimo = va_minimo;
            this.Ca_Maxima = ca_maxima;
            this.Ca_Minima = ca_minima;
            this.Oferta = oferta;
            this.Inicio = inicio;
            this.Fin = fin;
            this.V_Impuesto = v_impuesto;
            this.Balanza = balanza;
            this.Unidad = unidad;
            this.Medida = medida;

            this.Estado = estado;

            this.Auto = auto;
            this.Filtro = filtro;
        }

        //Metodo Insertar

        public string Guardar_DatosBasicos(Conexion_Produccion_Costos Costos)
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
                SqlCmd.CommandText = "Produccion.LA_Costos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdcostos = new SqlParameter();
                ParIdcostos.ParameterName = "@Idcostos";
                ParIdcostos.SqlDbType = SqlDbType.Int;
                ParIdcostos.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcostos);

                SqlParameter ParIdproducto = new SqlParameter();
                ParIdproducto.ParameterName = "@Idproducto";
                ParIdproducto.SqlDbType = SqlDbType.Int;
                ParIdproducto.Value = Costos.Idproducto;
                SqlCmd.Parameters.Add(ParIdproducto);

                SqlParameter ParIdimpuesto = new SqlParameter();
                ParIdimpuesto.ParameterName = "@Idimpuesto";
                ParIdimpuesto.SqlDbType = SqlDbType.Int;
                ParIdimpuesto.Value = Costos.Idimpuesto;
                SqlCmd.Parameters.Add(ParIdimpuesto);

                SqlParameter ParIdempleado = new SqlParameter();
                ParIdempleado.ParameterName = "@Idempleado";
                ParIdempleado.SqlDbType = SqlDbType.Int;
                ParIdempleado.Value = Costos.Idempleado;
                SqlCmd.Parameters.Add(ParIdempleado);

                SqlParameter ParCompra = new SqlParameter();
                ParCompra.ParameterName = "@Compra";
                ParCompra.SqlDbType = SqlDbType.VarChar;
                ParCompra.Size = 50;
                ParCompra.Value = Costos.Compra;
                SqlCmd.Parameters.Add(ParCompra);

                SqlParameter ParVa_Venta = new SqlParameter();
                ParVa_Venta.ParameterName = "@Va_Venta";
                ParVa_Venta.SqlDbType = SqlDbType.VarChar;
                ParVa_Venta.Size = 50;
                ParVa_Venta.Value = Costos.Va_Venta;
                SqlCmd.Parameters.Add(ParVa_Venta);

                SqlParameter ParVa_Maximo = new SqlParameter();
                ParVa_Maximo.ParameterName = "@Va_Maximo";
                ParVa_Maximo.SqlDbType = SqlDbType.VarChar;
                ParVa_Maximo.Size = 50;
                ParVa_Maximo.Value = Costos.Va_Maximo;
                SqlCmd.Parameters.Add(ParVa_Maximo);

                SqlParameter ParVa_Minimo = new SqlParameter();
                ParVa_Minimo.ParameterName = "@Va_Minimo";
                ParVa_Minimo.SqlDbType = SqlDbType.VarChar;
                ParVa_Minimo.Size = 50;
                ParVa_Minimo.Value = Costos.Va_Minimo;
                SqlCmd.Parameters.Add(ParVa_Minimo);

                SqlParameter ParCa_Maxima = new SqlParameter();
                ParCa_Maxima.ParameterName = "@Ca_Maxima";
                ParCa_Maxima.SqlDbType = SqlDbType.VarChar;
                ParCa_Maxima.Size = 50;
                ParCa_Maxima.Value = Costos.Ca_Maxima;
                SqlCmd.Parameters.Add(ParCa_Maxima);

                SqlParameter ParCa_Minima = new SqlParameter();
                ParCa_Minima.ParameterName = "@Ca_Minima";
                ParCa_Minima.SqlDbType = SqlDbType.VarChar;
                ParCa_Minima.Size = 50;
                ParCa_Minima.Value = Costos.Ca_Minima;
                SqlCmd.Parameters.Add(ParCa_Minima);

                SqlParameter ParOferta = new SqlParameter();
                ParOferta.ParameterName = "@Oferta";
                ParOferta.SqlDbType = SqlDbType.VarChar;
                ParOferta.Size = 10;
                ParOferta.Value = Costos.Oferta;
                SqlCmd.Parameters.Add(ParOferta);

                SqlParameter ParInicio = new SqlParameter();
                ParInicio.ParameterName = "@Inicio";
                ParInicio.SqlDbType = SqlDbType.Date;
                ParInicio.Value = Costos.Inicio;
                SqlCmd.Parameters.Add(ParInicio);

                SqlParameter ParFin = new SqlParameter();
                ParFin.ParameterName = "@Fin";
                ParFin.SqlDbType = SqlDbType.Date;
                ParFin.Value = Costos.Fin;
                SqlCmd.Parameters.Add(ParFin);

                SqlParameter ParV_Impuesto = new SqlParameter();
                ParV_Impuesto.ParameterName = "@V_Impuesto";
                ParV_Impuesto.SqlDbType = SqlDbType.VarChar;
                ParV_Impuesto.Size = 10;
                ParV_Impuesto.Value = Costos.V_Impuesto;
                SqlCmd.Parameters.Add(ParV_Impuesto);

                SqlParameter ParBalanza = new SqlParameter();
                ParBalanza.ParameterName = "@Balanza";
                ParBalanza.SqlDbType = SqlDbType.VarChar;
                ParBalanza.Size = 10;
                ParBalanza.Value = Costos.Balanza;
                SqlCmd.Parameters.Add(ParBalanza);

                SqlParameter ParUnidad = new SqlParameter();
                ParUnidad.ParameterName = "@Unidad";
                ParUnidad.SqlDbType = SqlDbType.VarChar;
                ParUnidad.Size = 10;
                ParUnidad.Value = Costos.Unidad;
                SqlCmd.Parameters.Add(ParUnidad);

                SqlParameter ParMedida = new SqlParameter();
                ParMedida.ParameterName = "@Medida";
                ParMedida.SqlDbType = SqlDbType.VarChar;
                ParMedida.Size = 10;
                ParMedida.Value = Costos.Medida;
                SqlCmd.Parameters.Add(ParMedida);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = Costos.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Costos.Auto;
                SqlCmd.Parameters.Add(ParAuto);

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

        public DataTable Buscar_Costos(Conexion_Produccion_Costos Proveedor)
        {
            DataTable DtResultado = new DataTable("Produccion.Proveedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Produccion.Buscar_Proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 100;
                ParTextoBuscar.Value = Proveedor.Filtro;
                SqlCmd.Parameters.Add(ParTextoBuscar);

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
