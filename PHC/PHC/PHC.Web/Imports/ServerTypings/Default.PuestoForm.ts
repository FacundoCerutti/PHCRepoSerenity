
namespace PHC.Default {
    export class PuestoForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Puesto';
    }

    export interface PuestoForm {
        Nombre: Serenity.StringEditor;
        Descripcion: Serenity.StringEditor;
        EsResponsableDpto: Serenity.BooleanEditor;
        IdDepartamento: Serenity.IntegerEditor;
        IdNivel: Serenity.IntegerEditor;
    }

    [,
        ['Nombre', () => Serenity.StringEditor],
        ['Descripcion', () => Serenity.StringEditor],
        ['EsResponsableDpto', () => Serenity.BooleanEditor],
        ['IdDepartamento', () => Serenity.IntegerEditor],
        ['IdNivel', () => Serenity.IntegerEditor]
    ].forEach(x => Object.defineProperty(PuestoForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}