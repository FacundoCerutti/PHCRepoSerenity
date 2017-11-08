using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHC.Migrations.DefaultDB
{
    [Migration(20171107100016)]
    public class PHCDB_20171107_100016_AlterTableUsuarioFKidEmpleado : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Usuario").InSchema("PHC")
                .AddColumn("idEmpleado").AsInt32().Nullable();
        }
    }
}