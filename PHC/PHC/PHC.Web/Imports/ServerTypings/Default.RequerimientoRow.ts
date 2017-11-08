
namespace PHC.Default {
    export interface RequerimientoRow {
        IdRequerimiento?: number;
        Descripcion?: string;
    }

    export namespace RequerimientoRow {
        export const idProperty = 'IdRequerimiento';
        export const nameProperty = 'Descripcion';
        export const localTextPrefix = 'Default.Requerimiento';

        export namespace Fields {
            export declare const IdRequerimiento;
            export declare const Descripcion;
        }

        [
            'IdRequerimiento',
            'Descripcion'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}