
namespace PHC.Default {
    export interface TareaRow {
        IdTarea?: number;
        Descripcion?: string;
    }

    export namespace TareaRow {
        export const idProperty = 'IdTarea';
        export const nameProperty = 'Descripcion';
        export const localTextPrefix = 'Default.Tarea';

        export namespace Fields {
            export declare const IdTarea;
            export declare const Descripcion;
        }

        [
            'IdTarea',
            'Descripcion'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}