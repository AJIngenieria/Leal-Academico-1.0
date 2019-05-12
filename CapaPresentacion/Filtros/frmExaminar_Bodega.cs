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
    public partial class frmExaminar_Bodega : Form
    {
        // Variable para La Consulta de Datos en la Tabla o DataGriview
        private DataTable dtDetalle;
        public frmExaminar_Bodega()
        {
            InitializeComponent();
        }

        private void frmExaminarProduccion_Bodega_Load(object sender, EventArgs e)
        {
            //Inicio de Clase
            this.CrearTabla();

            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void CrearTabla()
        {
            //Crea la tabla con el nombre de Detalle
            this.dtDetalle = new DataTable("Detalle");
            //Agrega las columnas que tendra la tabla
            this.dtDetalle.Columns.Add("Codigo", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Bodega", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Sucurzal", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Ciudad", System.Type.GetType("System.String"));
            //Relacionamos nuestro datagridview con nuestro datatable
            this.DGResultados.DataSource = this.dtDetalle;

        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.DGResultados.DataSource = fProduccion_Bodega.Buscar_Bodega(this.TBBuscar.Text);
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
                frmProduccion_Productos frmPP = frmProduccion_Productos.GetInstancia();
                frmProduccion_Ingresos frmPI = frmProduccion_Ingresos.GetInstancia();


                ////Variables de frmProduccion_Marcas
                //string frmPM1, frmPM2;
                //Variables de frmProduccion_Ingresos
                string frmPI1, frmPI2;

                //Variables de frmProduccion_Productos
                string frmPP1, frmPP2;


                if (frmPP.Filtro)
                {
                    frmPP1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                    frmPP2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Bodega"].Value);
                    frmPP.setBodega(frmPP1, frmPP2);
                    this.Hide();
                }

                if (frmPI.Filtro)
                {
                    frmPI1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                    frmPI2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Bodega"].Value);
                    frmPI.setBodega(frmPI1, frmPI2);
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
                    frmProduccion_Productos frmPP = frmProduccion_Productos.GetInstancia();
                    frmProduccion_Ingresos frmPI = frmProduccion_Ingresos.GetInstancia();


                    ////Variables de frmProduccion_Marcas
                    //string frmPM1, frmPM2;
                    //Variables de frmProduccion_Ingresos
                    string frmPI1, frmPI2;

                    //Variables de frmProduccion_Productos
                    string frmPP1, frmPP2;


                    if (frmPP.Filtro)
                    {
                        frmPP1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                        frmPP2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Bodega"].Value);
                        frmPP.setBodega(frmPP1, frmPP2);
                        this.Hide();
                    }

                    if (frmPI.Filtro)
                    {
                        frmPI1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                        frmPI2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Bodega"].Value);
                        frmPI.setBodega(frmPI1, frmPI2);
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
