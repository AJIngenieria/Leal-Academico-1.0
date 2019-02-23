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
    public partial class frmProduccion_Cliente : Form
    {
        private bool IsNuevo = false;
        public frmProduccion_Cliente()
        {
            InitializeComponent();
        }

        private void frmProduccion_Cliente_DatosBasicos_Load(object sender, EventArgs e)
        {
            this.ColoresDeBotones();
            this.Botones();
            this.Habilitar();

            this.CBTipo.Text = string.Empty;
            //this.CBDocumento.Text = string.Empty;
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
                this.TBCodigoID.Enabled = false;
                this.TBCodigoID.BackColor = Color.FromArgb(187, 222, 251);
                this.CBEstado.Enabled = false;
                this.CBEstado.BackColor = Color.FromArgb(187, 222, 251);
                this.TBCliente.Enabled = false;
                this.TBCliente.BackColor = Color.FromArgb(187, 222, 251);
                //this.CBDocumento.Enabled = false;
                //this.CBDocumento.BackColor = Color.FromArgb(187, 222, 251);
                this.TBDocumento.Enabled = false;
                this.TBDocumento.BackColor = Color.FromArgb(187, 222, 251);
                this.CBPais.Enabled = false;
                this.CBPais.BackColor = Color.FromArgb(187, 222, 251);
                this.CBCiudad.Enabled = false;
                this.CBCiudad.BackColor = Color.FromArgb(187, 222, 251);
                this.TBTelefono.Enabled = false;
                this.TBTelefono.BackColor = Color.FromArgb(187, 222, 251);
                this.TBMovil.Enabled = false;
                this.TBMovil.BackColor = Color.FromArgb(187, 222, 251);
                this.TBEmail.Enabled = false;
                this.TBEmail.BackColor = Color.FromArgb(187, 222, 251);
                this.TBDireccion.Enabled = false;
                this.TBDireccion.BackColor = Color.FromArgb(187, 222, 251);
            }

            else if (IsNuevo == true)
            {
                this.TBCodigoID.ReadOnly = false;
                this.TBCodigoID.BackColor = Color.FromArgb(32, 178, 170);
                this.CBEstado.Enabled = true;
                this.CBEstado.BackColor = Color.FromArgb(32, 178, 170);
                this.TBCliente.Enabled = true;
                this.TBCliente.BackColor = Color.FromArgb(32, 178, 170);
                //this.CBDocumento.Enabled = true;
                //this.CBDocumento.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDocumento.ReadOnly = false;
                this.TBDocumento.BackColor = Color.FromArgb(32, 178, 170);
                this.CBPais.Enabled = true;
                this.CBPais.BackColor = Color.FromArgb(32, 178, 170);
                this.CBCiudad.Enabled = true;
                this.CBCiudad.BackColor = Color.FromArgb(32, 178, 170);
                this.TBTelefono.Enabled = true;
                this.TBTelefono.BackColor = Color.FromArgb(32, 178, 170);
                this.TBMovil.Enabled = true;
                this.TBMovil.BackColor = Color.FromArgb(32, 178, 170);
                this.TBEmail.Enabled = true;
                this.TBEmail.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDireccion.Enabled = true;
                this.TBDireccion.BackColor = Color.FromArgb(32, 178, 170);
            }
        }

        private void Limpiar()
        {
            this.TBCodigoID.Text = string.Empty;
            this.CBEstado.Text = string.Empty;
            this.TBCliente.Text = string.Empty;
            //this.CBDocumento.Text = string.Empty;
            this.TBDocumento.Text = string.Empty;
            this.CBPais.Text = string.Empty;
            this.CBCiudad.Text = string.Empty;
            this.TBTelefono.Text = string.Empty;
            this.TBMovil.Text = string.Empty;
            this.TBEmail.Text = string.Empty;
            this.TBDireccion.Text = string.Empty;
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
            MessageBox.Show(mensaje, "Leal Academico", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Leal Academico - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Combobox()
        {
            try
            {
                //CBEstado.DataSource = fProduccion_Proveedor.Mostrar();
                //CBEstado.ValueMember = "Idproveedor";
                //CBEstado.DisplayMember = "Proveedor";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
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
            this.TBCliente.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //string rptaDatosBasicos = "";

                ////Datos Basicos
                //if (this.TBCodigoID.Text == string.Empty || this.CBEstado.Text == string.Empty || this.TBCliente.Text == string.Empty ||
                //    this.CBDocumento.Text == string.Empty)
                //{
                //    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                //    //TBCodigoID.BackColor = Color.FromArgb(250, 235, 215);

                //}

                //else
                //{
                //    if (this.IsNuevo)
                //    {
                //        //rptaDatosBasicos = fProduccion_Clientes.Guardar_DatosBasicos(1, Convert.ToInt32(this.CBEstado.Text), Convert.ToInt32(this.TBIdimpuesto.Text),
                //        //"1", this.CBEstado.Text, this.TBImpuesto_Tipo.Text, this.TBCliente.Text, this.CBDocumento.Text, this.TBDocumento.Text, this.CBPais.Text,
                //        //this.CBDepartamento.Text, this.CBCiudad.Text, this.TBCodigoPostal.Text, this.TBTelefono.Text, this.TBEmail.Text, this.TBDireccion.Text, this.TBGramo.Text,
                //        //this.TBImpuesto.Text, this.TBImpuesto_Valor.Text, this.TBValorbasico.Text, this.TBValorreal.Text, this.TBUbicacion.Text);
                //    }

                //    if (rptaDatosBasicos.Equals("OK"))
                //    {
                //        if (this.IsNuevo)
                //        {
                //            this.MensajeOk("Cliente Registrado Exitosamente");
                //        }
                //    }

                //    else
                //    {
                //        this.MensajeError(rptaDatosBasicos);
                //    }

                //    this.IsNuevo = false;
                //    this.Botones();
                //    this.Limpiar();
                //}
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

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void CHEliminar_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
