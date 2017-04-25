using System.Web.Mvc;

namespace Yamon.Module.Doc.Web.Controllers
{
    public class DocAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Doc";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Doc_default",
                "Doc/{controller}/{action}/{id}",
                new { action = "Index", Controller = "DocCatalog", id = UrlParameter.Optional },
                new string[] { "Yamon.Module.Doc.Web.Controllers" }
            );
        }
    }
}