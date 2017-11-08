using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHC.Migrations.DefaultDB
{
    [Migration(20171107100002)]
    public class PHCDB_20171107_100002_RequerimientoTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Requerimiento").InSchema("PHC")
                .WithColumn("idRequerimiento").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("descripcion").AsString(200);
        }
        
    }
}