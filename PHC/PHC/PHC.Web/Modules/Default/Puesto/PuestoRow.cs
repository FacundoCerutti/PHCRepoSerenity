
namespace PHC.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[PHC].[Puesto]")]
    [DisplayName("Puesto"), InstanceName("Puesto"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class PuestoRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id Puesto"), Column("idPuesto"), Identity]
        public Int32? IdPuesto
        {
            get { return Fields.IdPuesto[this]; }
            set { Fields.IdPuesto[this] = value; }
        }

        [DisplayName("Nombre"), Column("nombre"), Size(100), NotNull, QuickSearch]
        public String Nombre
        {
            get { return Fields.Nombre[this]; }
            set { Fields.Nombre[this] = value; }
        }

        [DisplayName("Descripcion"), Column("descripcion"), Size(200)]
        public String Descripcion
        {
            get { return Fields.Descripcion[this]; }
            set { Fields.Descripcion[this] = value; }
        }

        [DisplayName("Es Responsable Dpto"), Column("esResponsableDpto")]
        public Boolean? EsResponsableDpto
        {
            get { return Fields.EsResponsableDpto[this]; }
            set { Fields.EsResponsableDpto[this] = value; }
        }

        [DisplayName("Id Departamento"), Column("idDepartamento")]
        public Int32? IdDepartamento
        {
            get { return Fields.IdDepartamento[this]; }
            set { Fields.IdDepartamento[this] = value; }
        }

        [DisplayName("Id Nivel"), Column("idNivel")]
        public Int32? IdNivel
        {
            get { return Fields.IdNivel[this]; }
            set { Fields.IdNivel[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.IdPuesto; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Nombre; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PuestoRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field IdPuesto;
            public StringField Nombre;
            public StringField Descripcion;
            public BooleanField EsResponsableDpto;
            public Int32Field IdDepartamento;
            public Int32Field IdNivel;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.Puesto";
            }
        }
    }
}
