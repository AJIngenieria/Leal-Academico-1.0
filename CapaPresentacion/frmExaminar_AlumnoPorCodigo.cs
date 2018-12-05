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
    public partial class frmExaminar_AlumnoPorCodigo : Form
    {
        public frmExaminar_AlumnoPorCodigo()
        {
            InitializeComponent();
        }

        private void frmExaminarAcademico_CodigoID_Load(object sender, EventArgs e)
        {
            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void Buscar_AlumnosPorNombre()
        {
            try
            {
                this.DGResultados.DataSource = fAcademico_Alumno.Examinar_PorNombre(this.TBBuscar.Text);
                this.OcultarColumna();
                lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Buscar_AlumnoPorIdentificacion()
        {
            try
            {
                this.DGResultados.DataSource = fAcademico_Alumno.Examinar_PorIdentificacion(this.TBBuscar.Text);
                //this.OcultarColumna();
                lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void OcultarColumna()
        {
            this.DGResultados.Columns[0].Visible = false;
            //this.DGResultados.Columns["Idvalor"].Visible = false;
            //this.DGResultados.Columns["Auto"].Visible = false;
        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CBBuscar.SelectedIndex == 0)
                {
                    this.TBBuscar.ReadOnly = true;
                    this.TBBuscar.BackColor = Color.FromArgb(187, 222, 251);
                    this.TBBuscar.Text = string.Empty;
                }
                else if (CBBuscar.SelectedIndex == 1)
                {
                    this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
                    this.Buscar_AlumnosPorNombre();
                }
                else if (CBBuscar.SelectedIndex == 2)
                {
                    this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
                    this.Buscar_AlumnoPorIdentificacion();
                }
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
                par1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["CodigoID"].Value);
                par2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Orden"].Value);
                par3 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Alumno"].Value);
                par4 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Identificacion"].Value);
                par5 = Convert.ToString(this.DGResultados.CurrentRow.Cells["No Identificacion"].Value);
                form.setAlumno(par1, par2, par3, par4, par5);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
