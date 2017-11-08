
namespace PHC.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[PHC].[Nivel]")]
    [DisplayName("Nivel"), InstanceName("Nivel"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class NivelRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id Nivel"), Column("idNivel"), Identity]
        public Int32? IdNivel
        {
            get { return Fields.IdNivel[this]; }
            set { Fields.IdNivel[this] = value; }
        }

        [DisplayName("Nombre"), Column("nombre"), Size(45), NotNull, QuickSearch]
        public String Nombre
        {
            get { return Fields.Nombre[this]; }
            set { Fields.Nombre[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.IdNivel; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Nombre; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public NivelRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field IdNivel;
            public StringField Nombre;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.Nivel";
            }
        }
    }
}
