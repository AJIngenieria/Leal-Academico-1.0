using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Gestion_DatosPersonales
    {
        //Llaves primarias
        private int _Iddatospersonales;
        private int _Idempleados;

        private string _CodigoID;

        //Busqueda
        private string _Filtro;

        private string _Profesion;
        private string _Pension;
        private string _Compensacion;
        private string _Contrato;
        private string _Sueldos;
        private string _Adelantos;
        private string _Extras;
        private string _Banco;
        private string _Cuenta;
        private string _Numero;
        private string _Pago;
        private string _Moneda;
        private string _Recomendado;
        private DateTime _Nacimientos;
        private string _Hijos;
        private string _Plantel;
        private string _Civil;

        public int Iddatospersonales { get => _Iddatospersonales; set => _Iddatospersonales = value; }
        public int Idempleados { get => _Idempleados; set => _Idempleados = value; }
        public string CodigoID { get => _CodigoID; set => _CodigoID = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public string Profesion { get => _Profesion; set => _Profesion = value; }
        public string Pension { get => _Pension; set => _Pension = value; }
        public string Compensacion { get => _Compensacion; set => _Compensacion = value; }
        public string Contrato { get => _Contrato; set => _Contrato = value; }
        public string Sueldos { get => _Sueldos; set => _Sueldos = value; }
        public string Adelantos { get => _Adelantos; set => _Adelantos = value; }
        public string Extras { get => _Extras; set => _Extras = value; }
        public string Banco { get => _Banco; set => _Banco = value; }
        public string Cuenta { get => _Cuenta; set => _Cuenta = value; }
        public string Numero { get => _Numero; set => _Numero = value; }
        public string Pago { get => _Pago; set => _Pago = value; }
        public string Moneda { get => _Moneda; set => _Moneda = value; }
        public string Recomendado { get => _Recomendado; set => _Recomendado = value; }
        public DateTime Nacimientos { get => _Nacimientos; set => _Nacimientos = value; }
        public string Hijos { get => _Hijos; set => _Hijos = value; }
        public string Plantel { get => _Plantel; set => _Plantel = value; }
        public string Civil { get => _Civil; set => _Civil = value; }

        //Constructores
        public Conexion_Gestion_DatosPersonales()
        {

        }
        public Conexion_Gestion_DatosPersonales
            (//Datos Basicos
            int idempleado, string iddatospersonales, string profesion, string pension, string compensacion, string contrato, string sueldo, string adelanto,
            string extras, string banco, string cuenta, string numero,
            string pago, string moneda, string recomendado, DateTime nacimiento, string hijos, string plantel, string civil,
            
            string filtro)
        {
            this.Idempleados = idempleado;
            this.Filtro = filtro;

            this.Profesion = profesion;
            this.Pension = pension;
            this.Compensacion = compensacion;
            this.Contrato = contrato;
            this.Sueldos = sueldo;
            this.Adelantos = adelanto;
            this.Extras = extras;
            this.Banco = banco;
            this.Cuenta = cuenta;
            this.Numero = numero;
            this.Pago = pago;
            this.Moneda = moneda;
            this.Recomendado = recomendado;
            this.Nacimientos = nacimiento;
            this.Hijos = hijos;
            this.Plantel = plantel;
            this.Civil = civil;
        }

        

        public string Guardar_DatosBasicos(Conexion_Gestion_DatosPersonales DatosBasicos)
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
                SqlCmd.CommandText = "Gestion.AJ_DatosPersonales";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIddatospersonales = new SqlParameter();
                ParIddatospersonales.ParameterName = "@Iddatospersonales";
                ParIddatospersonales.SqlDbType = SqlDbType.Int;
                ParIddatospersonales.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddatospersonales);

                SqlParameter ParCodigoID = new SqlParameter();
                ParCodigoID.ParameterName = "@CodigoID";
                ParCodigoID.SqlDbType = SqlDbType.VarChar;
                ParCodigoID.Size = 50;
                ParCodigoID.Value = DatosBasicos.CodigoID;
                SqlCmd.Parameters.Add(ParCodigoID);

                SqlParameter ParProfesion = new SqlParameter();
                ParProfesion.ParameterName = "@Profesion";
                ParProfesion.SqlDbType = SqlDbType.VarChar;
                ParProfesion.Size = 50;
                ParProfesion.Value = DatosBasicos.Profesion;
                SqlCmd.Parameters.Add(ParProfesion);

                SqlParameter ParPension = new SqlParameter();
                ParPension.ParameterName = "@Pension";
                ParPension.SqlDbType = SqlDbType.VarChar;
                ParPension.Size = 20;
                ParPension.Value = DatosBasicos.Pension;
                SqlCmd.Parameters.Add(ParPension);

                SqlParameter ParCompensacion = new SqlParameter();
                ParCompensacion.ParameterName = "@Compensacion";
                ParCompensacion.SqlDbType = SqlDbType.VarChar;
                ParCompensacion.Size = 20;
                ParCompensacion.Value = DatosBasicos.Compensacion;
                SqlCmd.Parameters.Add(ParCompensacion);

                SqlParameter ParContrato = new SqlParameter();
                ParContrato.ParameterName = "@Contrato";
                ParContrato.SqlDbType = SqlDbType.VarChar;
                ParContrato.Size = 20;
                ParContrato.Value = DatosBasicos.Contrato;
                SqlCmd.Parameters.Add(ParContrato);

                SqlParameter ParSueldo = new SqlParameter();
                ParSueldo.ParameterName = "@Sueldo";
                ParSueldo.SqlDbType = SqlDbType.VarChar;
                ParSueldo.Size = 20;
                ParSueldo.Value = DatosBasicos.Sueldos;
                SqlCmd.Parameters.Add(ParSueldo);

                SqlParameter ParAdelantos = new SqlParameter();
                ParAdelantos.ParameterName = "@Adelantos";
                ParAdelantos.SqlDbType = SqlDbType.VarChar;
                ParAdelantos.Size = 20;
                ParAdelantos.Value = DatosBasicos.Adelantos;
                SqlCmd.Parameters.Add(ParAdelantos);

                SqlParameter ParExtras = new SqlParameter();
                ParExtras.ParameterName = "@Extras";
                ParExtras.SqlDbType = SqlDbType.VarChar;
                ParExtras.Size = 10;
                ParExtras.Value = DatosBasicos.Extras;
                SqlCmd.Parameters.Add(ParExtras);

                SqlParameter ParBanco = new SqlParameter();
                ParBanco.ParameterName = "@Banco";
                ParBanco.SqlDbType = SqlDbType.VarChar;
                ParBanco.Size = 20;
                ParBanco.Value = DatosBasicos.Banco;
                SqlCmd.Parameters.Add(ParBanco);

                SqlParameter ParCuenta = new SqlParameter();
                ParCuenta.ParameterName = "@Cuenta";
                ParCuenta.SqlDbType = SqlDbType.VarChar;
                ParCuenta.Size = 20;
                ParCuenta.Value = DatosBasicos.Cuenta;
                SqlCmd.Parameters.Add(ParCuenta);

                SqlParameter ParNumero = new SqlParameter();
                ParNumero.ParameterName = "@Numero";
                ParNumero.SqlDbType = SqlDbType.VarChar;
                ParNumero.Size = 30;
                ParNumero.Value = DatosBasicos.Numero;
                SqlCmd.Parameters.Add(ParNumero);

                SqlParameter ParPago = new SqlParameter();
                ParPago.ParameterName = "@Pago";
                ParPago.SqlDbType = SqlDbType.VarChar;
                ParPago.Size = 20;
                ParPago.Value = DatosBasicos.Pago;
                SqlCmd.Parameters.Add(ParPago);

                SqlParameter ParMoneda = new SqlParameter();
                ParMoneda.ParameterName = "@Moneda";
                ParMoneda.SqlDbType = SqlDbType.VarChar;
                ParMoneda.Size = 10;
                ParMoneda.Value = DatosBasicos.Moneda;
                SqlCmd.Parameters.Add(ParMoneda);

                SqlParameter ParRecomendado = new SqlParameter();
                ParRecomendado.ParameterName = "@Recomendado";
                ParRecomendado.SqlDbType = SqlDbType.VarChar;
                ParRecomendado.Size = 50;
                ParRecomendado.Value = DatosBasicos.Recomendado;
                SqlCmd.Parameters.Add(ParRecomendado);

                SqlParameter ParNacimiento = new SqlParameter();
                ParNacimiento.ParameterName = "@Nacimiento";
                ParNacimiento.SqlDbType = SqlDbType.Date;
                ParNacimiento.Value = DatosBasicos.Nacimientos;
                SqlCmd.Parameters.Add(ParNacimiento);

                SqlParameter ParHijos = new SqlParameter();
                ParHijos.ParameterName = "@Hijos";
                ParHijos.SqlDbType = SqlDbType.VarChar;
                ParHijos.Size = 10;
                ParHijos.Value = DatosBasicos.Hijos;
                SqlCmd.Parameters.Add(ParHijos);

                SqlParameter ParPlantel = new SqlParameter();
                ParPlantel.ParameterName = "@Plantel";
                ParPlantel.SqlDbType = SqlDbType.VarChar;
                ParPlantel.Size = 10;
                ParPlantel.Value = DatosBasicos.Plantel;
                SqlCmd.Parameters.Add(ParPlantel);

                SqlParameter ParCivil = new SqlParameter();
                ParCivil.ParameterName = "@Civil";
                ParCivil.SqlDbType = SqlDbType.VarChar;
                ParCivil.Size = 10;
                ParCivil.Value = DatosBasicos.Civil;
                SqlCmd.Parameters.Add(ParCivil);

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
