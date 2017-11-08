
namespace PHC.Default {

    @Serenity.Decorators.registerClass()
    export class NivelGrid extends Serenity.EntityGrid<NivelRow, any> {
        protected getColumnsKey() { return 'Default.Nivel'; }
        protected getDialogType() { return NivelDialog; }
        protected getIdProperty() { return NivelRow.idProperty; }
        protected getLocalTextPrefix() { return NivelRow.localTextPrefix; }
        protected getService() { return NivelService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}