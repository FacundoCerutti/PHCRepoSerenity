using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHC.Migrations.DefaultDB
{
    [Migration(20171107100008)]
    public class PHCDB_20171107_100008_PuestoTareaTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("PuestoTarea").InSchema("PHC")
                .WithColumn("idPuestoTarea").AsInt32().Identity().PrimaryKey().NotNullable();
                //.WithColumn("idPuesto").AsInt32().Nullable().ForeignKey("FK_PuestoTarea_idPuesto", "Puesto", "idPuesto")
                //.WithColumn("idTarea").AsInt32().Nullable().ForeignKey("FK_PuestoTarea_idTarea", "Tarea", "idTarea");            
        }       
    }
}