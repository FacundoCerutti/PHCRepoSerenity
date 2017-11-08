
namespace PHC.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[PHC].[Empleado]")]
    [DisplayName("Empleado"), InstanceName("Empleado"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class EmpleadoRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id Empleado"), Column("idEmpleado"), Identity]
        public Int32? IdEmpleado
        {
            get { return Fields.IdEmpleado[this]; }
            set { Fields.IdEmpleado[this] = value; }
        }

        [DisplayName("Apellido"), Column("apellido"), Size(45), QuickSearch]
        public String Apellido
        {
            get { return Fields.Apellido[this]; }
            set { Fields.Apellido[this] = value; }
        }

        [DisplayName("Nombre"), Column("nombre"), Size(45)]
        public String Nombre
        {
            get { return Fields.Nombre[this]; }
            set { Fields.Nombre[this] = value; }
        }

        [DisplayName("Legajo"), Column("legajo"), Size(45), NotNull]
        public String Legajo
        {
            get { return Fields.Legajo[this]; }
            set { Fields.Legajo[this] = value; }
        }

        [DisplayName("Fecha Ingreso"), Column("fechaIngreso")]
        public DateTime? FechaIngreso
        {
            get { return Fields.FechaIngreso[this]; }
            set { Fields.FechaIngreso[this] = value; }
        }

        [DisplayName("Dni"), Column("dni")]
        public Int32? Dni
        {
            get { return Fields.Dni[this]; }
            set { Fields.Dni[this] = value; }
        }

        [DisplayName("Cuil"), Column("cuil"), Size(45)]
        public String Cuil
        {
            get { return Fields.Cuil[this]; }
            set { Fields.Cuil[this] = value; }
        }

        [DisplayName("Fecha Nacimiento"), Column("fechaNacimiento")]
        public DateTime? FechaNacimiento
        {
            get { return Fields.FechaNacimiento[this]; }
            set { Fields.FechaNacimiento[this] = value; }
        }

        [DisplayName("Es Activo"), Column("esActivo")]
        public Boolean? EsActivo
        {
            get { return Fields.EsActivo[this]; }
            set { Fields.EsActivo[this] = value; }
        }

        [DisplayName("Telefono"), Column("telefono"), Size(45)]
        public String Telefono
        {
            get { return Fields.Telefono[this]; }
            set { Fields.Telefono[this] = value; }
        }

        [DisplayName("Email"), Column("email"), Size(45)]
        public String Email
        {
            get { return Fields.Email[this]; }
            set { Fields.Email[this] = value; }
        }

        [DisplayName("Domicilio"), Column("domicilio"), Size(100)]
        public String Domicilio
        {
            get { return Fields.Domicilio[this]; }
            set { Fields.Domicilio[this] = value; }
        }

        [DisplayName("Sexo"), Column("sexo"), Size(1)]
        public String Sexo
        {
            get { return Fields.Sexo[this]; }
            set { Fields.Sexo[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.IdEmpleado; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Apellido; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public EmpleadoRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field IdEmpleado;
            public StringField Apellido;
            public StringField Nombre;
            public StringField Legajo;
            public DateTimeField FechaIngreso;
            public Int32Field Dni;
            public StringField Cuil;
            public DateTimeField FechaNacimiento;
            public BooleanField EsActivo;
            public StringField Telefono;
            public StringField Email;
            public StringField Domicilio;
            public StringField Sexo;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.Empleado";
            }
        }
    }
}
