
namespace PHC.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/PuestoTarea"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.PuestoTareaRow))]
    public class PuestoTareaController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/PuestoTarea/PuestoTareaIndex.cshtml");
        }
    }
}