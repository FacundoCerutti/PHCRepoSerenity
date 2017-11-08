
namespace PHC.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class RequerimientoDialog extends Serenity.EntityDialog<RequerimientoRow, any> {
        protected getFormKey() { return RequerimientoForm.formKey; }
        protected getIdProperty() { return RequerimientoRow.idProperty; }
        protected getLocalTextPrefix() { return RequerimientoRow.localTextPrefix; }
        protected getNameProperty() { return RequerimientoRow.nameProperty; }
        protected getService() { return RequerimientoService.baseUrl; }

        protected form = new RequerimientoForm(this.idPrefix);

    }
}