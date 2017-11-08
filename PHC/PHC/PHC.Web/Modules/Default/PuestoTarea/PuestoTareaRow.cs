
namespace PHC.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[PHC].[PuestoTarea]")]
    [DisplayName("Puesto Tarea"), InstanceName("Puesto Tarea"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class PuestoTareaRow : Row, IIdRow
    {
        [DisplayName("Id Puesto Tarea"), Column("idPuestoTarea"), Identity]
        public Int32? IdPuestoTarea
        {
            get { return Fields.IdPuestoTarea[this]; }
            set { Fields.IdPuestoTarea[this] = value; }
        }

        [DisplayName("Id Puesto"), Column("idPuesto")]
        public Int32? IdPuesto
        {
            get { return Fields.IdPuesto[this]; }
            set { Fields.IdPuesto[this] = value; }
        }

        [DisplayName("Id Tarea"), Column("idTarea")]
        public Int32? IdTarea
        {
            get { return Fields.IdTarea[this]; }
            set { Fields.IdTarea[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.IdPuestoTarea; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PuestoTareaRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field IdPuestoTarea;
            public Int32Field IdPuesto;
            public Int32Field IdTarea;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.PuestoTarea";
            }
        }
    }
}
