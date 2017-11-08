
namespace PHC.Default {
    export interface PuestoRow {
        IdPuesto?: number;
        Nombre?: string;
        Descripcion?: string;
        EsResponsableDpto?: boolean;
        IdDepartamento?: number;
        IdNivel?: number;
    }

    export namespace PuestoRow {
        export const idProperty = 'IdPuesto';
        export const nameProperty = 'Nombre';
        export const localTextPrefix = 'Default.Puesto';

        export namespace Fields {
            export declare const IdPuesto;
            export declare const Nombre;
            export declare const Descripcion;
            export declare const EsResponsableDpto;
            export declare const IdDepartamento;
            export declare const IdNivel;
        }

        [
            'IdPuesto',
            'Nombre',
            'Descripcion',
            'EsResponsableDpto',
            'IdDepartamento',
            'IdNivel'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}