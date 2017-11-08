
namespace PHC.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.RequerimientoPuesto")]
    [BasedOnRow(typeof(Entities.RequerimientoPuestoRow))]
    public class RequerimientoPuestoColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 IdRequerimientoPuesto { get; set; }
        public Int32 IdRequerimiento { get; set; }
        public Int32 IdPuesto { get; set; }
    }
}