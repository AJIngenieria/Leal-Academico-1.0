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
    public partial class frmExaminar_Impuestos : Form
    {
        public frmExaminar_Impuestos()
        {
            InitializeComponent();
        }

        private void frmExaminarProduccion_Productos_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.TBBuscar.Focus();
        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            this.DGResultados.DataSource = fProduccion_Impuesto.Buscar_Impuesto(this.TBBuscar.Text);
            this.DGResultados.Columns[0].Visible = false;
            lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);
        }

        private void Mostrar()
        {
            this.DGResultados.DataSource = fProduccion_Impuesto.Mostrar_Impuesto();
            this.OcultarColumna();
            lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);
        }

        private void OcultarColumna()
        {
            this.DGResultados.Columns[0].Visible = false;
            //this.DGResultados.Columns["Idvalor"].Visible = false;
            //this.DGResultados.Columns["Auto"].Visible = false;
        }

        private void DGResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    frmProduccion_Productos_Costos form = frmProduccion_Productos_Costos.GetInstancia();
            //    string par1, par2, par3;
            //    par1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["idimpuesto"].Value);
            //    par2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Impuesto"].Value);
            //    par3 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Valor"].Value);
            //    form.setImpuesto(par1, par2,par3);
            //    this.Hide();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + ex.StackTrace);
            //}
        }
    }
}
