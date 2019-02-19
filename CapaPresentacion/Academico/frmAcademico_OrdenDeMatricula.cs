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
    public partial class frmAcademico_OrdenDeMatricula : Form
    {
        private bool IsNuevo = false;

        private static frmAcademico_OrdenDeMatricula _Instancia;

        public static frmAcademico_OrdenDeMatricula GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmAcademico_OrdenDeMatricula();
            }
            return _Instancia;
        }
        public frmAcademico_OrdenDeMatricula()
        {
            InitializeComponent();
        }

        private void frmFinanciera_OrdenDeMatricula_Load(object sender, EventArgs e)
        {
            this.ColoresDeBotones();
            this.Habilitar();
            this.Botones();
        }

        private void ColoresDeBotones()
        {
            btnNuevo.BackgroundImage = Properties.Resources.BV_Nuevo;
            btnGuardar.BackgroundImage = Properties.Resources.BV_Guardar;

            btnExaminar.BackgroundImage = Properties.Resources.btnExaminar;
        }

        private void Habilitar()
        {
            if (IsNuevo == false)
            {
                //Informacion Academica
                this.TBAlumno.ReadOnly = true;
                this.TBAlumno.BackColor = Color.FromArgb(187, 222, 251);
                this.CBDocumento.Enabled = false;
                this.CBDocumento.BackColor = Color.FromArgb(187, 222, 251);
                this.TBIdentificacion.Enabled = true;
                this.TBIdentificacion.BackColor = Color.FromArgb(187, 222, 251);
                this.TBOrden.ReadOnly = true;
                this.TBOrden.BackColor = Color.FromArgb(187, 222, 251);
                this.TBAño.ReadOnly = true;
                this.TBAño.BackColor = Color.FromArgb(187, 222, 251);
                this.TBValor.ReadOnly = true;
                this.TBValor.BackColor = Color.FromArgb(187, 222, 251);
            }

            else if (IsNuevo == true)
            {
                this.TBAlumno.ReadOnly = false;
                this.TBAlumno.BackColor = Color.FromArgb(32, 178, 170);
                this.CBDocumento.Enabled = true;
                this.CBDocumento.BackColor = Color.FromArgb(32, 178, 170);
                this.TBIdentificacion.ReadOnly = false;
                this.TBIdentificacion.BackColor = Color.FromArgb(32, 178, 170);
                this.TBOrden.ReadOnly = false;
                this.TBOrden.BackColor = Color.FromArgb(32, 178, 170);
            }
        }

        private void Limpiar()
        {
            this.TBAlumno.Text = string.Empty;
            this.CBDocumento.Text = string.Empty;
            this.TBIdentificacion.Text = string.Empty;
            this.TBValor.Text = string.Empty;
            this.TBAño.Text = string.Empty;
            this.TBOrden.Text = string.Empty;
        }

        private void Botones()
        {
            if (this.IsNuevo == true)
            {
                this.btnNuevo.Visible = false;
                this.btnGuardar.Visible = true;
                this.btnExaminar.Enabled = true;
            }

            else
            {
                this.btnNuevo.Visible = true;
                this.btnGuardar.Visible = false;
                this.btnExaminar.Enabled = false;
            }
        }

        public void setValorAcademico(string idvalor, string valor, string año)
        {
            this.IDValor.Text = idvalor;
            this.TBValor.Text = valor;
            this.TBAño.Text = año;
        }

        private void Combobox()
        {
            try
            {
                CBCurso.DataSource = fAcademico_Cursos.Mostrar();
                CBCurso.ValueMember = "Idcurso";
                CBCurso.DisplayMember = "Curso";

                CBJornada.DataSource = fSistema_Academico_Jornadas.Mostrar();
                CBJornada.ValueMember = "Idjornada";
                CBJornada.DisplayMember = "Jornada";

                CBEstado.DataSource = fSistema_Estados.Mostrar();
                CBEstado.ValueMember = "Idestado";
                CBEstado.DisplayMember = "Estado";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //Mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Leal Academico", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Leal Academico - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CBIdentificacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.Botones();
            this.Habilitar();
            this.Combobox();

            this.TBAlumno.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rptaDatosBasicos = "";

                //Datos Basicos
                if (this.TBAlumno.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBAlumno.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.CBDocumento.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    CBDocumento.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBIdentificacion.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBIdentificacion.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBValor.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBValor.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBAño.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBAño.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBOrden.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBOrden.BackColor = Color.FromArgb(250, 235, 215);
                }

                else
                {
                    if (this.IsNuevo)
                    {
                        rptaDatosBasicos = fAcademico_OrdenDeMatricula.Guardar_DatosBasicos(Convert.ToInt32(this.IDValor.Text), Convert.ToInt32(this.CBEstado.Text), Convert.ToInt32(this.CBCurso.Text), Convert.ToInt32(this.CBJornada.Text), this.TBAlumno.Text, this.TBIdentificacion.Text, this.CBDocumento.Text, this.TBValor.Text, this.TBAño.Text, this.TBOrden.Text, "1");
                    }

                    if (rptaDatosBasicos.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Orden Generada Exitosamente");
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

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            frmExaminarTesoreria_ValoresAcademicos frmExaminarTesoreria_ValoresAcademicos = new frmExaminarTesoreria_ValoresAcademicos();
            frmExaminarTesoreria_ValoresAcademicos.ShowDialog();
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

        private void frmTesoreria_OrdenDeMatricula_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }
    }
}
