
namespace PHC.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Requerimiento")]
    [BasedOnRow(typeof(Entities.RequerimientoRow))]
    public class RequerimientoForm
    {
        public String Descripcion { get; set; }
    }
}