
namespace PHC.Default {
    export class RequerimientoForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Requerimiento';
    }

    export interface RequerimientoForm {
        Descripcion: Serenity.StringEditor;
    }

    [,
        ['Descripcion', () => Serenity.StringEditor]
    ].forEach(x => Object.defineProperty(RequerimientoForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}