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
    public partial class frmExaminar_Proveedor : Form
    {

        // Variable para La Consulta de Datos en la Tabla o DataGriview
        private DataTable dtDetalle;

        public frmExaminar_Proveedor()
        {
            InitializeComponent();
        }

        private void frmExaminarProduccion_Proveedor_Load(object sender, EventArgs e)
        {
            this.CrearTabla();

            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void CrearTabla()
        {
            //Crea la tabla con el nombre de Detalle
            this.dtDetalle = new DataTable("Detalle");
            //Agrega las columnas que tendra la tabla
            this.dtDetalle.Columns.Add("Codigo", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Proveedor", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Documento", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Tipo", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Area", System.Type.GetType("System.String"));
            //Relacionamos nuestro datagridview con nuestro datatable
            this.DGResultados.DataSource = this.dtDetalle;

        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.DGResultados.DataSource = fProduccion_Proveedor.Buscar_Proveedor(this.TBBuscar.Text);
                //this.DGResultados.Columns[0].Visible = false;
                lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DGResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmProduccion_Marcas frmPM = frmProduccion_Marcas.GetInstancia();
                frmProduccion_Ingresos frmPI = frmProduccion_Ingresos.GetInstancia();
                frmProduccion_Productos frmPP = frmProduccion_Productos.GetInstancia();

                //Variables de frmProduccion_Marcas
                string frmPM1, frmPM2;
                //Variables de frmProduccion_Ingresos
                string frmPI1, frmPI2,frmPI3;
                //Variables de frmProduccion_Productos
                string frmPP1, frmPP2;

                if (frmPM.Filtro)
                {
                    frmPM1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                    frmPM2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Proveedor"].Value);
                    frmPM.setProveedor(frmPM1, frmPM2);
                    this.Hide();
                }
                if (frmPI.Filtro)
                {
                    frmPI1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                    frmPI2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Proveedor"].Value);
                    frmPI3 = Convert.ToString(this.DGResultados.CurrentRow.Cells[3].Value);
                    frmPI.setProveedor(frmPI1, frmPI2,frmPI3);
                    this.Hide();
                }
                if (frmPP.Filtro)
                {
                    frmPP1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                    frmPP2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Proveedor"].Value);
                    frmPP.setProveedor(frmPP1, frmPP2);
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void DGResultados_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    frmProduccion_Marcas frmPM = frmProduccion_Marcas.GetInstancia();
                    frmProduccion_Ingresos frmPI = frmProduccion_Ingresos.GetInstancia();

                    //Variables de frmProduccion_Marcas
                    string frmPM1, frmPM2;
                    //Variables de frmProduccion_Ingresos
                    string frmPI1, frmPI2, frmPI3;

                    if (frmPM.Filtro)
                    {
                        frmPM1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                        frmPM2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Proveedor"].Value);
                        frmPM.setProveedor(frmPM1, frmPM2);
                        this.Hide();
                    }
                    else if (frmPI.Filtro)
                    {
                        frmPI1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                        frmPI2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Proveedor"].Value);
                        frmPI3 = Convert.ToString(this.DGResultados.CurrentRow.Cells[3].Value);
                        frmPI.setProveedor(frmPI1, frmPI2, frmPI3);
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
