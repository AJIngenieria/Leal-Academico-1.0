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
    public partial class frmProduccion_Proveedor : Form
    {
        private bool IsNuevo = false;
        public frmProduccion_Proveedor()
        {
            InitializeComponent();
        }

        private void frmAlmacen_Proveedor_Load(object sender, EventArgs e)
        {
            this.ColoresDeBotones();
            this.Botones();
            this.Habilitar();

            this.CBEstado.SelectedIndex = 0;
            this.CBTipodeproveedor.SelectedIndex = 0;
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
                this.CBTipodeproveedor.Enabled = false;
                this.CBTipodeproveedor.BackColor = Color.FromArgb(187, 222, 251);
                this.TBArea.ReadOnly = true;
                this.TBArea.BackColor = Color.FromArgb(187, 222, 251);
                this.TBProveedor.ReadOnly = true;
                this.TBProveedor.BackColor = Color.FromArgb(187, 222, 251);
                this.TBCodigoID.ReadOnly = true;
                this.TBCodigoID.BackColor = Color.FromArgb(187, 222, 251);
                this.CBIdentificacion.Enabled = false;
                this.CBIdentificacion.BackColor = Color.FromArgb(187, 222, 251);
                this.TBIdentificacion.ReadOnly = true;
                this.TBIdentificacion.BackColor = Color.FromArgb(187, 222, 251);
                this.CBEstado.Enabled = false;
                this.CBEstado.BackColor = Color.FromArgb(187, 222, 251);
                this.TBRepresentante.ReadOnly = true;
                this.TBRepresentante.BackColor = Color.FromArgb(187, 222, 251);
                this.CBPais.Enabled = false;
                this.CBPais.BackColor = Color.FromArgb(187, 222, 251);
                this.CBCiudad.Enabled = false;
                this.CBCiudad.BackColor = Color.FromArgb(187, 222, 251);
                this.TBDireccion1.ReadOnly = true;
                this.TBDireccion1.BackColor = Color.FromArgb(187, 222, 251);
                this.TBDireccion2.ReadOnly = true;
                this.TBDireccion2.BackColor = Color.FromArgb(187, 222, 251);
                this.TBTelefono.ReadOnly = true;
                this.TBTelefono.BackColor = Color.FromArgb(187, 222, 251);
                this.TBMovil.ReadOnly = true;
                this.TBMovil.BackColor = Color.FromArgb(187, 222, 251);
                this.TBCorreo.ReadOnly = true;
                this.TBCorreo.BackColor = Color.FromArgb(187, 222, 251);
                this.DTInicio.Enabled = false;
                this.DTInicio.BackColor = Color.FromArgb(187, 222, 251);
            }

            else if (IsNuevo == true)
            {
                this.CBTipodeproveedor.Enabled = true;
                this.CBTipodeproveedor.BackColor = Color.FromArgb(32, 178, 170);
                this.TBArea.ReadOnly = false;
                this.TBArea.BackColor = Color.FromArgb(32, 178, 170);
                this.TBProveedor.ReadOnly = false;
                this.TBProveedor.BackColor = Color.FromArgb(32, 178, 170);
                this.TBCodigoID.ReadOnly = false;
                this.TBCodigoID.BackColor = Color.FromArgb(32, 178, 170);
                this.CBIdentificacion.Enabled = true;
                this.CBIdentificacion.BackColor = Color.FromArgb(32, 178, 170);
                this.TBIdentificacion.ReadOnly = false;
                this.TBIdentificacion.BackColor = Color.FromArgb(32, 178, 170);
                this.CBEstado.Enabled = true;
                this.CBEstado.BackColor = Color.FromArgb(32, 178, 170);
                this.TBRepresentante.ReadOnly = false;
                this.TBRepresentante.BackColor = Color.FromArgb(32, 178, 170);
                this.CBPais.Enabled = true;
                this.CBPais.BackColor = Color.FromArgb(32, 178, 170);
                this.CBCiudad.Enabled = true;
                this.CBCiudad.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDireccion1.ReadOnly = false;
                this.TBDireccion1.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDireccion2.ReadOnly = false;
                this.TBDireccion2.BackColor = Color.FromArgb(32, 178, 170);
                this.TBTelefono.ReadOnly = false;
                this.TBTelefono.BackColor = Color.FromArgb(32, 178, 170);
                this.TBMovil.ReadOnly = false;
                this.TBMovil.BackColor = Color.FromArgb(32, 178, 170);
                this.TBCorreo.ReadOnly = false;
                this.TBCorreo.BackColor = Color.FromArgb(32, 178, 170);
                this.DTInicio.Enabled = true;
                this.DTInicio.BackColor = Color.FromArgb(32, 178, 170);
            }
        }

        private void Limpiar()
        {
            this.CBTipodeproveedor.SelectedIndex = 0;
            this.TBArea.Text = string.Empty;
            this.TBProveedor.Text = string.Empty;
            this.TBCodigoID.Text = string.Empty;
            this.CBIdentificacion.SelectedIndex = 0;
            this.TBIdentificacion.Text = string.Empty;
            this.CBEstado.SelectedIndex = 0;
            this.TBRepresentante.Text = string.Empty;
            this.CBPais.Text = string.Empty;
            this.CBCiudad.Text = string.Empty;
            this.TBDireccion1.Text = string.Empty;
            this.TBDireccion2.Text = string.Empty;
            this.TBTelefono.Text = string.Empty;
            this.TBMovil.Text = string.Empty;
            this.TBCorreo.Text = string.Empty;
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
            this.TBProveedor.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rptaDatosBasicos = "";

                //Datos Basicos
                if (this.CBTipodeproveedor.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    CBTipodeproveedor.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBArea.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBArea.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBProveedor.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBProveedor.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBCodigoID.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBCodigoID.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.CBIdentificacion.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    CBIdentificacion.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBIdentificacion.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBIdentificacion.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.CBEstado.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    CBEstado.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBRepresentante.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBRepresentante.BackColor = Color.FromArgb(250, 235, 215);
                }
                
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.PanelLogo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    byte[] imagen = ms.GetBuffer();

                    if (this.IsNuevo)
                    {
                        rptaDatosBasicos = fProduccion_Proveedor.Guardar_DatosBasicos(4, this.TBCodigoID.Text, this.TBProveedor.Text,
                        this.CBTipodeproveedor.Text, this.TBArea.Text, this.CBIdentificacion.Text, this.TBIdentificacion.Text, Convert.ToInt32(this.TBEstado.Text), this.TBRepresentante.Text, Convert.ToInt32(this.CBPais.Text),
                        Convert.ToInt32(this.CBCiudad.Text), this.TBTelefono.Text, this.TBMovil.Text, this.TBDireccion1.Text, this.TBDireccion2.Text, this.TBCorreo.Text, this.DTInicio.Value, imagen, 1);
                    }

                    if (rptaDatosBasicos.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Proveedor Registrado Exitosamente");
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
                    this.TBProveedor.Focus();
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

        private void PanelLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.PanelLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                this.PanelLogo.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void CBEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBEstado.SelectedIndex == 0)
            {
                this.TBEstado.Text = "";
            }
            else if (CBEstado.SelectedIndex == 1)
            {
                this.TBEstado.Text = "1";
            }
            else if (CBEstado.SelectedIndex == 2)
            {
                this.TBEstado.Text = "0";
            }
        }
    }
}
