using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Meek.Commerce.Web.Mvc
{
    public class ExtendedRazorViewEngine : RazorViewEngine
    {
        public ExtendedRazorViewEngine() 
        {
            //Areas
            AreaViewLocationFormats = new[] {
                "~/Areas/{2}/{1}/{0}.cshtml",
                "~/Areas/{2}/{1}/{0}.vbhtml",
                "~/Areas/{2}/Shared/{0}.cshtml",
                "~/Areas/{2}/Shared/{0}.vbhtml"
            };

            AreaMasterLocationFormats = new[] {
                "~/Areas/{2}/{1}/{0}.cshtml",
                "~/Areas/{2}/{1}/{0}.vbhtml",
                "~/Areas/{2}/Shared/{0}.cshtml",
                "~/Areas/{2}/Shared/{0}.vbhtml"
            };

            AreaPartialViewLocationFormats = new[] {
                "~/Areas/{2}/{1}/{0}.cshtml",
                "~/Areas/{2}/{1}/{0}.vbhtml",
                "~/Areas/{2}/Shared/{0}.cshtml",
                "~/Areas/{2}/Shared/{0}.vbhtml"
            };

            //Root
            ViewLocationFormats = new [] {
                "~/{0}.cshtml",
                "~/{0}.vbhtml",
                "~/{1}/{0}.cshtml",
                "~/{1}/{0}.vbhtml"
            };

            PartialViewLocationFormats = new[]{
                "~/Controls/{0}.cshtml",
                "~/Controls/{0}.vbhtml"
            };

            MasterLocationFormats = new[] {
                "~/{0}.cshtml",
                "~/{0}.vbhtml",
                "~/Shared/{0}.cshtml",
                "~/Shared/{0}.vbhtml"
            };
        }
    }
}
