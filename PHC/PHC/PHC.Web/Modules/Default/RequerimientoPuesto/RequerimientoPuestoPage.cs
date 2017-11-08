
namespace PHC.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/RequerimientoPuesto"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.RequerimientoPuestoRow))]
    public class RequerimientoPuestoController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/RequerimientoPuesto/RequerimientoPuestoIndex.cshtml");
        }
    }
}