using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MvcApplication1.Filters;

namespace MvcApplication1.Controllers
{
    //[Authorize]
    [Log]
    public class CuisineController : Controller
    {
        public ActionResult Search(string name = "turtles")
        {
            throw new Exception("Something terrible has happened");

            var message = Server.HtmlEncode(name);
            return Content(message);
        }

    }
}
