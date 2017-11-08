
namespace PHC.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[PHC].[Usuario]")]
    [DisplayName("Usuario"), InstanceName("Usuario"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class UsuarioRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id Usuario"), Column("idUsuario"), Identity]
        public Int32? IdUsuario
        {
            get { return Fields.IdUsuario[this]; }
            set { Fields.IdUsuario[this] = value; }
        }

        [DisplayName("Nombre Usuario"), Column("nombreUsuario"), Size(45), NotNull, QuickSearch]
        public String NombreUsuario
        {
            get { return Fields.NombreUsuario[this]; }
            set { Fields.NombreUsuario[this] = value; }
        }

        [DisplayName("Contraseña"), Column("contraseña"), Size(45), NotNull]
        public String Contraseña
        {
            get { return Fields.Contraseña[this]; }
            set { Fields.Contraseña[this] = value; }
        }

        [DisplayName("Es Administrador"), Column("esAdministrador"), NotNull]
        public Boolean? EsAdministrador
        {
            get { return Fields.EsAdministrador[this]; }
            set { Fields.EsAdministrador[this] = value; }
        }

        [DisplayName("Habilitado"), Column("habilitado"), NotNull]
        public Boolean? Habilitado
        {
            get { return Fields.Habilitado[this]; }
            set { Fields.Habilitado[this] = value; }
        }

        [DisplayName("Contraseña Restaurada"), Column("contraseñaRestaurada"), NotNull]
        public Boolean? ContraseñaRestaurada
        {
            get { return Fields.ContraseñaRestaurada[this]; }
            set { Fields.ContraseñaRestaurada[this] = value; }
        }

        [DisplayName("Id Empleado"), Column("idEmpleado")]
        public Int32? IdEmpleado
        {
            get { return Fields.IdEmpleado[this]; }
            set { Fields.IdEmpleado[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.IdUsuario; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.NombreUsuario; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public UsuarioRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field IdUsuario;
            public StringField NombreUsuario;
            public StringField Contraseña;
            public BooleanField EsAdministrador;
            public BooleanField Habilitado;
            public BooleanField ContraseñaRestaurada;
            public Int32Field IdEmpleado;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.Usuario";
            }
        }
    }
}
