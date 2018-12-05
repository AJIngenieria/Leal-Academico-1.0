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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.TBUsuario.Focus();

            this.textBox1.ReadOnly = true;
            this.textBox2.ReadOnly = true;
            this.textBox5.ReadOnly = true;
        }

        private void TBContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    DataTable Datos = CapaNegocio.fSistema_Usuarios.Login(this.TBUsuario.Text, this.TBContraseña.Text);
                    //Evaluamos si  existen los Datos
                    if (Datos.Rows.Count == 0)
                    {
                        MessageBox.Show("Acceso Denegado al Sistema, Usuario o Contraseña Incorrecto. Si el Problema Persiste Contacte al Area de Sistemas", "A&J Academico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        frmMenuPrincipal frm = new frmMenuPrincipal();
                        frm.Idempleado = Datos.Rows[0][0].ToString();
                        frm.Empleado = Datos.Rows[0][1].ToString();
                        frm.Cede = Datos.Rows[0][2].ToString();

                        frm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
