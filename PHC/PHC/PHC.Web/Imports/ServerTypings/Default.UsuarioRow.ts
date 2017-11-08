
namespace PHC.Default {
    export interface UsuarioRow {
        IdUsuario?: number;
        NombreUsuario?: string;
        Contraseña?: string;
        EsAdministrador?: boolean;
        Habilitado?: boolean;
        ContraseñaRestaurada?: boolean;
        IdEmpleado?: number;
    }

    export namespace UsuarioRow {
        export const idProperty = 'IdUsuario';
        export const nameProperty = 'NombreUsuario';
        export const localTextPrefix = 'Default.Usuario';

        export namespace Fields {
            export declare const IdUsuario;
            export declare const NombreUsuario;
            export declare const Contraseña;
            export declare const EsAdministrador;
            export declare const Habilitado;
            export declare const ContraseñaRestaurada;
            export declare const IdEmpleado;
        }

        [
            'IdUsuario',
            'NombreUsuario',
            'Contraseña',
            'EsAdministrador',
            'Habilitado',
            'ContraseñaRestaurada',
            'IdEmpleado'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}