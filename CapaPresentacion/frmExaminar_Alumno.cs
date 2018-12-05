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
    public partial class frmExaminar_Alumno : Form
    {
        public frmExaminar_Alumno()
        {
            InitializeComponent();
        }

        private void ExaminarAcademico_AlumnoParaBitacora_Load(object sender, EventArgs e)
        {

        }
        
        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.DGResultados.DataSource = fAcademico_Alumno.Buscar_Alumno(this.TBBuscar.Text);
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
                frmAcademico_Bitacora form = frmAcademico_Bitacora.GetInstancia();
                string par1, par2, par3, par4, par5, par6, par7;
                par1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["idalumno"].Value);
                par2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Carnet"].Value);
                par3 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Alumno"].Value);
                par4 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Documento"].Value);
                par5 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Identificacion"].Value);
                par6 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Curso"].Value);
                par7 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Jornada"].Value);
                form.setAlumno(par1, par2, par3, par4, par5, par6, par7);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
