
namespace PHC.Default {

    @Serenity.Decorators.registerClass()
    export class HistorialEmpleadoGrid extends Serenity.EntityGrid<HistorialEmpleadoRow, any> {
        protected getColumnsKey() { return 'Default.HistorialEmpleado'; }
        protected getDialogType() { return HistorialEmpleadoDialog; }
        protected getIdProperty() { return HistorialEmpleadoRow.idProperty; }
        protected getLocalTextPrefix() { return HistorialEmpleadoRow.localTextPrefix; }
        protected getService() { return HistorialEmpleadoService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}