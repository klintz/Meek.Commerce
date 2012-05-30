using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Meek.Commerce.Extendable.Business;

namespace Meek.Commerce.StoreFront.Controllers
{
    public class RootController : Web.Mvc.Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }
    }
}
