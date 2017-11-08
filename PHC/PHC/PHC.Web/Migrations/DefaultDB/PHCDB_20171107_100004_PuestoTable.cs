using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHC.Migrations.DefaultDB
{
    [Migration(20171107100004)]
    public class PHCDB_20171107_100004_PuestoTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Puesto").InSchema("PHC")
                .WithColumn("idPuesto").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("nombre").AsString(100).NotNullable()
                .WithColumn("descripcion").AsString(200).Nullable()
                .WithColumn("esResponsableDpto").AsBoolean().Nullable();
                //.WithColumn("idDepartamento").AsInt32().Nullable().ForeignKey("FK_Puesto_idDepartamento","Departamento", "idDepartamento")
                //.WithColumn("idNivel").AsInt32().Nullable().ForeignKey("FK_Puesto_idNivel","Nivel", "idNivel");
        }
        
    }
}