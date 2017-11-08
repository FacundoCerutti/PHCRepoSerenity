
namespace PHC.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Requerimiento")]
    [BasedOnRow(typeof(Entities.RequerimientoRow))]
    public class RequerimientoColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 IdRequerimiento { get; set; }
        [EditLink]
        public String Descripcion { get; set; }
    }
}