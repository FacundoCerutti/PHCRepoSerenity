using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHC.Migrations.DefaultDB
{
    [Migration(20171107100009)]
    public class PHCDB_20171107_100009_BitacoraTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Bitacora").InSchema("PHC")
                .WithColumn("idBitacora").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("operacion").AsString(10).NotNullable()
                .WithColumn("usuario").AsString(40).NotNullable()
                .WithColumn("host").AsString(40).NotNullable()
                .WithColumn("fechahora").AsDateTime()
                .WithColumn("tabla").AsString(45).NotNullable()
                .WithColumn("columna").AsString(45).NotNullable()
                .WithColumn("id").AsString(45).NotNullable()
                .WithColumn("valorViejo").AsString(200).Nullable()
                .WithColumn("valorNuevo").AsString(200).Nullable();
        }       
    }
}