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
    public partial class frmGestionHumana_Empleados : Form
    {
        public string Idempleado = "";
        public string Empleado = "";

        private bool IsNuevo = false;
        
        public frmGestionHumana_Empleados()
        {
            InitializeComponent();
        }

        private void frmPlantel_Empleados_Load(object sender, EventArgs e)
        {
            this.Botones();
            this.Habilitar();

            this.CBIdentificacion.SelectedIndex = 0;
            this.CBHorasExtras.SelectedIndex = 0;
            this.CBAdelantos.SelectedIndex = 0;

        }

        private void ColoresDeBotones()
        {
            btnNuevo.BackgroundImage = Properties.Resources.BV_Nuevo;
            btnGuardar.BackgroundImage = Properties.Resources.BV_Guardar;

            this.PanelFoto.Image = global::CapaPresentacion.Properties.Resources.A_J_Academico;
        }

        private void Habilitar()
        {
            if (IsNuevo == false)
            {
                //Datos Basicos
                this.TBNombre.ReadOnly = true;
                this.TBNombre.BackColor = Color.FromArgb(187, 222, 251);
                this.TBProfesion.ReadOnly = true;
                this.TBProfesion.BackColor = Color.FromArgb(187, 222, 251);
                this.CBIdentificacion.Enabled = false;
                this.CBIdentificacion.BackColor = Color.FromArgb(187, 222, 251);
                this.DTFechaExpedicion.Enabled = false;
                this.DTFechaExpedicion.BackColor = Color.FromArgb(187, 222, 251);
                this.TBEmail.ReadOnly = true;
                this.TBEmail.BackColor = Color.FromArgb(187, 222, 251);
                this.TBTelefono.ReadOnly = true;
                this.TBTelefono.BackColor = Color.FromArgb(187, 222, 251);
                this.TBDireccion.ReadOnly = true;
                this.TBDireccion.BackColor = Color.FromArgb(187, 222, 251);
                //this.DTFechaDeIngreso.Enabled = false;
                //this.DTFechaDeIngreso.BackColor = Color.FromArgb(187, 222, 251);
                //this.DTFechadesalida.Enabled = false;
                //this.DTFechadesalida.BackColor = Color.FromArgb(187, 222, 251);
                
            }

            else if (IsNuevo == true)
            {
                this.TBNombre.ReadOnly = false;
                this.TBNombre.BackColor = Color.FromArgb(32, 178, 170);
                this.TBProfesion.ReadOnly = false;
                this.TBProfesion.BackColor = Color.FromArgb(32, 178, 170);
                this.CBIdentificacion.Enabled = true;
                this.CBIdentificacion.BackColor = Color.FromArgb(32, 178, 170);
                this.DTFechaExpedicion.Enabled = true;
                this.DTFechaExpedicion.BackColor = Color.FromArgb(32, 178, 170);
                this.TBEmail.ReadOnly = false;
                this.TBEmail.BackColor = Color.FromArgb(32, 178, 170);
                this.TBTelefono.ReadOnly = false;
                this.TBTelefono.BackColor = Color.FromArgb(32, 178, 170);
                this.CBBEstado.Enabled = true;
                this.CBBEstado.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDireccion.ReadOnly = false;
                this.TBDireccion.BackColor = Color.FromArgb(32, 178, 170);
                //this.DTFechaDeIngreso.Enabled = true;
                //this.DTFechaDeIngreso.BackColor = Color.FromArgb(32, 178, 170);
                //this.DTFechadesalida.Enabled = true;
                //this.DTFechadesalida.BackColor = Color.FromArgb(32, 178, 170);
            }
        }

        private void Limpiar()
        {
            //
            this.TBNombre.Text = string.Empty;
            this.TBProfesion.Text = string.Empty;
            this.CBIdentificacion.Text = string.Empty;
            this.TBIdentificacion.Text = string.Empty;
            this.TBExpedicion.Text = string.Empty;
            this.DTFechaExpedicion.Text = string.Empty;
            this.TBEmail.Text = string.Empty;
            this.TBTelefono.Text = string.Empty;
            this.CBBEstado.Text = string.Empty;
            this.TBDireccion.Text = string.Empty;
            //this.DTFechaDeIngreso.Text = string.Empty;
            //this.DTFechadesalida.Text = string.Empty;
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

        private void Auto_CodigoID()
        {
            try
            {
                string Auto = "0";
                DataTable Datos = CapaNegocio.fGestion_Empleados.Mostrar_CodigoID();
                //Evaluamos si  existen los Datos
                if (Datos.Rows.Count == 0)
                {
                    MessageBox.Show("Acceso Denegado al Sistema, Usuario o Contraseña Incorrecto. Si el Problema Persiste Contacte al Area de Sistemas", "A&J Academico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //this.TBCodigoID.Text = Auto.ToString();
                }
                else
                {
                    this.Idempleado = Auto + Datos.Rows[0][0].ToString();
                    //frm.Empleado = Datos.Rows[0][1].ToString();
                    this.TBCodigoID.Text = Idempleado;
                }
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

        
        private void limpiarDetalle()
        {
            //Datos Basicos
            this.TBNombre.Text = string.Empty;
            this.TBProfesion.Text = string.Empty; ;
            this.TBIdentificacion.Text = string.Empty;
            this.TBExpedicion.Text = string.Empty;
            this.TBEmail.Text = string.Empty;
            this.TBTelefono.Text = string.Empty; ;
            this.TBDireccion.Text = string.Empty;

            this.TBCodigoID.Text = string.Empty;
            
        }

        private void Combobox()
        {
            try
            {
                CBRol.DataSource = fSistema_Gestion_Roles.Mostrar();
                CBRol.ValueMember = "Idrol";
                CBRol.DisplayMember = "Rol";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CBIdentificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CBIdentificacion.SelectedIndex == 0)
                {
                    this.TBIdentificacion.Text = string.Empty;
                    this.TBExpedicion.Text = string.Empty;

                    this.TBIdentificacion.ReadOnly = true;
                    this.TBIdentificacion.BackColor = Color.FromArgb(187, 222, 251);
                    this.TBExpedicion.ReadOnly = true;
                    this.TBExpedicion.BackColor = Color.FromArgb(187, 222, 251);
                }
                else if (CBIdentificacion.SelectedIndex == 1)
                {
                    
                    this.TBIdentificacion.ReadOnly = false;
                    this.TBIdentificacion.BackColor = Color.FromArgb(32, 178, 170);
                    this.TBExpedicion.ReadOnly = false;
                    this.TBExpedicion.BackColor = Color.FromArgb(32, 178, 170);
                }
                else if (CBIdentificacion.SelectedIndex == 2)
                {
                    this.TBIdentificacion.ReadOnly = false;
                    this.TBIdentificacion.BackColor = Color.FromArgb(32, 178, 170);
                    this.TBExpedicion.ReadOnly = false;
                    this.TBExpedicion.BackColor = Color.FromArgb(32, 178, 170);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        
        private void PanelFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.PanelFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.PanelFoto.Image = Image.FromFile(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                this.IsNuevo = true;
                this.Botones();
                this.Habilitar();

                this.limpiarDetalle();
                this.Combobox();
                this.TBNombre.Focus();

                this.Auto_CodigoID();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rptaDatosBasicos = "";
                string rptaDatosPersonales = "";
                string rptaDatosMedicos = "";

                //Datos Basicos
                if (this.TBNombre.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBNombre.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBProfesion.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBProfesion.BackColor = Color.FromArgb(250, 235, 215);
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

                else
                {
                    if (this.IsNuevo)
                    {
                        //rptaDatosBasicos = fGestion_Empleados.Guardar_DatosBasicos(Convert.ToInt32(this.CBRol.SelectedValue), this.TBCodigoID.Text, this.CBBEstado.Text, this.TBNombre.Text, this.TBProfesion.Text, this.CBIdentificacion.Text, this.TBIdentificacion.Text, this.TBExpedicion.Text, this.DTFechaExpedicion.Value, this.TBEmail.Text, this.TBTelefono.Text, this.TBDireccion.Text, this.DTFechaDeIngreso.Value, this.DTFechadesalida.Value);
                        //rptaDatosMedicos = fGestion_DatosMedicos.Guardar_DatosBasicos(this.TBCodigoID.Text, this.CBRh.Text, this.CBEps.Text, this.TBAlimentos.Text, this.TBAnimales.Text, this.TBInsectos.Text, this.TBMedicamentos.Text, this.TBPlantas.Text, this.TBIndicaciones.Text);
                        //rptaDatosPersonales = fGestion_DatosPersonales.Guardar_DatosBasicos(this.TBCodigoID.Text, this.TBProfesionprincipal.Text, this.CBPension.Text, this.CBFondo.Text, this.CBContrato.Text, this.TBSueldo.Text, this.CBAdelantos.Text, this.CBHorasExtras.Text, this.CBBanco.Text, this.CBCuenta.Text, TBNumerodecuenta.Text, this.CBPago.Text, this.CBMoneda.Text, this.TBRecomendado.Text, this.DTNacimiento.Value, this.TBHijos.Text, this.TBHijosPlantel.Text, this.CBCivil.Text);
                    }

                    if (rptaDatosBasicos.Equals("OK") && rptaDatosMedicos.Equals("OK") && rptaDatosPersonales.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Empleado Registrado Exitosamente");
                        }
                    }

                    else
                    {
                        this.MensajeError(rptaDatosBasicos);
                        this.MensajeError(rptaDatosMedicos);
                        this.MensajeError(rptaDatosPersonales);
                    }

                    this.IsNuevo = false;
                    this.Botones();
                    this.Limpiar();
                    this.limpiarDetalle();
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
