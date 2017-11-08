
namespace PHC.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Puesto"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.PuestoRow))]
    public class PuestoController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Puesto/PuestoIndex.cshtml");
        }
    }
}