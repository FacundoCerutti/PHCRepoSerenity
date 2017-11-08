using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHC.Migrations.DefaultDB
{
    [Migration(20171107100019)]
    public class PHCDB_20171107_100019_TareaTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Tarea").InSchema("PHC")
                .WithColumn("idTarea").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("descripcion").AsString(200);
        }

    }
   
}