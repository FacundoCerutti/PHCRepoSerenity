
namespace PHC.Default {
    export interface NivelRow {
        IdNivel?: number;
        Nombre?: string;
    }

    export namespace NivelRow {
        export const idProperty = 'IdNivel';
        export const nameProperty = 'Nombre';
        export const localTextPrefix = 'Default.Nivel';

        export namespace Fields {
            export declare const IdNivel;
            export declare const Nombre;
        }

        [
            'IdNivel',
            'Nombre'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}