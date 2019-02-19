using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Academico_InformacionAcademica
    {
        //Llaves primarias
        private int _Idinformacionacademica;
        private string _CodigoID;

        //Informacion Academica
        private int _Idcurso;
        private int _Idjornada;
        private int _Idperiodo;
        private int _Idestado;
        private DateTime _FechaDeIngreso;
        private string _InstitutoAnterior;
        private string _Instituto;
        private string _Documentos;

        private byte[] _Foto;

        //Campos Auxiliares
        private string _Auto;
        private string _Filtro;

        public int Idinformacionacademica { get => _Idinformacionacademica; set => _Idinformacionacademica = value; }
        public string CodigoID { get => _CodigoID; set => _CodigoID = value; }
        public int Idcurso { get => _Idcurso; set => _Idcurso = value; }
        public int Idjornada { get => _Idjornada; set => _Idjornada = value; }
        public int Idperiodo { get => _Idperiodo; set => _Idperiodo = value; }
        public int Idestado { get => _Idestado; set => _Idestado = value; }
        public DateTime FechaDeIngreso { get => _FechaDeIngreso; set => _FechaDeIngreso = value; }
        public byte[] Foto { get => _Foto; set => _Foto = value; }
        public string Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public string InstitutoAnterior { get => _InstitutoAnterior; set => _InstitutoAnterior = value; }
        public string Instituto { get => _Instituto; set => _Instituto = value; }
        public string Documentos { get => _Documentos; set => _Documentos = value; }

        //Constructor Vacio
        public Conexion_Academico_InformacionAcademica()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Academico_InformacionAcademica(
            
            //Informacion Academica
            int idinformacion, int idcurso, int idjornada, int idperiodo, string codigoid, int idestado, string ultimocurso, string ultimajornada,
            DateTime fechadeingreso, string institutoanterior, string instituto, string documentos, byte[] Foto, 

            //Filtros de Busquda
            string filtro

            )
        {

            //Informacion Academica
            this.CodigoID = codigoid;
            this.Idcurso = idcurso;
            this.Idjornada = idjornada;
            this.Idperiodo = idperiodo;
            this.Idestado = idestado;
            this.FechaDeIngreso = fechadeingreso;
            this.InstitutoAnterior = InstitutoAnterior;
            this.Instituto = instituto;
            this.Documentos = documentos;
            this.Foto = Foto;

            //Filtros de Busquda
            this.Filtro = filtro;
        }

        

        public string Guardar_InformacionAcademica(Conexion_Academico_InformacionAcademica Alumno)
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
                SqlCmd.CommandText = "Academico.AJ_InformacionAcademica";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdalumno = new SqlParameter();
                ParIdalumno.ParameterName = "@Idinformacion";
                ParIdalumno.SqlDbType = SqlDbType.Int;
                ParIdalumno.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdalumno);

                SqlParameter ParCodigoID = new SqlParameter();
                ParCodigoID.ParameterName = "@CodigoID";
                ParCodigoID.SqlDbType = SqlDbType.VarChar;
                ParCodigoID.Size = 20;
                ParCodigoID.Value = Alumno.CodigoID;
                SqlCmd.Parameters.Add(ParCodigoID);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Alumno.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParCurso = new SqlParameter();
                ParCurso.ParameterName = "@Idcurso";
                ParCurso.SqlDbType = SqlDbType.Int;
                ParCurso.Value = Alumno.Idcurso;
                SqlCmd.Parameters.Add(ParCurso);

                SqlParameter ParJornada = new SqlParameter();
                ParJornada.ParameterName = "@Idjornada";
                ParJornada.SqlDbType = SqlDbType.Int;
                ParJornada.Value = Alumno.Idjornada;
                SqlCmd.Parameters.Add(ParJornada);

                SqlParameter ParPeriodo = new SqlParameter();
                ParPeriodo.ParameterName = "@Idperiodo";
                ParPeriodo.SqlDbType = SqlDbType.Int;
                ParPeriodo.Value = Alumno.Idperiodo;
                SqlCmd.Parameters.Add(ParPeriodo);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Idestado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = Alumno.Idestado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParFechaDeIngreso = new SqlParameter();
                ParFechaDeIngreso.ParameterName = "@Ingreso";
                ParFechaDeIngreso.SqlDbType = SqlDbType.Date;
                ParFechaDeIngreso.Value = Alumno.FechaDeIngreso;
                SqlCmd.Parameters.Add(ParFechaDeIngreso);

                SqlParameter ParInstitutoAnterior = new SqlParameter();
                ParInstitutoAnterior.ParameterName = "@InstitutoAnterior";
                ParInstitutoAnterior.SqlDbType = SqlDbType.VarChar;
                ParInstitutoAnterior.Size = 10;
                ParInstitutoAnterior.Value = Alumno.InstitutoAnterior;
                SqlCmd.Parameters.Add(ParInstitutoAnterior);

                SqlParameter ParInstituto = new SqlParameter();
                ParInstituto.ParameterName = "@Instituto";
                ParInstituto.SqlDbType = SqlDbType.VarChar;
                ParInstituto.Size = 30;
                ParInstituto.Value = Alumno.Instituto;
                SqlCmd.Parameters.Add(ParInstituto);

                SqlParameter ParDocumentos = new SqlParameter();
                ParDocumentos.ParameterName = "@Documento";
                ParDocumentos.SqlDbType = SqlDbType.VarChar;
                ParDocumentos.Size = 100;
                ParDocumentos.Value = Alumno.Documentos;
                SqlCmd.Parameters.Add(ParDocumentos);

                SqlParameter ParFoto = new SqlParameter();
                ParFoto.ParameterName = "@Foto";
                ParFoto.SqlDbType = SqlDbType.Image;
                ParFoto.Value = Alumno.Foto;
                SqlCmd.Parameters.Add(ParFoto);


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
