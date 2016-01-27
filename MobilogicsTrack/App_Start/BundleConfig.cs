using System.Web;
using System.Web.Optimization;

namespace MobilogicsTrack
{
  public class BundleConfig
  {
    // 如需「搭配」的詳細資訊，請瀏覽 http://go.microsoft.com/fwlink/?LinkId=301862
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                  "~/Scripts/jquery-{version}.js"));

      bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                  "~/Scripts/jquery.validate*"));

      // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
      // 準備好實際執行時，請使用 http://modernizr.com 上的建置工具，只選擇您需要的測試。
      bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                  "~/Scripts/modernizr-*"));

      bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

      /*
      bundles.Add(new ScriptBundle("~/bundles/templates").Include(
                "~/Scripts/flat-admin/ace.js",
                "~/Scripts/flat-admin/bootstrap-switch.min.js",
                "~/Scripts/flat-admin/dataTables.bootstrap.min.js",
                "~/Scripts/flat-admin/jquery.dataTables.min.js",
                "~/Scripts/flat-admin/jquery.matchHeight-min.js",
                "~/Scripts/flat-admin/list.js",
                "~/Scripts/flat-admin/modal.js",
                "~/Scripts/flat-admin/mode-html.js",
                "~/Scripts/flat-admin/select2.full.min.js",
                "~/Scripts/flat-admin/index.js",
                "~/Scripts/flat-admin/coffee/*.js"));
      */

      bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css"));

      /*
      bundles.Add(new StyleBundle("~/Content/css/templates").Include(
                "~/Content/flat-admin/animate.min.css",
                "~/Content/flat-admin/bootstrap-switch.min.css",
                "~/Content/flat-admin/checkbox3.min.css",
                "~/Content/flat-admin/dataTables.bootstrap.css",
                "~/Content/flat-admin/font-awesome.min.css",
                "~/Content/flat-admin/jquery.dataTables.min.css",
                "~/Content/flat-admin/select2.min.css",
                "~/Content/flat-admin/scss/themes/*.css",
                "~/Content/flat-admin/scss/style.css"));
      */

    }
  }
}
