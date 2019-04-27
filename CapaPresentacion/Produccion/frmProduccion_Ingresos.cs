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
    public partial class frmProduccion_Ingresos : Form
    {
        // Variable con la cual se define si el procecimiento a realizar es EDITAR, Guardar, Buscar
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public bool Filtro = true;

        //Variable para Captura el Empleado Logueado
        public int IDEmpleado;


        // Variable para La Consulta de Datos en DataGriview
        private DataTable dtDetalle;

        //Variables para los detalles del ingreso
        //Se trabaja las columnas
        int Cantidad = 0;
        decimal Unidad = 0;
        decimal Total = 0;

        // Variables para Generar Codigo de Proveedor
        // Y Consultarlo desde la Base de Datos
        public string Codigo_SQL = "";
        public string Codigo_ID = "";

        //Variable para Metodo Eliminar
        public string Eliminar_SQL;

        //Instancia Utilizadas para los metodos de Examinar
        private static frmProduccion_Ingresos _Instancia;

        public static frmProduccion_Ingresos GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmProduccion_Ingresos();
            }
            return _Instancia;
        }

        public frmProduccion_Ingresos()
        {
            InitializeComponent();
        }

        private void frmProduccion_Ingresos_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.DesHabilitar();
            this.CrearTabla();
            this.AutoAjustar_Columnas();
            
            //Desabilitacion de Botones
            this.btnGuardar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnAgregar.Enabled = false;
            this.btnExaminar_Bodega.Enabled = false;
            this.btnExaminar_Proveedor.Enabled = false;

            //Seleccion principal de Combobox
            this.CBComprobante.SelectedIndex = 0;
            
        }

        private void Habilitar()
        {
            this.TBBodega.ReadOnly = false;
            this.TBBodega.BackColor = Color.FromArgb(32, 178, 170);
            this.TBProveedor.ReadOnly = false;
            this.TBProveedor.BackColor = Color.FromArgb(32, 178, 170);
            this.TBIdbodega.ReadOnly = false;
            this.TBIdbodega.BackColor = Color.FromArgb(32, 178, 170);
            this.TBIdproveedor.ReadOnly = false;
            this.TBIdproveedor.BackColor = Color.FromArgb(32, 178, 170);
            this.TBComprobante.ReadOnly = false;
            this.TBComprobante.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void DesHabilitar()
        {
            this.TBBodega.ReadOnly = true;
            this.TBBodega.BackColor = Color.FromArgb(187, 222, 251);
            this.TBIdbodega.ReadOnly = true;
            this.TBIdbodega.BackColor = Color.FromArgb(187, 222, 251);
            this.TBIdproveedor.ReadOnly = true;
            this.TBIdproveedor.BackColor = Color.FromArgb(187, 222, 251);
            this.TBProveedor.ReadOnly = true;
            this.TBProveedor.BackColor = Color.FromArgb(187, 222, 251);
            this.TBComprobante.ReadOnly = true;
            this.TBComprobante.BackColor = Color.FromArgb(187, 222, 251);
        }

        private void Limpiar()
        {
            this.TBBodega.Text = string.Empty;
            this.TBProveedor.Text = string.Empty;
            this.TBIdbodega.Text = string.Empty;
            this.TBIdproveedor.Text = string.Empty;
            this.TBComprobante.Text = string.Empty;
        }


        private void Botones()
        {
            if (this.IsNuevo == true)
            {
                this.btnNuevo.Visible = false;
                this.btnGuardar.Visible = true;
                this.btnEliminar.Visible = true;
                this.btnAgregar.Visible = true;
            }

            else
            {
                this.btnNuevo.Visible = true;
                this.btnGuardar.Visible = false;
                this.btnEliminar.Visible = false;
                this.btnAgregar.Visible = false;
            }
        }

        private void Teclas(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.N))
            {
                MessageBox.Show("Se ha pulsado la combinación de teclas Control+N");
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

        private void AutoAjustar_Columnas()
        {
            DGDetalles.Columns[0].Width = 70;
            DGDetalles.Columns[1].Width = 375;
            DGDetalles.Columns[2].Width = 70;
            DGDetalles.Columns[3].Width = 70;
            DGDetalles.Columns[4].Width = 70;
            DGDetalles.Columns[5].Width = 70;
        }

        private void CrearTabla()
        {
            //Crea la tabla con el nombre de Detalle
            this.dtDetalle = new DataTable("Detalle");
            //Agrega las columnas que tendra la tabla
            this.dtDetalle.Columns.Add("Codigo ID", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Producto", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Cantidad", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Unidad", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Costo", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Total", System.Type.GetType("System.String"));
            //Relacionamos nuestro datagridview con nuestro datatable
            this.DGDetalles.DataSource = this.dtDetalle;

            DataRow row = dtDetalle.NewRow();
            row["Codigo ID"] = "001";
            row["Producto"] = "CAJA DE UNIFORMES DE DIARIO PARA HOMBRES";
            row["Cantidad"] = "1";
            row["Unidad"] = "CAJA";
            row["Costo"] = "20000";
            row["Total"] = "20000";

            dtDetalle.Rows.Add(row);
        }

        private void Consulta_CodigoID()
        {
            try
            {
                DataTable Datos = CapaNegocio.fProduccion_Ingresos.CodigoID_Solicitud("1");
                //Evaluamos si  existen los Datos
                if (Datos.Rows.Count == 0)
                {
                    Codigo_SQL = "1";
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

            //this.TBCodigoID.Text = Codigo_SQL;

        }

        public void setBodega(string idbodega, string bodega)
        {
            this.TBIdbodega.Text = idbodega;
            this.TBBodega.Text = bodega;
        }

        public void setProveedor(string idproveedor, string proveedor)
        {
            this.TBIdproveedor.Text = idproveedor;
            this.TBProveedor.Text = proveedor;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (!IsNuevo)
            {
                // Se procede habilitar los campos de textos del Datos Basicos
                this.Habilitar();

                // Se procede habilitar el Boton Guardar
                // y los Campos de Textos

                this.btnExaminar_Bodega.Enabled = true;
                this.btnExaminar_Proveedor.Enabled = true;
                this.btnGuardar.Enabled = true;
                this.btnGuardar.Image = Properties.Resources.BV_Guardar;
                this.btnEliminar.Enabled = true;
                this.btnEliminar.Image = Properties.Resources.BV_Eliminar;
                this.btnAgregar.Enabled = true;
                this.btnAgregar.Image = Properties.Resources.BV_Agregar;
            }

            // Se hace enfasis (Focus) Al Iniciar el Evento Click 
            // sobre el Campo Con Nombre Proveedor

            this.TBBodega.Focus();

            // Se realiza la consulta para Auto Generar
            // El Codigo del Proveedor desde la Base de Datos

            this.Consulta_CodigoID();
            this.AutoCompletar_ReInscripcion();

            this.IsNuevo = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.TBProveedor.Text == string.Empty)
                {
                    MensajeError("Falta Ingresar Campos Articulos, Estos Seran Remarcados");
                    TBProveedor.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBBodega.Text == string.Empty)
                {
                    MensajeError("Falta Ingresar Campos Articulos, Estos Seran Remarcados");
                    TBBodega.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBComprobante.Text == string.Empty)
                {
                    MensajeError("Falta Ingresar Campos Articulos, Estos Seran Remarcados");
                    TBComprobante.BackColor = Color.FromArgb(250, 235, 215);
                }
                //else if (this.TBAIANumeroDeComprobante.Text == string.Empty)
                //{
                //    MensajeError("Falta Ingresar Algunos Campos, Estos Seran Remarcados");
                //    TBAIANumeroDeComprobante.BackColor = Color.FromArgb(250, 235, 215);
                //}

                else
                {

                    if (this.IsNuevo)
                    {
                        //rpta = fProduccion_Ingresos.Guardar_DatosBasicos(IDEmpleado, Convert.ToInt32(this.IDProveedor.Text), CBAIAComprobante.Text, this.TBAIANumeroDeComprobante.Text, DTAIAFechaDeIngreso.Value, "EMITIDO", dtDetalle);
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Ingreso Registrado Exitosamente");
                        }
                    }

                    else
                    {
                        this.MensajeError(rpta);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = DGDetalles.CurrentRow.Index;
                DGDetalles.Rows.RemoveAt(fila);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnExaminar_Bodega_Click(object sender, EventArgs e)
        {
            frmExaminar_Bodega frmExaminarProduccion_Bodega = new frmExaminar_Bodega();
            frmExaminarProduccion_Bodega.ShowDialog();
        }

        private void btnExaminar_Proveedor_Click(object sender, EventArgs e)
        {
            frmExaminar_Proveedor frmExaminarProduccion_Proveedor = new frmExaminar_Proveedor();
            frmExaminarProduccion_Proveedor.ShowDialog();
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

        private void btnEliminar_MouseDown(object sender, MouseEventArgs e)
        {
            btnEliminar.Image = Properties.Resources.BV_Eliminar;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.Image = Properties.Resources.BV_Eliminar;
        }

        private void btnEliminar_MouseMove(object sender, MouseEventArgs e)
        {
            btnEliminar.Image = Properties.Resources.BR_Eliminar;
        }

        private void btnBuscar_MouseDown(object sender, MouseEventArgs e)
        {
            btnAgregar.Image = Properties.Resources.BV_Agregar;
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.Image = Properties.Resources.BV_Agregar;
        }

        private void btnBuscar_MouseMove(object sender, MouseEventArgs e)
        {
            btnAgregar.Image = Properties.Resources.BR_Agregar;
        }

        private void frmProduccion_Bodegas_Ingreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

        private void btnNuevo_Auxiliar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.Botones();
            this.Habilitar();
            //this.Combobox();
            //this.TBProducto.Focus();
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }
    }
}
