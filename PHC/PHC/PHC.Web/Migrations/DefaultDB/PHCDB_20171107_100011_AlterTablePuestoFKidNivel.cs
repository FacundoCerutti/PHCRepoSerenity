using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHC.Migrations.DefaultDB
{
    [Migration(20171107100011)]
    public class PHCDB_20171107_100011_AlterTablePuestoFKidNivel : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Puesto").InSchema("PHC")
                .AddColumn("idNivel").AsInt32().Nullable();
        }
    }
}