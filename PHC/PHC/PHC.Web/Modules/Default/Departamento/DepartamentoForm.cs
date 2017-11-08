
namespace PHC.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Departamento")]
    [BasedOnRow(typeof(Entities.DepartamentoRow))]
    public class DepartamentoForm
    {
        public String Nombre { get; set; }
    }
}