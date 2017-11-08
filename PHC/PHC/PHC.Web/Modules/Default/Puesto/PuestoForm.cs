
namespace PHC.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Puesto")]
    [BasedOnRow(typeof(Entities.PuestoRow))]
    public class PuestoForm
    {
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public Boolean EsResponsableDpto { get; set; }
        public Int32 IdDepartamento { get; set; }
        public Int32 IdNivel { get; set; }
    }
}