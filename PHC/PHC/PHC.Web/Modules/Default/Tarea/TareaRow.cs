
namespace PHC.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[PHC].[Tarea]")]
    [DisplayName("Tarea"), InstanceName("Tarea"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class TareaRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id Tarea"), Column("idTarea"), Identity]
        public Int32? IdTarea
        {
            get { return Fields.IdTarea[this]; }
            set { Fields.IdTarea[this] = value; }
        }

        [DisplayName("Descripcion"), Column("descripcion"), Size(200), NotNull, QuickSearch]
        public String Descripcion
        {
            get { return Fields.Descripcion[this]; }
            set { Fields.Descripcion[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.IdTarea; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Descripcion; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TareaRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field IdTarea;
            public StringField Descripcion;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.Tarea";
            }
        }
    }
}
