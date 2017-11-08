
namespace PHC.Default {

    @Serenity.Decorators.registerClass()
    export class RequerimientoGrid extends Serenity.EntityGrid<RequerimientoRow, any> {
        protected getColumnsKey() { return 'Default.Requerimiento'; }
        protected getDialogType() { return RequerimientoDialog; }
        protected getIdProperty() { return RequerimientoRow.idProperty; }
        protected getLocalTextPrefix() { return RequerimientoRow.localTextPrefix; }
        protected getService() { return RequerimientoService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}