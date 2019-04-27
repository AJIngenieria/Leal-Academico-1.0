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
            this.Combobox();
            this.DesHabilitar();

            this.btnGuardar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnEditar.Enabled = false;

            //Desabilitacion de Botones
            this.btnGuardar.Enabled = false;
            this.btnEditar.Enabled = false;
            this.btnEliminar.Enabled = false;

            this.TBIdproveedor.Visible = false;

            //Seleccion principal de Combobox
            this.CBImportado.SelectedIndex = 0;
            this.CBEmpacado.SelectedIndex = 0;
            this.CBVence.SelectedIndex = 0;
            this.CBTipo.SelectedIndex = 0;
            this.CBOfertable.SelectedIndex = 0;

            //
            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void Habilitar()
        {
            //Datos Basicos
            this.TBCodigoID.ReadOnly = false;
            this.TBCodigoID.BackColor = Color.FromArgb(32, 178, 170);
            this.TBProducto.ReadOnly = false;
            this.TBProducto.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDescripcion.ReadOnly = false;
            this.TBDescripcion.BackColor = Color.FromArgb(32, 178, 170);
            this.TBBuscar_Proveedor.ReadOnly = false;
            this.TBBuscar_Proveedor.BackColor = Color.FromArgb(32, 178, 170);
            this.CBMarca.Enabled = true;
            this.CBMarca.BackColor = Color.FromArgb(32, 178, 170);
            this.TBReferencia.ReadOnly = false;
            this.TBReferencia.BackColor = Color.FromArgb(32, 178, 170);
            this.CBImportado.Enabled = true;
            this.CBImportado.BackColor = Color.FromArgb(32, 178, 170);
            this.CBEmpacado.Enabled = true;
            this.CBEmpacado.BackColor = Color.FromArgb(32, 178, 170);
            this.CBVence.Enabled = true;
            this.CBVence.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDias.ReadOnly = false;
            this.TBDias.BackColor = Color.FromArgb(32, 178, 170);
            this.CBTipo.Enabled = true;
            this.CBTipo.BackColor = Color.FromArgb(32, 178, 170);
            this.CBOfertable.Enabled = true;
            this.CBOfertable.BackColor = Color.FromArgb(32, 178, 170);
            this.TBBodega.ReadOnly = false;
            this.TBBodega.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void DesHabilitar()
        {
            this.TBCodigoID.ReadOnly = true;
            this.TBCodigoID.BackColor = Color.FromArgb(187, 222, 251);
            this.TBProducto.ReadOnly = true;
            this.TBProducto.BackColor = Color.FromArgb(187, 222, 251);
            this.TBDescripcion.ReadOnly = true;
            this.TBDescripcion.BackColor = Color.FromArgb(187, 222, 251);
            this.TBBuscar_Proveedor.ReadOnly = true;
            this.TBBuscar_Proveedor.BackColor = Color.FromArgb(187, 222, 251);
            this.CBMarca.Enabled = false;
            this.CBMarca.BackColor = Color.FromArgb(187, 222, 251);
            this.TBReferencia.ReadOnly = true;
            this.TBReferencia.BackColor = Color.FromArgb(187, 222, 251);
            this.CBImportado.Enabled = false;
            this.CBImportado.BackColor = Color.FromArgb(187, 222, 251);
            this.CBEmpacado.Enabled = false;
            this.CBEmpacado.BackColor = Color.FromArgb(187, 222, 251);
            this.CBVence.Enabled = false;
            this.CBVence.BackColor = Color.FromArgb(187, 222, 251);
            this.TBDias.ReadOnly = true;
            this.TBDias.BackColor = Color.FromArgb(187, 222, 251);
            this.CBTipo.Enabled = false;
            this.CBTipo.BackColor = Color.FromArgb(187, 222, 251);
            this.CBOfertable.Enabled = false;
            this.CBOfertable.BackColor = Color.FromArgb(187, 222, 251);
            this.TBBodega.ReadOnly = true;
            this.TBBodega.BackColor = Color.FromArgb(187, 222, 251);

        }

        private void Limpiar()
        {
            this.TBCodigoID.Text = string.Empty;
            this.TBProducto.Text = string.Empty;
            this.TBDescripcion.Text = string.Empty;
            this.CBMarca.Text = string.Empty;
            this.TBReferencia.Text = string.Empty;
            this.TBBuscar_Proveedor.Text = string.Empty;
            this.CBImportado.SelectedIndex = 0;
            this.CBEmpacado.SelectedIndex = 0;
            this.CBVence.SelectedIndex = 0;
            this.TBDias.Text = string.Empty;
            this.CBTipo.SelectedIndex = 0;
            this.CBOfertable.SelectedIndex = 0;
            this.TBBodega.Text = string.Empty;
        }

        private void CrearTabla()
        {
            //Crea la tabla con el nombre de Detalle
            this.dtDetalle = new DataTable("Detalle");
            //Agrega las columnas que tendra la tabla
            this.dtDetalle.Columns.Add("Codigo Proveedor", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Proveedor", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Documento", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Referencia", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Tipo", System.Type.GetType("System.String"));
            //Relacionamos nuestro datagridview con nuestro datatable
            this.DGResultados.DataSource = this.dtDetalle;

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

                //Despues de realizar la consulta se procede
                //A darle colores o fondo a los botones Eliminar y Editar

                //btnEliminar.Image = Properties.Resources.BV_Eliminar;
                //btnNuevo.Image = Properties.Resources.BV_Editar;


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

        public void setProveedor(string idproveedor, string proveedor)
        {
            this.TBIdproveedor.Text = idproveedor;
            this.TBBuscar_Proveedor.Text = proveedor;
        }

        private void Combobox()
        {
            try
            {
                CBMarca.DataSource = fProduccion_Marcas.Mostrar();
                CBMarca.ValueMember = "Idmarcas";
                CBMarca.DisplayMember = "Marca";

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

                // Se procede habilitar el Boton Guardar
                // y los Campos de Textos

                //this.btnExaminar.Enabled = true;
                this.btnGuardar.Enabled = true;
                this.btnGuardar.Image = Properties.Resources.BV_Guardar;
            }

            // Se hace enfasis (Focus) Al Iniciar el Evento Click 
            // sobre el Campo Con Nombre Proveedor

            this.TBProducto.Focus();

            // Se realiza la consulta para Auto Generar
            // El Codigo del Proveedor desde la Base de Datos

            this.Consulta_CodigoID();
            this.AutoCompletar_ReInscripcion();

            this.Combobox();
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
                    MensajeError("Faltan Ingresar Algunos Datos en la Pestaña 'Datos Basicos', Estos Seran Remarcados");
                    TBProducto.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBBuscar_Proveedor.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos en la Pestaña 'Datos Basicos', Estos Seran Remarcados");
                    TBBuscar_Proveedor.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBDescripcion.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos en la Pestaña 'Datos Basicos', Estos Seran Remarcados");
                    TBDescripcion.BackColor = Color.FromArgb(250, 235, 215);
                }

                else
                {
                    if (this.IsNuevo)
                    {
                        //rptaDatosBasicos = fProduccion_Productos.Guardar_DatosBasicos(1,IDEmpleado, Convert.ToInt32(CBMarca.SelectedValue), 1,
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

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            frmExaminar_Proveedor frmExaminar_Proveedor = new frmExaminar_Proveedor();
            frmExaminar_Proveedor.ShowDialog();
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
                    this.TBBuscar_Proveedor.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Producto"].Value);
                    this.TBCodigoID.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Marca"].Value);

                }

                //Se realiza el cambio del Boton Nuevo a Editar
                //Igualmente se cambio se funcion de Habilitar o registrar un nuevo proveedor
                //Para ahora realizar la funcion de Editar un registro en la Base de Datos
                //cuando se le realice el evento Clip del Boton Ediatar/Guardar

                this.btnEditar.Enabled = true;
                this.btnEliminar.Enabled = true;

                this.Habilitar();

                btnGuardar.Enabled = true;
                btnGuardar.Image = Properties.Resources.BV_Guardar;

                btnEditar.Enabled = true;
                btnEditar.Image = Properties.Resources.BV_Editar;
                btnEliminar.Enabled = true;
                btnEliminar.Image = Properties.Resources.BV_Eliminar;
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

        private void DGResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmProduccion_Productos_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }
        
    }
}
