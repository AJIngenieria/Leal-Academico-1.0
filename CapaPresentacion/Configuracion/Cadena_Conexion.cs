using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace CapaPresentacion.Configuracion
{
    public class Cadena_Conexion
    {
        public static void ValoresDeConfiguracion(string Server, string Usuario, string Contraseña)
        {
            //Configuracion
            Configuration Obj = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //Borra la configuracion por defecto
            Obj.AppSettings.Settings.Remove(Server);
            //Guardar
            Obj.Save(ConfigurationSaveMode.Modified);
            //actualizacion
            ConfigurationManager.RefreshSection("appSettings");
            //nueva configuracion
            Obj.AppSettings.Settings.Add(Usuario, Contraseña);
            //Guardar nueva configuracion
            Obj.Save(ConfigurationSaveMode.Modified);
            //actualizacion nuevamente
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static string Extraer(string Server, string Defecto)
        {
            string Actualizar = ConfigurationManager.AppSettings[Server];
            if (Actualizar == null)
            { Actualizar = Defecto; }
            return Actualizar;
        }
    }
}
