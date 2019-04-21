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
    public partial class frmProduccion_Costos : Form
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
        private static frmProduccion_Costos _Instancia;

        public static frmProduccion_Costos GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmProduccion_Costos();
            }
            return _Instancia;
        }
        public frmProduccion_Costos()
        {
            InitializeComponent();
        }

        private void frmProduccion_Costos_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.DesHabilitar();

            //Desabilitacion de Botones
            this.btnGuardar.Enabled = false;
            this.btnEditar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnExaminar_Impuesto.Enabled = false;
            this.btnExaminar_Producto.Enabled = false;

            //this.TBIdimpuesto.Visible = false;
            //this.TBIdproducto.Visible = false;

            //Seleccion principal de Combobox
            this.CBBalanza.SelectedIndex = 0;
            this.CBMedida.SelectedIndex = 0;
            this.CBOferta.SelectedIndex = 0;

            //
            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void Habilitar()
        {
            this.TBCodigoID.ReadOnly = false;
            this.TBCodigoID.BackColor = Color.FromArgb(32, 178, 170);
            this.TBProducto.ReadOnly = false;
            this.TBProducto.BackColor = Color.FromArgb(32, 178, 170);
            this.TBValorCompra.ReadOnly = false;
            this.TBValorCompra.BackColor = Color.FromArgb(32, 178, 170);
            this.TBValorVenta.ReadOnly = false;
            this.TBValorVenta.BackColor = Color.FromArgb(32, 178, 170);
            this.TBValorMinimo.Enabled = true;
            this.TBValorMinimo.BackColor = Color.FromArgb(32, 178, 170);
            this.TBValorMaximo.ReadOnly = false;
            this.TBValorMaximo.BackColor = Color.FromArgb(32, 178, 170);
            this.TBCantidadMinima.ReadOnly = false;
            this.TBCantidadMinima.BackColor = Color.FromArgb(32, 178, 170);
            this.TBCantidadMaxima.ReadOnly = false;
            this.TBCantidadMaxima.BackColor = Color.FromArgb(32, 178, 170);
            this.CBOferta.Enabled = true;
            this.CBOferta.BackColor = Color.FromArgb(32, 178, 170);
            this.DTInicioOferta.Enabled = true;
            this.DTInicioOferta.BackColor = Color.FromArgb(32, 178, 170);
            this.DTFinDeOferta.Enabled = true;
            this.DTFinDeOferta.BackColor = Color.FromArgb(32, 178, 170);
            this.TBImpuesto.ReadOnly = false;
            this.TBImpuesto.BackColor = Color.FromArgb(32, 178, 170);
            this.TBValorImpuesto.ReadOnly = false;
            this.TBValorImpuesto.BackColor = Color.FromArgb(32, 178, 170);
            this.CBBalanza.Enabled = true;
            this.CBBalanza.BackColor = Color.FromArgb(32, 178, 170);
            this.CBMedida.Enabled = true;
            this.CBMedida.BackColor = Color.FromArgb(32, 178, 170);
            this.TBGramo.ReadOnly = false;
            this.TBGramo.BackColor = Color.FromArgb(32, 178, 170);
            this.TBValorOferta.ReadOnly = false;
            this.TBValorOferta.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void DesHabilitar()
        {
            this.TBCodigoID.ReadOnly = true;
            this.TBCodigoID.BackColor = Color.FromArgb(187, 222, 251);
            this.TBProducto.ReadOnly = true;
            this.TBProducto.BackColor = Color.FromArgb(187, 222, 251);
            this.TBValorCompra.ReadOnly = true;
            this.TBValorCompra.BackColor = Color.FromArgb(187, 222, 251);
            this.TBValorVenta.ReadOnly = true;
            this.TBValorVenta.BackColor = Color.FromArgb(187, 222, 251);
            this.TBValorMinimo.Enabled = false;
            this.TBValorMinimo.BackColor = Color.FromArgb(187, 222, 251);
            this.TBValorMaximo.ReadOnly = true;
            this.TBValorMaximo.BackColor = Color.FromArgb(187, 222, 251);
            this.TBCantidadMinima.ReadOnly = true;
            this.TBCantidadMinima.BackColor = Color.FromArgb(187, 222, 251);
            this.TBCantidadMaxima.ReadOnly = true;
            this.TBCantidadMaxima.BackColor = Color.FromArgb(187, 222, 251);
            this.CBOferta.Enabled = false;
            this.CBOferta.BackColor = Color.FromArgb(187, 222, 251);
            this.DTInicioOferta.Enabled = false;
            this.DTInicioOferta.BackColor = Color.FromArgb(187, 222, 251);
            this.DTFinDeOferta.Enabled = false;
            this.DTFinDeOferta.BackColor = Color.FromArgb(187, 222, 251);
            this.TBImpuesto.ReadOnly = true;
            this.TBImpuesto.BackColor = Color.FromArgb(187, 222, 251);
            this.TBValorImpuesto.ReadOnly = true;
            this.TBValorImpuesto.BackColor = Color.FromArgb(187, 222, 251);
            this.CBBalanza.Enabled = false;
            this.CBBalanza.BackColor = Color.FromArgb(187, 222, 251);
            this.CBMedida.Enabled = false;
            this.CBMedida.BackColor = Color.FromArgb(187, 222, 251);
            this.TBGramo.ReadOnly = true;
            this.TBGramo.BackColor = Color.FromArgb(187, 222, 251);
            this.TBValorOferta.ReadOnly = true;
            this.TBValorOferta.BackColor = Color.FromArgb(187, 222, 251);
        }

        private void Limpiar()
        {
            this.TBCodigoID.Text = string.Empty;
            this.TBProducto.Text = string.Empty;
            this.TBValorCompra.Text = string.Empty;
            this.TBValorVenta.Text = string.Empty;
            this.TBValorMinimo.Text = string.Empty;
            this.TBValorMaximo.Text = string.Empty;
            this.TBCantidadMinima.Text = string.Empty;
            this.TBCantidadMaxima.Text = string.Empty;
            this.CBOferta.SelectedIndex = 0;
            this.DTInicioOferta.Text = string.Empty;
            this.DTFinDeOferta.Text = string.Empty;
            this.TBImpuesto.Text = string.Empty;
            this.TBValorImpuesto.Text = string.Empty;
            this.CBBalanza.SelectedIndex = 0;
            this.CBMedida.SelectedIndex = 0;
            this.TBGramo.Text = string.Empty;
            this.TBValorOferta.Text = string.Empty;
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
            this.DGResultado.DataSource = this.dtDetalle;

        }

        private void Consulta()
        {
            //Se realiza una consulta General de los datos Registrados
            //La cual se produce en la tabla Historico.Proveedor
            //Y el procedimiento Almacenado Produccion.Buscar_Proveedor
            try
            {
                this.DGResultado.DataSource = fProduccion_Costos.Buscar_Costos(this.TBBuscar.Text);
                //this.DGResultado.Columns[0].Visible = false;
                lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultado.Rows.Count);

                
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

        public void setProducto(string idproducto, string producto)
        {
            this.TBCodigoID.Text = idproducto;
            this.TBProducto.Text = producto;
        }

        public void setImpuesto(string idimpuesto, string impuesto, string valor)
        {
            this.TBIdimpuesto.Text = idimpuesto;
            this.TBImpuesto.Text = impuesto;
            this.TBValorImpuesto.Text = valor;
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

                btnExaminar_Impuesto.Enabled = true;
                btnExaminar_Producto.Enabled = true;

                this.btnGuardar.Enabled = true;
                this.btnGuardar.Image = Properties.Resources.BV_Guardar;
            }

            // Se hace enfasis (Focus) Al Iniciar el Evento Click 
            // sobre el Campo Con Nombre Proveedor

            this.TBProducto.Focus();

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
                else if (this.TBImpuesto.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos en la Pestaña 'Datos Basicos', Estos Seran Remarcados");
                    TBImpuesto.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBValorCompra.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos en la Pestaña 'Datos Basicos', Estos Seran Remarcados");
                    TBValorCompra.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBValorVenta.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos en la Pestaña 'Datos Basicos', Estos Seran Remarcados");
                    TBValorVenta.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBValorMaximo.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos en la Pestaña 'Datos Basicos', Estos Seran Remarcados");
                    TBValorMaximo.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBValorMinimo.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos en la Pestaña 'Datos Basicos', Estos Seran Remarcados");
                    TBValorMinimo.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBCantidadMaxima.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos en la Pestaña 'Datos Basicos', Estos Seran Remarcados");
                    TBCantidadMaxima.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBCantidadMinima.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos en la Pestaña 'Datos Basicos', Estos Seran Remarcados");
                    TBCantidadMinima.BackColor = Color.FromArgb(250, 235, 215);
                }
                
                else
                {
                    if (this.IsNuevo)
                    {
                        rptaDatosBasicos = fProduccion_Costos.Guardar_DatosBasicos(Convert.ToInt32(TBCodigoID.Text), Convert.ToInt32(this.TBIdimpuesto.Text), IDEmpleado, this.TBValorCompra.Text, this.TBValorVenta.Text,
                        this.TBValorMaximo.Text, this.TBValorMinimo.Text, this.TBCantidadMaxima.Text, this.TBCantidadMinima.Text,
                        this.CBOferta.Text, this.DTInicioOferta.Value, this.DTFinDeOferta.Value, this.TBValorImpuesto.Text,this.CBBalanza.Text, this.CBMedida.Text, this.TBGramo.Text, 1, 1);
                    }

                    if (rptaDatosBasicos.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Costo Registrado Exitosamente");
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

        private void btnExaminar_Producto_Click(object sender, EventArgs e)
        {
            frmExaminar_Productos frmExaminar_Productos = new frmExaminar_Productos();
            frmExaminar_Productos.ShowDialog();
        }

        private void btnExaminar_Impuesto_Click(object sender, EventArgs e)
        {
            frmExaminar_Impuestos frmExaminar_Impuestos = new frmExaminar_Impuestos();
            frmExaminar_Impuestos.ShowDialog();
        }

        private void DGResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Cuando IsEditar o la Varible que se establezca en este caso IsEditar
                //Contenga el simbolo ! su valor es igual al False
                //Inicialmente esta Variable se esta Iniciando de Forma False en una variable de tipo Booleano

                if (!IsEditar)
                {
                    this.TBIdgastos.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Codigo"].Value);
                    this.TBProducto.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Producto"].Value);
                    this.TBIdproducto.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Idproducto"].Value);

                }

                //Se realiza el cambio del Boton Nuevo a Editar
                //Igualmente se cambio se funcion de Habilitar o registrar un nuevo proveedor
                //Para ahora realizar la funcion de Editar un registro en la Base de Datos
                //cuando se le realice el evento Clip del Boton Ediatar/Guardar

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

        private void TBBuscar_TextChanged(object sender, EventArgs e)
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

        private void frmProduccion_Costos_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }
    }
}
