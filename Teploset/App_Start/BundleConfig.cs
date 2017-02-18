using System.Web;
using System.Web.Optimization;

namespace Teploset
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //==============================================================
            // -- Style bundles

            bundles.Add(new StyleBundle("~/Content/css").Include(
                    "~/Content/bootstrap.css",
                    "~/Content/site.css",
                    "~/Content/contact_style.css",
                    "~/Content/flexslider.css",
                    "~/Content/menu_style.css",
                    "~/Content/slicknav.css"));

            bundles.Add(new StyleBundle("~/Content/datepicker").Include(
                    "~/Content/datepicker3.css"));

            //==============================================================
            //-- script bundle

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-1.12.4.js",
                    "~/Scripts/jquery.gmap3.min.js",
                    "~/Scripts/jquery.slicknav.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"));

            // Используйте версию Modernizr для разработчиков, чтобы учиться работать. Когда вы будете готовы перейти к работе,
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-2.6.2.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                    "~/Scripts/bootstrap-3.3.7.min.js",
                    "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
                       "~/ScriptsCustom/plugins.js",
                       "~/ScriptsCustom/script.js"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;

        }
    }
}
