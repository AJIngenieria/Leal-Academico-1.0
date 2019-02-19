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
    public partial class frmProduccion_Bodegas : Form
    {
        private bool IsNuevo = false;
        public frmProduccion_Bodegas()
        {
            InitializeComponent();
        }

        private void frmAlmacen_Bodegas_Load(object sender, EventArgs e)
        {
            this.ColoresDeBotones();
            this.Botones();
            this.Habilitar();

            this.CBEstado.SelectedIndex = 0;
            this.CBZonas.SelectedIndex = 0;
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
                this.TBCodigoID.ReadOnly = true;
                this.TBCodigoID.BackColor = Color.FromArgb(187, 222, 251);
                this.CBEstado.Enabled = false;
                this.CBEstado.BackColor = Color.FromArgb(187, 222, 251);
                this.TBDescripcion.ReadOnly = true;
                this.TBDescripcion.BackColor = Color.FromArgb(187, 222, 251);
                this.TBResponsable.ReadOnly = true;
                this.TBResponsable.BackColor = Color.FromArgb(187, 222, 251);
                this.CBCiudadB.Enabled = false;
                this.CBCiudadB.BackColor = Color.FromArgb(187, 222, 251);
                this.CBZonas.Enabled = false;
                this.CBZonas.BackColor = Color.FromArgb(187, 222, 251);
                this.CBSucurzal.Enabled = false;
                this.CBSucurzal.BackColor = Color.FromArgb(187, 222, 251);
                this.TBDireccion1.ReadOnly = true;
                this.TBDireccion1.BackColor = Color.FromArgb(187, 222, 251);
                this.TBTelefono.ReadOnly = true;
                this.TBTelefono.BackColor = Color.FromArgb(187, 222, 251);
            }

            else if (IsNuevo == true)
            {
                this.TBCodigoID.ReadOnly = false;
                this.TBCodigoID.BackColor = Color.FromArgb(32, 178, 170);
                this.CBEstado.Enabled = true;
                this.CBEstado.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDescripcion.ReadOnly = false;
                this.TBDescripcion.BackColor = Color.FromArgb(32, 178, 170);
                this.TBResponsable.ReadOnly = false;
                this.TBResponsable.BackColor = Color.FromArgb(32, 178, 170);
                this.CBCiudadB.Enabled = true;
                this.CBCiudadB.BackColor = Color.FromArgb(32, 178, 170);
                this.CBZonas.Enabled = true;
                this.CBZonas.BackColor = Color.FromArgb(32, 178, 170);
                this.CBSucurzal.Enabled = true;
                this.CBSucurzal.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDireccion1.ReadOnly = false;
                this.TBDireccion1.BackColor = Color.FromArgb(32, 178, 170);
                this.TBTelefono.ReadOnly = false;
                this.TBTelefono.BackColor = Color.FromArgb(32, 178, 170);
            }
        }

        private void Limpiar()
        {
            this.TBCodigoID.Text = string.Empty;
            this.CBEstado.SelectedIndex = 0;
            this.TBDescripcion.Text = string.Empty;
            this.TBResponsable.Text = string.Empty;
            this.CBCiudadB.Text = string.Empty;
            this.CBZonas.SelectedIndex = 0;
            this.CBSucurzal.SelectedIndex = 0;
            this.TBDireccion1.Text = string.Empty;
            this.TBTelefono.Text = string.Empty;
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

        private void Combobox()
        {
            try
            {
                CBSucurzal.DataSource = fSistema_Sucurzal.Mostrar_Surcurzal();
                CBSucurzal.ValueMember = "Idsucuzal";
                CBSucurzal.DisplayMember = "Sucurzal";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.Botones();
            this.Habilitar();
            this.Combobox();
            this.TBDescripcion.Focus();
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
                else if (this.CBEstado.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    CBEstado.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBDescripcion.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBDescripcion.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.CBCiudadB.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    CBCiudadB.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.CBZonas.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    CBZonas.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.CBSucurzal.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    CBSucurzal.BackColor = Color.FromArgb(250, 235, 215);
                }

                else
                {
                    if (this.IsNuevo)
                    {
                        //rptaDatosBasicos = fProduccion_Bodega.Guardar_DatosBasicos(4, this.TBCodigoID.Text, this.TBDescripcion.Text,
                        //this.TBResponsable.Text, this.CBCiudadB.Text, this.CBZonas.Text, this.CBSucurzal.Text, this.TBDireccion1.Text, this.TBDireccion2.Text, this.TBTelefono.Text,
                        //this.TBMovil.Text, this.CBPropiedad.Text, this.CBMensualidad.Text, this.TBValor.Text, this.CBEstado.Text, "1");
                    }

                    if (rptaDatosBasicos.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Bodega Registrada Exitosamente");
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
