
namespace PHC.Default {
    export class HistorialEmpleadoForm extends Serenity.PrefixedContext {
        static formKey = 'Default.HistorialEmpleado';
    }

    export interface HistorialEmpleadoForm {
        FechaIngreso: Serenity.DateEditor;
        FechaEgreso: Serenity.DateEditor;
        IdEmpleado: Serenity.IntegerEditor;
        IdPuesto: Serenity.IntegerEditor;
    }

    [,
        ['FechaIngreso', () => Serenity.DateEditor],
        ['FechaEgreso', () => Serenity.DateEditor],
        ['IdEmpleado', () => Serenity.IntegerEditor],
        ['IdPuesto', () => Serenity.IntegerEditor]
    ].forEach(x => Object.defineProperty(HistorialEmpleadoForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}