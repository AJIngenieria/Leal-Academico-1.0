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
    public partial class frmBiblioteca_Libros : Form
    {
        private bool IsNuevo = false;
        public frmBiblioteca_Libros()
        {
            InitializeComponent();
        }

        private void frmBiblioteca_Libros_Load(object sender, EventArgs e)
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
                this.TBTitulo.ReadOnly = true;
                this.TBTitulo.BackColor = Color.FromArgb(187, 222, 251);
                this.TBSubTitulos.ReadOnly = true;
                this.TBSubTitulos.BackColor = Color.FromArgb(187, 222, 251);
                this.CBCategoria.Enabled = false;
                this.CBCategoria.BackColor = Color.FromArgb(187, 222, 251);
                this.TBEditorial.ReadOnly = true;
                this.TBEditorial.BackColor = Color.FromArgb(187, 222, 251);
                this.TBAutor.ReadOnly = true;
                this.TBAutor.BackColor = Color.FromArgb(187, 222, 251);
                this.DTFechaDeRegistro.Enabled = false;
                this.DTFechaDeRegistro.BackColor = Color.FromArgb(187, 222, 251);
                this.TBCantidad.ReadOnly = true;
                this.TBCantidad.BackColor = Color.FromArgb(187, 222, 251);
                this.TBSerie.ReadOnly = true;
                this.TBSerie.BackColor = Color.FromArgb(187, 222, 251);
            }

            else if (IsNuevo == true)
            {
                this.TBTitulo.ReadOnly = false;
                this.TBTitulo.BackColor = Color.FromArgb(32, 178, 170);
                this.TBSubTitulos.ReadOnly = false;
                this.TBSubTitulos.BackColor = Color.FromArgb(32, 178, 170);
                this.CBCategoria.Enabled = true;
                this.CBCategoria.BackColor = Color.FromArgb(32, 178, 170);
                this.TBEditorial.ReadOnly = false;
                this.TBEditorial.BackColor = Color.FromArgb(32, 178, 170);
                this.TBAutor.ReadOnly = false;
                this.TBAutor.BackColor = Color.FromArgb(32, 178, 170);
                this.DTFechaDeRegistro.Enabled = true;
                this.DTFechaDeRegistro.BackColor = Color.FromArgb(32, 178, 170);
                this.TBCantidad.ReadOnly = false;
                this.TBCantidad.BackColor = Color.FromArgb(32, 178, 170);
                this.TBSerie.ReadOnly = false;
                this.TBSerie.BackColor = Color.FromArgb(32, 178, 170);
            }
        }

        private void Limpiar()
        {
            this.TBTitulo.Text = string.Empty;
            this.TBSubTitulos.Text = string.Empty;
            this.CBCategoria.Text = string.Empty;
            this.TBEditorial.Text = string.Empty;
            this.TBAutor.Text = string.Empty;
            this.DTFechaDeRegistro.Text = string.Empty;
            this.TBCantidad.Text = string.Empty;
            this.TBSerie.Text = string.Empty;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.Botones();
            this.Habilitar();
            this.TBTitulo.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rptaDatosBasicos = "";

                //Datos Basicos
                if (this.TBTitulo.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBTitulo.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBSubTitulos.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBSubTitulos.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.CBCategoria.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    CBCategoria.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBEditorial.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBEditorial.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBAutor.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBAutor.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBCantidad.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBCantidad.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBSerie.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBSerie.BackColor = Color.FromArgb(250, 235, 215);
                }

                else
                {
                    if (this.IsNuevo)
                    {
                        rptaDatosBasicos = fBiblioteca_Libros.Guardar_DatosBasicos("1",this.TBTitulo.Text, this.TBSubTitulos.Text, this.CBCategoria.Text, this.TBEditorial.Text, this.TBAutor.Text, this.DTFechaDeRegistro.Value, this.TBCantidad.Text, this.TBSerie.Text);
                    }

                    if (rptaDatosBasicos.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Libro Registrado Exitosamente");
                        }
                    }

                    else
                    {
                        this.MensajeError(rptaDatosBasicos);
                    }

                    this.IsNuevo = false;
                    this.Botones();
                    this.Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnNuevo_MouseDown(object sender, MouseEventArgs e)
        {
            btnNuevo.Image = Properties.Resources.BV_Nuevo;
        }

        private void btnNuevo_MouseLeave(object sender, EventArgs e)
        {
            btnNuevo.Image = Properties.Resources.BV_Nuevo;
        }

        private void btnNuevo_MouseMove(object sender, MouseEventArgs e)
        {
            btnNuevo.Image = Properties.Resources.BR_Nuevo;
        }

        private void btnGuardar_MouseDown(object sender, MouseEventArgs e)
        {
            btnGuardar.Image = Properties.Resources.BV_Guardar;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar.Image = Properties.Resources.BV_Guardar;
        }

        private void btnGuardar_MouseMove(object sender, MouseEventArgs e)
        {
            btnGuardar.Image = Properties.Resources.BR_Guardar;
        }
    }
}
