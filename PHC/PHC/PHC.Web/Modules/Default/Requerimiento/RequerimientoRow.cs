
namespace PHC.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[PHC].[Requerimiento]")]
    [DisplayName("Requerimiento"), InstanceName("Requerimiento"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class RequerimientoRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id Requerimiento"), Column("idRequerimiento"), Identity]
        public Int32? IdRequerimiento
        {
            get { return Fields.IdRequerimiento[this]; }
            set { Fields.IdRequerimiento[this] = value; }
        }

        [DisplayName("Descripcion"), Column("descripcion"), Size(200), NotNull, QuickSearch]
        public String Descripcion
        {
            get { return Fields.Descripcion[this]; }
            set { Fields.Descripcion[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.IdRequerimiento; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Descripcion; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public RequerimientoRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field IdRequerimiento;
            public StringField Descripcion;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.Requerimiento";
            }
        }
    }
}
