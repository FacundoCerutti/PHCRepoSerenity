using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHC.Migrations.DefaultDB
{
    [Migration(20171107100007)]
    public class PHCDB_20171107_100007_UsuarioTable : AutoReversingMigration
    {      
            public override void Up()
            {
            Create.Table("Usuario").InSchema("PHC")
            .WithColumn("idUsuario").AsInt32()
                .Identity().PrimaryKey().NotNullable()
            .WithColumn("nombreUsuario").AsString(45).NotNullable()
            .WithColumn("contraseña").AsString(45).NotNullable()
            .WithColumn("esAdministrador").AsBoolean().NotNullable()
            .WithColumn("habilitado").AsBoolean().NotNullable()
            .WithColumn("contraseñaRestaurada").AsBoolean().NotNullable();
            //.WithColumn("idEmpleado").AsInt32().Nullable().ForeignKey("FK_Usuario_idEmpleado","Empleado","idEmpleado");                                  
            }
            
    }
}
