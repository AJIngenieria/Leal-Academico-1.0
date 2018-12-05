using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fAcademico_Alumno
    {
        public static string Guardar_DatosBasicos
            (//Datos Basicos
            string auto, int idfamilia, string codigoid, int idorden,string carnet, string noorden, string nombres,
            string documentos, string identificacion, string familia, DateTime fechadenacimiento, string genero, int idciudad, int idmunicipio,
            int idnacionalidad, string becado, string direccion, string barrio, string estracto, string comuna, string telefono, string movil, string email)
        {
            Conexion_Academico_Alumno Obj = new Conexion_Academico_Alumno();
            //Datos Basicos
            Obj.IdFamilia = idfamilia;
            Obj.CodigoID = codigoid;
            Obj.IdOrden = idorden;
            Obj.Auto = auto;
            Obj.Carnet = carnet;
            Obj.No_Orden = noorden;
            Obj.Nombres = nombres;
            Obj.Documentos = documentos;
            Obj.Identificacion = identificacion;
            Obj.Familia = familia;
            Obj.FechaDeNacimiento = fechadenacimiento;
            Obj.Genero = genero;
            Obj.Idciudad = idciudad;
            Obj.Idmunicipio = idmunicipio;
            Obj.Idnacionalidad = idnacionalidad;
            Obj.Becado = becado;
            Obj.Direccion = direccion;
            Obj.Barrio = barrio;
            Obj.Estracto = estracto;
            Obj.Comuna = comuna;
            Obj.Telefono = telefono;
            Obj.Movil = movil;
            Obj.Email = email;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static string Guardar_DatosDelPadre
            (//Dato del Padre
            string auto, string padre, string codigoid, string identificacionpadre, string noidentificacionpadre, string hogarpadre, string direccionpadre, string barriopadre,
            string telefonopadre, string movilpadre, string profesionpadre, string empresapadre,
            string direccionempresapadre, string telefonoempresapadre, string estadocivilpadre, string emailpadre, string retiropadre, string informacionpadre)
        {
            Conexion_Academico_Padre Obj = new Conexion_Academico_Padre();
            //Datos del padre
            Obj.Auto = auto;
            Obj.CodigoID = codigoid;
            Obj.Padre = padre;
            Obj.Documento = identificacionpadre;
            Obj.Identificacion = noidentificacionpadre;
            Obj.Hogar = hogarpadre;
            Obj.Direccion = direccionpadre;
            Obj.Barrio = barriopadre;
            Obj.Telefono = telefonopadre;
            Obj.Movil = movilpadre;
            Obj.Profesion = profesionpadre;
            Obj.Empresa = empresapadre;
            Obj.DireccionEmpresa = direccionempresapadre;
            Obj.TelefonoEmpresa = telefonoempresapadre;
            Obj.EstadoCivil = estadocivilpadre;
            Obj.Email = emailpadre;
            Obj.Retiro = retiropadre;
            Obj.Informacion = informacionpadre;

            return Obj.Guardar_Padre(Obj);
        }

        public static string Guardar_DatosDeLaMadre
            (//Datos de la Madre
            string auto, string madre, string codigoid, string identificacionmadre, string noidentificacionmadre, string hogarmadre, string direccionmadre, string barriomadre,
            string telefonomadre, string movilmadre, string profesionmadre, string empresamadre, string direccionempresamadre, string telefonoempresamadre,
            string estadocivilmadre, string emailmadre, string retiromadre, string informacionmadre)
        {
            Conexion_Academico_Madre Obj = new Conexion_Academico_Madre();
            //Datos de la Madre
            Obj.Auto = auto;
            Obj.Madre = madre;
            Obj.CodigoID = codigoid;
            Obj.Identificacion_Madre = identificacionmadre;
            Obj.No_Identificacion_Madre = noidentificacionmadre;
            Obj.Hogar_Madre = hogarmadre;
            Obj.Direccion_Madre = direccionmadre;
            Obj.Barrio_Madre = barriomadre;
            Obj.Telefono_Madre = telefonomadre;
            Obj.Movil_Madre = movilmadre;
            Obj.Profesion_Madre = profesionmadre;
            Obj.Empresa_Madre = empresamadre;
            Obj.DireccionEmpresa_Madre = direccionempresamadre;
            Obj.TelefonoEmpresa_Madre = telefonoempresamadre;
            Obj.EstadoCivil_Madre = estadocivilmadre;
            Obj.Email_Madre = emailmadre;
            Obj.Retiro_Madre = retiromadre;
            Obj.Informacion_Madre = informacionmadre;

            return Obj.Guardar_Madre(Obj);
        }

        public static string Guardar_DatosDelAcudiente
            (//Datos del acudiente
            string auto, string acudiente, string codigoid, string identificacionacudiente, string noidentificacionacudiente, string parentescoacudiente,
            string direccionacudiente, string telefonoacudiente, string movilacudiente, string emailacudiente, string observacionacudiente)
        {
            Conexion_Academico_Acudiente Obj = new Conexion_Academico_Acudiente();
            //Datos del Acudiente
            Obj.Auto = auto;
            Obj.Acudiente = acudiente;
            Obj.CodigoID = codigoid;
            Obj.Documento = identificacionacudiente;
            Obj.Identificacion = noidentificacionacudiente;
            Obj.Parentesco = parentescoacudiente;
            Obj.Direccion = direccionacudiente;
            Obj.Telefono = telefonoacudiente;
            Obj.Movil = movilacudiente;
            Obj.Email = emailacudiente;
            Obj.Observacion = observacionacudiente;

            return Obj.Guardar_Acudiente(Obj);
        }

        public static string Guardar_DatosMedicos
            (//Datos Medicos
            string auto, string codigoid, string gruposanguineo, string eps, string alimentos, string animales, string insectos,
            string medicamentos, string plantas, string otros, string indicaciones)
        {
            Conexion_Academico_Salud Obj = new Conexion_Academico_Salud();
            //Datos Medicos
            Obj.Auto = auto;
            Obj.CodigoID = codigoid;
            Obj.GrupoSanguineo = gruposanguineo;
            Obj.Eps = eps;
            Obj.Alimentos = alimentos;
            Obj.Animales = animales;
            Obj.Insectos = insectos;
            Obj.Medicamentos = medicamentos;
            Obj.Plantas = plantas;
            Obj.Otros = otros;
            Obj.Indicaciones = indicaciones;

            return Obj.Guardar_Salud(Obj);
        }

        public static string Guardar_InformacionAcademica(string auto, int idcurso, int idjornada, int idperiodo, int idestado, DateTime fechadeingreso, byte[] Foto, string codigoid,string institutoanterior, string instituto, string documento)
        {
            Conexion_Academico_InformacionAcademica Obj = new Conexion_Academico_InformacionAcademica();
            //Informacion Academica
            Obj.Auto = auto;
            Obj.Idcurso = idcurso;
            Obj.Idjornada = idjornada;
            Obj.Idperiodo = idperiodo;
            Obj.Idestado = idestado;
            Obj.FechaDeIngreso = fechadeingreso;
            Obj.InstitutoAnterior = institutoanterior;
            Obj.Instituto = instituto;
            Obj.Documentos = documento;
            Obj.Foto = Foto;
            Obj.CodigoID = codigoid;

            return Obj.Guardar_InformacionAcademica(Obj);
        }

        public static DataTable Examinar_PorCarnet(string filtro)
        {
            Conexion_Academico_Alumno Obj = new Conexion_Academico_Alumno();
            Obj.Filtro = filtro;
            return Obj.Examinar_AlumnoPorCarnet(Obj);
        }

        public static DataTable Examinar_PorIdentificacion(string filtro)
        {
            Conexion_Academico_Alumno Obj = new Conexion_Academico_Alumno();
            Obj.Filtro = filtro;
            return Obj.Examinar_AlumnoPorIdentificacion(Obj);
        }

        public static DataTable Examinar_PorNombre(string filtro)
        {
            Conexion_Academico_Alumno Obj = new Conexion_Academico_Alumno();
            Obj.Filtro = filtro;
            return Obj.Examinar_Alumno(Obj);
        }

    }
}
