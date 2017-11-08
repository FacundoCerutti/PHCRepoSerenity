
namespace PHC.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[PHC].[RequerimientoPuesto]")]
    [DisplayName("Requerimiento Puesto"), InstanceName("Requerimiento Puesto"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class RequerimientoPuestoRow : Row, IIdRow
    {
        [DisplayName("Id Requerimiento Puesto"), Column("idRequerimientoPuesto"), Identity]
        public Int32? IdRequerimientoPuesto
        {
            get { return Fields.IdRequerimientoPuesto[this]; }
            set { Fields.IdRequerimientoPuesto[this] = value; }
        }

        [DisplayName("Id Requerimiento"), Column("idRequerimiento")]
        public Int32? IdRequerimiento
        {
            get { return Fields.IdRequerimiento[this]; }
            set { Fields.IdRequerimiento[this] = value; }
        }

        [DisplayName("Id Puesto"), Column("idPuesto")]
        public Int32? IdPuesto
        {
            get { return Fields.IdPuesto[this]; }
            set { Fields.IdPuesto[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.IdRequerimientoPuesto; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public RequerimientoPuestoRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field IdRequerimientoPuesto;
            public Int32Field IdRequerimiento;
            public Int32Field IdPuesto;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.RequerimientoPuesto";
            }
        }
    }
}
