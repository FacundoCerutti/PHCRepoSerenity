
namespace PHC.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Tarea")]
    [BasedOnRow(typeof(Entities.TareaRow))]
    public class TareaForm
    {
        public String Descripcion { get; set; }
    }
}