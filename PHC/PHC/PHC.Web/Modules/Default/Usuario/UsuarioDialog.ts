
namespace PHC.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class UsuarioDialog extends Serenity.EntityDialog<UsuarioRow, any> {
        protected getFormKey() { return UsuarioForm.formKey; }
        protected getIdProperty() { return UsuarioRow.idProperty; }
        protected getLocalTextPrefix() { return UsuarioRow.localTextPrefix; }
        protected getNameProperty() { return UsuarioRow.nameProperty; }
        protected getService() { return UsuarioService.baseUrl; }

        protected form = new UsuarioForm(this.idPrefix);

    }
}