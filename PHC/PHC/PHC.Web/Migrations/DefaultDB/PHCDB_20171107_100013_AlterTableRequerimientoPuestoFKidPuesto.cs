using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHC.Migrations.DefaultDB
{
    [Migration(20171107100013)]
    public class PHCDB_20171107_100013_AlterTableRequerimientoPuestoFKidPuesto : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("RequerimientoPuesto").InSchema("PHC")
                .AddColumn("idPuesto").AsInt32().Nullable();
        }
    }
}