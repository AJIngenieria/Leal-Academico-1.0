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
    public partial class frmProduccion_Proveedor : Form
    {
        private bool IsNuevo = false;
        private DataTable dtDetalle;

        public string Codigo_SQL = "";
        public string Codigo_ID = "";

        public frmProduccion_Proveedor()
        {
            InitializeComponent();
        }

        private void frmAlmacen_Proveedor_Load(object sender, EventArgs e)
        {
            this.Habilitar();

            this.CBEstado.SelectedIndex = 0;
            this.CBTipodeproveedor.SelectedIndex = 0;

            this.Botones_Consultas();
            this.CrearTabla();

            //Ocultar
            this.btnEliminar.Visible = false;
            this.TBFiltroID.Visible = false;
        }

        private void Habilitar()
        {
            if (IsNuevo == false)
            {
                //Texboxt

                this.CBTipodeproveedor.Enabled = false;
                this.CBTipodeproveedor.BackColor = Color.FromArgb(187, 222, 251);
                this.TBArea.ReadOnly = true;
                this.TBArea.BackColor = Color.FromArgb(187, 222, 251);
                this.TBProveedor.ReadOnly = true;
                this.TBProveedor.BackColor = Color.FromArgb(187, 222, 251);
                this.TBCodigoID.ReadOnly = true;
                this.TBCodigoID.BackColor = Color.FromArgb(187, 222, 251);
                this.TBDocumento.ReadOnly = true;
                this.TBDocumento.BackColor = Color.FromArgb(187, 222, 251);
                this.CBEstado.Enabled = false;
                this.CBEstado.BackColor = Color.FromArgb(187, 222, 251);
                this.TBRepresentante.ReadOnly = true;
                this.TBRepresentante.BackColor = Color.FromArgb(187, 222, 251);
                this.TBPais.Enabled = false;
                this.TBPais.BackColor = Color.FromArgb(187, 222, 251);
                this.TBCiudad.Enabled = false;
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

                //Botones de Datos Basicos y Panel de Logo
                this.btnNuevo.Visible = true;
                this.btnGuardar.Visible = false;

                this.PanelLogo.Enabled = false;
                this.PanelLogo.BackColor = Color.FromArgb(187, 222, 251);
                this.PanelLogo.BackgroundImage = Properties.Resources.A_J_Academico;

                //Texboxt Buscar o Filtro

                this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
            }

            else if (IsNuevo == true)
            {
                //Texboxt

                this.CBTipodeproveedor.Enabled = true;
                this.CBTipodeproveedor.BackColor = Color.FromArgb(32, 178, 170);
                this.TBArea.ReadOnly = false;
                this.TBArea.BackColor = Color.FromArgb(32, 178, 170);
                this.TBProveedor.ReadOnly = false;
                this.TBProveedor.BackColor = Color.FromArgb(32, 178, 170);
                this.TBCodigoID.ReadOnly = false;
                this.TBCodigoID.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDocumento.ReadOnly = false;
                this.TBDocumento.BackColor = Color.FromArgb(32, 178, 170);
                this.CBEstado.Enabled = true;
                this.CBEstado.BackColor = Color.FromArgb(32, 178, 170);
                this.TBRepresentante.ReadOnly = false;
                this.TBRepresentante.BackColor = Color.FromArgb(32, 178, 170);
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

                //Botones de Datos Basicos y Panel de Logo

                this.btnNuevo.Visible = false;
                this.btnGuardar.Visible = true;

                this.PanelLogo.Enabled = true;
                this.PanelLogo.BackColor = Color.FromArgb(32, 178, 170);
                this.PanelLogo.BackgroundImage = Properties.Resources.A_J_Academico;
            }
        }

        private void Limpiar()
        {
            this.CBTipodeproveedor.SelectedIndex = 0;
            this.TBArea.Text = string.Empty;
            this.TBProveedor.Text = string.Empty;
            this.TBCodigoID.Text = string.Empty;
            this.TBDocumento.Text = string.Empty;
            this.CBEstado.SelectedIndex = 0;
            this.TBRepresentante.Text = string.Empty;
            this.TBPais.Text = string.Empty;
            this.TBCiudad.Text = string.Empty;
            this.TBDireccion1.Text = string.Empty;
            this.TBDireccion2.Text = string.Empty;
            this.TBTelefono.Text = string.Empty;
            this.TBMovil.Text = string.Empty;
            this.TBCorreo.Text = string.Empty;
            this.PanelLogo.BackgroundImage = Properties.Resources.A_J_Academico;
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
            this.dtDetalle.Columns.Add("Idproveedor", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("CodigoID", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Documento", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Proveedor", System.Type.GetType("System.String"));
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
            MessageBox.Show(mensaje, "A&J Academico", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "A&J Academico - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.Habilitar();
            this.TBProveedor.Focus();

            this.Consulta_CodigoID();
            this.AutoCompletar_ReInscripcion();

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
                else if (this.TBCodigoID.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBCodigoID.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBDocumento.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBDocumento.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.CBEstado.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    CBEstado.BackColor = Color.FromArgb(250, 235, 215);
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
                        rptaDatosBasicos = fProduccion_Proveedor.Guardar_DatosBasicos(4, this.TBCodigoID.Text, this.TBProveedor.Text,
                        this.CBTipodeproveedor.Text, this.TBArea.Text, this.TBDocumento.Text, this.CBEstado.Text, this.TBRepresentante.Text, this.TBPais.Text,
                        this.TBCiudad.Text, this.TBTelefono.Text, this.TBMovil.Text, this.TBDireccion1.Text, this.TBDireccion2.Text, this.TBCorreo.Text, this.DTInicio.Value, imagen, 1);
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

                    this.IsNuevo = false;
                    this.Limpiar();
                    this.Habilitar();
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

        private void CBEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (CBEstado.SelectedIndex == 0)
            //{
            //    this.TBEstado.Text = "";
            //}
            //else if (CBEstado.SelectedIndex == 1)
            //{
            //    this.TBEstado.Text = "1";
            //}
            //else if (CBEstado.SelectedIndex == 2)
            //{
            //    this.TBEstado.Text = "0";
            //}
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

        private void btnEditar_MouseDown(object sender, MouseEventArgs e)
        {
            btnEditar.BackgroundImage = Properties.Resources.BV_Editar;
        }

        private void btnEditar_MouseLeave(object sender, EventArgs e)
        {
            btnEditar.BackgroundImage = Properties.Resources.BV_Editar;
        }

        private void btnEditar_MouseMove(object sender, MouseEventArgs e)
        {
            btnEditar.BackgroundImage = Properties.Resources.BR_Editar;
        }

        private void btnEliminar_MouseDown(object sender, MouseEventArgs e)
        {
            btnEliminar.BackgroundImage = Properties.Resources.BV_Eliminar;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImage = Properties.Resources.BV_Eliminar;
        }

        private void btnEliminar_MouseMove(object sender, MouseEventArgs e)
        {
            btnEliminar.BackgroundImage = Properties.Resources.BR_Eliminar;
        }

        
    }
}
