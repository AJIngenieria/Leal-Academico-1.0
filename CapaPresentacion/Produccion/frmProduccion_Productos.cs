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
    public partial class frmProduccion_Productos : Form
    {
        // Variable con la cual se define si el procecimiento 
        // A realizar es Editar, Guardar, Buscar,Eliminar
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public bool Filtro = true;

        //Variable para Metodo Eliminar
        public string Eliminar_SQL;

        //Variable para Captura el Empleado Logueado
        public int IDEmpleado;
        
        // Variable para La Consulta de Datos en la Tabla o DataGriview
        private DataTable dtDetalle;

        // Variables para Generar Codigo de Proveedor
        // Y Consultarlo desde la Base de Datos
        public string Codigo_SQL = "";
        public string Codigo_ID = "";

        //Instancia Utilizadas para los metodos de Examinar
        private static frmProduccion_Productos _Instancia;

        public static frmProduccion_Productos GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmProduccion_Productos();
            }
            return _Instancia;
        }

        public frmProduccion_Productos()
        {
            InitializeComponent();
        }

        private void frmAlmacen_Productos_Load(object sender, EventArgs e)
        {
            
            //Inicio de Clase y Botones
            this.DesHabilitar();

            this.btnGuardar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnEditar.Enabled = false;
            this.btnExaminar_Bodega.Enabled = false;
            this.btnExaminar_Impuesto.Enabled = false;
            this.btnExaminar_Marca.Enabled = false;
            this.btnExaminar_Proveedor.Enabled = false;

            //Ocultacion de Texbox ID
            this.TBIdbodega.Visible = false;
            this.TBIdimpuesto.Visible = false;
            this.TBIdmarca.Visible = false;
            this.TBIdproveedor.Visible = false;

            //Seleccion principal de Combobox
            this.CBImportado.SelectedIndex = 0;
            this.CBEmpacado.SelectedIndex = 0;
            this.CBVence.SelectedIndex = 0;
            this.CBTipo.SelectedIndex = 0;
            this.CBGrupo.SelectedIndex = 0;
            this.CBOfertable.SelectedIndex = 0;
            this.CBVentaPublico.SelectedIndex = 0;
            this.CBUnidad.SelectedIndex = 0;

            //Color para Texboxt Buscar
            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void Habilitar()
        {
            //Panel - Datos Basicos
            this.TBCodigoID.ReadOnly = false;
            this.TBCodigoID.BackColor = Color.FromArgb(32, 178, 170);
            this.TBProducto.ReadOnly = false;
            this.TBProducto.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDescripcion.ReadOnly = false;
            this.TBDescripcion.BackColor = Color.FromArgb(32, 178, 170);
            //this.TBMarca.ReadOnly = false;
            //this.TBMarca.BackColor = Color.FromArgb(32, 178, 170);
            this.TBReferencia.ReadOnly = false;
            this.TBReferencia.BackColor = Color.FromArgb(32, 178, 170);
            this.CBImportado.Enabled = true;
            this.CBImportado.BackColor = Color.FromArgb(32, 178, 170);
            this.CBEmpacado.Enabled = true;
            this.CBEmpacado.BackColor = Color.FromArgb(32, 178, 170);
            this.CBVence.Enabled = true;
            this.CBVence.BackColor = Color.FromArgb(32, 178, 170);
            this.CBTipo.Enabled = true;
            this.CBTipo.BackColor = Color.FromArgb(32, 178, 170);
            this.CBGrupo.Enabled = true;
            this.CBGrupo.BackColor = Color.FromArgb(32, 178, 170);
            this.CBOfertable.Enabled = true;
            this.CBOfertable.BackColor = Color.FromArgb(32, 178, 170);

            //Panel - Costos y Precios
            this.TBValorCompra.ReadOnly = false;
            this.TBValorCompra.BackColor = Color.FromArgb(32, 178, 170);
            this.TBValorVenta01.ReadOnly = false;
            this.TBValorVenta01.BackColor = Color.FromArgb(32, 178, 170);
            this.TBValorVenta02.ReadOnly = false;
            this.TBValorVenta02.BackColor = Color.FromArgb(32, 178, 170);
            this.TBValorVenta03.ReadOnly = false;
            this.TBValorVenta03.BackColor = Color.FromArgb(32, 178, 170);
            this.TBValorOferta.ReadOnly = false;
            this.TBValorOferta.BackColor = Color.FromArgb(32, 178, 170);

            this.CBVentaPublico.Enabled = true;
            this.CBVentaPublico.BackColor = Color.FromArgb(32, 178, 170);
            this.TBCantidadMinima.ReadOnly = false;
            this.TBCantidadMinima.BackColor = Color.FromArgb(32, 178, 170);
            this.TBCantidadMaxima.ReadOnly = false;
            this.TBCantidadMaxima.BackColor = Color.FromArgb(32, 178, 170);

            //Panel Impuestos y Otros
            //this.TBImpuesto.ReadOnly = false;
            //this.TBImpuesto.BackColor = Color.FromArgb(32, 178, 170);
            //this.TBBodega.ReadOnly = false;
            //this.TBBodega.BackColor = Color.FromArgb(32, 178, 170);
            this.TBUbicacion.ReadOnly = false;
            this.TBUbicacion.BackColor = Color.FromArgb(32, 178, 170);
            //this.TBProveedor.ReadOnly = false;
            //this.TBProveedor.BackColor = Color.FromArgb(32, 178, 170);
            this.CBUnidad.Enabled = true;
            this.CBUnidad.BackColor = Color.FromArgb(32, 178, 170);
            this.TBObservacion.ReadOnly = false;
            this.TBObservacion.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void DesHabilitar()
        {
            //Panel - Datos Basicos
            this.TBCodigoID.ReadOnly = true;
            this.TBCodigoID.BackColor = Color.FromArgb(187, 222, 251);
            this.TBProducto.ReadOnly = true;
            this.TBProducto.BackColor = Color.FromArgb(187, 222, 251);
            this.TBDescripcion.ReadOnly = true;
            this.TBDescripcion.BackColor = Color.FromArgb(187, 222, 251);
            this.TBMarca.ReadOnly = true;
            this.TBMarca.BackColor = Color.FromArgb(187, 222, 251);
            this.TBReferencia.ReadOnly = true;
            this.TBReferencia.BackColor = Color.FromArgb(187, 222, 251);
            this.CBImportado.Enabled = false;
            this.CBImportado.BackColor = Color.FromArgb(187, 222, 251);
            this.CBEmpacado.Enabled = false;
            this.CBEmpacado.BackColor = Color.FromArgb(187, 222, 251);
            this.CBVence.Enabled = false;
            this.CBVence.BackColor = Color.FromArgb(187, 222, 251);
            this.CBTipo.Enabled = false;
            this.CBTipo.BackColor = Color.FromArgb(187, 222, 251);
            this.CBGrupo.Enabled = false;
            this.CBGrupo.BackColor = Color.FromArgb(187, 222, 251);
            this.CBOfertable.Enabled = false;
            this.CBOfertable.BackColor = Color.FromArgb(187, 222, 251);
            this.TBBodega.ReadOnly = true;
            this.TBBodega.BackColor = Color.FromArgb(187, 222, 251);

            //Panel - Costos y Precios
            this.TBValorCompra.ReadOnly = true;
            this.TBValorCompra.BackColor = Color.FromArgb(187, 222, 251);
            this.TBValorVenta01.ReadOnly = true;
            this.TBValorVenta01.BackColor = Color.FromArgb(187, 222, 251);
            this.TBValorVenta02.ReadOnly = true;
            this.TBValorVenta02.BackColor = Color.FromArgb(187, 222, 251);
            this.TBValorVenta03.ReadOnly = true;
            this.TBValorVenta03.BackColor = Color.FromArgb(187, 222, 251);
            this.TBValorOferta.ReadOnly = true;
            this.TBValorOferta.BackColor = Color.FromArgb(187, 222, 251);

            this.CBVentaPublico.Enabled = false;
            this.CBVentaPublico.BackColor = Color.FromArgb(187, 222, 251);
            this.TBCantidadMinima.ReadOnly = true;
            this.TBCantidadMinima.BackColor = Color.FromArgb(187, 222, 251);
            this.TBCantidadMaxima.ReadOnly = true;
            this.TBCantidadMaxima.BackColor = Color.FromArgb(187, 222, 251);

            //Panel Impuestos y Otros
            this.TBImpuesto.ReadOnly = true;
            this.TBImpuesto.BackColor = Color.FromArgb(187, 222, 251);
            this.TBBodega.ReadOnly = true;
            this.TBBodega.BackColor = Color.FromArgb(187, 222, 251);
            this.TBUbicacion.ReadOnly = true;
            this.TBUbicacion.BackColor = Color.FromArgb(187, 222, 251);
            this.TBProveedor.ReadOnly = true;
            this.TBProveedor.BackColor = Color.FromArgb(187, 222, 251);
            this.CBUnidad.Enabled = false;
            this.CBUnidad.BackColor = Color.FromArgb(187, 222, 251);
            this.TBObservacion.ReadOnly = true;
            this.TBObservacion.BackColor = Color.FromArgb(187, 222, 251);
        }

        private void Limpiar()
        {
            //Panel - Datos Basicos
            this.TBCodigoID.Text = string.Empty;
            this.TBProducto.Text = string.Empty;
            this.TBDescripcion.Text = string.Empty;
            this.TBMarca.Text = string.Empty;
            this.TBReferencia.Text = string.Empty;
            this.CBImportado.SelectedIndex = 0;
            this.CBEmpacado.SelectedIndex = 0;
            this.CBVence.SelectedIndex = 0;
            this.CBTipo.SelectedIndex = 0;
            this.CBGrupo.SelectedIndex = 0;
            this.CBOfertable.SelectedIndex = 0;

            //Panel - Costos y Precios
            this.TBValorCompra.Text = string.Empty;
            this.TBValorVenta01.Text = string.Empty;
            this.TBValorVenta02.Text = string.Empty;
            this.TBValorVenta03.Text = string.Empty;
            this.TBValorOferta.Text = string.Empty;

            this.CBVentaPublico.SelectedIndex = 0;
            this.TBCantidadMinima.Text = string.Empty;
            this.TBCantidadMaxima.Text = string.Empty;

            // Panel Impuestos y Otros
            this.TBImpuesto.Text = string.Empty;
            this.TBBodega.Text = string.Empty;
            this.TBUbicacion.Text = string.Empty;
            this.TBProveedor.Text = string.Empty;
            this.CBUnidad.SelectedIndex = 0;
            this.TBObservacion.Text = string.Empty;
        }

        
        private void Consulta()
        {
            //Se realiza una consulta General de los datos Registrados
            //La cual se produce en la tabla Historico.Proveedor
            //Y el procedimiento Almacenado Produccion.Buscar_Proveedor
            try
            {
                this.DGResultados.DataSource = fProduccion_Productos.Buscar_Producto(this.TBBuscar.Text);
                //this.DGResultado.Columns[0].Visible = false;
                lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Consulta_CodigoID()
        {
            try
            {
                DataTable Datos = CapaNegocio.fProduccion_Productos.CodigoID_Solicitud("1");
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

            this.TBCodigoID.Text = Codigo_SQL;

        }

        //Instancias Para los Filtros de Busqueda
        public void setMarca(string idmarca, string marca)
        {
            this.TBIdmarca.Text = idmarca;
            this.TBMarca.Text = marca;
        }

        public void setImpuesto(string idimpuesto, string impuesto)
        {
            this.TBIdimpuesto.Text = idimpuesto;
            this.TBImpuesto.Text = impuesto;
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
                // Se procede habilitar los campos de textos
                this.Habilitar();

                // Se procede habilitar los Botones Basicos
                // Los Campos de Textos y Botones de Examinar

                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = true;
                this.btnEliminar.Enabled = true;

                this.btnExaminar_Marca.Enabled = true;
                this.btnExaminar_Bodega.Enabled = true;
                this.btnExaminar_Impuesto.Enabled = true;
                this.btnExaminar_Proveedor.Enabled = true;
            }

            // Se hace enfasis (Focus) Al Iniciar el Evento Click 
            // sobre el Campo Con Nombre Proveedor

            this.TBProducto.Focus();

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
                string rptaDatosBasicos = "";

                //Datos Basicos
                if (this.TBProducto.Text == string.Empty)
                {
                    MensajeError("Debe Ingresar un Producto - Panel Datos Basicos");
                    TBProducto.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBMarca.Text == string.Empty)
                {
                    MensajeError("Debe Ingresar una Marca - Panel Datos Basicos");
                    TBMarca.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBValorCompra.Text == string.Empty)
                {
                    MensajeError("Ingrese un Valor de Compra - Panel de Costos y Precios");
                    TBValorCompra.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBValorVenta01.Text == string.Empty)
                {
                    MensajeError("Ingrese un Valor de Venta - Panel de Costos y Precios");
                    TBValorVenta01.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBCantidadMinima.Text == string.Empty)
                {
                    MensajeError("Ingrese la Cantidad Minina de Venta - Panel de Costos y Precios");
                    TBCantidadMinima.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBCantidadMaxima.Text == string.Empty)
                {
                    MensajeError("Ingrese la Cantidad Maxima de Venta - Panel de Costos y Precios");
                    TBCantidadMaxima.BackColor = Color.FromArgb(250, 235, 215);
                }

                else
                {
                    if (this.IsNuevo)
                    {
                        //rptaDatosBasicos = fProduccion_Productos.Guardar_DatosBasicos(1,IDEmpleado, Convert.ToInt32(TBMarca.SelectedValue), 1,
                        //this.TBCodigoID.Text, this.TBProducto.Text, this.TBDescripcion.Text, this.TBReferencia.Text,
                        //this.CBImportado.Text, this.CBEmpacado.Text, this.CBVence.Text, this.CBTipo.Text, this.CBOfertable.Text,this.TBBodega.Text);
                    }

                    if (rptaDatosBasicos.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Producto Registrado Exitosamente");
                        }
                    }

                    else
                    {
                        this.MensajeError(rptaDatosBasicos);
                    }

                    this.IsNuevo = false;
                    this.DesHabilitar();
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


        private void btnExaminar_Marca_Click(object sender, EventArgs e)
        {
            frmExaminar_Marcas frmExaminar_Marcas = new frmExaminar_Marcas();
            frmExaminar_Marcas.ShowDialog();
        }

        private void btnExaminar_Impuesto_Click(object sender, EventArgs e)
        {
            frmExaminar_Impuestos frmExaminar_Impuestos = new frmExaminar_Impuestos();
            frmExaminar_Impuestos.ShowDialog();
        }

        private void btnExaminar_Bodega_Click(object sender, EventArgs e)
        {
            frmExaminar_Bodega frmExaminar_Bodega = new frmExaminar_Bodega();
            frmExaminar_Bodega.ShowDialog();
        }

        private void btnExaminar_Proveedor_Click(object sender, EventArgs e)
        {
            frmExaminar_Bodega frmExaminar_Bodega = new frmExaminar_Bodega();
            frmExaminar_Bodega.ShowDialog();
        }

        private void DGResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Cuando IsEditar o la Varible que se establezca en este caso IsEditar
                //Contenga el simbolo ! su valor es igual al False
                //Inicialmente esta Variable se esta Iniciando de Forma False en una variable de tipo Booleano

                if (!IsEditar)
                {
                    this.TBIdproveedor.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                    this.TBProveedor.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Producto"].Value);
                    this.TBCodigoID.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Marca"].Value);

                }

                //Se realiza el cambio del Boton Nuevo a Editar
                //Igualmente se cambio se funcion de Habilitar o registrar un nuevo proveedor
                //Para ahora realizar la funcion de Editar un registro en la Base de Datos
                //cuando se le realice el evento Clip del Boton Ediatar/Guardar

                this.Habilitar();

                //Botones Comunes
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;

                //Botones Examinar
                this.btnExaminar_Bodega.Enabled = true;
                this.btnExaminar_Impuesto.Enabled = true;
                this.btnExaminar_Marca.Enabled = true;
                this.btnExaminar_Proveedor.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CHEliminar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Consulta();
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
        
        private void btnEditar_MouseDown(object sender, MouseEventArgs e)
        {
            btnEditar.Image = Properties.Resources.BV_Editar;
        }

        private void btnEditar_MouseLeave(object sender, EventArgs e)
        {
            btnEditar.Image = Properties.Resources.BV_Editar;
        }

        private void btnEditar_MouseMove(object sender, MouseEventArgs e)
        {
            btnEditar.Image = Properties.Resources.BR_Editar;
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

        private void frmProduccion_Productos_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

    }
}
