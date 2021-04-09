using System.Web;
using System.Web.Optimization;

namespace ShopDevmo2
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Script bundle for AdminLTE
            bundles.Add(new ScriptBundle("~/bundles/adminlte").Include(
                        "~/Scripts/adminlte.min.js",
                        "~/Scripts/bootstrap.bundle.min.js",
                        "~/Scripts/Chart.min.js",
                        "~/Scripts/sparkline.js",
                        "~/Scripts/moment.min.js",
                        "~/Scripts/daterangepicker.js",
                        "~/Scripts/tempusdominus-bootstrap-4.min.js",
                        "~/Scripts/summernote-bs4.min.js",
                        "~/Scripts/jquery.overlayScrollbars.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            // Style bundle for AdminLTE
            bundles.Add(new StyleBundle("~/Content/adminlte/css").Include(
                        "~/Content/Fontawesome/all.min.css",
                        "~/Content/adminlte.min.css",
                        "~/Content/tempusdominus-bootstrap-4.min.css",
                        "~/Content/icheck-bootstrap.min.css",
                        "~/Content/OverlayScrollbars.css",
                        "~/Content/daterangepicker.css",
                        "~/Content/summernote-bs4.css"));
        }
    }
}
