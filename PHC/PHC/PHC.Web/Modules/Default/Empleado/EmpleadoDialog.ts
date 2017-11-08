
namespace PHC.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class EmpleadoDialog extends Serenity.EntityDialog<EmpleadoRow, any> {
        protected getFormKey() { return EmpleadoForm.formKey; }
        protected getIdProperty() { return EmpleadoRow.idProperty; }
        protected getLocalTextPrefix() { return EmpleadoRow.localTextPrefix; }
        protected getNameProperty() { return EmpleadoRow.nameProperty; }
        protected getService() { return EmpleadoService.baseUrl; }

        protected form = new EmpleadoForm(this.idPrefix);

    }
}