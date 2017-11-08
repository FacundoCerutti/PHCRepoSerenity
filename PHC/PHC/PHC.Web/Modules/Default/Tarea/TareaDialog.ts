
namespace PHC.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class TareaDialog extends Serenity.EntityDialog<TareaRow, any> {
        protected getFormKey() { return TareaForm.formKey; }
        protected getIdProperty() { return TareaRow.idProperty; }
        protected getLocalTextPrefix() { return TareaRow.localTextPrefix; }
        protected getNameProperty() { return TareaRow.nameProperty; }
        protected getService() { return TareaService.baseUrl; }

        protected form = new TareaForm(this.idPrefix);

    }
}