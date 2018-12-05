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
    public partial class frmExaminarTesoreria_ValoresAcademicos : Form
    {
        public frmExaminarTesoreria_ValoresAcademicos()
        {
            InitializeComponent();
        }

        private void frmExaminrTesoreria_ValoresAcademicos_Load(object sender, EventArgs e)
        {
            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void Ajustar_Columnas()
        {
            DGResultados.Columns[1].Width = 350;
            DGResultados.Columns[2].Width = 100;
            DGResultados.Columns[3].Width = 100;
        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // se realiza la busqueda desde el texboxt
                this.DGResultados.DataSource = fTesoreria_ValoresAcademicos.Buscar_ValoresAcademico(this.TBBuscar.Text);
                // se oculta la primera columna la cual pertenece al id
                this.DGResultados.Columns[0].Visible = false;
                this.Ajustar_Columnas();
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
                frmAcademico_OrdenDeMatricula form = frmAcademico_OrdenDeMatricula.GetInstancia();
                string par1, par2, par3;
                par1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Idvalores"].Value);
                par2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Valor"].Value);
                par3 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Año"].Value);
                form.setValorAcademico(par1, par2, par3);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

    }
}
