
namespace PHC.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[PHC].[HistorialEmpleado]")]
    [DisplayName("Historial Empleado"), InstanceName("Historial Empleado"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class HistorialEmpleadoRow : Row, IIdRow
    {
        [DisplayName("Id Historial Empleado"), Column("idHistorialEmpleado"), Identity]
        public Int32? IdHistorialEmpleado
        {
            get { return Fields.IdHistorialEmpleado[this]; }
            set { Fields.IdHistorialEmpleado[this] = value; }
        }

        [DisplayName("Fecha Ingreso"), Column("fechaIngreso"), NotNull]
        public DateTime? FechaIngreso
        {
            get { return Fields.FechaIngreso[this]; }
            set { Fields.FechaIngreso[this] = value; }
        }

        [DisplayName("Fecha Egreso"), Column("fechaEgreso"), NotNull]
        public DateTime? FechaEgreso
        {
            get { return Fields.FechaEgreso[this]; }
            set { Fields.FechaEgreso[this] = value; }
        }

        [DisplayName("Id Empleado"), Column("idEmpleado")]
        public Int32? IdEmpleado
        {
            get { return Fields.IdEmpleado[this]; }
            set { Fields.IdEmpleado[this] = value; }
        }

        [DisplayName("Id Puesto"), Column("idPuesto")]
        public Int32? IdPuesto
        {
            get { return Fields.IdPuesto[this]; }
            set { Fields.IdPuesto[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.IdHistorialEmpleado; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public HistorialEmpleadoRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field IdHistorialEmpleado;
            public DateTimeField FechaIngreso;
            public DateTimeField FechaEgreso;
            public Int32Field IdEmpleado;
            public Int32Field IdPuesto;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.HistorialEmpleado";
            }
        }
    }
}
