
namespace PHC.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Departamento"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.DepartamentoRow))]
    public class DepartamentoController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Departamento/DepartamentoIndex.cshtml");
        }
    }
}