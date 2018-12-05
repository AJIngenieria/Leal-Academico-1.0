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
    public partial class frmExaminarBiblioteca_Solicitante : Form
    {
        public frmExaminarBiblioteca_Solicitante()
        {
            InitializeComponent();
        }

        private void CBBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmExaminarBiblioteca_Alumno_Load(object sender, EventArgs e)
        {

        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CBBuscar.SelectedIndex == 0)
                {
                    this.TBBuscar.Text = "";
                }
                else if (CBBuscar.SelectedIndex == 1)
                {
                    this.DGResultados.DataSource = fAcademico_Alumno.Examinar_PorCarnet(this.TBBuscar.Text);
                    this.DGResultados.Columns[0].Visible = false;
                    lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);
                }
                else if (CBBuscar.SelectedIndex == 2)
                {
                    this.DGResultados.DataSource = fAcademico_Alumno.Examinar_PorIdentificacion(this.TBBuscar.Text);
                    this.DGResultados.Columns[0].Visible = false;
                    lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);
                }
                else if (CBBuscar.SelectedIndex == 3)
                {
                    this.DGResultados.DataSource = fAcademico_Alumno.Examinar_PorNombre(this.TBBuscar.Text);
                    this.DGResultados.Columns[0].Visible = false;
                    lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);
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
                frmBiblioteca_Prestamos form = frmBiblioteca_Prestamos.GetInstancia();
                string par1, par2,par3,par4;
                par1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["idalumno"].Value);
                par2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Alumno"].Value);
                par3 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Documento"].Value);
                par4 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Identificacion"].Value);
                form.setSolicitante(par1, par2, par3, par4);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
