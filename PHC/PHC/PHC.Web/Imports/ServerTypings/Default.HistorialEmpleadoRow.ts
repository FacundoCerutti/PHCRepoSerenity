
namespace PHC.Default {
    export interface HistorialEmpleadoRow {
        IdHistorialEmpleado?: number;
        FechaIngreso?: string;
        FechaEgreso?: string;
        IdEmpleado?: number;
        IdPuesto?: number;
    }

    export namespace HistorialEmpleadoRow {
        export const idProperty = 'IdHistorialEmpleado';
        export const localTextPrefix = 'Default.HistorialEmpleado';

        export namespace Fields {
            export declare const IdHistorialEmpleado;
            export declare const FechaIngreso;
            export declare const FechaEgreso;
            export declare const IdEmpleado;
            export declare const IdPuesto;
        }

        [
            'IdHistorialEmpleado',
            'FechaIngreso',
            'FechaEgreso',
            'IdEmpleado',
            'IdPuesto'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}