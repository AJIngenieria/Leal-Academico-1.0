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
        private bool IsEditar = false;

        // Variable para La Consulta de Datos en la Tabla o DataGriview
        private DataTable dtDetalle;

        // Variables para Generar Codigo de Proveedor
        // Y Consultarlo desde la Base de Datos
        public string Codigo_SQL = "";
        public string Codigo_ID = "";

        //Variable para Metodo Eliminar
        public string Eliminar_SQL;
        public frmProduccion_Bodegas()
        {
            InitializeComponent();
        }

        private void frmAlmacen_Bodegas_Load(object sender, EventArgs e)
        {
            //Inicio de Variables Basicas
            this.DesHabilitar();

            //Desabilitacion de Botones y Texboxt ID
            this.btnGuardar.Enabled = false;
            this.btnEditar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.TBIdbodega.Visible = false;

            //Seleccion de Combobox
            //Color De Texboxt Para Buscar
            //Creacion de Tablas
            this.CBZonas.SelectedIndex = 0;
            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
            this.CrearTabla();
        }

        private void Habilitar()
        {
            //this.TBCodigoID.ReadOnly = false;
            //this.TBCodigoID.BackColor = Color.FromArgb(32, 178, 170);
            this.TBNombre.ReadOnly = false;
            this.TBNombre.BackColor = Color.FromArgb(32, 178, 170);
            this.TBResponsable.ReadOnly = false;
            this.TBResponsable.BackColor = Color.FromArgb(32, 178, 170);
            this.TBCiudad.Enabled = true;
            this.TBCiudad.BackColor = Color.FromArgb(32, 178, 170);
            this.CBZonas.Enabled = true;
            this.CBZonas.BackColor = Color.FromArgb(32, 178, 170);
            this.CBSucurzal.Enabled = true;
            this.CBSucurzal.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDireccion1.ReadOnly = false;
            this.TBDireccion1.BackColor = Color.FromArgb(32, 178, 170);
            this.TBTelefono.ReadOnly = false;
            this.TBTelefono.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void DesHabilitar()
        {
            this.TBCodigoID.ReadOnly = true;
            this.TBCodigoID.BackColor = Color.FromArgb(187, 222, 251);
            this.TBNombre.ReadOnly = true;
            this.TBNombre.BackColor = Color.FromArgb(187, 222, 251);
            this.TBResponsable.ReadOnly = true;
            this.TBResponsable.BackColor = Color.FromArgb(187, 222, 251);
            this.TBCiudad.Enabled = false;
            this.TBCiudad.BackColor = Color.FromArgb(187, 222, 251);
            this.CBZonas.Enabled = false;
            this.CBZonas.BackColor = Color.FromArgb(187, 222, 251);
            this.CBSucurzal.Enabled = false;
            this.CBSucurzal.BackColor = Color.FromArgb(187, 222, 251);
            this.TBDireccion1.ReadOnly = true;
            this.TBDireccion1.BackColor = Color.FromArgb(187, 222, 251);
            this.TBTelefono.ReadOnly = true;
            this.TBTelefono.BackColor = Color.FromArgb(187, 222, 251);

        }

        private void Limpiar()
        {
            this.TBCodigoID.Text = string.Empty;
            this.TBNombre.Text = string.Empty;
            this.TBResponsable.Text = string.Empty;
            this.TBCiudad.Text = string.Empty;
            this.CBZonas.SelectedIndex = 0;
            this.CBSucurzal.SelectedIndex = 0;
            this.TBDireccion1.Text = string.Empty;
            this.TBTelefono.Text = string.Empty;
        }

        private void CrearTabla()
        {
            //Crea la tabla con el nombre de Detalle
            this.dtDetalle = new DataTable("Detalle");
            //Agrega las columnas que tendra la tabla
            this.dtDetalle.Columns.Add("Codigo Bodega", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Descripcion", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Sucurzal", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Ciudad", System.Type.GetType("System.String"));
            //Relacionamos nuestro datagridview con nuestro datatable
            this.DGResultado.DataSource = this.dtDetalle;

        }

        private void Consulta_CodigoID()
        {
            try
            {
                DataTable Datos = CapaNegocio.fProduccion_Bodega.CodigoID_Solicitud("1");
                //Evaluamos si  existen los Datos
                if (Datos.Rows.Count == 0)
                {
                    Codigo_SQL = "1";
                    //MessageBox.Show("No se Encontraron Registros en la Base de Datos", "Sistema Instituto Fundecar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
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
            //La cual se produce en la tabla Historico.Bodega
            //Y el procedimiento Almacenado Produccion.Buscar_Bodega
            try
            {
                this.DGResultado.DataSource = fProduccion_Bodega.Buscar_Bodega(this.TBBuscar.Text);
                //this.DGResultado.Columns[0].Visible = false;
                lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultado.Rows.Count);

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
            if (!IsNuevo)
            {
                // Se procede habilitar los campos de textos del Datos Basicos
                this.Habilitar();

                // Se procede habilitar el Boton Guardar
                // y los Campos de Textos junto con el Panel de Logo

                this.btnGuardar.Enabled = true;
                this.btnGuardar.Image = Properties.Resources.BV_Guardar;
            }

            // Se hace enfasis (Focus) Al Iniciar el Evento Click 
            // sobre el Campo Nombre
            
            this.TBNombre.Focus();
            this.Combobox();

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
                if (this.TBCodigoID.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBCodigoID.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBNombre.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBNombre.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBCiudad.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBCiudad.BackColor = Color.FromArgb(250, 235, 215);
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
                        rptaDatosBasicos = fProduccion_Bodega.Guardar_DatosBasicos(4, Convert.ToInt32(CBSucurzal.SelectedValue), this.TBCodigoID.Text, this.TBNombre.Text,
                        this.TBResponsable.Text, this.TBCiudad.Text, this.CBZonas.Text, this.TBDireccion1.Text, this.TBTelefono.Text,
                        1,"1");
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
                    this.Limpiar();
                    this.DesHabilitar();
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

        private void DGResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Cuando IsEditar o la Varible que se establezca en este caso IsEditar
                //Contenga el simbolo ! su valor es igual al False
                //Inicialmente esta Variable se esta Iniciando de Forma False en una variable de tipo Booleano

                if (!IsEditar)
                {
                    this.TBIdbodega.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Codigo"].Value);
                    this.TBNombre.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Bodega"].Value);
                    this.CBSucurzal.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Sucurzal"].Value);
                    this.TBCiudad.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Ciudad"].Value);

                }

                //Se realiza el cambio del Boton Nuevo a Editar
                //Igualmente se cambio se funcion de Habilitar o registrar un nuevo proveedor
                //Para ahora realizar la funcion de Editar un registro en la Base de Datos
                //cuando se le realice el evento Clip del Boton Ediatar/Guardar

                this.btnEditar.Enabled = true;
                this.btnEliminar.Enabled = true;

                this.Habilitar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
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

        private void DGResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
