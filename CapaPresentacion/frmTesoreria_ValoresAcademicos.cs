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
    public partial class frmTesoreria_ValoresAcademicos : Form
    {
        private bool IsNuevo = false;

        public frmTesoreria_ValoresAcademicos()
        {
            InitializeComponent();
        }

        private void frmFinanciera_ValoresAcademicos_Load(object sender, EventArgs e)
        {
            this.ColoresDeBotones();
            this.Habilitar();
            this.Botones();
        }

        private void ColoresDeBotones()
        {
            btnNuevo.BackgroundImage = Properties.Resources.BV_Nuevo;
            btnGuardar.BackgroundImage = Properties.Resources.BV_Guardar;
        }

        private void Habilitar()
        {
            if (IsNuevo == false)
            {
                //Informacion Academica
                this.TBConcepto.ReadOnly = true;
                this.TBConcepto.BackColor = Color.FromArgb(187, 222, 251);
                this.TBValor.ReadOnly = true;
                this.TBValor.BackColor = Color.FromArgb(187, 222, 251);
                this.TBPeriodo.ReadOnly = true;
                this.TBPeriodo.BackColor = Color.FromArgb(187, 222, 251);
                this.TBAñoElectivo.ReadOnly = true;
                this.TBAñoElectivo.BackColor = Color.FromArgb(187, 222, 251);
            }

            else if (IsNuevo == true)
            {
                this.TBConcepto.ReadOnly = false;
                this.TBConcepto.BackColor = Color.FromArgb(32, 178, 170);
                this.TBValor.ReadOnly = false;
                this.TBValor.BackColor = Color.FromArgb(32, 178, 170);
                this.TBPeriodo.ReadOnly = false;
                this.TBPeriodo.BackColor = Color.FromArgb(32, 178, 170);
                this.TBAñoElectivo.ReadOnly = false;
                this.TBAñoElectivo.BackColor = Color.FromArgb(32, 178, 170);
            }
        }

        private void Limpiar()
        {
            this.TBConcepto.Text = string.Empty;
            this.TBValor.Text = string.Empty;
            this.TBPeriodo.Text = string.Empty;
            this.TBAñoElectivo.Text = string.Empty;
        }

        private void Botones()
        {
            if (this.IsNuevo == true)
            {
                this.btnNuevo.Visible = false;
                this.btnGuardar.Visible = true;
            }

            else
            {
                this.btnNuevo.Visible = true;
                this.btnGuardar.Visible = false;
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
            this.TBConcepto.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rptaDatosBasicos = "";

                //Datos Basicos
                if (this.TBConcepto.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBConcepto.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBValor.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBValor.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBPeriodo.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBPeriodo.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBAñoElectivo.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBAñoElectivo.BackColor = Color.FromArgb(250, 235, 215);
                }

                else
                {
                    if (this.IsNuevo)
                    {
                        rptaDatosBasicos = fTesoreria_ValoresAcademicos.Guardar_DatosBasicos(this.TBConcepto.Text, this.TBValor.Text, this.TBPeriodo.Text, this.TBAñoElectivo.Text, "1");
                    }

                    if (rptaDatosBasicos.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Concepto Registrado Exitosamente");
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
    }
}
