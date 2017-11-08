
namespace PHC.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.RequerimientoPuesto")]
    [BasedOnRow(typeof(Entities.RequerimientoPuestoRow))]
    public class RequerimientoPuestoForm
    {
        public Int32 IdRequerimiento { get; set; }
        public Int32 IdPuesto { get; set; }
    }
}