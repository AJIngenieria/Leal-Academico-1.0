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
    public partial class frmProduccion_Impuestos : Form
    {
        // Variable con la cual se define si el procecimiento 
        // A realizar es Editar, Guardar, Buscar,Eliminar
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public bool Filtro = true;

        //Variable para Metodo Eliminar
        public string Eliminar_SQL;

        //Variable para Captura el Empleado Logueado
        public int IDEmpleado;

        // Variable para La Consulta de Datos en la Tabla o DataGriview
        private DataTable dtDetalle;

        // Variables para Generar Codigo de Proveedor
        // Y Consultarlo desde la Base de Datos
        public string Codigo_SQL = "";
        public string Codigo_ID = "";
        public frmProduccion_Impuestos()
        {
            InitializeComponent();
        }

        private void frmProduccion_Impuestos_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.DesHabilitar();

            this.btnGuardar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnEditar.Enabled = false;

            //Ocultacion de Texbox ID
            this.TBIdimpuesto.Visible = false;

            //Seleccion principal de Combobox
            this.CBTipo.SelectedIndex = 0;
            
            //Color para Texboxt Buscar
            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);

        }

        private void DesHabilitar()
        {
            this.TBImpuesto.ReadOnly = true;
            this.TBImpuesto.BackColor = Color.FromArgb(187, 222, 251);
            this.CBTipo.Enabled = false;
            this.CBTipo.BackColor = Color.FromArgb(187, 222, 251);
            this.TBValor.ReadOnly = true;
            this.TBValor.BackColor = Color.FromArgb(187, 222, 251);
            this.CBAplicable.Enabled = false;
            this.CBAplicable.BackColor = Color.FromArgb(187, 222, 251);

        }

        private void Habilitar()
        {
            this.TBImpuesto.ReadOnly = false;
            this.TBImpuesto.BackColor = Color.FromArgb(32, 178, 170);
            this.CBTipo.Enabled = true;
            this.CBTipo.BackColor = Color.FromArgb(32, 178, 170);
            this.TBValor.ReadOnly = false;
            this.TBValor.BackColor = Color.FromArgb(32, 178, 170);
            this.CBAplicable.Enabled = true;
            this.CBAplicable.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void Limpiar()
        {
            this.TBImpuesto.Text = string.Empty;
            this.CBTipo.SelectedIndex = 0;
            this.TBValor.Text = string.Empty;
            this.CBAplicable.SelectedIndex = 0;
        }


        //Mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Leal Academico", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Leal Academico - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (!IsNuevo)
            {
                // Se procede habilitar los campos de textos del Datos Basicos
                this.Habilitar();

                // Se procede habilitar el Boton Guardar
                // y los Campos de Textos junto con el Panel de Logo

                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = true;
                this.btnEliminar.Enabled = true;

                // Se hace enfasis (Focus) Al Iniciar el Evento Click 
                // sobre el Campo Con Nombre Proveedor

                this.TBImpuesto.Focus();

                this.IsNuevo = true;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rptaDatosBasicos = "";
                this.IsNuevo = true;

                //Datos Basicos
                if (this.TBImpuesto.Text == string.Empty)
                {
                    MensajeError("Por Favor Ingrese el Nombre del Impuesto a Registrar");
                    TBImpuesto.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.CBTipo.SelectedIndex == 0)
                {
                    MensajeError("Seleccione un Tipo de Impuesto");
                    CBTipo.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBValor.Text == string.Empty)
                {
                    MensajeError("Por Favor Ingrese el Valor del Impuesto a Registrar");
                    TBValor.BackColor = Color.FromArgb(250, 235, 215);
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rptaDatosBasicos = fProduccion_Impuesto.Guardar_DatosBasicos("1", this.TBImpuesto.Text, this.CBTipo.Text, Convert.ToInt32(this.TBValor.Text), this.CBAplicable.Text);
                    }

                    if (rptaDatosBasicos.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Impuesto Registrado Exitosamente");
                        }
                    }

                    else
                    {
                        this.MensajeError(rptaDatosBasicos);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        
        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void DGResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Cuando IsEditar o la Varible que se establezca en este caso IsEditar
                //Contenga el simbolo ! su valor es igual al False
                //Inicialmente esta Variable se esta Iniciando de Forma False en una variable de tipo Booleano

                if (!IsEditar)
                {
                    this.TBIdimpuesto.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                    this.TBImpuesto.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Impuesto"].Value);
                    this.CBTipo.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Tipo"].Value);
                    this.TBValor.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Valor"].Value);
                    this.CBAplicable.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Aplicable"].Value);
                }

                //Se realiza el cambio del Boton Nuevo a Editar
                //Igualmente se cambio se funcion de Habilitar o registrar un nuevo proveedor
                //Para ahora realizar la funcion de Editar un registro en la Base de Datos
                //cuando se le realice el evento Clip del Boton Ediatar/Guardar

                this.Habilitar();

                //Botones Comunes
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

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

        private void btnEditar_MouseDown(object sender, MouseEventArgs e)
        {
            btnEditar.Image = Properties.Resources.BV_Editar;
        }

        private void btnEditar_MouseLeave(object sender, EventArgs e)
        {
            btnEditar.Image = Properties.Resources.BV_Editar;
        }

        private void btnEditar_MouseMove(object sender, MouseEventArgs e)
        {
            btnEditar.Image = Properties.Resources.BR_Editar;
        }

        private void btnEliminar_MouseDown(object sender, MouseEventArgs e)
        {
            btnEliminar.Image = Properties.Resources.BV_Eliminar;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.Image = Properties.Resources.BV_Eliminar;
        }

        private void btnEliminar_MouseMove(object sender, MouseEventArgs e)
        {
            btnEliminar.Image = Properties.Resources.BR_Eliminar;
        }

    }
}
