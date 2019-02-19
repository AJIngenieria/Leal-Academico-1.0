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
    public partial class frmExaminar_Familias : Form
    {
        public frmExaminar_Familias()
        {
            InitializeComponent();
        }

        private void frmExaminarAcademico_Familias_Load(object sender, EventArgs e)
        {

        }
                
        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.DGResultados.DataSource = fAcademico_Familia.Buscar(this.TBBuscar.Text);
                this.DGResultados.Columns[0].Visible = false;
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
                frmAcademico_Alumnos form = frmAcademico_Alumnos.GetInstancia();
                string par1, par2;
                par1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Idfamilia"].Value);
                par2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Familia"].Value);
                form.setFamilia(par1, par2);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
