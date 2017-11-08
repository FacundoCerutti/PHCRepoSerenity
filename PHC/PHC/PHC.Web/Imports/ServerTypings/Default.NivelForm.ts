
namespace PHC.Default {
    export class NivelForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Nivel';
    }

    export interface NivelForm {
        Nombre: Serenity.StringEditor;
    }

    [,
        ['Nombre', () => Serenity.StringEditor]
    ].forEach(x => Object.defineProperty(NivelForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}