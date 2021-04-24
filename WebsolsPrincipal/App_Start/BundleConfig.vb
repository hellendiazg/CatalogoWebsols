Imports System.Web.Optimization

Public Module BundleConfig
    ' Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"))

        ' Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
        ' para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
                  "~/Content/assets/js/jquery.js",
                  "~/Content/assets/js/bootstrap.min.js",
                  "~/Content/assets/js/bootsnav.js",
                  "~/Content/assets/js/owl.carousel.min.js",
                  "~/Content/assets/js/custom.js"
))

        bundles.Add(New StyleBundle("~/Content/css").Include(
                  "~/Content/assets/logo/favicon.png",
                  "~/Content/assets/css/font-awesome.min.css",
                  "~/Content/assets/css/linearicons.css",
                  "~/Content/assets/css/animate.css",
                  "~/Content/assets/css/owl.carousel.min.css",
                  "~/Content/assets/css/owl.theme.default.min.css",
                  "~/Content/assets/css/bootstrap.min.css",
                  "~/Content/assets/css/bootsnav.css",
                  "~/Content/assets/css/style.css",
                  "~/Content/assets/css/responsive.css"
))
    End Sub
End Module

