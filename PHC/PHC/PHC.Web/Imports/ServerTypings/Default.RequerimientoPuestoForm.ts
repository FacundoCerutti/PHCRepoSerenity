
namespace PHC.Default {
    export class RequerimientoPuestoForm extends Serenity.PrefixedContext {
        static formKey = 'Default.RequerimientoPuesto';
    }

    export interface RequerimientoPuestoForm {
        IdRequerimiento: Serenity.IntegerEditor;
        IdPuesto: Serenity.IntegerEditor;
    }

    [,
        ['IdRequerimiento', () => Serenity.IntegerEditor],
        ['IdPuesto', () => Serenity.IntegerEditor]
    ].forEach(x => Object.defineProperty(RequerimientoPuestoForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}