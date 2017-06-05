using System.Web.Optimization;

namespace Carsales.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            var cssBundle = new StyleBundle("~/content/css/all-css")
                .IncludeDirectory("~/content/css", "*.css", true);
            bundles.Add(cssBundle);

            //previous approach was duplicating scripts. It turns out that scripts appear to be rendered in the order
            //in which they're added to the bundle, or after those, in alphabetical order
            var contentBundle = new ScriptBundle("~/content/js/content-js")
                .Include("~/content/js/jquery.js")
                .Include("~/content/js/angular.js")
                .Include("~/content/js/angular-route.js")
                .Include("~/content/js/angular-ui-router.js")
                .Include("~/content/js/angular-resource.js")
                .Include("~/content/js/ui-bootstrap-tpls.js")
                .Include("~/content/js/bootstrap.min.js")
                .IncludeDirectory("~/content/js", "*.js", false);  

            bundles.Add(contentBundle);

            var scriptBundle = new ScriptBundle("~/app/app-javascript")
                .Include("~/app/app.js")
                .IncludeDirectory("~/app", "*.js", true);

            bundles.Add(scriptBundle);

            //bundles.IgnoreList.Ignore("xyz.js");
        }
    }
}
