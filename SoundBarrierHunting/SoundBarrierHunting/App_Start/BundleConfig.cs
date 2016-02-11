using System.Web.Optimization;

namespace SoundBarrierHunting.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            #if !DEBUG
                        bundles.UseCdn = true;
                        BundleTable.EnableOptimizations = true;
            #endif

            bundles.Add(new StyleBundle("~/bundles/commoncss")
                .Include("~/Content/Styles.css")
                .Include("~/Content/NavCSS.css")
                );

            bundles.Add(new StyleBundle("~/bundles/bootstrapcss",
                "//maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css")
                .Include("~/Content/bootstrap.css")
                );

            bundles.Add(new StyleBundle("~/bundles/bootstrap-theme-css",
            "//maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap-theme.min.css")
            .Include("~/Content/bootstrap-theme.css")
            );

            bundles.Add(new ScriptBundle("~/bundles/commonjavascript")
            .Include("~/Scripts/jquery-2.1.4.js")
            .Include("~/Scripts/jquery-ui.min.js")
            );

            bundles.Add(new ScriptBundle("~/bundles/bootstrapjs",
                "//maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js")
                .Include("~/Scripts/bootstrap.js")
                );

            BundleTable.EnableOptimizations = true;
        }
    }
}