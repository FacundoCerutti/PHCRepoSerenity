
namespace PHC.Default {
    export class UsuarioForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Usuario';
    }

    export interface UsuarioForm {
        NombreUsuario: Serenity.StringEditor;
        Contraseña: Serenity.StringEditor;
        EsAdministrador: Serenity.BooleanEditor;
        Habilitado: Serenity.BooleanEditor;
        ContraseñaRestaurada: Serenity.BooleanEditor;
        IdEmpleado: Serenity.IntegerEditor;
    }

    [,
        ['NombreUsuario', () => Serenity.StringEditor],
        ['Contraseña', () => Serenity.StringEditor],
        ['EsAdministrador', () => Serenity.BooleanEditor],
        ['Habilitado', () => Serenity.BooleanEditor],
        ['ContraseñaRestaurada', () => Serenity.BooleanEditor],
        ['IdEmpleado', () => Serenity.IntegerEditor]
    ].forEach(x => Object.defineProperty(UsuarioForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}