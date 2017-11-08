using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHC.Migrations.DefaultDB
{
    [Migration(20171107100015)]
    public class PHCDB_20171107_100015_AlterTableHistorialEmpleadoFKidPuesto : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("HistorialEmpleado").InSchema("PHC")
                .AddColumn("idPuesto").AsInt32().Nullable();
        }
    }
}