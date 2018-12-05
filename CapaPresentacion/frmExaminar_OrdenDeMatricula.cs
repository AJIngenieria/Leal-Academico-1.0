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

        private void Buscar_PorAlumno()
        {
            try
            {
                this.DGResultados.DataSource = fAcademico_OrdenDeMatricula.Buscar_PorAlumno(this.TBBuscar.Text);
                this.OcultarColumna();
                lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Buscar_PorAño()
        {
            try
            {
                this.DGResultados.DataSource = fAcademico_OrdenDeMatricula.Buscar_PorAño(this.TBBuscar.Text);
                this.OcultarColumna();
                lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Buscar_PorOrden()
        {
            try
            {
                this.DGResultados.DataSource = fAcademico_OrdenDeMatricula.Buscar_PorOrden(this.TBBuscar.Text);
                this.OcultarColumna();
                lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void OcultarColumna()
        {
            try
            {
                this.DGResultados.Columns[0].Visible = false;
                this.DGResultados.Columns["Idvalor"].Visible = false;
                this.DGResultados.Columns["Estado"].Visible = false;
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
                if (CBBuscar.SelectedIndex == 0)
                {
                    this.TBBuscar.ReadOnly = true;
                    this.TBBuscar.BackColor = Color.FromArgb(187, 222, 251);
                    this.TBBuscar.Text = string.Empty;
                }
                else if (CBBuscar.SelectedIndex == 1)
                {
                    this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
                    this.Buscar_PorAlumno();
                }
                else if (CBBuscar.SelectedIndex == 2)
                {
                    this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
                    this.Buscar_PorAño();
                }
                else if (CBBuscar.SelectedIndex == 3)
                {
                    this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
                    this.Buscar_PorOrden();
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
