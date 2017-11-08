
namespace PHC.Default {

    @Serenity.Decorators.registerClass()
    export class TareaGrid extends Serenity.EntityGrid<TareaRow, any> {
        protected getColumnsKey() { return 'Default.Tarea'; }
        protected getDialogType() { return TareaDialog; }
        protected getIdProperty() { return TareaRow.idProperty; }
        protected getLocalTextPrefix() { return TareaRow.localTextPrefix; }
        protected getService() { return TareaService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}