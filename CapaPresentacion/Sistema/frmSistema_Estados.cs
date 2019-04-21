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
    public partial class frmSistema_Estados : Form
    {
        private bool IsNuevo = false;
        public frmSistema_Estados()
        {
            InitializeComponent();
        }

        private void frmSistema_Estados_Load(object sender, EventArgs e)
        {
            this.ColoresDeBotones();
            this.Botones();
            this.Habilitar();
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
                this.TBBuscar.ReadOnly = true;
                this.TBBuscar.BackColor = Color.FromArgb(187, 222, 251);

                //
                this.TBEstado.ReadOnly = true;
                this.TBEstado.BackColor = Color.FromArgb(187, 222, 251);
                this.TBDescripcion.ReadOnly = true;
                this.TBDescripcion.BackColor = Color.FromArgb(187, 222, 251);
            }

            else if (IsNuevo == true)
            {
                this.TBBuscar.ReadOnly = false;
                this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);

                //
                this.TBEstado.ReadOnly = false;
                this.TBEstado.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDescripcion.ReadOnly = false;
                this.TBDescripcion.BackColor = Color.FromArgb(32, 178, 170);
            }
        }

        private void Limpiar()
        {
            this.TBBuscar.Text = string.Empty;
            this.TBDescripcion.Text = string.Empty;
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
            this.TBDescripcion.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rptaDatosBasicos = "";

                //Datos Basicos
                if (this.TBEstado.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBEstado.BackColor = Color.FromArgb(250, 235, 215);
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
                        rptaDatosBasicos = fSistema_Estados.Guardar_DatosBasicos(1, this.TBEstado.Text, this.TBDescripcion.Text);
                    }

                    if (rptaDatosBasicos.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Estado Registrado Exitosamente");
                        }
                    }

                    else
                    {
                        this.MensajeError(rptaDatosBasicos);
                    }

                    this.IsNuevo = false;
                    this.Botones();
                    this.Limpiar();
                    this.Habilitar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

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
