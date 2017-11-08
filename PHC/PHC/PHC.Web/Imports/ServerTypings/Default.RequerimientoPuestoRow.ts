
namespace PHC.Default {
    export interface RequerimientoPuestoRow {
        IdRequerimientoPuesto?: number;
        IdRequerimiento?: number;
        IdPuesto?: number;
    }

    export namespace RequerimientoPuestoRow {
        export const idProperty = 'IdRequerimientoPuesto';
        export const localTextPrefix = 'Default.RequerimientoPuesto';

        export namespace Fields {
            export declare const IdRequerimientoPuesto;
            export declare const IdRequerimiento;
            export declare const IdPuesto;
        }

        [
            'IdRequerimientoPuesto',
            'IdRequerimiento',
            'IdPuesto'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}