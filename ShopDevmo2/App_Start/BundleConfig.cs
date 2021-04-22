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

            bundles.Add(new ScriptBundle("~/bundles/bagbag").Include(
                        "~/Scripts/bagbag/cart.js",
                        "~/Scripts/bagbag/categories.js",
                        "~/Scripts/bagbag/details.js",
                        "~/Scripts/bagbag/main.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            // Bundle CKeditor
            bundles.Add(new ScriptBundle("~/bundles/ckeditor").Include(
                      "~/Scripts/ckeditor/ckeditor.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // Style bundle for AdminLTE
            bundles.Add(new StyleBundle("~/Content/adminlte/css").Include(
                        "~/Content/fontawesome/all.min.css",
                        "~/Content/adminlte.min.css",
                        "~/Content/tempusdominus-bootstrap-4.min.css",
                        "~/Content/icheck-bootstrap.min.css",
                        "~/Content/OverlayScrollbars.css",
                        "~/Content/daterangepicker.css",
                        "~/Content/summernote-bs4.css"));

            // Style bundle for Main Index
            bundles.Add(new StyleBundle("~/Content/MainIndex/css").Include(
                "~/Content/css/header.css",
                "~/Content/css/main-footer.css",
                "~/Content/css/bootstrap.min.css",
                "~/Content/css/all.min.css"));

            // Style bundle for Login
            bundles.Add(new StyleBundle("~/Content/Login/css").Include(
                "~/Content/css/signin.css"));

            // Style bundle for Categories
            bundles.Add(new StyleBundle("~/Content/Categories/css").Include(
                "~/Content/css/categories.css"));

            // Libs bundle for Main Index
            bundles.Add(new StyleBundle("~/Content/MainIndex/libs").Include(
                "~/Content/libs/font-awesome/css/font-awesome.css",
                "~/Content/libs/font-awesome/css/font-awesome.min.css"));
        }
    }
}
