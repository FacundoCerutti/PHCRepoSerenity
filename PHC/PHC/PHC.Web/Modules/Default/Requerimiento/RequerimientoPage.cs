
namespace PHC.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Requerimiento"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.RequerimientoRow))]
    public class RequerimientoController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Requerimiento/RequerimientoIndex.cshtml");
        }
    }
}