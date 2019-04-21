using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmBiblioteca_Prestamos : Form
    {
        private bool IsNuevo = false;

        private static frmBiblioteca_Prestamos _Instancia;

        public static frmBiblioteca_Prestamos GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmBiblioteca_Prestamos();
            }
            return _Instancia;
        }
        public frmBiblioteca_Prestamos()
        {
            InitializeComponent();
        }

        private void frmBiblioteca_Prestamos_Load(object sender, EventArgs e)
        {
            this.ColoresDeBotones();

            this.Habilitar();
            this.Botones();
        }

        private void ColoresDeBotones()
        {
            btnNuevo.Image = Properties.Resources.BV_Nuevo;
            btnGuardar.Image = Properties.Resources.BV_Guardar;
        }

        private void Habilitar()
        {
            if (IsNuevo == false)
            {
                this.TBSolicitante.ReadOnly = true;
                this.TBSolicitante.BackColor = Color.FromArgb(187, 222, 251);
                this.TBIdentificacion.ReadOnly = true;
                this.TBIdentificacion.BackColor = Color.FromArgb(187, 222, 251);
                this.TBDocumento.ReadOnly = true;
                this.TBDocumento.BackColor = Color.FromArgb(187, 222, 251);
                this.DTFechadeprestamo_Alumnos.Enabled = false;
                this.DTFechadeprestamo_Alumnos.BackColor = Color.FromArgb(187, 222, 251);
                this.DTFechadedevolucion.Enabled = false;
                this.DTFechadedevolucion.BackColor = Color.FromArgb(187, 222, 251);
                this.TBArticulo.ReadOnly = true;
                this.TBArticulo.BackColor = Color.FromArgb(187, 222, 251);
            }

            else if (IsNuevo == true)
            {
                this.TBSolicitante.ReadOnly = false;
                this.TBSolicitante.BackColor = Color.FromArgb(32, 178, 170);
                this.TBIdentificacion.ReadOnly = false;
                this.TBIdentificacion.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDocumento.Enabled = true;
                this.TBDocumento.BackColor = Color.FromArgb(32, 178, 170);
                this.DTFechadeprestamo_Alumnos.Enabled = true;
                this.DTFechadeprestamo_Alumnos.BackColor = Color.FromArgb(32, 178, 170);
                this.DTFechadedevolucion.Enabled = true;
                this.DTFechadedevolucion.BackColor = Color.FromArgb(32, 178, 170);
                this.TBArticulo.ReadOnly = false;
                this.TBArticulo.BackColor = Color.FromArgb(32, 178, 170);
            }
        }

        
        private void Limpiar()
        {
            this.TBSolicitante.Text = string.Empty;
            this.TBIdentificacion.Text = string.Empty;
            this.TBDocumento.Text = string.Empty;
            this.DTFechadeprestamo_Alumnos.Text = string.Empty;
            this.DTFechadedevolucion.Text = string.Empty;
            this.TBArticulo.Text = string.Empty;
        }

        private void Botones()
        {
            if (this.IsNuevo == true)
            {
                this.btnNuevo.Visible = false;
                this.btnGuardar.Visible = true;
            }

            else
            {
                this.btnNuevo.Visible = true;
                this.btnGuardar.Visible = false;
            }
        }
        
        public void setArticulos_Alumnos(string idarticulo, string articulo)
        {
            this.IDArticulo.Text = idarticulo;
            this.TBArticulo.Text = articulo;
        }

        public void setSolicitante(string idsolicitante, string solicitante, string documento, string identficacion)
        {
            this.IDSolicitante.Text = idsolicitante;
            this.TBSolicitante.Text = solicitante;
            this.TBDocumento.Text = documento;
            this.TBIdentificacion.Text = identficacion;
        }


        //Mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "A&J Academico", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "A&J Academico - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnNuevo_Alumnos_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.Botones();
            this.Habilitar();
            this.TBSolicitante.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Solicitante_Click(object sender, EventArgs e)
        {
            frmExaminarBiblioteca_Solicitante frmExaminarBiblioteca_Alumno = new frmExaminarBiblioteca_Solicitante();
            frmExaminarBiblioteca_Alumno.ShowDialog();

        }

        private void btnExaminar_Articulo_Click(object sender, EventArgs e)
        {

        }

        private void frmBiblioteca_Prestamos_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

    }
}
