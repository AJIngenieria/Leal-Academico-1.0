using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fGestion_DatosPersonales
    {
        //Método Insertar que llama al método Insertar de la clase DIngreso
        //de la CapaDatos
        public static string Guardar_DatosBasicos(/*int idempleado,*/ string codigoid, string profesion, string pension, string compensacion, string contrato, string sueldo, string adelanto,
            string extras, string banco, string cuenta, string numero,
            string pago, string moneda, string recomendado, DateTime nacimiento, string hijos, string plantel, string civil)
        {
            Conexion_Gestion_DatosPersonales Obj = new Conexion_Gestion_DatosPersonales();
            //Obj.Idempleados = idempleado;
            Obj.CodigoID = codigoid;

            Obj.Profesion = profesion;
            Obj.Pension = pension;
            Obj.Compensacion = compensacion;
            Obj.Contrato = contrato;
            Obj.Sueldos = sueldo;
            Obj.Adelantos = adelanto;
            Obj.Extras = extras;
            Obj.Banco = banco;
            Obj.Cuenta = cuenta;
            Obj.Numero = numero;
            Obj.Pago = pago;
            Obj.Moneda = moneda;
            Obj.Recomendado = recomendado;
            Obj.Nacimientos = nacimiento;
            Obj.Hijos = hijos;
            Obj.Plantel = plantel;
            Obj.Civil = civil;

            return Obj.Guardar_DatosBasicos(Obj);
        }
    }
}
