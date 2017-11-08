using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHC.Migrations.DefaultDB
{
    [Migration(20171107100018)]
    public class PHCDB_20171107_100018_AlterTablePuestoTareaFKidTarea : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("PuestoTarea").InSchema("PHC")
                .AddColumn("idTarea").AsInt32().Nullable();
        }
    }
}