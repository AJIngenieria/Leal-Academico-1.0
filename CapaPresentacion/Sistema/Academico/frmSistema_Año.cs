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
    public partial class frmSistemaAcademico_Año : Form
    {
        private bool IsNuevo = false;
        public frmSistemaAcademico_Año()
        {
            InitializeComponent();
        }

        private void frmSistemaAcademico_AñoElectivo_Load(object sender, EventArgs e)
        {
            this.ColoresDeBotones();
            this.Habilitar();
            this.Botones();
        }

        private void ColoresDeBotones()
        {
            btnNuevo.Image = Properties.Resources.BV_Nuevo;
            btnGuardar.Image = Properties.Resources.BV_Guardar;
        }

        private void Habilitar()
        {
            if (IsNuevo == false)
            {
                this.TBAño.ReadOnly = true;
                this.TBAño.BackColor = Color.FromArgb(187, 222, 251);
                this.CBEstado.Enabled = true;
                this.CBEstado.BackColor = Color.FromArgb(187, 222, 251);
            }

            else if (IsNuevo == true)
            {
                this.TBAño.ReadOnly = false;
                this.TBAño.BackColor = Color.FromArgb(32, 178, 170);
                this.CBEstado.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBEstado.BackColor = Color.FromArgb(32, 178, 170);
            }
        }

        private void Limpiar()
        {
            this.TBAño.Text = string.Empty;
            this.CBEstado.Text = string.Empty;
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
            this.TBAño.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rptaDatosBasicos = "";

                //Datos Basicos
                if (this.TBAño.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBAño.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.CBEstado.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    CBEstado.BackColor = Color.FromArgb(250, 235, 215);
                }
                
                else
                {
                    if (this.IsNuevo)
                    {
                        rptaDatosBasicos = fSistema_Academico_Año.Guardar_DatosBasicos(this.TBAuto.Text, this.TBAño.Text, Convert.ToInt32(this.CBEstado.Text));
                    }

                    if (rptaDatosBasicos.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Año Academico Registrado Exitosamente");
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
    }
}
