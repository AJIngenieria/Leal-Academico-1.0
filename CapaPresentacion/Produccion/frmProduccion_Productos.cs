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
        private bool IsNuevo = false;
        private string IDEmpleado;

        public string Codigo = "";

        public frmProduccion_Productos()
        {
            InitializeComponent();
        }

        private void frmAlmacen_Productos_Load(object sender, EventArgs e)
        {
            this.ColoresDeBotones();
            this.Botones();
            this.Combobox();
            this.Habilitar();

            this.CBImportado.SelectedIndex = 0;
            this.CBEmpacado.SelectedIndex = 0;
            this.CBVence.SelectedIndex = 0;
            this.CBGrupo.SelectedIndex = 0;
            this.CBOfertable.SelectedIndex = 0;

            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Idempleado = IDEmpleado;

        }

        private void ColoresDeBotones()
        {
            btnNuevo.BackgroundImage = Properties.Resources.BV_Nuevo;
            btnGuardar.BackgroundImage = Properties.Resources.BV_Guardar;
        }

        private void Habilitar()
        {
            if (IsNuevo == false)
            {
                this.TBCodigoID.ReadOnly = true;
                this.TBCodigoID.BackColor = Color.FromArgb(187, 222, 251);
                this.CBEstado.Enabled = false;
                this.CBEstado.BackColor = Color.FromArgb(187, 222, 251);
                this.TBProducto.ReadOnly = true;
                this.TBProducto.BackColor = Color.FromArgb(187, 222, 251);
                this.TBDescripcion.ReadOnly = true;
                this.TBDescripcion.BackColor = Color.FromArgb(187, 222, 251);
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
                this.CBGrupo.Enabled = false;
                this.CBGrupo.BackColor = Color.FromArgb(187, 222, 251);
                this.CBOfertable.Enabled = false;
                this.CBOfertable.BackColor = Color.FromArgb(187, 222, 251);
                this.TBUbicacion.ReadOnly = true;
                this.TBUbicacion.BackColor = Color.FromArgb(187, 222, 251);
            }

            else if (IsNuevo == true)
            {
                this.TBCodigoID.ReadOnly = false;
                this.TBCodigoID.BackColor = Color.FromArgb(32, 178, 170);
                this.CBEstado.Enabled = true;
                this.CBEstado.BackColor = Color.FromArgb(32, 178, 170);
                this.TBProducto.Enabled = true;
                this.TBProducto.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDescripcion.ReadOnly = false;
                this.TBDescripcion.BackColor = Color.FromArgb(32, 178, 170);
                this.CBMarca.Enabled = true;
                this.CBMarca.BackColor = Color.FromArgb(32, 178, 170);
                this.TBReferencia.Enabled = true;
                this.TBReferencia.BackColor = Color.FromArgb(32, 178, 170);
                this.CBImportado.Enabled = true;
                this.CBImportado.BackColor = Color.FromArgb(32, 178, 170);
                this.CBEmpacado.Enabled = true;
                this.CBEmpacado.BackColor = Color.FromArgb(32, 178, 170);
                this.CBVence.Enabled = true;
                this.CBVence.BackColor = Color.FromArgb(32, 178, 170);
                this.CBGrupo.Enabled = true;
                this.CBGrupo.BackColor = Color.FromArgb(32, 178, 170);
                this.CBOfertable.Enabled = true;
                this.CBOfertable.BackColor = Color.FromArgb(32, 178, 170);
                this.TBUbicacion.ReadOnly = false;
                this.TBUbicacion.BackColor = Color.FromArgb(32, 178, 170);
            }
        }

        private void Limpiar()
        {
            this.TBCodigoID.Text = string.Empty;
            this.CBEstado.SelectedIndex = 0;
            this.TBProducto.Text = string.Empty;
            this.TBDescripcion.Text = string.Empty;
            this.CBMarca.Text = string.Empty;
            this.TBReferencia.Text = string.Empty;
            this.CBImportado.SelectedIndex = 0;
            this.CBEmpacado.SelectedIndex = 0;
            this.CBVence.SelectedIndex = 0;
            this.CBGrupo.SelectedIndex = 0;
            this.CBOfertable.SelectedIndex = 0;
            this.TBUbicacion.Text = string.Empty;
        }

        private void Consulta_CodigoID()
        {
            try
            {
                DataTable Datos = CapaNegocio.fProduccion_Productos.CodigoID_Solicitud(this.TBFiltroID.Text);
                //Evaluamos si  existen los Datos
                if (Datos.Rows.Count == 0)
                {
                    Codigo = TBFiltroID.Text;
                    //TBCodigoID.Text = "1";
                    //MessageBox.Show("No se Encontraron Registros en la Base de Datos", "Sistema Instituto Fundecar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //frmAcademico_RegistrarAlumno frm = new frmAcademico_RegistrarAlumno();
                    Codigo = Datos.Rows[0][0].ToString();
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

            this.TBCodigoID.Text = Codigo;

        }

        private void Botones()
        {
            if (this.IsNuevo == true)
            {
                this.btnNuevo.Visible = false;
                this.btnGuardar.Visible = true;
            }

            else
            {
                this.btnNuevo.Visible = true;
                this.btnGuardar.Visible = false;
            }
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
            this.Botones();
            this.Habilitar();
            this.Combobox();
            this.TBProducto.Focus();

            this.Consulta_CodigoID();
            this.AutoCompletar_ReInscripcion();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rptaDatosBasicos = "";

                //Datos Basicos
                if (this.TBCodigoID.Text == string.Empty|| this.CBEstado.Text == string.Empty ||this.TBProducto.Text == string.Empty || 
                    this.TBDescripcion.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    //TBCodigoID.BackColor = Color.FromArgb(250, 235, 215);
                    
                }
                
                else
                {
                    if (this.IsNuevo)
                    {
                        rptaDatosBasicos = fProduccion_Productos.Guardar_DatosBasicos(1,Convert.ToInt32(CBMarca),1, Convert.ToInt32(this.CBEstado.Text),
                        this.TBCodigoID.Text, this.TBProducto.Text, this.TBDescripcion.Text, this.TBReferencia.Text,
                        this.CBImportado.Text, this.CBEmpacado.Text, this.CBVence.Text, this.CBGrupo.Text, this.CBOfertable.Text,this.TBUbicacion.Text);
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
                    this.Botones();
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

        private void CHEliminar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {

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

        private void DGResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
