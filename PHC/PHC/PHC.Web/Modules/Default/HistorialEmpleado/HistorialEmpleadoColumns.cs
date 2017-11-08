
namespace PHC.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.HistorialEmpleado")]
    [BasedOnRow(typeof(Entities.HistorialEmpleadoRow))]
    public class HistorialEmpleadoColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 IdHistorialEmpleado { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaEgreso { get; set; }
        public Int32 IdEmpleado { get; set; }
        public Int32 IdPuesto { get; set; }
    }
}