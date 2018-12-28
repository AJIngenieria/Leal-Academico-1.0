using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmAcademico_Alumnos : Form
    {
        private bool IsNuevo = false;
        private bool Habilitado = false;

        public int Idtrabajador;
        private DataTable dtDetalle;

        public string Auto_CodigoID = "";

        private static frmAcademico_Alumnos _Instancia;

        public static frmAcademico_Alumnos GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmAcademico_Alumnos();
            }
            return _Instancia;
        }

        public frmAcademico_Alumnos()
        {
            InitializeComponent();
        }

        private void frmAcademico_Alumnos_Load(object sender, EventArgs e)
        {
            this.Habilitar();
            this.Botones();

            this.CBGenero.SelectedIndex = 0;
            this.CBBecario.SelectedIndex = 0;
            this.CBEstado.SelectedIndex = 0;
            this.CBIdentificacion_Madre.SelectedIndex = 0;
            this.CBIdentificacion_Padre.SelectedIndex = 0;
            this.CBHogar_Madre.SelectedIndex = 0;
            this.CBHogar_Padre.SelectedIndex = 0;
            this.CBEstadoCivil_Madre.SelectedIndex = 0;
            this.CBEstadocivil_Padre.SelectedIndex = 0;
            this.CBRetiro_Madre.SelectedIndex = 0;
            this.CBRetiro_Padre.SelectedIndex = 0;
            this.CBInformacion_Madre.SelectedIndex = 0;
            this.CBInformacion_Padre.SelectedIndex = 0;
            this.CBIdentificacion_Acudiente.SelectedIndex = 0;
            this.CBSangre_DatosMedicos.SelectedIndex = 0;
        }

        //public string Auto_CodigoID = "";

        //public string Codigo = "";
        //public string IdentificacionAlumno = "";
        //public string NºIdentificacion = "";
        //public string FechadeRegistro = "";
        //public string TipodeSangre = "";
        //public string OtroInstituto = "";
        //public string Plantel = "";
        //public string UltimoCurso = "";
        //public string Documentos = "";
        //public string Estado = "";
        //public string Observacion = "";
        //public string PlanPadrino = "";
        //public string Matricula = "";
        //public string Acudiente = "";
        //public string IdentificacionAcudiente = "";
        //public string NºIdentificacionAcudiente = "";
        //public string Telefono = "";
        //public string Correo = "";
        //public string Direccion = "";

        private void Gestion_Usuarios()
        {
            

            //Menus Principales

            //if (MenuAcademico == "Permitido")
            //{
            //    this.MPAcademico.Visible = true;
            //}
            //if (MenuAcademico == "Denegado")
            //{
            //    this.MPAcademico.Visible = false;
            //}

            //if (MenuBiblioteca == "Permitido")
            //{
            //    this.MPBiblioteca.Visible = true;
            //}
            //if (MenuBiblioteca == "Denegado")
            //{
            //    this.MPBiblioteca.Visible = false;
            //}

        }

        private void ColoresDeBotones()
        {
            btnNuevo.BackgroundImage = Properties.Resources.BV_Nuevo;
            btnGuardar.BackgroundImage = Properties.Resources.BV_Guardar;

            PanelFoto.BackgroundImage = Properties.Resources.A_J_Academico;
        }

        private void Habilitar()
        {
            if (Habilitado == false)
            {
                //Datos Basicos
                this.TBCodigoID.ReadOnly = true;
                this.TBCodigoID.BackColor = Color.FromArgb(187, 222, 251);
                this.TBCarnet.ReadOnly = true;
                this.TBCarnet.BackColor = Color.FromArgb(187, 222, 251);
                this.TBOrden.ReadOnly = true;
                this.TBOrden.BackColor = Color.FromArgb(187, 222, 251);
                this.TBNombres.ReadOnly = true;
                this.TBNombres.BackColor = Color.FromArgb(187, 222, 251);
                this.TBTipoIdentificacion_Alumno.ReadOnly = true;
                this.TBTipoIdentificacion_Alumno.BackColor = Color.FromArgb(187, 222, 251);
                this.TBIdentificacion_Alumno.ReadOnly = true;
                this.TBIdentificacion_Alumno.BackColor = Color.FromArgb(187, 222, 251);
                this.TBFamilia.ReadOnly = true;
                this.TBFamilia.BackColor = Color.FromArgb(187, 222, 251);
                //this.DTFechadenacimiento.ReadOnly = !Estado;
                this.DTFechadenacimiento.BackColor = Color.FromArgb(187, 222, 251);
                this.CBGenero.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBGenero.BackColor = Color.FromArgb(187, 222, 251);
                //this.TBCiudad.ReadOnly = true;
                //this.TBCiudad.BackColor = Color.FromArgb(187, 222, 251);
                //this.TBMunicipio.ReadOnly = true;
                //this.TBMunicipio.BackColor = Color.FromArgb(187, 222, 251);
                //this.TBNacionalidad.ReadOnly = true;
                //this.TBNacionalidad.BackColor = Color.FromArgb(187, 222, 251);
                this.CBBecario.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBBecario.BackColor = Color.FromArgb(187, 222, 251);
                this.TBDireccion.ReadOnly = true;
                this.TBDireccion.BackColor = Color.FromArgb(187, 222, 251);
                this.TBBarrio.ReadOnly = true;
                this.TBBarrio.BackColor = Color.FromArgb(187, 222, 251);
                this.TBEstracto.ReadOnly = true;
                this.TBEstracto.BackColor = Color.FromArgb(187, 222, 251);
                this.TBComuna.ReadOnly = true;
                this.TBComuna.BackColor = Color.FromArgb(187, 222, 251);
                this.TBTelefono.ReadOnly = true;
                this.TBTelefono.BackColor = Color.FromArgb(187, 222, 251);
                this.TBMovil.ReadOnly = true;
                this.TBMovil.BackColor = Color.FromArgb(187, 222, 251);
                this.TBEmail.ReadOnly = true;
                this.TBEmail.BackColor = Color.FromArgb(187, 222, 251);

                //Informacion Academica
                this.TBCurso.Enabled = false;
                this.TBCurso.BackColor = Color.FromArgb(187, 222, 251);
                this.TBJornada.Enabled = false;
                this.TBJornada.BackColor = Color.FromArgb(187, 222, 251);
                this.CBEstado.Enabled = false;
                this.CBEstado.BackColor = Color.FromArgb(187, 222, 251);

                //Datos del Padre

                this.TBPadre.ReadOnly = true;
                this.TBPadre.BackColor = Color.FromArgb(187, 222, 251);
                this.CBIdentificacion_Padre.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBIdentificacion_Padre.BackColor = Color.FromArgb(187, 222, 251);
                this.TBIdentificacion_Padre.ReadOnly = true;
                this.TBIdentificacion_Padre.BackColor = Color.FromArgb(187, 222, 251);
                this.CBHogar_Padre.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBHogar_Padre.BackColor = Color.FromArgb(187, 222, 251);
                this.TBDireccion_Padre.ReadOnly = true;
                this.TBDireccion_Padre.BackColor = Color.FromArgb(187, 222, 251);
                this.TBBarrio_Padre.ReadOnly = true;
                this.TBBarrio_Padre.BackColor = Color.FromArgb(187, 222, 251);
                this.TBFijo_Padre.ReadOnly = true;
                this.TBFijo_Padre.BackColor = Color.FromArgb(187, 222, 251);
                this.TBMovil_Padre.ReadOnly = true;
                this.TBMovil_Padre.BackColor = Color.FromArgb(187, 222, 251);
                this.TBProfesion_Padre.ReadOnly = true;
                this.TBProfesion_Padre.BackColor = Color.FromArgb(187, 222, 251);
                this.TBEmpresa_Padre.ReadOnly = true;
                this.TBEmpresa_Padre.BackColor = Color.FromArgb(187, 222, 251);
                this.TBDireccion_Empresa.ReadOnly = true;
                this.TBDireccion_Empresa.BackColor = Color.FromArgb(187, 222, 251);
                this.TBTelefono_Padre.ReadOnly = true;
                this.TBTelefono_Padre.BackColor = Color.FromArgb(187, 222, 251);
                this.CBEstadocivil_Padre.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBEstadocivil_Padre.BackColor = Color.FromArgb(187, 222, 251);
                this.TBEmail_Padre.ReadOnly = true;
                this.TBEmail_Padre.BackColor = Color.FromArgb(187, 222, 251);
                this.CBRetiro_Padre.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBRetiro_Padre.BackColor = Color.FromArgb(187, 222, 251);
                this.CBInformacion_Padre.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBInformacion_Padre.BackColor = Color.FromArgb(187, 222, 251);

                //Datos del Madre
                this.TBMadre.ReadOnly = true;
                this.TBMadre.BackColor = Color.FromArgb(187, 222, 251);
                this.CBIdentificacion_Madre.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBIdentificacion_Madre.BackColor = Color.FromArgb(187, 222, 251);
                this.TBIdentificacion_Madre.ReadOnly = true;
                this.TBIdentificacion_Madre.BackColor = Color.FromArgb(187, 222, 251);
                this.CBHogar_Madre.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBHogar_Madre.BackColor = Color.FromArgb(187, 222, 251);
                this.TBDireccion_Madre.ReadOnly = true;
                this.TBDireccion_Madre.BackColor = Color.FromArgb(187, 222, 251);
                this.TBBarrio_Madre.ReadOnly = true;
                this.TBBarrio_Madre.BackColor = Color.FromArgb(187, 222, 251);
                this.TBTelefono_Madre.ReadOnly = true;
                this.TBTelefono_Madre.BackColor = Color.FromArgb(187, 222, 251);
                this.TBMovil_Madre.ReadOnly = true;
                this.TBMovil_Madre.BackColor = Color.FromArgb(187, 222, 251);
                this.TBProfesion_Madre.ReadOnly = true;
                this.TBProfesion_Madre.BackColor = Color.FromArgb(187, 222, 251);
                this.TBEmpresa_Madre.ReadOnly = true;
                this.TBEmpresa_Madre.BackColor = Color.FromArgb(187, 222, 251);
                this.TBDireccion_Madre.ReadOnly = true;
                this.TBDireccion_Madre.BackColor = Color.FromArgb(187, 222, 251);
                this.TBTelefonoEmpresa_Madre.ReadOnly = true;
                this.TBTelefonoEmpresa_Madre.BackColor = Color.FromArgb(187, 222, 251);
                this.CBEstadoCivil_Madre.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBEstadoCivil_Madre.BackColor = Color.FromArgb(187, 222, 251);
                this.TBEmail_Madre.ReadOnly = true;
                this.TBEmail_Madre.BackColor = Color.FromArgb(187, 222, 251);
                this.CBRetiro_Madre.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBRetiro_Madre.BackColor = Color.FromArgb(187, 222, 251);
                this.CBInformacion_Madre.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBInformacion_Madre.BackColor = Color.FromArgb(187, 222, 251);

                //Acudiente
                this.TBAcudiente.ReadOnly = true;
                this.TBAcudiente.BackColor = Color.FromArgb(187, 222, 251);
                this.CBIdentificacion_Acudiente.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBIdentificacion_Acudiente.BackColor = Color.FromArgb(187, 222, 251);
                this.TBIdentificacion_Acudiente.ReadOnly = true;
                this.TBIdentificacion_Acudiente.BackColor = Color.FromArgb(187, 222, 251);
                this.TBParentesco_Acudiente.ReadOnly = true;
                this.TBParentesco_Acudiente.BackColor = Color.FromArgb(187, 222, 251);
                this.TBDireccion_Acudiente.ReadOnly = true;
                this.TBDireccion_Acudiente.BackColor = Color.FromArgb(187, 222, 251);
                this.TBTelefono_Acudiente.ReadOnly = true;
                this.TBTelefono_Acudiente.BackColor = Color.FromArgb(187, 222, 251);
                this.TBMovil_Acudiente.ReadOnly = true;
                this.TBMovil_Acudiente.BackColor = Color.FromArgb(187, 222, 251);
                this.TBEmail_Acudiente.ReadOnly = true;
                this.TBEmail_Acudiente.BackColor = Color.FromArgb(187, 222, 251);
                this.TBObservacion_Acudiente.ReadOnly = true;
                this.TBObservacion_Acudiente.BackColor = Color.FromArgb(187, 222, 251);

                //Datos Medicos
                this.CBSangre_DatosMedicos.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBSangre_DatosMedicos.BackColor = Color.FromArgb(187, 222, 251);
                this.CBEps_Medicos.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBEps_Medicos.BackColor = Color.FromArgb(187, 222, 251);
                this.TBAnimales_DatosMedicos.ReadOnly = true;
                this.TBAnimales_DatosMedicos.BackColor = Color.FromArgb(187, 222, 251);
                this.TBAlimentos_DatosMedicos.ReadOnly = true;
                this.TBAlimentos_DatosMedicos.BackColor = Color.FromArgb(187, 222, 251);
                this.TBInsectos_DatosMedicos.ReadOnly = true;
                this.TBInsectos_DatosMedicos.BackColor = Color.FromArgb(187, 222, 251);
                this.TBMedicamentos_DatosMedicos.ReadOnly = true;
                this.TBMedicamentos_DatosMedicos.BackColor = Color.FromArgb(187, 222, 251);
                this.TBPlantas_DatosMedicos.ReadOnly = true;
                this.TBPlantas_DatosMedicos.BackColor = Color.FromArgb(187, 222, 251);
                this.TBOtro_DatosMedicos.ReadOnly = true;
                this.TBOtro_DatosMedicos.BackColor = Color.FromArgb(187, 222, 251);
                this.TBInformacion_DatosMedicos.ReadOnly = true;
                this.TBInformacion_DatosMedicos.BackColor = Color.FromArgb(187, 222, 251);

                //Otros Datos
                this.TBInstitutoAnterior.ReadOnly = true;
                this.TBInstitutoAnterior.BackColor = Color.FromArgb(187, 222, 251);
                this.CBInstitutoAnterior.Enabled = false;
                this.CBInstitutoAnterior.BackColor = Color.FromArgb(187, 222, 251);
                //this.TBDocumentos.ReadOnly = true;
                //this.TBDocumentos.BackColor = Color.FromArgb(187, 222, 251);
            }

            else if (Habilitado == true)
            {
                //Datos Basicos
                //this.TBCodigoID.ReadOnly = false;
                //this.TBCodigoID.BackColor = Color.FromArgb(32, 178, 170);
                //this.TBOrden.ReadOnly = false;
                //this.TBOrden.BackColor = Color.FromArgb(32, 178, 170);
                //this.TBNombres.ReadOnly = false;
                //this.TBNombres.BackColor = Color.FromArgb(32, 178, 170);
                //this.TBTipoIdentificacion_Alumno.ReadOnly = false;
                //this.TBTipoIdentificacion_Alumno.BackColor = Color.FromArgb(32, 178, 170);
                //this.TBIdentificacion_Alumno.ReadOnly = false;
                //this.TBIdentificacion_Alumno.BackColor = Color.FromArgb(32, 178, 170);
                //this.TBFamilia.ReadOnly = false;
                //this.TBFamilia.BackColor = Color.FromArgb(32, 178, 170);
                //this.DTFechadenacimiento.ReadOnly = false;
                this.DTFechadenacimiento.BackColor = Color.FromArgb(32, 178, 170);
                this.CBGenero.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBGenero.BackColor = Color.FromArgb(32, 178, 170);
                //this.TBCiudad.ReadOnly = false;
                //this.TBCiudad.BackColor = Color.FromArgb(32, 178, 170);
                //this.TBMunicipio.ReadOnly = false;
                //this.TBMunicipio.BackColor = Color.FromArgb(32, 178, 170);
                //this.TBNacionalidad.ReadOnly = false;
                //this.TBNacionalidad.BackColor = Color.FromArgb(32, 178, 170);
                this.CBBecario.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBBecario.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDireccion.ReadOnly = false;
                this.TBDireccion.BackColor = Color.FromArgb(32, 178, 170);
                this.TBBarrio.ReadOnly = false;
                this.TBBarrio.BackColor = Color.FromArgb(32, 178, 170);
                this.TBEstracto.ReadOnly = false;
                this.TBEstracto.BackColor = Color.FromArgb(32, 178, 170);
                this.TBComuna.ReadOnly = false;
                this.TBComuna.BackColor = Color.FromArgb(32, 178, 170);
                this.TBTelefono.ReadOnly = false;
                this.TBTelefono.BackColor = Color.FromArgb(32, 178, 170);
                this.TBMovil.ReadOnly = false;
                this.TBMovil.BackColor = Color.FromArgb(32, 178, 170);
                this.TBEmail.ReadOnly = false;
                this.TBEmail.BackColor = Color.FromArgb(32, 178, 170);

                //Informacion Academica
                this.TBCurso.Enabled = true;
                this.TBCurso.BackColor = Color.FromArgb(32, 178, 170);
                this.TBJornada.Enabled = true;
                this.TBJornada.BackColor = Color.FromArgb(32, 178, 170);
                this.CBEstado.Enabled = true;
                this.CBEstado.BackColor = Color.FromArgb(32, 178, 170);

                ////Datos del Padre
                this.TBPadre.ReadOnly = false;
                this.TBPadre.BackColor = Color.FromArgb(32, 178, 170);
                this.CBIdentificacion_Padre.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBIdentificacion_Padre.BackColor = Color.FromArgb(32, 178, 170);
                this.TBIdentificacion_Padre.ReadOnly = false;
                this.TBIdentificacion_Padre.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDireccion_Padre.ReadOnly = false;
                this.TBDireccion_Padre.BackColor = Color.FromArgb(32, 178, 170);
                this.TBBarrio_Padre.ReadOnly = false;
                this.TBBarrio_Padre.BackColor = Color.FromArgb(32, 178, 170);
                this.TBFijo_Padre.ReadOnly = false;
                this.TBFijo_Padre.BackColor = Color.FromArgb(32, 178, 170);
                this.TBEmpresa_Padre.ReadOnly = false;
                this.TBEmpresa_Padre.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDireccion_Empresa.ReadOnly = false;
                this.TBDireccion_Empresa.BackColor = Color.FromArgb(32, 178, 170);
                this.TBTelefono_Padre.ReadOnly = false;
                this.TBTelefono_Padre.BackColor = Color.FromArgb(32, 178, 170);
                this.TBMovil_Padre.ReadOnly = false;
                this.TBMovil_Padre.BackColor = Color.FromArgb(32, 178, 170);
                this.TBProfesion_Padre.ReadOnly = false;
                this.TBProfesion_Padre.BackColor = Color.FromArgb(32, 178, 170);
                this.CBEstadocivil_Padre.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBEstadocivil_Padre.BackColor = Color.FromArgb(32, 178, 170);
                this.TBEmail_Padre.ReadOnly = false;
                this.TBEmail_Padre.BackColor = Color.FromArgb(32, 178, 170);
                this.CBRetiro_Padre.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBRetiro_Padre.BackColor = Color.FromArgb(32, 178, 170);
                this.CBInformacion_Padre.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBInformacion_Padre.BackColor = Color.FromArgb(32, 178, 170);

                //Datos de la Madre
                this.TBMadre.ReadOnly = false;
                this.TBMadre.BackColor = Color.FromArgb(32, 178, 170);
                this.CBIdentificacion_Madre.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBIdentificacion_Madre.BackColor = Color.FromArgb(32, 178, 170);
                this.TBIdentificacion_Madre.ReadOnly = false;
                this.TBIdentificacion_Madre.BackColor = Color.FromArgb(32, 178, 170);
                this.CBHogar_Madre.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBHogar_Madre.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDireccion_Madre.ReadOnly = false;
                this.TBDireccion_Madre.BackColor = Color.FromArgb(32, 178, 170);
                this.TBBarrio_Madre.ReadOnly = false;
                this.TBBarrio_Madre.BackColor = Color.FromArgb(32, 178, 170);
                this.TBTelefono_Madre.ReadOnly = false;
                this.TBTelefono_Madre.BackColor = Color.FromArgb(32, 178, 170);
                this.TBMovil_Madre.ReadOnly = false;
                this.TBMovil_Madre.BackColor = Color.FromArgb(32, 178, 170);
                this.TBProfesion_Madre.ReadOnly = false;
                this.TBProfesion_Madre.BackColor = Color.FromArgb(32, 178, 170);
                this.TBEmpresa_Madre.ReadOnly = false;
                this.TBEmpresa_Madre.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDireccionEmpresa_Madre.ReadOnly = false;
                this.TBDireccionEmpresa_Madre.BackColor = Color.FromArgb(32, 178, 170);
                this.TBTelefonoEmpresa_Madre.ReadOnly = false;
                this.TBTelefonoEmpresa_Madre.BackColor = Color.FromArgb(32, 178, 170);
                this.CBEstadoCivil_Madre.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBEstadoCivil_Madre.BackColor = Color.FromArgb(32, 178, 170);
                this.TBEmail_Madre.ReadOnly = false;
                this.TBEmail_Madre.BackColor = Color.FromArgb(32, 178, 170);
                this.CBRetiro_Madre.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBRetiro_Madre.BackColor = Color.FromArgb(32, 178, 170);
                this.CBInformacion_Madre.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBInformacion_Madre.BackColor = Color.FromArgb(32, 178, 170);

                //Acudiente
                this.TBAcudiente.ReadOnly = false;
                this.TBAcudiente.BackColor = Color.FromArgb(32, 178, 170);
                this.CBIdentificacion_Acudiente.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBIdentificacion_Acudiente.BackColor = Color.FromArgb(32, 178, 170);
                this.TBIdentificacion_Acudiente.ReadOnly = false;
                this.TBIdentificacion_Acudiente.BackColor = Color.FromArgb(32, 178, 170);
                this.TBParentesco_Acudiente.ReadOnly = false;
                this.TBParentesco_Acudiente.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDireccion_Acudiente.ReadOnly = false;
                this.TBDireccion_Acudiente.BackColor = Color.FromArgb(32, 178, 170);
                this.TBTelefono_Acudiente.ReadOnly = false;
                this.TBTelefono_Acudiente.BackColor = Color.FromArgb(32, 178, 170);
                this.TBMovil_Acudiente.ReadOnly = false;
                this.TBMovil_Acudiente.BackColor = Color.FromArgb(32, 178, 170);
                this.TBEmail_Acudiente.ReadOnly = false;
                this.TBEmail_Acudiente.BackColor = Color.FromArgb(32, 178, 170);
                this.TBObservacion_Acudiente.ReadOnly = false;
                this.TBObservacion_Acudiente.BackColor = Color.FromArgb(32, 178, 170);

                //Datos Medicos
                this.CBSangre_DatosMedicos.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBSangre_DatosMedicos.BackColor = Color.FromArgb(32, 178, 170);
                this.CBEps_Medicos.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBEps_Medicos.BackColor = Color.FromArgb(32, 178, 170);
                this.TBAlimentos_DatosMedicos.ReadOnly = false;
                this.TBAlimentos_DatosMedicos.BackColor = Color.FromArgb(32, 178, 170);
                this.TBAnimales_DatosMedicos.ReadOnly = false;
                this.TBAnimales_DatosMedicos.BackColor = Color.FromArgb(32, 178, 170);
                this.TBInsectos_DatosMedicos.ReadOnly = false;
                this.TBInsectos_DatosMedicos.BackColor = Color.FromArgb(32, 178, 170);
                this.TBMedicamentos_DatosMedicos.ReadOnly = false;
                this.TBMedicamentos_DatosMedicos.BackColor = Color.FromArgb(32, 178, 170);
                this.TBPlantas_DatosMedicos.ReadOnly = false;
                this.TBPlantas_DatosMedicos.BackColor = Color.FromArgb(32, 178, 170);
                this.TBOtro_DatosMedicos.ReadOnly = false;
                this.TBOtro_DatosMedicos.BackColor = Color.FromArgb(32, 178, 170);
                this.TBInformacion_DatosMedicos.ReadOnly = false;
                this.TBInformacion_DatosMedicos.BackColor = Color.FromArgb(32, 178, 170);

                //Otros Datos
                this.TBInstitutoAnterior.ReadOnly = false;
                this.TBInstitutoAnterior.BackColor = Color.FromArgb(32, 178, 170);
                this.CBInstitutoAnterior.Enabled = true;
                this.CBInstitutoAnterior.BackColor = Color.FromArgb(32, 178, 170);
                //this.TBDocumentos.ReadOnly = false;
                //this.TBDocumentos.BackColor = Color.FromArgb(32, 178, 170);
            }
        }

        private void Limpiar()
        {
            //Datos Basicos
            this.TBCarnet.Text = string.Empty;
            this.TBOrden.Text = string.Empty;
            this.TBNombres.Text = string.Empty;
            this.TBTipoIdentificacion_Alumno.Text = string.Empty;
            this.TBIdentificacion_Alumno.Text = string.Empty;
            this.TBFamilia.Text = string.Empty;
            this.DTFechadenacimiento.Text = string.Empty;
            this.CBGenero.Text = string.Empty;
            //this.TBCiudad.Text = string.Empty; ;
            //this.TBMunicipio.Text = string.Empty;
            //this.TBNacionalidad.Text = string.Empty;
            this.CBBecario.Text = string.Empty;
            this.TBDireccion.Text = string.Empty;
            this.TBBarrio.Text = string.Empty;
            this.TBEstracto.Text = string.Empty;
            this.TBComuna.Text = string.Empty;
            this.TBTelefono.Text = string.Empty;
            this.TBMovil.Text = string.Empty;
            this.TBEmail.Text = string.Empty;
            //Datos del Padre

            this.TBPadre.Text = string.Empty;
            this.CBIdentificacion_Padre.Text = string.Empty;
            this.TBIdentificacion_Padre.Text = string.Empty;
            this.TBDireccion_Padre.Text = string.Empty;
            this.TBBarrio_Padre.Text = string.Empty;
            this.TBFijo_Padre.Text = string.Empty;
            this.TBMovil_Padre.Text = string.Empty;
            this.TBEmpresa_Padre.Text = string.Empty;
            this.TBDireccion_Empresa.Text = string.Empty;
            this.TBTelefono_Padre.Text = string.Empty;
            this.CBEstadocivil_Padre.Text = string.Empty;
            this.TBEmail_Padre.Text = string.Empty;
            this.CBRetiro_Padre.Text = string.Empty;
            this.CBInformacion_Padre.Text = string.Empty;
        }

        public void MensajeDeAyuda()
        {
            //this.ttMensaje.SetToolTip(this.TBARANombre, "Ingrese el Nombre del Alumno");
            //this.ttMensaje.SetToolTip(this.TBARMCurso, "Ingrese el Curso a Iniciar en el Instituto");
            //this.ttMensaje.SetToolTip(this.TBARACodigo, "Ingrese el Codigo del Alumno");
            //this.ttMensaje.SetToolTip(this.CBIdentificacionAlumno, "Seleccione el Tipo de Identificacion del Alumno");
            //this.ttMensaje.SetToolTip(this.TBARAIdentificacion, "Ingrese el Numero de Identificacion del Alumno");
            //this.ttMensaje.SetToolTip(this.DTPFechadeingreso, "Seleccione la Fecha de Registro");
            //this.ttMensaje.SetToolTip(this.TBARATipodesangre, "Seleccione el Tipo de Sangre del Alumno");
            //this.ttMensaje.SetToolTip(this.CBBARAOtrainstitucion, "Seleccione si Aplica o no Otra Institucion");
            //this.ttMensaje.SetToolTip(this.TBARAPlantel, "Ingrese el Nombre del Plantel si Este Aplica");
            //this.ttMensaje.SetToolTip(this.TBARAUltimocurso, "Ingrese el Ultimo Curso Realizado por el Alumno");
            //this.ttMensaje.SetToolTip(this.TBARADocumentos, "Ingrese Los Documentos Entregados por el Alumno");
            //this.ttMensaje.SetToolTip(this.TBEstadoActual, "Seleccione el Estado Actual del Alumno");
            //this.ttMensaje.SetToolTip(this.TBARAObservacion, "Ingrese una Observacion si Esta Aplica");
            //this.ttMensaje.SetToolTip(this.CBPlanPadrino, "Seleccione el Estado Actual del Programa Plan Padrino");
            //this.ttMensaje.SetToolTip(this.CBBARAEstadodematricula, "Seleccione el Estado Actual de la Matricula Academica");
            //this.ttMensaje.SetToolTip(this.TBARAAcudiente, "Ingrese el Nombre del Acudiente");
            //this.ttMensaje.SetToolTip(this.CBIdentificacionAcudiente, "Seleccione el Tipo de Identificacion del Acudiente");
            //this.ttMensaje.SetToolTip(this.TBARAIdentificacionacudiente, "Ingrese el Numero de Identificacion del Acudiente");
            //this.ttMensaje.SetToolTip(this.TBARATelefono, "Ingrese un Numero de Contacto");
            //this.ttMensaje.SetToolTip(this.TBARACorreo, "Ingrese un Correo de Contacto si Aplica");
            //this.ttMensaje.SetToolTip(this.TBARADireccion, "Ingrese una Direccion de Contacto");
            //this.ttMensaje.SetToolTip(this.PanelFoto, "Ingrese la Foto del Alumno");
        }

        private void Botones()
        {
            if (this.IsNuevo == true)
            {
                this.Habilitar();
                this.Habilitado = true;
                this.btnNuevo.Visible = false;
                this.btnGuardar.Visible = true;
            }

            else
            {
                this.Habilitado = false;
                this.btnNuevo.Visible = true;
                this.btnGuardar.Visible = false;
            }
        }

        private void Consulta_Auto_Codigo()
        {
            try
            {
                DataTable Datos = CapaNegocio.fConfiguracion_CodigoID.Auto_CodigoID_Alumno();
                //Evaluamos si  existen los Datos
                if (Datos.Rows.Count == 0)
                {
                    //MessageBox.Show("No se Encontraron Registros en la Base de Datos", "Sistema Instituto Fundecar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //SI NO ENCUENTRA REGISTROS EN LA BASE DE DATOS ES DECIR SI ESTA EN BLANCO LA TABLA ACADEMICO.DATOSBASICOS
                    //TBCODIGOID SE LLENARA DE LA SIGUIENTE FORMA
                    this.TBCodigoID.Text = "T000";
                }
                else
                {
                    Auto_CodigoID = Datos.Rows[0][0].ToString();

                    this.TBCodigoID.Text = Auto_CodigoID + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void setAlumno(string carnet, string orden, string alumno, string tipo, string identificacion)
        {
            this.TBCarnet.Text = carnet;
            this.TBNombres.Text = alumno;
            this.TBTipoIdentificacion_Alumno.Text = tipo;
            this.TBIdentificacion_Alumno.Text = identificacion;
        }

        public void setOrdenDeMatricula(string idorden, string orden, string alumno, string tipo, string identificacion)
        {
            this.IDOrden.Text = idorden;
            this.TBOrden.Text = orden;
            this.TBNombres.Text = alumno;
            this.TBTipoIdentificacion_Alumno.Text = tipo;
            this.TBIdentificacion_Alumno.Text = identificacion;
        }

        public void setFamilia(string idfamilia, string familia)
        {
            this.IDFamilia.Text = idfamilia;
            this.TBFamilia.Text = familia;
        }

        private void Combobox_InformacionAcademica()
        {
            try
            {
                //CBCurso.DataSource = fAcademico_Cursos.Mostrar();
                //CBCurso.ValueMember = "Idcurso";
                //CBCurso.DisplayMember = "Curso";

                //CBJornada.DataSource = fSistema_Academico_Jornadas.Mostrar();
                //CBJornada.ValueMember = "Idjornada";
                //CBJornada.DisplayMember = "Jornada";

                //CBPeriodo.DataSource = fSistema_Academico_Periodos.Mostrar();
                //CBPeriodo.ValueMember = "Idperiodo";
                //CBPeriodo.DisplayMember = "Periodo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //Mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "A&J Academico", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "A&J Academico - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.Botones();
            this.Habilitar();

            this.Combobox_InformacionAcademica();
            this.TBDireccion.Focus();

            this.Consulta_Auto_Codigo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rptaDatosBasicos = "";
                string rptaDatosDelPadre = "";
                string rptaDatosDeLaMadre = "";
                string rptaDatosDelAcudiente = "";
                string rptaDatosMedicos = "";
                string rptaDocumentos = "";
                string rptaInformacionAcademicas = "";

                //Datos Basicos
                if (this.TBOrden.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos en la Pestaña 'Datos Basicos', Estos Seran Remarcados");
                    TBOrden.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBNombres.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos en la Pestaña 'Datos Basicos', Estos Seran Remarcados");
                    TBNombres.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBTipoIdentificacion_Alumno.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos en la Pestaña 'Datos Basicos', Estos Seran Remarcados");
                    TBTipoIdentificacion_Alumno.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBIdentificacion_Alumno.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos en la Pestaña 'Datos Basicos', Estos Seran Remarcados");
                    TBIdentificacion_Alumno.BackColor = Color.FromArgb(250, 235, 215);
                }
                
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.PanelFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    byte[] imagen = ms.GetBuffer();

                    if (this.IsNuevo)
                    {
                        rptaDatosBasicos = fAcademico_Alumno.Guardar_DatosBasicos("1",Convert.ToInt32(this.IDFamilia.Text),this.TBCodigoID.Text,Convert.ToInt32(this.IDOrden.Text), this.TBCarnet.Text, this.TBOrden.Text, this.TBNombres.Text, this.TBTipoIdentificacion_Alumno.Text, this.TBIdentificacion_Alumno.Text, this.TBFamilia.Text,
                        this.DTFechadenacimiento.Value, this.CBGenero.Text, Convert.ToInt32(this.CBCiudad.Text), Convert.ToInt32(this.CBMunicipio.Text), Convert.ToInt32(this.CBNacionalidad.Text), this.CBBecario.Text, this.TBDireccion.Text, this.TBBarrio.Text, this.TBEstracto.Text, this.TBComuna.Text, this.TBTelefono.Text, this.TBMovil.Text, this.TBEmail.Text);

                        rptaDatosDelPadre = fAcademico_Alumno.Guardar_DatosDelPadre("1", this.TBPadre.Text, this.TBCodigoID.Text, this.CBIdentificacion_Padre.Text, this.TBIdentificacion_Padre.Text, this.CBHogar_Padre.Text, this.TBDireccion_Padre.Text, this.TBBarrio_Padre.Text, this.TBTelefono_Padre.Text, this.TBMovil_Padre.Text, this.TBProfesion_Padre.Text,
                        this.TBEmpresa_Padre.Text, this.TBDireccion_Empresa.Text, this.TBTelefono_Padre.Text, this.CBEstadocivil_Padre.Text, this.TBEmail_Padre.Text, this.CBRetiro_Padre.Text, this.CBInformacion_Padre.Text);

                        rptaDatosDeLaMadre = fAcademico_Alumno.Guardar_DatosDeLaMadre("1", this.TBMadre.Text, this.TBCodigoID.Text, this.CBIdentificacion_Madre.Text, this.TBIdentificacion_Madre.Text, this.CBHogar_Madre.Text, this.TBDireccion_Madre.Text, this.TBBarrio_Madre.Text, this.TBTelefono_Madre.Text, TBMovil_Madre.Text, this.TBProfesion_Madre.Text, this.TBEmpresa_Madre.Text, this.TBDireccionEmpresa_Madre.Text,
                        this.TBTelefonoEmpresa_Madre.Text, this.CBEstadoCivil_Madre.Text, this.TBEmail_Madre.Text, this.CBRetiro_Madre.Text, this.CBInformacion_Madre.Text);

                        rptaDatosDelAcudiente = fAcademico_Alumno.Guardar_DatosDelAcudiente("1", this.TBAcudiente.Text, this.TBCodigoID.Text, this.CBIdentificacion_Acudiente.Text, this.TBIdentificacion_Acudiente.Text, this.TBParentesco_Acudiente.Text, this.TBDireccion_Acudiente.Text, this.TBTelefono_Acudiente.Text, this.TBMovil_Acudiente.Text, this.TBEmail_Acudiente.Text, this.TBObservacion_Acudiente.Text);

                        rptaDatosMedicos = fAcademico_Alumno.Guardar_DatosMedicos("1", this.TBCodigoID.Text, this.CBSangre_DatosMedicos.Text, this.CBEps_Medicos.Text, this.TBAlimentos_DatosMedicos.Text, this.TBAnimales_DatosMedicos.Text, this.TBInsectos_DatosMedicos.Text, this.TBMedicamentos_DatosMedicos.Text, this.TBPlantas_DatosMedicos.Text, TBOtro_DatosMedicos.Text, this.TBInformacion_DatosMedicos.Text);

                        //rptaInformacionAcademicas = fAcademico_Alumno.Guardar_InformacionAcademica("1", Convert.ToInt32(this.CBCurso.SelectedValue), Convert.ToInt32(this.CBJornada.SelectedValue), Convert.ToInt32(this.CBPeriodo.SelectedValue), Convert.ToInt32(this.CBEstado.Text), this.DTFechaDeRegistro.Value, imagen, this.TBCodigoID.Text, this.CBInstitutoAnterior.Text, this.TBInstitutoAnterior.Text, this.TBDocumentos.Text);
                    }

                    if (rptaDatosBasicos.Equals("OK") && rptaDatosDelPadre.Equals("OK") && rptaDatosDeLaMadre.Equals("OK") && rptaDatosDelAcudiente.Equals("OK") && rptaDatosMedicos.Equals("OK") && rptaDocumentos.Equals("OK") && rptaInformacionAcademicas.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Alumno Registrado Exitosamente");
                        }
                    }

                    else
                    {
                        this.MensajeError(rptaDatosBasicos);
                        this.MensajeError(rptaDatosDelPadre);
                        this.MensajeError(rptaDatosDeLaMadre);
                        this.MensajeError(rptaDatosDelAcudiente);
                        this.MensajeError(rptaDatosMedicos);
                        this.MensajeError(rptaDocumentos);
                        this.MensajeError(rptaInformacionAcademicas);
                    }

                    this.IsNuevo = false;
                    this.Botones();
                    this.Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnExaminar_Orden_Click(object sender, EventArgs e)
        {
            frmExaminar_OrdenDeMatricula frmExaminar_OrdenDeMatricula = new frmExaminar_OrdenDeMatricula();
            frmExaminar_OrdenDeMatricula.ShowDialog();
        }

        private void btnExaminar_Familia_Click(object sender, EventArgs e)
        {
            frmExaminar_Familias frmExaminarAcademico_Familias = new frmExaminar_Familias();
            frmExaminarAcademico_Familias.ShowDialog();
        }

        private void btnExaminar_Codigo_Click(object sender, EventArgs e)
        {
            
        }

        private void PanelFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.PanelFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                this.PanelFoto.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnNuevo_MouseDown(object sender, MouseEventArgs e)
        {
            btnNuevo.BackgroundImage = Properties.Resources.BV_Nuevo;
        }

        private void btnNuevo_MouseLeave(object sender, EventArgs e)
        {
            btnNuevo.BackgroundImage = Properties.Resources.BV_Nuevo;
        }

        private void btnNuevo_MouseMove(object sender, MouseEventArgs e)
        {
            btnNuevo.BackgroundImage = Properties.Resources.BR_Nuevo;
        }

        private void btnGuardar_MouseDown(object sender, MouseEventArgs e)
        {
            btnGuardar.BackgroundImage = Properties.Resources.BV_Guardar;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar.BackgroundImage = Properties.Resources.BV_Guardar;
        }

        private void btnGuardar_MouseMove(object sender, MouseEventArgs e)
        {
            btnGuardar.BackgroundImage = Properties.Resources.BR_Guardar;
        }

        private void frmAcademico_Alumnos_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

        private void CBIdentificacion_Madre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBIdentificacion_Madre.SelectedIndex == 0)
            {

            }
            else if (CBIdentificacion_Madre.SelectedIndex == 0)
            {

            }
        }

        private void CBIdentificacion_Padre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBIdentificacion_Padre.SelectedIndex == 0)
            {

            }
            else if (CBIdentificacion_Padre.SelectedIndex == 0)
            {

            }
        }

        private void CBIdentificacion_Acudiente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
