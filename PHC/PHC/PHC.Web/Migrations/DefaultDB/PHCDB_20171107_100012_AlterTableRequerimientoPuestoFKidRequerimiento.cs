using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHC.Migrations.DefaultDB
{
    [Migration(20171107100012)]
    public class PHCDB_20171107_100012_AlterTableRequerimientoPuestoFKidRequerimiento : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("RequerimientoPuesto").InSchema("PHC")
                .AddColumn("idRequerimiento").AsInt32().Nullable();
        }
    }
}