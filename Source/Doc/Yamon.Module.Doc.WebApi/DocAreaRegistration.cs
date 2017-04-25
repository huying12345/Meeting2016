using System.Web.Mvc;

namespace Yamon.Module.Doc.WebApi
{
    public class DocAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Doc_WebApi";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Doc_WebApi_default",
                "api/Doc/{controller}/{action}/{id}",
                new { action = "Index", Controller = "DocCatalog", id = UrlParameter.Optional },
                new string[] { "Yamon.Module.Doc.WebApi" }
            );
        }
    }
}