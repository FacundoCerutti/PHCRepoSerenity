
namespace PHC.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Usuario")]
    [BasedOnRow(typeof(Entities.UsuarioRow))]
    public class UsuarioForm
    {
        public String NombreUsuario { get; set; }
        public String Contraseña { get; set; }
        public Boolean EsAdministrador { get; set; }
        public Boolean Habilitado { get; set; }
        public Boolean ContraseñaRestaurada { get; set; }
        public Int32 IdEmpleado { get; set; }
    }
}