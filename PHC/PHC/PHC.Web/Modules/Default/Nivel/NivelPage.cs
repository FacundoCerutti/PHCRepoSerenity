
namespace PHC.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Nivel"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.NivelRow))]
    public class NivelController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Nivel/NivelIndex.cshtml");
        }
    }
}