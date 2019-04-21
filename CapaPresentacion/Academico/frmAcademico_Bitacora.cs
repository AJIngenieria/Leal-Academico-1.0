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
    public partial class frmAcademico_Bitacora : Form
    {
        private bool IsNuevo = false;
        private bool Habilitado = false;

        public string Auto_CodigoID = "";

        private static frmAcademico_Bitacora _Instancia;

        public static frmAcademico_Bitacora GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmAcademico_Bitacora();
            }
            return _Instancia;
        }
        public frmAcademico_Bitacora()
        {
            InitializeComponent();
        }

        private void frmAcademico_Bitacora_Load(object sender, EventArgs e)
        {
            this.Habilitar();
            this.Botones();
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
                this.TBAlumno.ReadOnly = true;
                this.TBAlumno.BackColor = Color.FromArgb(187, 222, 251);
                this.TBDocumento.ReadOnly = true;
                this.TBDocumento.BackColor = Color.FromArgb(187, 222, 251);
                this.TBIdentificacion.ReadOnly = true;
                this.TBIdentificacion.BackColor = Color.FromArgb(187, 222, 251);
                this.TBCurso.ReadOnly = true;
                this.TBCurso.BackColor = Color.FromArgb(187, 222, 251);
                this.TBJornada.ReadOnly = true;
                this.TBJornada.BackColor = Color.FromArgb(187, 222, 251);
                this.TBDirector.ReadOnly = true;
                this.TBDirector.BackColor = Color.FromArgb(187, 222, 251);
                this.TBBitacora.ReadOnly = true;
                this.TBBitacora.BackColor = Color.FromArgb(187, 222, 251);
                this.CBTIpo.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBTIpo.BackColor = Color.FromArgb(187, 222, 251);
                //this.DTFechadeRegistro.ReadOnly = true;
                this.DTFechadeRegistro.BackColor = Color.FromArgb(187, 222, 251);
                //this.DTFechaDeCitacion.DropDownStyle = ComboBoxStyle.DropDownList;
                this.DTFechaDeCitacion.BackColor = Color.FromArgb(187, 222, 251);
                this.TBDescripcion.ReadOnly = true;
                this.TBDescripcion.BackColor = Color.FromArgb(187, 222, 251);
            }

            else if (Habilitado == true)
            {
                //Datos Basicos
                //this.TBCodigoID.ReadOnly = false;
                //this.TBCodigoID.BackColor = Color.FromArgb(32, 178, 170);
                //this.TBCodigo.ReadOnly = false;
                //this.TBCodigo.BackColor = Color.FromArgb(32, 178, 170);
                //this.TBAlumno.ReadOnly = false;
                //this.TBAlumno.BackColor = Color.FromArgb(32, 178, 170);
                //this.CBIdentificacion.DropDownStyle = ComboBoxStyle.DropDownList;
                //this.CBIdentificacion.BackColor = Color.FromArgb(32, 178, 170);
                //this.TBIdentificacion.ReadOnly = false;
                //this.TBIdentificacion.BackColor = Color.FromArgb(32, 178, 170);
                this.TBCurso.ReadOnly = true;
                this.TBCurso.BackColor = Color.FromArgb(32, 178, 170);
                this.TBJornada.ReadOnly = false;
                this.TBJornada.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDirector.ReadOnly = false;
                this.TBDirector.BackColor = Color.FromArgb(32, 178, 170);
                this.TBBitacora.ReadOnly = false;
                this.TBBitacora.BackColor = Color.FromArgb(32, 178, 170);
                this.CBTIpo.Enabled = true;
                this.CBTIpo.BackColor = Color.FromArgb(32, 178, 170);
                //this.DTFechadeRegistro.ReadOnly = false;
                this.DTFechadeRegistro.BackColor = Color.FromArgb(32, 178, 170);
                //this.DTFechaDeCitacion.DropDownStyle = ComboBoxStyle.DropDownList;
                this.DTFechaDeCitacion.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDescripcion.ReadOnly = false;
                this.TBDescripcion.BackColor = Color.FromArgb(32, 178, 170);
            }
        }

        private void Limpiar()
        {
            //Datos Basicos
            this.TBCodigoID.Text = string.Empty;
            this.TBCarnet.Text = string.Empty;
            this.TBAlumno.Text = string.Empty;
            this.TBDocumento.Text = string.Empty;
            this.TBIdentificacion.Text = string.Empty;
            this.TBCurso.Text = string.Empty;
            this.TBJornada.Text = string.Empty;
            this.TBDirector.Text = string.Empty;
            this.TBBitacora.Text = string.Empty; ;
            this.CBTIpo.Text = string.Empty;
            this.TBDescripcion.Text = string.Empty;
        }

        private void Botones()
        {
            if (this.IsNuevo == true)
            {
                this.Habilitar();
                this.Habilitado = true;
                this.btnNuevo.Visible = false;
                this.btnGuardar.Visible = true;

                this.btnExaminar_Codigo.Enabled = true;
            }

            else
            {
                this.Habilitado = false;
                this.btnNuevo.Visible = true;
                this.btnGuardar.Visible = false;

                this.btnExaminar_Codigo.Enabled = false;
            }
        }

        public void setAlumno(string idalumno,string carnet, string alumno, string documento, string identificacion, string curso, string jornada)
        {
            TBIdAlumno.Text = idalumno;
            this.TBCarnet.Text = carnet;
            this.TBAlumno.Text = alumno;
            this.TBDocumento.Text = documento;
            this.TBIdentificacion.Text = identificacion;
            this.TBCurso.Text = curso;
            this.TBJornada.Text = jornada;
        }

        private void Combobox()
        {
            try
            {
                CBTIpo.DataSource = fSistema_Academico_Bitacora.Mostrar();
                CBTIpo.ValueMember = "Idbitacora";
                CBTIpo.DisplayMember = "Bitacora";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Consulta_Auto_Codigo()
        {
            try
            {
                DataTable Datos = CapaNegocio.fAcademico_Bitacora.AutoCompletar_CodigoID();
                //Evaluamos si  existen los Datos
                if (Datos.Rows.Count == 0)
                {
                    MessageBox.Show("No se Encontraron Registros en la Base de Datos", "Sistema Instituto Fundecar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //SI NO ENCUENTRA REGISTROS EN LA BASE DE DATOS ES DECIR SI ESTA EN BLANCO LA TABLA ACADEMICO.DATOSBASICOS
                    //TBCODIGOID SE LLENARA DE LA SIGUIENTE FORMA
                    this.TBCodigoID.Text = "T000";
                }
                else
                {
                    //frmAcademico_RegistrarAlumno frm = new frmAcademico_RegistrarAlumno();
                    Auto_CodigoID = Datos.Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void AutoCompletar_CodigoID()
        {
            this.TBCodigoID.Text = Auto_CodigoID;
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
            this.TBBitacora.Focus();

            this.Consulta_Auto_Codigo();
            this.AutoCompletar_CodigoID();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rptaDatosBasicos = "";

                //Datos Basicos
                if (this.TBCodigoID.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBCodigoID.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBCarnet.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBCarnet.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBAlumno.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBAlumno.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBDocumento.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBDocumento.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBIdentificacion.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBIdentificacion.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBCurso.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBCurso.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBJornada.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBJornada.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBDirector.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBDirector.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBBitacora.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBBitacora.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.CBTIpo.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    CBTIpo.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.DTFechadeRegistro.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    DTFechadeRegistro.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.DTFechaDeCitacion.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    DTFechaDeCitacion.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBDescripcion.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBDescripcion.BackColor = Color.FromArgb(250, 235, 215);
                }

                else
                {
                    if (this.IsNuevo)
                    {
                        rptaDatosBasicos = fAcademico_Bitacora.Guardar_DatosBasicos(Convert.ToInt32(this.TBIdAlumno.Text), this.TBCodigoID.Text, this.TBCarnet.Text, this.TBAlumno.Text, this.TBDocumento.Text, this.TBIdentificacion.Text, this.TBCurso.Text, this.TBJornada.Text, this.TBDirector.Text, this.TBBitacora.Text, this.CBTIpo.Text, this.DTFechadeRegistro.Value, this.DTFechaDeCitacion.Value, this.TBDescripcion.Text);
                    }

                    if (rptaDatosBasicos.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Bitacora Registrada Exitosamente");
                        }
                    }

                    else
                    {
                        this.MensajeError(rptaDatosBasicos);
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

        private void btnExaminar_Codigo_Click(object sender, EventArgs e)
        {
            frmExaminar_Alumno frmExaminarAcademico_Alumno = new frmExaminar_Alumno();
            frmExaminarAcademico_Alumno.ShowDialog();
        }

        private void btnNuevo_MouseDown(object sender, MouseEventArgs e)
        {
            btnNuevo.Image = Properties.Resources.BV_Nuevo;
        }

        private void btnNuevo_MouseLeave(object sender, EventArgs e)
        {
            btnNuevo.Image = Properties.Resources.BV_Nuevo;
        }

        private void btnNuevo_MouseMove(object sender, MouseEventArgs e)
        {
            btnNuevo.Image = Properties.Resources.BR_Nuevo;
        }

        private void btnGuardar_MouseDown(object sender, MouseEventArgs e)
        {
            btnGuardar.Image = Properties.Resources.BV_Guardar;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar.Image = Properties.Resources.BV_Guardar;
        }

        private void btnGuardar_MouseMove(object sender, MouseEventArgs e)
        {
            btnGuardar.Image = Properties.Resources.BR_Guardar;
        }

        private void frmAcademico_Bitacora_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }
    }
}
