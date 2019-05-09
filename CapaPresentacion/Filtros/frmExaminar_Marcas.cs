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
    public partial class frmExaminar_Marcas : Form
    {
        public frmExaminar_Marcas()
        {
            InitializeComponent();
        }

        private void frmExaminar_Marcas_Load(object sender, EventArgs e)
        {
            this.TBBuscar.Focus();

            //
            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            this.DGResultados.DataSource = fProduccion_Marcas.Buscar_Marca(this.TBBuscar.Text);
            lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);
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
                    frmPP2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Marca"].Value);
                    frmPP.setMarca(frmPP1, frmPP2);
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
                        frmPP2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Marca"].Value);
                        frmPP.setMarca(frmPP1, frmPP2);
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
