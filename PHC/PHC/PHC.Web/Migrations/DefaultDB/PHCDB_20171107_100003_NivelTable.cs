using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHC.Migrations.DefaultDB
{
    [Migration(20171107100003)]
    public class PHCDB_20171107_100003_NivelTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Nivel").InSchema("PHC")
                .WithColumn("idNivel").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("nombre").AsString(45).NotNullable();
        }
        
    }
}