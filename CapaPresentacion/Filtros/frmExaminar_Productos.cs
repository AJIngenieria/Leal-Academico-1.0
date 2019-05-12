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
    public partial class frmExaminar_Productos : Form
    {
        // Variable para La Consulta de Datos en la Tabla o DataGriview
        private DataTable dtDetalle;
        public frmExaminar_Productos()
        {
            InitializeComponent();
        }

        private void frmExaminarProduccion_Productos_Load(object sender, EventArgs e)
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
            this.dtDetalle.Columns.Add("Producto", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Marca", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Referencia", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Unidad", System.Type.GetType("System.String"));
            //Relacionamos nuestro datagridview con nuestro datatable
            this.DGResultados.DataSource = this.dtDetalle;

        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.DGResultados.DataSource = fProduccion_Productos.Buscar_Producto(this.TBBuscar.Text);
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
                frmProduccion_Costos frmPC = frmProduccion_Costos.GetInstancia();
                frmProduccion_Ingresos frmPI = frmProduccion_Ingresos.GetInstancia();

                ////Variables de frmProduccion_Marcas
                //string frmPM1, frmPM2;
                ////Variables de frmProduccion_Ingresos
                //string frmPI1, frmPI2, frmPI3;
                //Variables de frmProduccion_Productos
                string frmPC1, frmPC2;


                if (frmPC.Filtro)
                {
                    frmPC1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                    frmPC2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Producto"].Value);
                    frmPC.setProducto(frmPC1, frmPC2);
                    this.Hide();
                }

                if (frmPI.Filtro)
                {
                    //BOTON PASAR DATOS DE UNA DATAGRID A OTRA 
                    foreach (DataGridViewRow row in DGResultados.SelectedRows)
                    {

                        //CAPTURAMOS VALOR DE LA FILA SELECCIONADA DG FORM2
                        string A = this.DGResultados.CurrentRow.Cells["Codigo"].Value.ToString();
                        string B = this.DGResultados.CurrentRow.Cells["Producto"].Value.ToString();
                        string C = this.DGResultados.CurrentRow.Cells["Unidad"].Value.ToString();

                        //PASAMOS VAMOSRES DE FORM2  A FORM1 
                        frmProduccion_Ingresos dato = new frmProduccion_Ingresos();
                        foreach (Form frm in Application.OpenForms)
                        {
                            if (frm.Name == "frmProduccion_Ingresos")
                            {
                                dato = (frmProduccion_Ingresos)frm;
                                dato.DGDetalles.Rows.Add(A, B, C);

                                this.Close();
                                break;
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

        private void DGResultados_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                frmProduccion_Costos frmPC = frmProduccion_Costos.GetInstancia();
                frmProduccion_Ingresos frmPI = frmProduccion_Ingresos.GetInstancia();

                ////Variables de frmProduccion_Marcas
                //string frmPM1, frmPM2;
                ////Variables de frmProduccion_Ingresos
                //string frmPI1, frmPI2, frmPI3;
                //Variables de frmProduccion_Productos
                string frmPC1, frmPC2;


                if (frmPC.Filtro)
                {
                    frmPC1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                    frmPC2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Producto"].Value);
                    frmPC.setProducto(frmPC1, frmPC2);
                    this.Hide();
                }

                if (frmPI.Filtro)
                {
                    //BOTON PASAR DATOS DE UNA DATAGRID A OTRA 
                    foreach (DataGridViewRow row in DGResultados.SelectedRows)
                    {

                        //CAPTURAMOS VALOR DE LA FILA SELECCIONADA DG FORM2
                        string A = this.DGResultados.CurrentRow.Cells["Codigo"].Value.ToString();
                        string B = this.DGResultados.CurrentRow.Cells["Producto"].Value.ToString();
                        string C = this.DGResultados.CurrentRow.Cells["Unidad"].Value.ToString();

                        //PASAMOS VAMOSRES DE FORM2  A FORM1 
                        frmProduccion_Ingresos dato = new frmProduccion_Ingresos();
                        foreach (Form frm in Application.OpenForms)
                        {
                            if (frm.Name == "frmProduccion_Ingresos")
                            {
                                dato = (frmProduccion_Ingresos)frm;
                                dato.DGDetalles.Rows.Add(A, B, C);
                                dato.DGDetalles.Focus();
                                this.Close();
                                break;
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
    }
}
