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
    public partial class frmAcademico_Asistencia : Form
    {
        public frmAcademico_Asistencia()
        {
            InitializeComponent();
        }

        private void frmAcademico_Asistencia_Load(object sender, EventArgs e)
        {
            this.Combobox();
        }

        private void Combobox()
        {
            try
            {
                CBCurso.DataSource = fAcademico_Cursos.Mostrar();
                CBCurso.ValueMember = "Idcurso";
                CBCurso.DisplayMember = "Curso";

                //CBPeriodo.DataSource = fSistema_Academico_Periodos.Mostrar();
                //CBPeriodo.ValueMember = "Idperiodo";
                //CBPeriodo.DisplayMember = "Periodo";

                CBJornada.DataSource = fSistema_Academico_Jornadas.Mostrar();
                CBJornada.ValueMember = "Idjornada";
                CBJornada.DisplayMember = "Jornada";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Mostrar_TomaDeAsistencia()
        {
            try
            {
                this.DGResultados.DataSource = fAcademico_Asistencia.Mostrar_TomaDeAsistencia(this.CBCurso.Text, this.CBJornada.Text);
                lblTotal.Text = "Alumnos Activados: " + Convert.ToString(DGResultados.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Mostrar_TomaDeAsistencia();
        }
    }
}
