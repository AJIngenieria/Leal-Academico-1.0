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
        private DataTable dtDetalle;

        public string Codigo_SQL = "";
        public string Codigo_ID = "";
        public frmProduccion_Cliente()
        {
            InitializeComponent();
        }

        private void frmProduccion_Cliente_DatosBasicos_Load(object sender, EventArgs e)
        {
            this.Habilitar();

            this.CBTipo.SelectedIndex = 0;
            this.CBEstado.SelectedIndex = 0;
            
            this.Botones_Consultas();

            //Ocultar
            this.btnEliminar.Visible = false;
            this.TBFiltroID.Visible = false;
        }

        private void Habilitar()
        {
            if (IsNuevo == false)
            {
                this.TBCodigoID.ReadOnly = true;
                this.TBCodigoID.BackColor = Color.FromArgb(187, 222, 251);
                this.CBEstado.Enabled = false;
                this.CBEstado.BackColor = Color.FromArgb(187, 222, 251);
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
                this.TBDireccion.ReadOnly = true;
                this.TBDireccion.BackColor = Color.FromArgb(187, 222, 251);

                //Botones de Datos Basicos y Panel de Logo
                this.btnNuevo.Visible = true;
                this.btnGuardar.Visible = false;

                //Texboxt Buscar o Filtro

                this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);

            }

            else if (IsNuevo == true)
            {
                this.TBCodigoID.ReadOnly = false;
                this.TBCodigoID.BackColor = Color.FromArgb(32, 178, 170);
                this.CBEstado.Enabled = true;
                this.CBEstado.BackColor = Color.FromArgb(32, 178, 170);
                this.TBCliente.ReadOnly = false;
                this.TBCliente.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDocumento.ReadOnly = false;
                this.TBDocumento.BackColor = Color.FromArgb(32, 178, 170);
                this.TBPais.ReadOnly = false;
                this.TBPais.BackColor = Color.FromArgb(32, 178, 170);
                this.TBCiudad.ReadOnly = false;
                this.TBCiudad.BackColor = Color.FromArgb(32, 178, 170);
                this.TBTelefono.ReadOnly = false;
                this.TBTelefono.BackColor = Color.FromArgb(32, 178, 170);
                this.TBMovil.ReadOnly = false;
                this.TBMovil.BackColor = Color.FromArgb(32, 178, 170);
                this.TBEmail.ReadOnly = false;
                this.TBEmail.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDireccion.ReadOnly = false;
                this.TBDireccion.BackColor = Color.FromArgb(32, 178, 170);

                //Botones de Datos Basicos y Panel de Logo

                this.btnNuevo.Visible = false;
                this.btnGuardar.Visible = true;

            }
        }

        private void Limpiar()
        {
            this.TBCodigoID.Text = string.Empty;
            this.CBEstado.Text = string.Empty;
            this.TBCliente.Text = string.Empty;
            this.TBDocumento.Text = string.Empty;
            this.TBPais.Text = string.Empty;
            this.TBCiudad.Text = string.Empty;
            this.TBTelefono.Text = string.Empty;
            this.TBMovil.Text = string.Empty;
            this.TBEmail.Text = string.Empty;
            this.TBDireccion.Text = string.Empty;
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
            this.dtDetalle.Columns.Add("Idcliente", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("CodigoID", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Cliente", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Identificacion", System.Type.GetType("System.String"));
            //Relacionamos nuestro datagridview con nuestro datatable
            this.DGResultado.DataSource = this.dtDetalle;
        }

        private void Consulta_CodigoID()
        {
            try
            {
                DataTable Datos = CapaNegocio.fProduccion_Proveedor.CodigoID_Solicitud(this.TBFiltroID.Text);
                //Evaluamos si  existen los Datos
                if (Datos.Rows.Count == 0)
                {
                    Codigo_SQL = TBFiltroID.Text;
                    //TBCodigoID.Text = "1";
                    //MessageBox.Show("No se Encontraron Registros en la Base de Datos", "Sistema Instituto Fundecar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //frmAcademico_RegistrarAlumno frm = new frmAcademico_RegistrarAlumno();
                    Codigo_SQL = Datos.Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void AutoCompletar_ReInscripcion()
        {
            //Obtenemos el resultado de la base de datos de
            //La columna Iddatos basicos - Tabla Prestamos.DatosBasicos
            //Procedimiento Almacenado Sistema.CodigoID_Solicitud

            this.TBCodigoID.Text = Codigo_SQL;

        }

        private void Consulta()
        {
            //Se realiza una consulta General de los datos Registrados
            //La cual se produce en la tabla Historico.Proveedor
            //Y el procedimiento Almacenado Produccion.Buscar_Proveedor

            try
            {
                this.DGResultado.DataSource = fProduccion_Proveedor.Buscar_Proveedor(this.TBBuscar.Text);
                this.DGResultado.Columns[0].Visible = false;
                lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultado.Rows.Count);

                //Despues de realizar la consulta se procede
                //A darle colores o fondo a los botones Eliminar y Editar
                btnEliminar.BackgroundImage = Properties.Resources.BV_Eliminar;
                btnEditar.BackgroundImage = Properties.Resources.BV_Editar;


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
    }
}
