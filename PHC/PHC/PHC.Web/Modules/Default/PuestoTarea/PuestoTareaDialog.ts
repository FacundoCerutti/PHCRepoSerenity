
namespace PHC.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PuestoTareaDialog extends Serenity.EntityDialog<PuestoTareaRow, any> {
        protected getFormKey() { return PuestoTareaForm.formKey; }
        protected getIdProperty() { return PuestoTareaRow.idProperty; }
        protected getLocalTextPrefix() { return PuestoTareaRow.localTextPrefix; }
        protected getService() { return PuestoTareaService.baseUrl; }

        protected form = new PuestoTareaForm(this.idPrefix);

    }
}