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
    public partial class frmExaminar_OrdenDeMatricula : Form
    {
        public frmExaminar_OrdenDeMatricula()
        {
            InitializeComponent();
        }

        private void frmExaminarAcademico_OrdenDeMatricula_Load(object sender, EventArgs e)
        {

        }

        private void Mostrar()
        {
            //this.DGResultados.DataSource = fTesoreria_OrdenDeMatricula.Mostrar();
            //this.OcultarColumna();
            //lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);
        }

        private void OcultarColumna()
        {
            try
            {
                this.DGResultados.Columns["Idorden"].Visible = false;
                this.DGResultados.Columns["Idvalor"].Visible = false;
                this.DGResultados.Columns["Idestado"].Visible = false;
                this.DGResultados.Columns["Idcurso"].Visible = false;
                this.DGResultados.Columns["Idjornada"].Visible = false;
                this.DGResultados.Columns["Documento"].Visible = false;
                this.DGResultados.Columns["Fecha"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            
        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.DGResultados.DataSource = fAcademico_OrdenDeMatricula.Buscar_OrdenDeMatricula(this.TBBuscar.Text);
                this.OcultarColumna();
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
                string par1, par2, par3, par4, par5;
                par1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Idorden"].Value);
                par2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Orden"].Value);
                par3 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Alumno"].Value);
                par4 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Documento"].Value);
                par5 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Identificacion"].Value);
                form.setOrdenDeMatricula(par1, par2, par3,par4,par5);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
