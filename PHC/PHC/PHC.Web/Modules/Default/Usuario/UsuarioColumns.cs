
namespace PHC.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Usuario")]
    [BasedOnRow(typeof(Entities.UsuarioRow))]
    public class UsuarioColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 IdUsuario { get; set; }
        [EditLink]
        public String NombreUsuario { get; set; }
        public String Contraseña { get; set; }
        public Boolean EsAdministrador { get; set; }
        public Boolean Habilitado { get; set; }
        public Boolean ContraseñaRestaurada { get; set; }
        public Int32 IdEmpleado { get; set; }
    }
}