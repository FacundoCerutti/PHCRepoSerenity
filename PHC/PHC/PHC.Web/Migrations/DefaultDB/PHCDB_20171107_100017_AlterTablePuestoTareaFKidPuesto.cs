using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHC.Migrations.DefaultDB
{
    [Migration(20171107100017)]
    public class PHCDB_20171107_100017_AlterTablePuestoTareaFKidPuesto : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("PuestoTarea").InSchema("PHC")
                .AddColumn("idPuesto").AsInt32().Nullable();
        }
    }
}