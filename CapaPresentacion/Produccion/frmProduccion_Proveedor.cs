using CapaNegocio;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmProduccion_Proveedor : Form
    {
        // Variable con la cual se define si el procecimiento a realizar es EDITAR o Guardar
        private bool IsNuevo = false;
        private bool IsEditar = true;

        // Variable para La Consulta de Datos en la Tabla o DataGriview
        private DataTable dtDetalle;

        // Variables para Generar Codigo de Proveedor
        // Y Consultarlo desde la Base de Datos
        public string Codigo_SQL = "";
        public string Codigo_ID = "";

        //Variable para Metodo Eliminar
        public string Eliminar_SQL;

        public frmProduccion_Proveedor()
        {
            InitializeComponent();
        }

        private void frmAlmacen_Proveedor_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.CrearTabla();
            this.DesHabilitar();

            //Desabilitacion de Botones
            this.btnGuardar.Enabled = false;
            this.btnEditar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.TBIdproveedor.Visible = false;

            //Seleccion principal de Combobox
            this.CBTipodeproveedor.SelectedIndex = 0;

            //Y ocultacion de Texboxt
            this.TBFiltroID.Visible = false;
            this.TBResultado.Visible = false;
            this.TBIdproveedor.Visible = false;
        }

        private void Habilitar()
        {
            //Habilitacion de Combobox
            this.CBTipodeproveedor.Enabled = true;
            this.CBTipodeproveedor.BackColor = Color.FromArgb(32, 178, 170);

            //Habilitacion de Campos de Textos
            this.TBArea.ReadOnly = false;
            this.TBArea.BackColor = Color.FromArgb(32, 178, 170);
            this.TBRepresentante.ReadOnly = false;
            this.TBRepresentante.BackColor = Color.FromArgb(32, 178, 170);
            this.TBProveedor.ReadOnly = false;
            this.TBProveedor.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDocumento.ReadOnly = false;
            this.TBDocumento.BackColor = Color.FromArgb(32, 178, 170);
            this.TBPais.ReadOnly = false;
            this.TBPais.BackColor = Color.FromArgb(32, 178, 170);
            this.TBCiudad.ReadOnly = false;
            this.TBCiudad.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDireccion1.ReadOnly = false;
            this.TBDireccion1.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDireccion2.ReadOnly = false;
            this.TBDireccion2.BackColor = Color.FromArgb(32, 178, 170);
            this.TBTelefono.ReadOnly = false;
            this.TBTelefono.BackColor = Color.FromArgb(32, 178, 170);
            this.TBMovil.ReadOnly = false;
            this.TBMovil.BackColor = Color.FromArgb(32, 178, 170);
            this.TBCorreo.ReadOnly = false;
            this.TBCorreo.BackColor = Color.FromArgb(32, 178, 170);
            this.DTInicio.Enabled = true;
            this.DTInicio.BackColor = Color.FromArgb(32, 178, 170);

            this.PanelLogo.Enabled = true;
            this.PanelLogo.BackColor = Color.FromArgb(32, 178, 170);
            this.PanelLogo.Image = Properties.Resources.A_J_Academico;
        }

        private void DesHabilitar()
        {
            //Desabilitacion de Combobox
            this.CBTipodeproveedor.Enabled = false;
            this.CBTipodeproveedor.BackColor = Color.FromArgb(187, 222, 251);

            //Desabilitacion de Campos de Textos
            this.TBArea.ReadOnly = true;
            this.TBArea.BackColor = Color.FromArgb(187, 222, 251);
            this.TBRepresentante.ReadOnly = true;
            this.TBRepresentante.BackColor = Color.FromArgb(187, 222, 251);
            this.TBProveedor.ReadOnly = true;
            this.TBProveedor.BackColor = Color.FromArgb(187, 222, 251);
            this.TBDocumento.ReadOnly = true;
            this.TBDocumento.BackColor = Color.FromArgb(187, 222, 251);
            this.TBCodigoID.ReadOnly = true;
            this.TBCodigoID.BackColor = Color.FromArgb(187, 222, 251);
            this.TBPais.ReadOnly = true;
            this.TBPais.BackColor = Color.FromArgb(187, 222, 251);
            this.TBCiudad.ReadOnly = true;
            this.TBCiudad.BackColor = Color.FromArgb(187, 222, 251);
            this.TBDireccion1.ReadOnly = true;
            this.TBDireccion1.BackColor = Color.FromArgb(187, 222, 251);
            this.TBDireccion2.ReadOnly = true;
            this.TBDireccion2.BackColor = Color.FromArgb(187, 222, 251);
            this.TBTelefono.ReadOnly = true;
            this.TBTelefono.BackColor = Color.FromArgb(187, 222, 251);
            this.TBMovil.ReadOnly = true;
            this.TBMovil.BackColor = Color.FromArgb(187, 222, 251);
            this.TBCorreo.ReadOnly = true;
            this.TBCorreo.BackColor = Color.FromArgb(187, 222, 251);
            this.DTInicio.Enabled = false;
            this.DTInicio.BackColor = Color.FromArgb(187, 222, 251);


            this.PanelLogo.Enabled = false;
            this.PanelLogo.BackColor = Color.FromArgb(187, 222, 251);
            this.PanelLogo.Image = Properties.Resources.A_J_Academico;

            //Texboxt Buscar o Filtro

            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);

        }
              
        private void Limpiar()
        {
            //Limpieza de Coombobox
            this.CBTipodeproveedor.SelectedIndex = 0;

            //Limpieza de Campos de Textox
            this.TBArea.Text = string.Empty;
            this.TBRepresentante.Text = string.Empty;
            this.TBProveedor.Text = string.Empty;
            this.TBDocumento.Text = string.Empty;
            this.TBCodigoID.Text = string.Empty;
            this.TBPais.Text = string.Empty;
            this.TBCiudad.Text = string.Empty;
            this.TBDireccion1.Text = string.Empty;
            this.TBDireccion2.Text = string.Empty;
            this.TBTelefono.Text = string.Empty;
            this.TBMovil.Text = string.Empty;
            this.TBCorreo.Text = string.Empty;
            
            //Limpiar el Panel de Foto a la Imagen Predeterminada
            this.PanelLogo.Image = Properties.Resources.A_J_Academico;
        }

        private void CrearTabla()
        {
            //Crea la tabla con el nombre de Detalle
            this.dtDetalle = new DataTable("Detalle");
            //Agrega las columnas que tendra la tabla
            this.dtDetalle.Columns.Add("Codigo Proveedor", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Proveedor", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Documento", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Tipo", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Area", System.Type.GetType("System.String"));
            //Relacionamos nuestro datagridview con nuestro datatable
            this.DGResultado.DataSource = this.dtDetalle;

        }

        private void Consulta_CodigoID()
        {
            try
            {
                DataTable Datos = CapaNegocio.fProduccion_Proveedor.CodigoID_Solicitud("1");
                //Evaluamos si  existen los Datos
                if (Datos.Rows.Count == 0)
                {
                    Codigo_SQL = TBFiltroID.Text;
                    //TBCodigoID.Text = "1";
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
            //La cual se produce en la tabla Historico.Proveedor
            //Y el procedimiento Almacenado Produccion.Buscar_Proveedor
            try
            {          
                this.DGResultado.DataSource = fProduccion_Proveedor.Buscar_Proveedor(this.TBBuscar.Text);
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

            this.TBProveedor.Focus();

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
                if (this.CBTipodeproveedor.Text == string.Empty)
                {
                    MensajeError("Seleccione el tipo de Proveedor a Registrar");
                    CBTipodeproveedor.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBArea.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBArea.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBProveedor.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBProveedor.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBDocumento.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBDocumento.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBRepresentante.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBRepresentante.BackColor = Color.FromArgb(250, 235, 215);
                }

                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.PanelLogo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    byte[] imagen = ms.GetBuffer();

                    if (this.IsNuevo)
                    {
                        rptaDatosBasicos = fProduccion_Proveedor.Guardar_DatosBasicos(4, this.TBProveedor.Text, this.TBCodigoID.Text,
                        this.CBTipodeproveedor.Text, this.TBArea.Text, this.TBDocumento.Text, this.TBRepresentante.Text, this.TBPais.Text,
                        this.TBCiudad.Text, this.TBTelefono.Text, this.TBMovil.Text, this.TBDireccion1.Text, this.TBDireccion2.Text, this.TBCorreo.Text, this.DTInicio.Value, imagen, 1, 1);
                    }

                    if (rptaDatosBasicos.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Proveedor Registrado Exitosamente");
                        }
                    }

                    else
                    {
                        this.MensajeError(rptaDatosBasicos);
                    }

                    //this.Limpiar();
                    //this.DesHabilitar();
                    this.TBProveedor.Focus();
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
            try
            {
                double Resultado;
                TBResultado.Text = Convert.ToString(DGResultado.Rows.Count);
                Resultado = Convert.ToDouble(TBResultado.Text);

                if (Resultado == 0)
                {
                    MessageBox.Show("Actualmente no se Encuentran Registros en la Base de Datos", "Sistema General Instituto Fundecar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("Desea Eliminar el Registro Seleccionado", "Sistema General Instituto Fundecar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Opcion == DialogResult.OK)
                    {
                        string Codigo;
                        string Rpta = "";

                        foreach (DataGridViewRow row in DGResultado.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToString(row.Cells[1].Value);
                                Rpta = fProduccion_Proveedor.Eliminar(Convert.ToInt32(Codigo));

                                if (Rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Articulo Eliminado Correctamente");
                                }
                                else
                                {
                                    this.MensajeError(Rpta);
                                }

                            }
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void PanelLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.PanelLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                this.PanelLogo.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Consulta();
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
                    this.TBIdproveedor.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Codigo Proveedor"].Value);
                    this.TBProveedor.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Proveedor"].Value);
                    //this.TBCodigoID.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["CodigoID"].Value);

                }

                //Se realiza el cambio del Boton Nuevo a Editar
                //Igualmente se cambio se funcion de Habilitar o registrar un nuevo proveedor
                //Para ahora realizar la funcion de Editar un registro en la Base de Datos
                //cuando se le realice el evento Clip del Boton Ediatar/Guardar

                this.btnEditar.Enabled = true;
                this.btnEliminar.Enabled = true;

                this.Habilitar();


                btnNuevo.Enabled = true;
                btnNuevo.Image = Properties.Resources.BV_Nuevo;
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

        private void DGResultado_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == Convert.ToChar(Keys.Delete))
                {
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("Desea Eliminar el Registro Seleccionado", "Leal Academico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Opcion == DialogResult.OK)
                    {
                        string Codigo;
                        string Rpta = "";

                        foreach (DataGridViewRow row in DGResultado.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToString(row.Cells[1].Value);
                                Rpta = fProduccion_Proveedor.Eliminar(Convert.ToInt32(Codigo));

                                if (Rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Articulo Eliminado Correctamente");
                                }
                                else
                                {
                                    this.MensajeError(Rpta);
                                }

                            }
                        }
                        this.TBBuscar.Text = string.Empty;
                    }
                }

                else if (e.KeyValue == Convert.ToChar(Keys.Enter))
                {
                    this.IsEditar = true;
                    //this.IsNuevo = false;

                    if (IsEditar == true)
                    {
                        this.TBIdproveedor.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Codigo Proveedor"].Value);
                        this.TBProveedor.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Proveedor"].Value);
                        //this.TBCodigoID.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["CodigoID"].Value);

                        //Se realiza el cambio del Boton Nuevo a Editar
                        //Igualmente se cambio se funcion de Habilitar o registrar un nuevo proveedor
                        //Para ahora realizar la funcion de editar cuando se le de clip

                        btnNuevo.Visible = true;
                        btnNuevo.Image = Properties.Resources.BV_Editar;

                        btnGuardar.Visible = true;
                        btnGuardar.Image = Properties.Resources.BV_Cancelar;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CHEliminar_CheckedChanged(object sender, EventArgs e)
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
            //esta funcion hace que el boton cambie a rojo

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
