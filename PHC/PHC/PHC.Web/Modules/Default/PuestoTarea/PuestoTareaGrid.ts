
namespace PHC.Default {

    @Serenity.Decorators.registerClass()
    export class PuestoTareaGrid extends Serenity.EntityGrid<PuestoTareaRow, any> {
        protected getColumnsKey() { return 'Default.PuestoTarea'; }
        protected getDialogType() { return PuestoTareaDialog; }
        protected getIdProperty() { return PuestoTareaRow.idProperty; }
        protected getLocalTextPrefix() { return PuestoTareaRow.localTextPrefix; }
        protected getService() { return PuestoTareaService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}