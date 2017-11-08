
namespace PHC.Default {

    @Serenity.Decorators.registerClass()
    export class EmpleadoGrid extends Serenity.EntityGrid<EmpleadoRow, any> {
        protected getColumnsKey() { return 'Default.Empleado'; }
        protected getDialogType() { return EmpleadoDialog; }
        protected getIdProperty() { return EmpleadoRow.idProperty; }
        protected getLocalTextPrefix() { return EmpleadoRow.localTextPrefix; }
        protected getService() { return EmpleadoService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}