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

namespace Leal_Configuracion
{
    public partial class frmSETUP_Equipos : Form
    {

        private bool IsNuevo = false;
        private DataTable dtDetalle;

        public string Codigo_SQL = "";
        public string Codigo_ID = "";

        public frmSETUP_Equipos()
        {
            InitializeComponent();
        }

        private void frmSETUP_Equipos_Load(object sender, EventArgs e)
        {
            this.Habilitar();

            this.CBEstado.SelectedIndex = 0;
            this.CBTipo.SelectedIndex = 0;

            this.Botones_Consultas();
            this.CrearTabla();

            //Ocultar
            //this.btnEliminar.Visible = false;
            //this.TBFiltroID.Visible = false;
        }

        private void Habilitar()
        {
            if (IsNuevo == false)
            {
                //Texboxt

                this.TBCodigoID.ReadOnly = true;
                this.TBCodigoID.BackColor = Color.FromArgb(187, 222, 251);
                this.CBEstado.Enabled = false;
                this.CBEstado.BackColor = Color.FromArgb(187, 222, 251);
                this.TBEquipo.ReadOnly = true;
                this.TBEquipo.BackColor = Color.FromArgb(187, 222, 251);
                this.TBHdd.ReadOnly = true;
                this.TBHdd.BackColor = Color.FromArgb(187, 222, 251);
                this.CBTipo.Enabled = false;
                this.CBTipo.BackColor = Color.FromArgb(187, 222, 251);
                
                //Botones de Datos Basicos y Panel de Logo
                this.btnNuevo.Visible = true;
                this.btnGuardar.Visible = false;

                //this.PanelLogo.Enabled = false;
                //this.PanelLogo.BackColor = Color.FromArgb(187, 222, 251);
                //this.PanelLogo.BackgroundImage = Properties.Resources.A_J_Academico;

                //Texboxt Buscar o Filtro

                this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
            }

            else if (IsNuevo == true)
            {
                //Texboxt

                this.TBCodigoID.ReadOnly = false;
                this.TBCodigoID.BackColor = Color.FromArgb(32, 178, 170);
                this.CBEstado.Enabled = true;
                this.CBEstado.BackColor = Color.FromArgb(32, 178, 170);
                this.TBEquipo.ReadOnly = false;
                this.TBEquipo.BackColor = Color.FromArgb(32, 178, 170);
                this.TBHdd.ReadOnly = false;
                this.TBHdd.BackColor = Color.FromArgb(32, 178, 170);
                this.CBTipo.Enabled = true;
                this.CBTipo.BackColor = Color.FromArgb(32, 178, 170);
                

                //Botones de Datos Basicos y Panel de Logo

                this.btnNuevo.Visible = false;
                this.btnGuardar.Visible = true;

                //this.PanelLogo.Enabled = true;
                //this.PanelLogo.BackColor = Color.FromArgb(32, 178, 170);
                //this.PanelLogo.BackgroundImage = Properties.Resources.A_J_Academico;
            }
        }

        private void Limpiar()
        {
            this.TBCodigoID.Text = string.Empty;
            this.CBEstado.SelectedIndex = 0;
            this.TBEquipo.Text = string.Empty;
            this.TBHdd.Text = string.Empty;
            this.CBTipo.SelectedIndex = 0;

            //this.PanelLogo.BackgroundImage = Properties.Resources.A_J_Academico;
        }

        private void Botones_Consultas()
        {
            ////Si el texboxt esta vacio desabilitara el Boton editar
            ////Y la tabla de resultados

            //if (TBBuscar.Text == "")
            //{
            //    btnEditar.Visible = false;
            //    DGResultado.Enabled = false;
            //}
            ////Si el texboxt esta LLENO Habilitara el Boton editar
            ////Y la tabla de resultados

            //else if (TBBuscar.Text != "")
            //{
            //    btnEditar.Visible = true;
            //    DGResultado.Enabled = true;
            //    this.Consulta();
            //}
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
            //try
            //{
            //    DataTable Datos = CapaNegocio.fConfiguracion_Equipos.CodigoID_Solicitud(this.TBFiltroID.Text);
            //    //Evaluamos si  existen los Datos
            //    if (Datos.Rows.Count == 0)
            //    {
            //        Codigo_SQL = TBFiltroID.Text;
            //        //TBCodigoID.Text = "1";
            //        //MessageBox.Show("No se Encontraron Registros en la Base de Datos", "Sistema Instituto Fundecar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            //        //frmAcademico_RegistrarAlumno frm = new frmAcademico_RegistrarAlumno();
            //        Codigo_SQL = Datos.Rows[0][0].ToString();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + ex.StackTrace);
            //}
        }

        public void AutoCompletar_ReInscripcion()
        {
            ////Obtenemos el resultado de la base de datos de
            ////La columna Iddatos basicos - Tabla Prestamos.DatosBasicos
            ////Procedimiento Almacenado Sistema.CodigoID_Solicitud

            //this.TBCodigoID.Text = Codigo_SQL;

        }

        private void Consulta()
        {
            //Se realiza una consulta General de los datos Registrados
            //La cual se produce en la tabla Historico.Proveedor
            //Y el procedimiento Almacenado Produccion.Buscar_Proveedor

            //try
            //{
            //    this.DGResultado.DataSource = fProduccion_Proveedor.Buscar_Proveedor(this.TBBuscar.Text);
            //    this.DGResultado.Columns[0].Visible = false;
            //    lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultado.Rows.Count);

            //    //Despues de realizar la consulta se procede
            //    //A darle colores o fondo a los botones Eliminar y Editar
            //    btnEliminar.BackgroundImage = Properties.Resources.BV_Eliminar;
            //    btnEditar.BackgroundImage = Properties.Resources.BV_Editar;


            //}
            //catch (Exception ex)
            //{
            ////    MessageBox.Show(ex.Message + ex.StackTrace);
            //}
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
            this.IsNuevo = true;
            this.Habilitar();
            this.TBEquipo.Focus();

            //this.Consulta_CodigoID();
            //this.AutoCompletar_ReInscripcion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //string rptaDatosBasicos = "";

                ////Datos Basicos
                //if (this.TBEstado.Text == string.Empty)
                //{
                //    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                //    TBEstado.BackColor = Color.FromArgb(250, 235, 215);
                //}
                //else if (this.TBDescripcion.Text == string.Empty)
                //{
                //    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                //    TBDescripcion.BackColor = Color.FromArgb(250, 235, 215);
                //}


                //else
                //{
                //    if (this.IsNuevo)
                //    {
                //        rptaDatosBasicos = fSistema_Estados.Guardar_DatosBasicos(1, this.TBEstado.Text, this.TBDescripcion.Text);
                //    }

                //    if (rptaDatosBasicos.Equals("OK"))
                //    {
                //        if (this.IsNuevo)
                //        {
                //            this.MensajeOk("Estado Registrado Exitosamente");
                //        }
                //    }

                //    else
                //    {
                //        this.MensajeError(rptaDatosBasicos);
                //    }

                //    this.IsNuevo = false;
                //    this.Botones();
                //    this.Limpiar();
                //    this.Habilitar();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmSETUP_Equipos_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void btnNuevo_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnNuevo_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnNuevo_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnGuardar_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnGuardar_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
