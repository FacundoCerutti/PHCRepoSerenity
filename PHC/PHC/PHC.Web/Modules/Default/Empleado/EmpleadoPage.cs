
namespace PHC.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Empleado"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.EmpleadoRow))]
    public class EmpleadoController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Empleado/EmpleadoIndex.cshtml");
        }
    }
}