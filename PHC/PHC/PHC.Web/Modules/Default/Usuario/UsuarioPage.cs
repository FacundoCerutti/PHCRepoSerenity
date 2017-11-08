
namespace PHC.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Usuario"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.UsuarioRow))]
    public class UsuarioController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Usuario/UsuarioIndex.cshtml");
        }
    }
}