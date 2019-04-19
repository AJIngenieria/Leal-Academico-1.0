using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmProduccion_Ingresos : Form
    {
        private bool IsNuevo = false;
        private DataTable dtDetalle;
        public bool Filtro = true;

        private static frmProduccion_Ingresos _Instancia;

        public static frmProduccion_Ingresos GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmProduccion_Ingresos();
            }
            return _Instancia;
        }

        public frmProduccion_Ingresos()
        {
            InitializeComponent();
        }

        private void frmAlmacen_IngresosDeBodega_Load(object sender, EventArgs e)
        {
            this.CrearTabla();
            this.AutoAjustar_Columnas();

            this.ColoresDeBotones();
            this.Botones();
            this.Habilitar();

        }

        private void ColoresDeBotones()
        {
            btnNuevo.BackgroundImage = Properties.Resources.BV_Nuevo;
            btnGuardar.BackgroundImage = Properties.Resources.BV_Guardar;
            btnEliminar.BackgroundImage = Properties.Resources.BV_Eliminar;
            btnBuscar.BackgroundImage = Properties.Resources.BV_Agregar;
        }

        private void Habilitar()
        {
            if (IsNuevo == false)
            {
                this.TBBodega.ReadOnly = true;
                this.TBBodega.BackColor = Color.FromArgb(187, 222, 251);
                this.TBReferencia_Bodega.ReadOnly = true;
                this.TBReferencia_Bodega.BackColor = Color.FromArgb(187, 222, 251);
                this.TBReferencia_Proveedor.ReadOnly = true;
                this.TBReferencia_Proveedor.BackColor = Color.FromArgb(187, 222, 251);
                this.TBProveedor.ReadOnly = true;
                this.TBProveedor.BackColor = Color.FromArgb(187, 222, 251);
                this.TBComprobante.ReadOnly = true;
                this.TBComprobante.BackColor = Color.FromArgb(187, 222, 251);
            }

            else if (IsNuevo == true)
            {
                this.TBBodega.ReadOnly = false;
                this.TBBodega.BackColor = Color.FromArgb(32, 178, 170);
                this.TBProveedor.ReadOnly = false;
                this.TBProveedor.BackColor = Color.FromArgb(32, 178, 170);
                this.TBReferencia_Bodega.ReadOnly = false;
                this.TBReferencia_Bodega.BackColor = Color.FromArgb(32, 178, 170);
                this.TBReferencia_Proveedor.ReadOnly = false;
                this.TBReferencia_Proveedor.BackColor = Color.FromArgb(32, 178, 170);
                this.TBComprobante.ReadOnly = false;
                this.TBComprobante.BackColor = Color.FromArgb(32, 178, 170);
            }
        }

        private void Limpiar()
        {
            this.TBBodega.Text = string.Empty;
            this.TBProveedor.Text = string.Empty;
            this.TBReferencia_Bodega.Text = string.Empty;
            this.TBReferencia_Proveedor.Text = string.Empty;
            this.TBComprobante.Text = string.Empty;
        }


        private void Botones()
        {
            if (this.IsNuevo == true)
            {
                this.btnNuevo.Visible = false;
                this.btnGuardar.Visible = true;
                this.btnEliminar.Visible = true;
                this.btnBuscar.Visible = true;
            }

            else
            {
                this.btnNuevo.Visible = true;
                this.btnGuardar.Visible = false;
                this.btnEliminar.Visible = false;
                this.btnBuscar.Visible = false;
            }
        }

        private void Teclas(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.N))
            {
                MessageBox.Show("Se ha pulsado la combinación de teclas Control+N");
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

        private void AutoAjustar_Columnas()
        {
            DGDetalles.Columns[0].Width = 70;
            DGDetalles.Columns[1].Width = 375;
            DGDetalles.Columns[2].Width = 70;
            DGDetalles.Columns[3].Width = 70;
            DGDetalles.Columns[4].Width = 70;
            DGDetalles.Columns[5].Width = 70;
        }

        private void CrearTabla()
        {
            //Crea la tabla con el nombre de Detalle
            this.dtDetalle = new DataTable("Detalle");
            //Agrega las columnas que tendra la tabla
            this.dtDetalle.Columns.Add("Codigo ID", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Producto", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Cantidad", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Unidad", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Costo", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Total", System.Type.GetType("System.String"));
            //Relacionamos nuestro datagridview con nuestro datatable
            this.DGDetalles.DataSource = this.dtDetalle;

            DataRow row = dtDetalle.NewRow();
            row["Codigo ID"] = "001";
            row["Producto"] = "CAJA DE UNIFORMES DE DIARIO PARA HOMBRES";
            row["Cantidad"] = "1";
            row["Unidad"] = "CAJA";
            row["Costo"] = "20000";
            row["Total"] = "20000";

            dtDetalle.Rows.Add(row);
        }

        public void setBodega(string idbodega, string bodega, string referencia)
        {
            this.TBIdbodega.Text = idbodega;
            this.TBBodega.Text = bodega;
            this.TBReferencia_Bodega.Text = referencia;
        }

        public void setProveedor(string idproveedor, string proveedor, string referencia)
        {
            this.TBIdproveedor.Text = idproveedor;
            this.TBProveedor.Text = proveedor;
            this.TBReferencia_Proveedor.Text = referencia;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.Botones();
            this.Habilitar();
            //this.Combobox();
            //this.TBProducto.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = DGDetalles.CurrentRow.Index;
                DGDetalles.Rows.RemoveAt(fila);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Bodega_Click(object sender, EventArgs e)
        {
            frmExaminar_Bodega frmExaminarProduccion_Bodega = new frmExaminar_Bodega();
            frmExaminarProduccion_Bodega.ShowDialog();
        }

        private void btnExaminar_Proveedor_Click(object sender, EventArgs e)
        {
            frmExaminar_Proveedor frmExaminarProduccion_Proveedor = new frmExaminar_Proveedor();
            frmExaminarProduccion_Proveedor.ShowDialog();
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

        private void btnBuscar_MouseDown(object sender, MouseEventArgs e)
        {
            btnBuscar.BackgroundImage = Properties.Resources.BV_Agregar;
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar.BackgroundImage = Properties.Resources.BV_Agregar;
        }

        private void btnBuscar_MouseMove(object sender, MouseEventArgs e)
        {
            btnBuscar.BackgroundImage = Properties.Resources.BR_Agregar;
        }

        private void frmProduccion_Bodegas_Ingreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

        private void btnNuevo_Auxiliar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.Botones();
            this.Habilitar();
            //this.Combobox();
            //this.TBProducto.Focus();
        }

    }
}
