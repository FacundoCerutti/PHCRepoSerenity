using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHC.Migrations.DefaultDB
{
    [Migration(20171107100006)]
    public class PHCDB_20171107_100006_HistorialEmpleadoTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("HistorialEmpleado").InSchema("PHC")
                .WithColumn("idHistorialEmpleado").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("fechaIngreso").AsDate().NotNullable()
                .WithColumn("fechaEgreso").AsDate().NotNullable();
                //.WithColumn("idEmpleado").AsInt32().Nullable().ForeignKey( "FK_HistorialEmpleado_Empleado", "idEmpleado")
                //.WithColumn("idPuesto").AsInt32().Nullable().ForeignKey("FK_HistorialEmpleado_Puesto", "idPuesto");         
        }        
    }
}