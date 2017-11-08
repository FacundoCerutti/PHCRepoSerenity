
namespace PHC.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Nivel")]
    [BasedOnRow(typeof(Entities.NivelRow))]
    public class NivelColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 IdNivel { get; set; }
        [EditLink]
        public String Nombre { get; set; }
    }
}