using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHC.Migrations.DefaultDB
{
    [Migration(20171107100005)]
    public class PHCDB_20171107_100005_RequerimientoPuestoTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("RequerimientoPuesto").InSchema("PHC")
                .WithColumn("idRequerimientoPuesto").AsInt32().Identity().PrimaryKey().NotNullable();
                //.WithColumn("idRequerimiento").AsInt32().Nullable().ForeignKey("FK_RequerimientoPuesto_idRequerimiento","Requerimiento", "idRequerimiento")
                //.WithColumn("idPuesto").AsInt32().Nullable().ForeignKey("FK_RequerimientoPuesto_idPuesto","Puesto", "idPuesto");
        }       
    }
}