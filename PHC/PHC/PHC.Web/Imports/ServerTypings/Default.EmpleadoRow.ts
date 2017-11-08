
namespace PHC.Default {
    export interface EmpleadoRow {
        IdEmpleado?: number;
        Apellido?: string;
        Nombre?: string;
        Legajo?: string;
        FechaIngreso?: string;
        Dni?: number;
        Cuil?: string;
        FechaNacimiento?: string;
        EsActivo?: boolean;
        Telefono?: string;
        Email?: string;
        Domicilio?: string;
        Sexo?: string;
    }

    export namespace EmpleadoRow {
        export const idProperty = 'IdEmpleado';
        export const nameProperty = 'Apellido';
        export const localTextPrefix = 'Default.Empleado';

        export namespace Fields {
            export declare const IdEmpleado;
            export declare const Apellido;
            export declare const Nombre;
            export declare const Legajo;
            export declare const FechaIngreso;
            export declare const Dni;
            export declare const Cuil;
            export declare const FechaNacimiento;
            export declare const EsActivo;
            export declare const Telefono;
            export declare const Email;
            export declare const Domicilio;
            export declare const Sexo;
        }

        [
            'IdEmpleado',
            'Apellido',
            'Nombre',
            'Legajo',
            'FechaIngreso',
            'Dni',
            'Cuil',
            'FechaNacimiento',
            'EsActivo',
            'Telefono',
            'Email',
            'Domicilio',
            'Sexo'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}