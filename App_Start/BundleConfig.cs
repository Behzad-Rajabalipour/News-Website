using System.Web;
using System.Web.Optimization;          // NutGet => install Microsoft.AspNet.Web.Optimization

namespace WebApplication11
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // jquery ro bundle mikone
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // jquery ro bundle mikone
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            
            // JS ro bundle mikone
            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            // style ro bundle mikone
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/Site.css",           // Case sensetive hast. Captial case ro havaset bashe
                      "~/Content/MySite.css"));       // MySite.cs ro inja ezzafe mikonim
        }
    }
}
