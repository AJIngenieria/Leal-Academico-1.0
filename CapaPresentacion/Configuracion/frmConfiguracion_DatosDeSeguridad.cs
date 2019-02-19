using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Management;
using System.Configuration;

namespace CapaPresentacion
{
    public partial class frmConfiguracion_DatosDeSeguridad : Form
    {
        public frmConfiguracion_DatosDeSeguridad()
        {
            InitializeComponent();
        }

        private void frmConfiguracion_DatosDeSeguridad_Load(object sender, EventArgs e)
        {
            this.Lector();
            TBSerialHDD.Text = Informacion_Computer.Serial_HDD();
            TBSerialProcesador.Text = Informacion_Computer.Serial_Procesador();
            TBMac.Text = Informacion_Computer.MAC_Address();
            TBServidor.Text = Informacion_Computer.Nombre_PC();
            TBCodigoDeSeguridad.Text = Informacion_Computer.SO_Informacion();
        }

        private void Lector()
        {
            try
            {
                //Abrir el archivo, recuperar filas y cerrar el archivo
                //string[] rows = File.ReadAllLines(@"C:\Windows\System32\drivers\etc\DatosServer.ini", Encoding.Default);
                string[] rows = File.ReadAllLines(@"D:\Software de Programacion\Proyectos\Leal Academico 1.0\CapaDatos\app.config", Encoding.Default);

                //Recuperar el encabezado
                textBox1.Text = rows[0];
                textBox2.Text = rows[1];
            }
            catch
            {
                MessageBox.Show("Error de Lectura");
            }

        }

        
        public static String Serial_HDD()
        {
            ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                result += Convert.ToString(strt["VolumeSerialNumber"]);
            }
            return result;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Primero se establece la direccion de la carpeta
            string Almacenamiento = Application.StartupPath + @"C:\Windows\System32\drivers\etc";
            string Documentos = @"\DatosServer.ini";
            string Direccion = Almacenamiento + Documentos;

            if (File.Exists(Direccion))
            {
                MessageBox.Show("Archivo Existente");
            }
            else
            {
                MessageBox.Show("Archivo No Existente, Se realizara la creacion de la direccion");
                //StreamWriter Datos = new StreamWriter(@"C:\Windows\System32\drivers\etc\DatosServer.ini", true);
                StreamWriter Datos = new StreamWriter(@"C:\Windows\System32\drivers\etc\DatosServer.ini", true);
                try
                {
                    Datos.WriteLine("[Base Principal] = " + TBServidor.Text);
                    Datos.WriteLine("[Server Principal] = " + TBBasePrincipal.Text);
                    Datos.WriteLine("[Codigo Server] = " + TBCodigoServer.Text);
                    Datos.WriteLine("[Codigo de Seguidad] = " + TBCodigoDeSeguridad.Text);
                    Datos.WriteLine("\n");
                }
                catch
                {
                    MessageBox.Show("Error de Lectura");
                }
                Datos.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //string Almacenamiento = @"C:\Windows\System32\drivers\etc\DatosServer.ini";
                //D:\Software de Programacion\Proyectos\Leal Academico 1.0\CapaDatos\app.config
                //string Almacenamiento = @"C:\Windows\System32\drivers\etc\DatosServer.ini";
                //string Almacenamiento = @"D:\Software de Programacion\Proyectos\Leal Academico 1.0\CapaDatos\Properties\Settings.settings";


                string Almacenamiento = @"D:\Software de Programacion\Proyectos\Leal Academico 1.0\CapaDatos\Properties\Settings.Designer.cs";
                //string Configuracion = @"D:\Software de Programacion\Proyectos\Leal Academico 1.0\CapaDatos\Properties\Settings.settings";

                string Datos = File.ReadAllText(Almacenamiento);
                //string Config = File.ReadAllText(Configuracion);
                TBDatosServer.Text = Datos;
                //TBDatosConfiguracion.Text = Config;
            }
            catch
            {
                MessageBox.Show("Error de Lectura");
            }

        }

        private void btnEditarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                //string Almacenamiento = @"C:\Programas\A&J Academico 1.0\AJ Academico 1.0\bin\Debug\AJ Academico 1.0.exe.config";
                //string Almacenamiento = @"C:\Windows\System32\drivers\etc\DatosServer.ini";
                //string Almacenamiento = @"D:\Software de Programacion\Proyectos\Leal Academico 1.0\CapaDatos\Properties\Settings.settings";

                string Almacenamiento = @"D:\Software de Programacion\Proyectos\Leal Academico 1.0\CapaDatos\Properties\Settings.Designer.cs";
                //string Configuracion = @"D:\Software de Programacion\Proyectos\Leal Academico 1.0\CapaDatos\Properties\Settings.settings";


                File.WriteAllText(Almacenamiento, TBDatosServer.Text);
                //File.WriteAllText(Configuracion, TBDatosConfiguracion.Text);

                MessageBox.Show("Datos de Actualizados Correctamente");
            }
            catch
            {
                MessageBox.Show("Error de Lectura");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Configuracion.Cadena_Conexion.ValoresDeConfiguracion(TBBasePrincipal.Text, TBSerialProcesador.Text, TBSerialHDD.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
