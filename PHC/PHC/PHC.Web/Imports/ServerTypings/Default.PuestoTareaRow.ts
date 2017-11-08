
namespace PHC.Default {
    export interface PuestoTareaRow {
        IdPuestoTarea?: number;
        IdPuesto?: number;
        IdTarea?: number;
    }

    export namespace PuestoTareaRow {
        export const idProperty = 'IdPuestoTarea';
        export const localTextPrefix = 'Default.PuestoTarea';

        export namespace Fields {
            export declare const IdPuestoTarea;
            export declare const IdPuesto;
            export declare const IdTarea;
        }

        [
            'IdPuestoTarea',
            'IdPuesto',
            'IdTarea'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}