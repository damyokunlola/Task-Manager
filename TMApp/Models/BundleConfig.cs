using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace TMApp.Models
{
    public class BundleConfig
    {
        public static void RegisterBundle( BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/js/MyScript.js",
                "~/Scripts/jquery-3.5.1.min.js",
                "~/Scripts/jquery-ui-1.12.1.js"

                ));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/js/bootstrap.min.js",
                "~/Scripts/bootstrap.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
             "~/Scripts/popper.min.js"
        
             ));
            bundles.Add(new StyleBundle("~/Content/css").Include(
               "~/Content/themes/base/jquery-ui.min.css",
               "~/Content/bootstrap.min.css"

               ));

        }

    }
}