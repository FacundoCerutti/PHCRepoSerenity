
namespace PHC.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Tarea")]
    [BasedOnRow(typeof(Entities.TareaRow))]
    public class TareaColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 IdTarea { get; set; }
        [EditLink]
        public String Descripcion { get; set; }
    }
}