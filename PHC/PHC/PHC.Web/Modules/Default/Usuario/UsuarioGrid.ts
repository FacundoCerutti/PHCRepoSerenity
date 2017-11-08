
namespace PHC.Default {

    @Serenity.Decorators.registerClass()
    export class UsuarioGrid extends Serenity.EntityGrid<UsuarioRow, any> {
        protected getColumnsKey() { return 'Default.Usuario'; }
        protected getDialogType() { return UsuarioDialog; }
        protected getIdProperty() { return UsuarioRow.idProperty; }
        protected getLocalTextPrefix() { return UsuarioRow.localTextPrefix; }
        protected getService() { return UsuarioService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}