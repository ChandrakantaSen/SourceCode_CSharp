using System.Web;
using System.Web.Optimization;

namespace Lab8_LINQwithASP.NET
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //Create Bundle for jQueryUI
            //js
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                "~/Scripts/jquery-ui-{version}.js"));

            //css
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include("~/Content/themes/base/accordion.css"));
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include("~/Content/themes/base/all.css"));
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include("~/Content/themes/base/autocomplete.css"));
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include("~/Content/themes/base/base.css"));
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include("~/Content/themes/base/button.css"));
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include("~/Content/themes/base/core.css"));
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include("~/Content/themes/base/datepicker.css"));
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include("~/Content/themes/base/dialog.css"));
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include("~/Content/themes/base/draggable.css"));
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include("~/Content/themes/base/menu.css"));
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include("~/Content/themes/base/progressbar.css"));
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include("~/Content/themes/base/resizable.css"));
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include("~/Content/themes/base/selectable.css"));
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include("~/Content/themes/base/selectmenu.css"));
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include("~/Content/themes/base/slider.css"));
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include("~/Content/themes/base/sortable.css"));
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include("~/Content/themes/base/spinner.css"));
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include("~/Content/themes/base/tabs.css"));
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include("~/Content/themes/base/theme.css"));
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include("~/Content/themes/base/tooltip.css"));
        }
    }
}
