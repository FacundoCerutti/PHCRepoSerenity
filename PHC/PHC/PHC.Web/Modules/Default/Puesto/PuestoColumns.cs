
namespace PHC.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Puesto")]
    [BasedOnRow(typeof(Entities.PuestoRow))]
    public class PuestoColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 IdPuesto { get; set; }
        [EditLink]
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public Boolean EsResponsableDpto { get; set; }
        public Int32 IdDepartamento { get; set; }
        public Int32 IdNivel { get; set; }
    }
}