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
    public partial class frmProduccion_Marcas : Form
    {
        // Variable con la cual se define si el procecimiento a realizar es EDITAR o Guardar
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public bool Filtro = true;

        // Variable para La Consulta de Datos en la Tabla o DataGriview
        private DataTable dtDetalle;

        // Variables para Generar Codigo de Proveedor
        // Y Consultarlo desde la Base de Datos
        public string Codigo_SQL = "";
        public string Codigo_ID = "";

        //Variable para Metodo Eliminar
        public string Eliminar_SQL;

        //Instancia Utilizadas para los metodos de Examinar
        private static frmProduccion_Marcas _Instancia;

        public static frmProduccion_Marcas GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmProduccion_Marcas();
            }
            return _Instancia;
        }
        public frmProduccion_Marcas()
        {
            InitializeComponent();
        }

        private void frmProduccion_Marcas_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.CrearTabla();
            this.DesHabilitar();

            //Desabilitacion de Botones
            this.btnGuardar.Enabled = false;
            this.btnEditar.Enabled = false;
            this.btnEliminar.Enabled = false;

            //Ocultacion de Texboxt
            this.TBIdproveedor.Visible = false;

            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
        }
        
        private void Habilitar()
        {
            //Campos de Textox
            this.TBMarca.ReadOnly = false;
            this.TBMarca.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDescripcion.ReadOnly = false;
            this.TBDescripcion.BackColor = Color.FromArgb(32, 178, 170);
            this.TBProveedor.Enabled = true;
            this.TBProveedor.BackColor = Color.FromArgb(32, 178, 170);

            //Botones 
            this.btnExaminar.Enabled = true;
        }

        private void DesHabilitar()
        {
            //Campos de Textox
            this.TBMarca.ReadOnly = true;
            this.TBMarca.BackColor = Color.FromArgb(187, 222, 251);
            this.TBDescripcion.ReadOnly = true;
            this.TBDescripcion.BackColor = Color.FromArgb(187, 222, 251);
            this.TBProveedor.Enabled = false;
            this.TBProveedor.BackColor = Color.FromArgb(187, 222, 251);

            //Botones 
            this.btnExaminar.Enabled = false;
        }

        private void Limpiar()
        {
            this.TBIdproveedor.Text = string.Empty;
            this.TBMarca.Text = string.Empty;
            this.TBDescripcion.Text = string.Empty;
            this.TBProveedor.Text = string.Empty;
        }

        private void CrearTabla()
        {
            //Crea la tabla con el nombre de Detalle
            this.dtDetalle = new DataTable("Detalle");
            //Agrega las columnas que tendra la tabla
            this.dtDetalle.Columns.Add("Codigo", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Marca", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Descripcion", System.Type.GetType("System.String"));
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
                this.DGResultado.DataSource = fProduccion_Marcas.Buscar_Marca(this.TBBuscar.Text);
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
                // Se procede habilitar los campos de textos del Datos Basicos
                this.Habilitar();

                // Se procede habilitar el Boton Guardar
                // y los Campos de Textos junto con el Panel de Logo

                this.btnGuardar.Enabled = true;
                this.btnGuardar.Image = Properties.Resources.BV_Guardar;
            }

            // Se hace enfasis (Focus) Al Iniciar el Evento Click 
            // sobre el Campo Con Nombre Proveedor

            this.TBMarca.Focus();

            this.IsNuevo = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rptaDatosBasicos = "";

                //Datos Basicos
                if (this.TBMarca.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos en la Pestaña 'Datos Basicos', Estos Seran Remarcados");
                    TBMarca.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBProveedor.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos en la Pestaña 'Datos Basicos', Estos Seran Remarcados");
                    TBProveedor.BackColor = Color.FromArgb(250, 235, 215);
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
                        rptaDatosBasicos = fProduccion_Marcas.Guardar_DatosBasicos(1, 1, Convert.ToInt32(this.TBIdproveedor.Text), this.TBMarca.Text, this.TBDescripcion.Text);
                    }

                    if (rptaDatosBasicos.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Marca Registrada Exitosamente");
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
            //try
            //{
            //    double Resultado;
            //    TBResultado.Text = Convert.ToString(DGResultado.Rows.Count);
            //    Resultado = Convert.ToDouble(TBResultado.Text);

            //    if (Resultado == 0)
            //    {
            //        MessageBox.Show("Actualmente no se Encuentran Registros en la Base de Datos", "Sistema General Instituto Fundecar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }

            //    else
            //    {
            //        DialogResult Opcion;
            //        Opcion = MessageBox.Show("Desea Eliminar el Registro Seleccionado", "Sistema General Instituto Fundecar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //        if (Opcion == DialogResult.OK)
            //        {
            //            string Codigo;
            //            string Rpta = "";

            //            foreach (DataGridViewRow row in DGResultado.Rows)
            //            {
            //                if (Convert.ToBoolean(row.Cells[0].Value))
            //                {
            //                    Codigo = Convert.ToString(row.Cells[1].Value);
            //                    Rpta = fProduccion_Proveedor.Eliminar(Convert.ToInt32(Codigo));

            //                    if (Rpta.Equals("OK"))
            //                    {
            //                        this.MensajeOk("Articulo Eliminado Correctamente");
            //                    }
            //                    else
            //                    {
            //                        this.MensajeError(Rpta);
            //                    }

            //                }
            //            }
            //        }
            //    }


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + ex.StackTrace);
            //}
        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Consulta();
        }


        private void btnExaminar_Click(object sender, EventArgs e)
        {
            frmExaminar_Proveedor frmExaminar_Proveedor = new frmExaminar_Proveedor();
            frmExaminar_Proveedor.ShowDialog();
        }

        private void CHEliminar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DGResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    this.TBIdproveedor.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Codigo"].Value);
                    this.TBProveedor.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Descripcion"].Value);
                    this.TBMarca.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Marca"].Value);

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

        private void frmProduccion_Marcas_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }
    }
}
