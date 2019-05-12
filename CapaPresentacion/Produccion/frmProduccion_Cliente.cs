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
        // Variable con la cual se define si el procecimiento a realizar es EDITAR, Guardar, Buscar
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public bool Filtro = true;

        //Variable para Captura el Empleado Logueado
        public int IDEmpleado;
        
        // Variable para La Consulta de Datos en la Tabla o DataGriview
        private DataTable dtDetalle;

        // Variables para Generar Codigo de Proveedor
        // Y Consultarlo desde la Base de Datos
        public string Codigo_SQL = "";
        public string Codigo_ID = "";

        //Variable para Metodo Eliminar
        public string Eliminar_SQL;

        //Instancia Utilizadas para los metodos de Examinar
        private static frmProduccion_Cliente _Instancia;

        public static frmProduccion_Cliente GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmProduccion_Cliente();
            }
            return _Instancia;
        }

        public frmProduccion_Cliente()
        {
            InitializeComponent();
        }

        private void frmProduccion_Cliente_DatosBasicos_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.DesHabilitar();

            //Desabilitacion de Botones
            this.btnGuardar.Enabled = false;
            this.btnEditar.Enabled = false;
            this.btnEliminar.Enabled = false;

            //Seleccion principal de Combobox
            this.CBTipo.SelectedIndex = 0;
            this.CBTipoDeCuenta01.SelectedIndex = 0;
            this.CBTipoDeCuenta02.SelectedIndex = 0;

            //
            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void Habilitar()
        {
            //Panel - Datos Basicos
            this.CBTipo.Enabled = true;
            this.CBTipo.BackColor = Color.FromArgb(32, 178, 170);
            this.TBCliente.ReadOnly = false;
            this.TBCliente.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDocumento.ReadOnly = false;
            this.TBDocumento.BackColor = Color.FromArgb(32, 178, 170);
            this.TBTelefono.ReadOnly = false;
            this.TBTelefono.BackColor = Color.FromArgb(32, 178, 170);
            this.TBMovil.ReadOnly = false;
            this.TBMovil.BackColor = Color.FromArgb(32, 178, 170);
            this.TBEmail.ReadOnly = false;
            this.TBEmail.BackColor = Color.FromArgb(32, 178, 170);

            //Panel - Datos de Envio
            this.TBCodigoPostal.ReadOnly = false;
            this.TBCodigoPostal.BackColor = Color.FromArgb(32, 178, 170);
            this.TBPais.ReadOnly = false;
            this.TBPais.BackColor = Color.FromArgb(32, 178, 170);
            this.TBCiudad.ReadOnly = false;
            this.TBCiudad.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDireccion01.ReadOnly = false;
            this.TBDireccion01.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDireccion02.ReadOnly = false;
            this.TBDireccion02.BackColor = Color.FromArgb(32, 178, 170);

            //Panel - Datos Financieros
            this.CBBancoPrincipal.Enabled = true;
            this.CBBancoPrincipal.BackColor = Color.FromArgb(32, 178, 170);
            this.CBTipoDeCuenta01.Enabled = true;
            this.CBTipoDeCuenta01.BackColor = Color.FromArgb(32, 178, 170);
            this.TBNumeroCuenta01.ReadOnly = false;
            this.TBNumeroCuenta01.BackColor = Color.FromArgb(32, 178, 170);
            this.CBBancoSecundario.Enabled = true;
            this.CBBancoSecundario.BackColor = Color.FromArgb(32, 178, 170);
            this.CBTipoDeCuenta02.Enabled = true;
            this.CBTipoDeCuenta02.BackColor = Color.FromArgb(32, 178, 170);
            this.TBNumeroCuenta02.ReadOnly = false;
            this.TBNumeroCuenta02.BackColor = Color.FromArgb(32, 178, 170);
            
        }

        private void DesHabilitar()
        {
            //Panel - Datos Basicos
            this.TBCliente.ReadOnly = true;
            this.TBCliente.BackColor = Color.FromArgb(187, 222, 251);
            this.TBDocumento.ReadOnly = true;
            this.TBDocumento.BackColor = Color.FromArgb(187, 222, 251);
            this.TBPais.ReadOnly = true;
            this.TBPais.BackColor = Color.FromArgb(187, 222, 251);
            this.TBCiudad.ReadOnly = true;
            this.TBCiudad.BackColor = Color.FromArgb(187, 222, 251);
            this.TBTelefono.ReadOnly = true;
            this.TBTelefono.BackColor = Color.FromArgb(187, 222, 251);
            this.TBMovil.ReadOnly = true;
            this.TBMovil.BackColor = Color.FromArgb(187, 222, 251);
            this.TBEmail.ReadOnly = true;
            this.TBEmail.BackColor = Color.FromArgb(187, 222, 251);
            this.TBDireccion02.ReadOnly = true;
            this.TBDireccion02.BackColor = Color.FromArgb(187, 222, 251);

            //Panel - Datos de Envio
            this.TBCodigoPostal.ReadOnly = true;
            this.TBCodigoPostal.BackColor = Color.FromArgb(187, 222, 251);
            this.TBPais.ReadOnly = true;
            this.TBPais.BackColor = Color.FromArgb(187, 222, 251);
            this.TBCiudad.ReadOnly = true;
            this.TBCiudad.BackColor = Color.FromArgb(187, 222, 251);
            this.TBDireccion01.ReadOnly = true;
            this.TBDireccion01.BackColor = Color.FromArgb(187, 222, 251);
            this.TBDireccion02.ReadOnly = true;
            this.TBDireccion02.BackColor = Color.FromArgb(187, 222, 251);

            //Panel - Datos Financieros
            this.CBBancoPrincipal.Enabled = false;
            this.CBBancoPrincipal.BackColor = Color.FromArgb(187, 222, 251);
            this.CBTipoDeCuenta01.Enabled = false;
            this.CBTipoDeCuenta01.BackColor = Color.FromArgb(187, 222, 251);
            this.TBNumeroCuenta01.ReadOnly = false;
            this.TBNumeroCuenta01.BackColor = Color.FromArgb(187, 222, 251);
            this.CBBancoSecundario.Enabled = false;
            this.CBBancoSecundario.BackColor = Color.FromArgb(187, 222, 251);
            this.CBTipoDeCuenta02.Enabled = false;
            this.CBTipoDeCuenta02.BackColor = Color.FromArgb(187, 222, 251);
            this.TBNumeroCuenta02.ReadOnly = false;
            this.TBNumeroCuenta02.BackColor = Color.FromArgb(187, 222, 251);
        }

        private void Limpiar()
        {
            //Panel - Datos Basicos
            this.CBTipo.SelectedIndex = 0;
            this.TBCliente.Text = string.Empty;
            this.TBDocumento.Text = string.Empty;
            this.TBPais.Text = string.Empty;
            this.TBCiudad.Text = string.Empty;
            this.TBTelefono.Text = string.Empty;
            this.TBMovil.Text = string.Empty;
            this.TBEmail.Text = string.Empty;
            this.TBDireccion02.Text = string.Empty;

            //Panel - Datos de Envio
            this.TBCodigoPostal.Text = string.Empty;
            this.TBPais.Text = string.Empty;
            this.TBCiudad.Text = string.Empty;
            this.TBDireccion01.Text = string.Empty;
            this.TBDireccion02.Text = string.Empty;

            //Panel - Datos Financieros
            this.CBBancoPrincipal.SelectedIndex = 0;
            this.CBTipoDeCuenta01.SelectedIndex = 0;
            this.TBNumeroCuenta01.Text = string.Empty;
            this.CBBancoSecundario.SelectedIndex = 0;
            this.CBTipoDeCuenta02.SelectedIndex = 0;
            this.TBNumeroCuenta02.Text = string.Empty;


        }

        private void Botones_Consultas()
        {
            //Si el texboxt esta vacio desabilitara el Boton editar
            //Y la tabla de resultados

            if (TBBuscar.Text == "")
            {
                btnEditar.Visible = false;
                DGResultado.Enabled = false;
            }
            //Si el texboxt esta LLENO Habilitara el Boton editar
            //Y la tabla de resultados

            else if (TBBuscar.Text != "")
            {
                btnEditar.Visible = true;
                DGResultado.Enabled = true;
                this.Consulta();
            }
        }

        private void CrearTabla()
        {
            //Crea la tabla con el nombre de Detalle
            this.dtDetalle = new DataTable("Detalle");
            //Agrega las columnas que tendra la tabla
            this.dtDetalle.Columns.Add("Codigo", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Cliente", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Identificacion", System.Type.GetType("System.String"));
            //Relacionamos nuestro datagridview con nuestro datatable
            this.DGResultado.DataSource = this.dtDetalle;
        }

        private void Consulta()
        {
            //Se realiza una consulta General de los datos Registrados
            //procedimiento Almacenado Produccion.Buscar_Cliente

            try
            {
                this.DGResultado.DataSource = fProduccion_Clientes.Buscar_Cliente(this.TBBuscar.Text);
                lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultado.Rows.Count);

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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (!IsNuevo)
            {
                // Se procede habilitar los campos de textos del Datos Basicos
                this.Habilitar();

                // Se hace enfasis (Focus) Al Iniciar el Evento Click 
                // sobre el Campo Con Nombre Proveedor

                this.TBCliente.Focus();

                // Se realiza la consulta para Auto Generar
                // El Codigo del Proveedor desde la Base de Datos

                this.IsNuevo = true;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rptaDatosBasicos = "";

                //Datos Basicos
                if (this.TBCliente.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBCliente.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBDocumento.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBDocumento.BackColor = Color.FromArgb(250, 235, 215);
                }
                
                else
                {
                    if (this.IsNuevo)
                    {
                        rptaDatosBasicos = fProduccion_Clientes.Guardar_DatosBasicos(IDEmpleado, this.TBCliente.Text, this.TBDocumento.Text,
                        this.TBPais.Text, this.TBCiudad.Text, this.TBTelefono.Text, this.TBMovil.Text, this.TBEmail.Text, this.TBDireccion02.Text, 1, 1);
                    }

                    if (rptaDatosBasicos.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Cliente Registrado Exitosamente");
                        }
                    }

                    else
                    {
                        this.MensajeError(rptaDatosBasicos);
                    }

                    this.IsNuevo = false;
                    this.Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Botones_Consultas();
        }

        private void CHEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (CHEliminar.Checked == true)
            {
                btnEliminar.Visible = true;
            }
            else if (CHEliminar.Checked == false)
            {
                btnEliminar.Visible = false;
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
              
        private void frmProduccion_Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }
    }
}
