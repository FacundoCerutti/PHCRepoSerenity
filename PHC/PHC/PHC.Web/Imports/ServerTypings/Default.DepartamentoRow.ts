
namespace PHC.Default {
    export interface DepartamentoRow {
        IdDepartamento?: number;
        Nombre?: string;
    }

    export namespace DepartamentoRow {
        export const idProperty = 'IdDepartamento';
        export const nameProperty = 'Nombre';
        export const localTextPrefix = 'Default.Departamento';

        export namespace Fields {
            export declare const IdDepartamento;
            export declare const Nombre;
        }

        [
            'IdDepartamento',
            'Nombre'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}