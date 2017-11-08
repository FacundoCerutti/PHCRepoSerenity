
namespace PHC.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.PuestoTarea")]
    [BasedOnRow(typeof(Entities.PuestoTareaRow))]
    public class PuestoTareaForm
    {
        public Int32 IdPuesto { get; set; }
        public Int32 IdTarea { get; set; }
    }
}