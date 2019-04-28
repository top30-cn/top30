using System.Web;
using System.Web.Optimization;

namespace Top30
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

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new ScriptBundle("~/umeditor/config").Include(
            "~/umeditor1_2_2-utf8-net/umeditor.config.js"));
            bundles.Add(new ScriptBundle("~/umeditor/umeditor").Include(
            "~/umeditor1_2_2-utf8-net/umeditor.js"));
            bundles.Add(new ScriptBundle("~/umeditor/lang").Include(
            "~/umeditor1_2_2-utf8-net/lang/zh-cn/zh-cn.js"));

            //       < script type = "text/javascript" charset = "utf-8" src = "~/umeditor1_2_2-utf8-net/umeditor.config.js" ></ script >
            //< script type = "text/javascript" charset = "utf-8" src = "~/umeditor1_2_2-utf8-net/umeditor.js" ></ script >
            //     < script type = "text/javascript" src = "~/umeditor1_2_2-utf8-net/lang/zh-cn/zh-cn.js" ></ script >
        }
    }
}
