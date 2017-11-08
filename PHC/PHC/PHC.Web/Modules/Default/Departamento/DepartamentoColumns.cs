
namespace PHC.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Departamento")]
    [BasedOnRow(typeof(Entities.DepartamentoRow))]
    public class DepartamentoColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 IdDepartamento { get; set; }
        [EditLink]
        public String Nombre { get; set; }
    }
}