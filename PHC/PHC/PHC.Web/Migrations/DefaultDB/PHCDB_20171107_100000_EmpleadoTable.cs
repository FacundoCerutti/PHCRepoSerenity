using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHC.Migrations.DefaultDB
{
    [Migration(20171107100000)]
    public class PHCDB_20171107_100000_EmpleadoTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Schema("PHC");
            Create.Table("Empleado").InSchema("PHC")
                .WithColumn("idEmpleado").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("apellido").AsString(45).Nullable()
                .WithColumn("nombre").AsString(45).Nullable()
                .WithColumn("legajo").AsString(45).NotNullable()
                .WithColumn("fechaIngreso").AsDate().Nullable()
                .WithColumn("dni").AsInt32().Nullable()
                .WithColumn("cuil").AsString(45).Nullable()
                .WithColumn("fechaNacimiento").AsDate().Nullable()
                .WithColumn("esActivo").AsBoolean().Nullable()
                .WithColumn("telefono").AsString(45).Nullable()
                .WithColumn("email").AsString(45).Nullable()
                .WithColumn("domicilio").AsString(100).Nullable()
                .WithColumn("sexo").AsString(1).Nullable();
        }        
    }
}