using System.Web.Mvc;

namespace WebApplication1.Areas.EMP
{
    public class EMPAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "EMP";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "EMP_default",
                "EMP/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}