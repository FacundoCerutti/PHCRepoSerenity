
namespace PHC.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/HistorialEmpleado"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.HistorialEmpleadoRow))]
    public class HistorialEmpleadoController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/HistorialEmpleado/HistorialEmpleadoIndex.cshtml");
        }
    }
}