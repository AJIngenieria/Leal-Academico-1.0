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
    public partial class frmProduccion_Codigos : Form
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
        public frmProduccion_Codigos()
        {
            InitializeComponent();
        }

        private void frmProduccion_CodigosDeBarra_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.CrearTabla();
            this.DesHabilitar();

            this.btnGuardar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnEditar.Enabled = false;

            //Desabilitacion de Botones
            this.btnGuardar.Enabled = false;
            this.btnEditar.Enabled = false;
            this.btnEliminar.Enabled = false;

            this.TBIdproducto.Visible = false;

            //
            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void Habilitar()
        {
            this.TBProducto.ReadOnly = false;
            this.TBProducto.BackColor = Color.FromArgb(32, 178, 170);
            this.TBMarca.ReadOnly = false;
            this.TBMarca.BackColor = Color.FromArgb(32, 178, 170);
            this.TBReferencia.ReadOnly = false;
            this.TBReferencia.BackColor = Color.FromArgb(32, 178, 170);
            this.TBCodigoDeBarra.ReadOnly = false;
            this.TBCodigoDeBarra.BackColor = Color.FromArgb(32, 178, 170);
            
        }

        private void DesHabilitar()
        {
            this.TBProducto.ReadOnly = true;
            this.TBProducto.BackColor = Color.FromArgb(187, 222, 251);
            this.TBMarca.ReadOnly = true;
            this.TBMarca.BackColor = Color.FromArgb(187, 222, 251);
            this.TBReferencia.ReadOnly = true;
            this.TBReferencia.BackColor = Color.FromArgb(187, 222, 251);
            this.TBCodigoDeBarra.ReadOnly = true;
            this.TBCodigoDeBarra.BackColor = Color.FromArgb(187, 222, 251);
            
        }

        private void Limpiar()
        {
            this.TBProducto.Text = string.Empty;
            this.TBMarca.Text = string.Empty;
            this.TBReferencia.Text = string.Empty;
            this.TBCodigoDeBarra.Text = string.Empty;
        }

        private void CrearTabla()
        {
            //Crea la tabla con el nombre de Detalle
            this.dtDetalle = new DataTable("Detalle");
            //Agrega las columnas que tendra la tabla
            this.dtDetalle.Columns.Add("Codigo", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Producto", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Marca", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Referencia", System.Type.GetType("System.String"));
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
                this.DGResultado.DataSource = fProduccion_Productos.Buscar_Producto(this.TBBuscar.Text);
                //this.DGResultado.Columns[0].Visible = false;
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

                // Se procede habilitar el Boton Guardar
                // y los Campos de Textos

                this.btnGuardar.Enabled = true;
                this.btnGuardar.Image = Properties.Resources.BV_Guardar;
            }

            // Se hace enfasis (Focus) Al Iniciar el Evento Click 
            // sobre el Campo Con Nombre Producto

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
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBProducto.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBMarca.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBMarca.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBReferencia.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBReferencia.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBCodigoDeBarra.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBCodigoDeBarra.BackColor = Color.FromArgb(250, 235, 215);
                }

                else
                {
                    if (this.IsNuevo)
                    {
                        rptaDatosBasicos = fProduccion_CodigoDeBarra.Guardar_DatosBasicos(1, Convert.ToInt32(TBIdproducto.Text), this.TBCodigoDeBarra.Text, 
                        this.TBMarca.Text, this.TBReferencia.Text);
                    }

                    if (rptaDatosBasicos.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Codigo Registrado Exitosamente");
                        }
                    }

                    else
                    {
                        this.MensajeError(rptaDatosBasicos);
                    }

                    this.IsNuevo = false;
                    this.Limpiar();

                    this.btnEditar.Enabled = false;
                    this.btnEliminar.Enabled = false;
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
                    this.TBIdproducto.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Codigo"].Value);
                    this.TBProducto.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Producto"].Value);
                    this.TBMarca.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Marca"].Value);
                    this.TBReferencia.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Referencia"].Value);

                }

                //Se realiza el cambio del Boton Nuevo a Editar
                //Igualmente se cambio se funcion de Habilitar o registrar un nuevo proveedor
                //Para ahora realizar la funcion de Editar un registro en la Base de Datos
                //cuando se le realice el evento Clip del Boton Ediatar/Guardar

                this.IsNuevo = true;
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
    }
}
