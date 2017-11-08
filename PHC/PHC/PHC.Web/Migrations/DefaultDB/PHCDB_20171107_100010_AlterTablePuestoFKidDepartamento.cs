using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHC.Migrations.DefaultDB
{
    [Migration(20171107100010)]
    public class PHCDB_20171107_100010_AlterTablePuestoFKidDepartamento : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Puesto").InSchema("PHC")
                .AddColumn("idDepartamento").AsInt32().Nullable();
        }        
    }
}