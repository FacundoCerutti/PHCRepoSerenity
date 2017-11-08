
namespace PHC.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class NivelDialog extends Serenity.EntityDialog<NivelRow, any> {
        protected getFormKey() { return NivelForm.formKey; }
        protected getIdProperty() { return NivelRow.idProperty; }
        protected getLocalTextPrefix() { return NivelRow.localTextPrefix; }
        protected getNameProperty() { return NivelRow.nameProperty; }
        protected getService() { return NivelService.baseUrl; }

        protected form = new NivelForm(this.idPrefix);

    }
}