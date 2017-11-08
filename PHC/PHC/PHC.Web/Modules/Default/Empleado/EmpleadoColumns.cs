
namespace PHC.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Empleado")]
    [BasedOnRow(typeof(Entities.EmpleadoRow))]
    public class EmpleadoColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 IdEmpleado { get; set; }
        [EditLink]
        public String Apellido { get; set; }
        public String Nombre { get; set; }
        public String Legajo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public Int32 Dni { get; set; }
        public String Cuil { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Boolean EsActivo { get; set; }
        public String Telefono { get; set; }
        public String Email { get; set; }
        public String Domicilio { get; set; }
        public String Sexo { get; set; }
    }
}