
namespace PHC.Default {

    @Serenity.Decorators.registerClass()
    export class PuestoGrid extends Serenity.EntityGrid<PuestoRow, any> {
        protected getColumnsKey() { return 'Default.Puesto'; }
        protected getDialogType() { return PuestoDialog; }
        protected getIdProperty() { return PuestoRow.idProperty; }
        protected getLocalTextPrefix() { return PuestoRow.localTextPrefix; }
        protected getService() { return PuestoService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}