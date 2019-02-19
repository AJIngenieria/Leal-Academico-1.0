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
    public partial class frmSistemaAcademico_CodigoID : Form
    {
        private bool IsNuevo = false;
        public frmSistemaAcademico_CodigoID()
        {
            InitializeComponent();
        }

        private void frmSistemaAcademico_CodigoID_Load(object sender, EventArgs e)
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
                this.TBLetra.ReadOnly = true;
                this.TBLetra.BackColor = Color.FromArgb(187, 222, 251);
                this.TBNumero.ReadOnly = true;
                this.TBNumero.BackColor = Color.FromArgb(187, 222, 251);
                this.TBSimbolo.ReadOnly = true;
                this.TBSimbolo.BackColor = Color.FromArgb(187, 222, 251);
            }

            else if (IsNuevo == true)
            {
                this.TBLetra.ReadOnly = false;
                this.TBLetra.BackColor = Color.FromArgb(32, 178, 170);
                this.TBNumero.ReadOnly = false;
                this.TBNumero.BackColor = Color.FromArgb(32, 178, 170);
                this.TBSimbolo.ReadOnly = false;
                this.TBSimbolo.BackColor = Color.FromArgb(32, 178, 170);
            }
        }

        private void Limpiar()
        {
            this.TBLetra.Text = string.Empty;
            this.TBNumero.Text = string.Empty;
            this.TBSimbolo.Text = string.Empty;
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
            this.TBLetra.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rptaDatosBasicos = "";

                //Datos Basicos
                if (this.TBLetra.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBLetra.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBNumero.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBNumero.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBSimbolo.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBSimbolo.BackColor = Color.FromArgb(250, 235, 215);
                }

                else
                {
                    if (this.IsNuevo)
                    {
                        rptaDatosBasicos = fSistema_Academico_CodigoID.Guardar(this.TBNumero.Text, this.TBLetra.Text, this.TBSimbolo.Text,"1");
                    }

                    if (rptaDatosBasicos.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Registro Exitoso");
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
    }
}
