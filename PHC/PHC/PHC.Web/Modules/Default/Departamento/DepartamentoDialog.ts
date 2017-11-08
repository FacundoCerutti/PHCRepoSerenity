
namespace PHC.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class DepartamentoDialog extends Serenity.EntityDialog<DepartamentoRow, any> {
        protected getFormKey() { return DepartamentoForm.formKey; }
        protected getIdProperty() { return DepartamentoRow.idProperty; }
        protected getLocalTextPrefix() { return DepartamentoRow.localTextPrefix; }
        protected getNameProperty() { return DepartamentoRow.nameProperty; }
        protected getService() { return DepartamentoService.baseUrl; }

        protected form = new DepartamentoForm(this.idPrefix);

    }
}