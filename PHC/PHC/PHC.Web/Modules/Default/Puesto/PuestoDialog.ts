
namespace PHC.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PuestoDialog extends Serenity.EntityDialog<PuestoRow, any> {
        protected getFormKey() { return PuestoForm.formKey; }
        protected getIdProperty() { return PuestoRow.idProperty; }
        protected getLocalTextPrefix() { return PuestoRow.localTextPrefix; }
        protected getNameProperty() { return PuestoRow.nameProperty; }
        protected getService() { return PuestoService.baseUrl; }

        protected form = new PuestoForm(this.idPrefix);

    }
}