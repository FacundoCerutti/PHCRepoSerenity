
namespace PHC.Default {
    export class DepartamentoForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Departamento';
    }

    export interface DepartamentoForm {
        Nombre: Serenity.StringEditor;
    }

    [,
        ['Nombre', () => Serenity.StringEditor]
    ].forEach(x => Object.defineProperty(DepartamentoForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}