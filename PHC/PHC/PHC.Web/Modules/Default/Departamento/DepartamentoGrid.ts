
namespace PHC.Default {

    @Serenity.Decorators.registerClass()
    export class DepartamentoGrid extends Serenity.EntityGrid<DepartamentoRow, any> {
        protected getColumnsKey() { return 'Default.Departamento'; }
        protected getDialogType() { return DepartamentoDialog; }
        protected getIdProperty() { return DepartamentoRow.idProperty; }
        protected getLocalTextPrefix() { return DepartamentoRow.localTextPrefix; }
        protected getService() { return DepartamentoService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}