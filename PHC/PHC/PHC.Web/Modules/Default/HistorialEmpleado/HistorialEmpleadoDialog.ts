
namespace PHC.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class HistorialEmpleadoDialog extends Serenity.EntityDialog<HistorialEmpleadoRow, any> {
        protected getFormKey() { return HistorialEmpleadoForm.formKey; }
        protected getIdProperty() { return HistorialEmpleadoRow.idProperty; }
        protected getLocalTextPrefix() { return HistorialEmpleadoRow.localTextPrefix; }
        protected getService() { return HistorialEmpleadoService.baseUrl; }

        protected form = new HistorialEmpleadoForm(this.idPrefix);

    }
}