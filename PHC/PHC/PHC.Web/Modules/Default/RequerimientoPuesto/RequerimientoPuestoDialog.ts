
namespace PHC.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class RequerimientoPuestoDialog extends Serenity.EntityDialog<RequerimientoPuestoRow, any> {
        protected getFormKey() { return RequerimientoPuestoForm.formKey; }
        protected getIdProperty() { return RequerimientoPuestoRow.idProperty; }
        protected getLocalTextPrefix() { return RequerimientoPuestoRow.localTextPrefix; }
        protected getService() { return RequerimientoPuestoService.baseUrl; }

        protected form = new RequerimientoPuestoForm(this.idPrefix);

    }
}