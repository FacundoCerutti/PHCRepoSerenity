using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHC.Migrations.DefaultDB
{
    [Migration(20171107100014)]
    public class PHCDB_20171107_100014_AlterTableHistorialEmpleadoFKidEmpleado : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("HistorialEmpleado").InSchema("PHC")
                .AddColumn("idEmpleado").AsInt32().Nullable();
        }
    }
}