
namespace PHC.Default {
    export class EmpleadoForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Empleado';
    }

    export interface EmpleadoForm {
        Apellido: Serenity.StringEditor;
        Nombre: Serenity.StringEditor;
        Legajo: Serenity.StringEditor;
        FechaIngreso: Serenity.DateEditor;
        Dni: Serenity.IntegerEditor;
        Cuil: Serenity.StringEditor;
        FechaNacimiento: Serenity.DateEditor;
        EsActivo: Serenity.BooleanEditor;
        Telefono: Serenity.StringEditor;
        Email: Serenity.StringEditor;
        Domicilio: Serenity.StringEditor;
        Sexo: Serenity.StringEditor;
    }

    [,
        ['Apellido', () => Serenity.StringEditor],
        ['Nombre', () => Serenity.StringEditor],
        ['Legajo', () => Serenity.StringEditor],
        ['FechaIngreso', () => Serenity.DateEditor],
        ['Dni', () => Serenity.IntegerEditor],
        ['Cuil', () => Serenity.StringEditor],
        ['FechaNacimiento', () => Serenity.DateEditor],
        ['EsActivo', () => Serenity.BooleanEditor],
        ['Telefono', () => Serenity.StringEditor],
        ['Email', () => Serenity.StringEditor],
        ['Domicilio', () => Serenity.StringEditor],
        ['Sexo', () => Serenity.StringEditor]
    ].forEach(x => Object.defineProperty(EmpleadoForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}