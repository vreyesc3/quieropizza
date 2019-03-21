using System.Web;
using System.Web.Optimization;

namespace Sistema_Inventario.WebAdmin
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(

                      
                        "~/Scripts/vendor/jquery/jquery.min.js",
                        "~/Scripts/vendor/bootstrap/js/bootstrap.bundle.min.js",
                        "~/Scripts/vendor/jquery-easing/jquery.easing.min.js",
                        "~/Scripts/sb-admin-2.min.js",
                        "~/Scripts/vendor/chart.js/Chart.min.js",
                        "~/Scripts/demo/chart-area-demo.js",
                        "~/Scripts/demo/chart-pie-demo.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Scripts/vendor/fontawesome-free/css/all.min.css",
                      "~/Content/sb-admin-2.min.css"
                      ));

        }
    }
}
