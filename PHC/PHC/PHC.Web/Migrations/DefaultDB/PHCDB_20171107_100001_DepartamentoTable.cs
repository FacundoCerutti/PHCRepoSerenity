using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHC.Migrations.DefaultDB
{
    [Migration(20171107100001)]
    public class PHCDB_20171107_100001_DepartamentoTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Departamento").InSchema("PHC")
                .WithColumn("idDepartamento").AsInt32().Identity().NotNullable().PrimaryKey()
                .WithColumn("nombre").AsString(100).Nullable();
        }
        
    }
}