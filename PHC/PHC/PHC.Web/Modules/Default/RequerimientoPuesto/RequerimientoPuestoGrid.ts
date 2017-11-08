
namespace PHC.Default {

    @Serenity.Decorators.registerClass()
    export class RequerimientoPuestoGrid extends Serenity.EntityGrid<RequerimientoPuestoRow, any> {
        protected getColumnsKey() { return 'Default.RequerimientoPuesto'; }
        protected getDialogType() { return RequerimientoPuestoDialog; }
        protected getIdProperty() { return RequerimientoPuestoRow.idProperty; }
        protected getLocalTextPrefix() { return RequerimientoPuestoRow.localTextPrefix; }
        protected getService() { return RequerimientoPuestoService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}