using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fBiblioteca_Prestamos
    {
        //Método Insertar que llama al método Insertar de la clase DIngreso
        //de la CapaDatos
        public static string Guardar_PrestamosAlumnos(int idalumno,  string alumno, string identificacion, int nu_identificacion, DateTime prestamo , DateTime devolucion, string estado, DataTable dtDetalles)
        {
            Conexion_Biblioteca_Prestamos Obj = new Conexion_Biblioteca_Prestamos();
            Obj.Idalumno = idalumno;
            Obj.Alumno = alumno;
            Obj.Identificacion = identificacion;
            Obj.Nu_Identificacion = nu_identificacion;
            Obj.Prestamo = prestamo;
            Obj.Devolucion = devolucion;
            Obj.Estado = estado;
            List<Conexion_Biblioteca_DetalleDePrestamos> detalles = new List<Conexion_Biblioteca_DetalleDePrestamos>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                Conexion_Biblioteca_DetalleDePrestamos detalle = new Conexion_Biblioteca_DetalleDePrestamos();
                detalle.Idarticulo = Convert.ToInt32(row["idarticulo"].ToString());
                detalle.Articulo = Convert.ToString(row["Articulo"].ToString());
                detalle.Cantidad = Convert.ToString(row["Cantidad"].ToString());
                detalle.Serie = Convert.ToString(row["Serie"].ToString());
                detalles.Add(detalle);
            }
            return Obj.Guardar_PrestamosAlumnos(Obj, detalles);
        }
        
        public static string Guardar_PrestamosDocente(int idempleado, string docente, string identificacion, int nu_identificacion, DateTime prestamo, DateTime devolucion, string estado, DataTable dtDetalles)
        {
            Conexion_Biblioteca_Prestamos Obj = new Conexion_Biblioteca_Prestamos();
            Obj.Idempleado = idempleado;
            Obj.Docente = docente;
            Obj.Identificacion = identificacion;
            Obj.Nu_Identificacion = nu_identificacion;
            Obj.Prestamo = prestamo;
            Obj.Devolucion = devolucion;
            Obj.Estado = estado;
            List<Conexion_Biblioteca_DetalleDePrestamos> detalles = new List<Conexion_Biblioteca_DetalleDePrestamos>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                Conexion_Biblioteca_DetalleDePrestamos detalle = new Conexion_Biblioteca_DetalleDePrestamos();
                detalle.Idarticulo = Convert.ToInt32(row["idarticulo"].ToString());
                detalle.Articulo = Convert.ToString(row["Articulo"].ToString());
                detalle.Cantidad = Convert.ToString(row["Cantidad"].ToString());
                detalle.Serie = Convert.ToString(row["Serie"].ToString());
                detalles.Add(detalle);
            }
            return Obj.Guardar_PrestamosDocente(Obj, detalles);
        }

    }
}
