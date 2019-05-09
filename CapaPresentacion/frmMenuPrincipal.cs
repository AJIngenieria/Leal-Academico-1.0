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
    public partial class frmMenuPrincipal : Form
    {
        public string Idempleado = "";
        public string Empleado = "";
        public string Cede = "";
        public string BaseDeDatos = "";

        public string UsuarioLogueado = "";
        //Menu Principal
        public string MenuArchivo = "";
        public string MenuAcademico = "";
        public string MenuBiblioteca = "";
        public string MenuAlmacen = "";
        public string MenuDotacion = "";
        public string MenuConsultas = "";
        public string MenuPagos = "";
        public string MenuReportes = "";
        public string MenuReciclaje = "";
        public string MenuVentas = "";

        //Sub Menu Archivo

        public string SubMTrabajador = "";
        public string SubMServicios = "";
        public string SubMUsuarios = "";

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.enfermeriaToolStripMenuItem.Visible = false;


            this.toolStripLabel3.Text = Empleado;
            this.toolStripLabel7.Text = Cede;
        }

        private void GestionDeUsuarios()
        {

        }

        private void datosDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracion_DatosDeSeguridad frmConfiguracion_DatosDeSeguridad = new frmConfiguracion_DatosDeSeguridad();
            frmConfiguracion_DatosDeSeguridad.MdiParent = this;
            frmConfiguracion_DatosDeSeguridad.Show();
        }

        private void cursosAcademicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcademico_Cursos frmSistemaAcademico_Cursos = new frmAcademico_Cursos();
            frmSistemaAcademico_Cursos.MdiParent = this;
            frmSistemaAcademico_Cursos.Show();
        }

        private void añoElectivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistemaAcademico_Año frmSistemaAcademico_AñoElectivo = new frmSistemaAcademico_Año();
            frmSistemaAcademico_AñoElectivo.MdiParent = this;
            frmSistemaAcademico_AñoElectivo.Show();
        }

        private void jornadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistemaAcademico_Jornada frmSistemaAcademico_Jornada = new frmSistemaAcademico_Jornada();
            frmSistemaAcademico_Jornada.MdiParent = this;
            frmSistemaAcademico_Jornada.Show();
        }

        private void periodosAcademicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistemaAcademico_Periodos frmSistemaAcademico_Periodos = new frmSistemaAcademico_Periodos();
            frmSistemaAcademico_Periodos.MdiParent = this;
            frmSistemaAcademico_Periodos.Show();
        }

        private void aulasDeClaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistemaAcademico_Aula frmSistemaAcademico_Aula = new frmSistemaAcademico_Aula();
            frmSistemaAcademico_Aula.MdiParent = this;
            frmSistemaAcademico_Aula.Show();
        }

        private void areasAcademicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistemaAcademico_AreaAcademica frmSistemaAcademico_AreaAcademica = new frmSistemaAcademico_AreaAcademica();
            frmSistemaAcademico_AreaAcademica.MdiParent = this;
            frmSistemaAcademico_AreaAcademica.Show();
        }

        private void familiaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcademico_Familias frmAcademico_Familias = new frmAcademico_Familias();
            frmAcademico_Familias.MdiParent = this;
            frmAcademico_Familias.Show();
        }

        private void ordenDeMatriculaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void valoresAcademicosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmTesoreria_ValoresAcademicos frmFinanciera_ValoresAcademicos = new frmTesoreria_ValoresAcademicos();
            frmFinanciera_ValoresAcademicos.MdiParent = this;
            frmFinanciera_ValoresAcademicos.Show();
        }

        private void boletinesAcademicosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmGestionHumana_Empleados frmGestionHumana_Empleados = new frmGestionHumana_Empleados();
            frmGestionHumana_Empleados.MdiParent = this;
            frmGestionHumana_Empleados.Show();
        }

        private void articulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBiblioteca_Libros frmBiblioteca_Libros = new frmBiblioteca_Libros();
            frmBiblioteca_Libros.MdiParent = this;
            frmBiblioteca_Libros.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proveedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void ingresosToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmProduccion_Ingresos frmProduccion_IngresosDeBodega = frmProduccion_Ingresos.GetInstancia();
            frmProduccion_IngresosDeBodega.MdiParent = this;
            frmProduccion_IngresosDeBodega.Show();
            frmProduccion_IngresosDeBodega.IDEmpleado = Convert.ToInt32(this.Idempleado);
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion_Bodegas frmProduccion_Bodegas = new frmProduccion_Bodegas();
            frmProduccion_Bodegas.MdiParent = this;
            frmProduccion_Bodegas.Show();
            frmProduccion_Bodegas.IDEmpleado = Convert.ToInt32(this.Idempleado);
        }

        private void salidasDeBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmProduccion_SalidasBodega frmProduccion_SalidaDeProductos = new frmProduccion_SalidasBodega();
            //frmProduccion_SalidaDeProductos.MdiParent = this;
            //frmProduccion_SalidaDeProductos.Show();
        }

        private void trasladosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void impuestosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmProduccion_Impuestos frmProduccion_Impuestos = new frmProduccion_Impuestos();
            frmProduccion_Impuestos.MdiParent = this;
            frmProduccion_Impuestos.Show();
            frmProduccion_Impuestos.IDEmpleado = Convert.ToInt32(this.Idempleado);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBiblioteca_Prestamos frmBiblioteca_Prestamos = frmBiblioteca_Prestamos.GetInstancia();
            frmBiblioteca_Prestamos.MdiParent = this;
            frmBiblioteca_Prestamos.Show();
        }

        private void codigoDeRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistemaAcademico_CodigoID frmSistemaAcademico_CodigoID = new frmSistemaAcademico_CodigoID();
            frmSistemaAcademico_CodigoID.MdiParent = this;
            frmSistemaAcademico_CodigoID.Show();
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void datosDeSeguridadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmConfiguracion_DatosDeSeguridad frmConfiguracion_DatosDeSeguridad = new frmConfiguracion_DatosDeSeguridad();
            frmConfiguracion_DatosDeSeguridad.MdiParent = this;
            frmConfiguracion_DatosDeSeguridad.Show();
        }

        private void tipoDeBitacorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistemaAcademico_Bitacora frmSistemaAcademico_Bitacora = new frmSistemaAcademico_Bitacora();
            frmSistemaAcademico_Bitacora.MdiParent = this;
            frmSistemaAcademico_Bitacora.Show();
        }

        private void editoralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBiblioteca_Editorial frmBiblioteca_Editorial = new frmBiblioteca_Editorial();
            frmBiblioteca_Editorial.MdiParent = this;
            frmBiblioteca_Editorial.Show();
        }

        private void gruposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBiblioteca_Grupos frmBiblioteca_Grupos = new frmBiblioteca_Grupos();
            frmBiblioteca_Grupos.MdiParent = this;
            frmBiblioteca_Grupos.Show();
        }

        private void nivelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBiblioteca_Niveles frmBiblioteca_Niveles = new frmBiblioteca_Niveles();
            frmBiblioteca_Niveles.MdiParent = this;
            frmBiblioteca_Niveles.Show();
        }

        private void temasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBiblioteca_Temas frmBiblioteca_Temas = new frmBiblioteca_Temas();
            frmBiblioteca_Temas.MdiParent = this;
            frmBiblioteca_Temas.Show();
        }

        private void registroAcademicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcademico_Alumnos frmAcademico_Alumnos = frmAcademico_Alumnos.GetInstancia();
            frmAcademico_Alumnos.MdiParent = this;
            frmAcademico_Alumnos.Show();
        }

        private void tomaDeAsistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcademico_Asistencia frmAcademico_Asistencia = new frmAcademico_Asistencia();
            frmAcademico_Asistencia.MdiParent = this;
            frmAcademico_Asistencia.Show();

        }

        private void matriculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcademico_Matricula frmAcademico_Matricula = new frmAcademico_Matricula();
            frmAcademico_Matricula.MdiParent = this;
            frmAcademico_Matricula.Show();
        }

        private void ordenDeMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcademico_OrdenDeMatricula frmAcademico_Familias = frmAcademico_OrdenDeMatricula.GetInstancia();
            frmAcademico_Familias.MdiParent = this;
            frmAcademico_Familias.Show();
        }

        private void datosFinancierosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion_Cliente_Financiera frmProduccion_Cliente_DatosFinancieros = new frmProduccion_Cliente_Financiera();
            frmProduccion_Cliente_DatosFinancieros.MdiParent = this;
            frmProduccion_Cliente_DatosFinancieros.Show();
        }

        private void datosBasicosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmProduccion_Cliente frmProduccion_Cliente_DatosBasicos = frmProduccion_Cliente.GetInstancia();
            frmProduccion_Cliente_DatosBasicos.MdiParent = this;
            frmProduccion_Cliente_DatosBasicos.Show();
            frmProduccion_Cliente_DatosBasicos.IDEmpleado = Convert.ToInt32(this.Idempleado);
        }

        private void datosBasicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProduccion_Productos frmProduccion_Productos = frmProduccion_Productos.GetInstancia();
            frmProduccion_Productos.MdiParent = this;
            frmProduccion_Productos.Show();
            frmProduccion_Productos.IDEmpleado = Convert.ToInt32(this.Idempleado);

        }

        private void costosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion_Costos frmProduccion_Costos = frmProduccion_Costos.GetInstancia();
            frmProduccion_Costos.MdiParent = this;
            frmProduccion_Costos.Show();
            frmProduccion_Costos.IDEmpleado = Convert.ToInt32(this.Idempleado);
        }

        private void impuestosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmProduccion_Impuestos frmProduccion_Impuestos = new frmProduccion_Impuestos();
            frmProduccion_Impuestos.MdiParent = this;
            frmProduccion_Impuestos.Show();
        }

        private void codigosDeBarraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion_Codigos frmProduccion_CodigosDeBarra = new frmProduccion_Codigos();
            frmProduccion_CodigosDeBarra.MdiParent = this;
            frmProduccion_CodigosDeBarra.Show();
        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProduccion_Proveedor frmProduccion_Proveedor = new frmProduccion_Proveedor();
            frmProduccion_Proveedor.MdiParent = this;
            frmProduccion_Proveedor.Show();
        }

        private void cuentasBancariasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmProduccion_CuentasBancarias frmProduccion_CuentasBancarias = new frmProduccion_CuentasBancarias();
            frmProduccion_CuentasBancarias.MdiParent = this;
            frmProduccion_CuentasBancarias.Show();
        }

        private void sucurzalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistema_Sucursal frmSistema_Sucurzal = new frmSistema_Sucursal();
            frmSistema_Sucurzal.MdiParent = this;
            frmSistema_Sucurzal.Show();
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistema_Estados frmSistema_Estados = new frmSistema_Estados();
            frmSistema_Estados.MdiParent = this;
            frmSistema_Estados.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion_Marcas frmProduccion_Productos_Marcas = frmProduccion_Marcas.GetInstancia();
            frmProduccion_Productos_Marcas.MdiParent = this;
            frmProduccion_Productos_Marcas.Show();
        }

        private void asignaturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAcademico_Asignaturas frmAcademico_Asignaturas = new frmAcademico_Asignaturas();
            frmAcademico_Asignaturas.MdiParent = this;
            frmAcademico_Asignaturas.Show();
        }

        private void creditosFinancierosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datosFinancierosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProduccion_Financiera frmProduccion_Proveedor_Financiera = new frmProduccion_Financiera();
            frmProduccion_Proveedor_Financiera.MdiParent = this;
            frmProduccion_Proveedor_Financiera.Show();
        }
    }
}
