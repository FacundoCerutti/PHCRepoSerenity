
namespace PHC.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[PHC].[Departamento]")]
    [DisplayName("Departamento"), InstanceName("Departamento"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class DepartamentoRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id Departamento"), Column("idDepartamento"), Identity]
        public Int32? IdDepartamento
        {
            get { return Fields.IdDepartamento[this]; }
            set { Fields.IdDepartamento[this] = value; }
        }

        [DisplayName("Nombre"), Column("nombre"), Size(100), QuickSearch]
        public String Nombre
        {
            get { return Fields.Nombre[this]; }
            set { Fields.Nombre[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.IdDepartamento; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Nombre; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public DepartamentoRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field IdDepartamento;
            public StringField Nombre;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.Departamento";
            }
        }
    }
}
