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
        public frmExaminar_Bodega()
        {
            InitializeComponent();
        }

        private void frmExaminarProduccion_Bodega_Load(object sender, EventArgs e)
        {

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

                ////Variables de frmProduccion_Marcas
                //string frmPM1, frmPM2;
                ////Variables de frmProduccion_Ingresos
                //string frmPI1, frmPI2, frmPI3;

                //Variables de frmProduccion_Productos
                string frmPP1, frmPP2;


                if (frmPP.Filtro)
                {
                    frmPP1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                    frmPP2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Bodega"].Value);
                    frmPP.setBodega(frmPP1, frmPP2);
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

                    ////Variables de frmProduccion_Marcas
                    //string frmPM1, frmPM2;
                    ////Variables de frmProduccion_Ingresos
                    //string frmPI1, frmPI2, frmPI3;

                    //Variables de frmProduccion_Productos
                    string frmPP1, frmPP2;


                    if (frmPP.Filtro)
                    {
                        frmPP1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                        frmPP2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Bodega"].Value);
                        frmPP.setBodega(frmPP1, frmPP2);
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
