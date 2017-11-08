
namespace PHC.Default {
    export class PuestoTareaForm extends Serenity.PrefixedContext {
        static formKey = 'Default.PuestoTarea';
    }

    export interface PuestoTareaForm {
        IdPuesto: Serenity.IntegerEditor;
        IdTarea: Serenity.IntegerEditor;
    }

    [,
        ['IdPuesto', () => Serenity.IntegerEditor],
        ['IdTarea', () => Serenity.IntegerEditor]
    ].forEach(x => Object.defineProperty(PuestoTareaForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}