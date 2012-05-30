using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Meek.Commerce.Web.Mvc;

namespace Meek.Commerce.StoreFront.Areas.Admin.Controllers
{
    public class AdminController : Web.Mvc.Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
